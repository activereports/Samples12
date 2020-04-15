Imports GrapeCity.ActiveReports.Design
Imports GrapeCity.ActiveReports.Design.Resources
Imports System.IO
Imports System.Drawing.Design
Imports GrapeCity.ActiveReports.PageReportModel
Imports System.ComponentModel
Imports System.ComponentModel.Design
Public Class EndUserDesigner
	Dim _fileMenu As ToolStripDropDownItem
	Dim _reportName As String
	Dim _filter As IMessageFilter
	Dim _toogleFilterMenu As ToolStripMenuItem
	Public Sub New()
		Application.EnableVisualStyles()
		' This call is required by the designer.
		InitializeComponent()
		'Add any initialization after the InitializeComponent() call. 
		'Set the ToolBox, ReportExplorer and PropertyGrid in the Designer.
		reportDesigner.Toolbox = reportToolbox 'Attaches the toolbox to the report designer
		reportExplorer.ReportDesigner = reportDesigner 'Attaches the report explorer to the report designer
		AddHandler reportDesigner.LayoutChanged, AddressOf reportDesigner_LayoutChanged
		AddHandler reportDesigner.ReportChanged, AddressOf OnReportChanged
		layerList.ReportDesigner = reportDesigner
		reportDesigner.PropertyGrid = reportPropertyGrid 'Attaches the Property Grid to the report designer
		'Populate the menu.
		groupEditor.ReportDesigner = reportDesigner
		reportsLibrary.ReportDesigner = reportDesigner
		Dim toolstrip As ToolStrip = reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Menu})(0)
		_fileMenu = DirectCast(toolstrip.Items(0), ToolStripDropDownItem)
		CreateFileMenu(_fileMenu)
		_toogleFilterMenu = New ToolStripMenuItem(My.Resources.Resource.DisableShortcutsText, Nothing, New EventHandler(AddressOf ToggleMessageFilter))
		DirectCast(toolstrip.Items(2), ToolStripDropDownItem).DropDownItems.Add(New ToolStripSeparator())
		DirectCast(toolstrip.Items(2), ToolStripDropDownItem).DropDownItems.Add(_toogleFilterMenu)
		AppendToolStrips(0, New ToolStrip() {toolstrip})
		AppendToolStrips(1, reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Edit, DesignerToolStrips.Undo, DesignerToolStrips.Zoom}))
		AppendToolStrips(1, New ToolStrip() {CreateReportToolbar()})
		AppendToolStrips(2, reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Format, DesignerToolStrips.Layout}))
		LoadTools(reportToolbox, reportDesigner.ReportType)
		AddHandler reportDesigner.ActiveTabChanged, AddressOf OnEnableExport
		RefreshExportEnabled()
		CreateReportExplorer()
		SplitContainerMiddle.Panel2Collapsed = (reportDesigner.ReportType = DesignerReportType.Section)
		AddHandler FormClosing, AddressOf EndUserDesigner_FormClosing
	End Sub
	Private Sub EndUserDesigner_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
		e.Cancel = Not ConfirmSaveChanges()
	End Sub
	Private Function PerformSave() As Boolean
		If String.IsNullOrEmpty(_reportName) OrElse String.IsNullOrEmpty(Path.GetDirectoryName(_reportName)) OrElse Not File.Exists(_reportName) Then
			Return PerformSaveAs()
		End If
		reportDesigner.SaveReport(New FileInfo(_reportName))
		Return True
	End Function
	Private Function PerformSaveAs() As Boolean
		Using dlg As New SaveFileDialog()
			dlg.Filter = GetSaveFilter(reportDesigner.ReportType, GetIsMaster())
			If dlg.ShowDialog() = DialogResult.OK Then
				_reportName = dlg.FileName
				reportDesigner.SaveReport(New FileInfo(dlg.FileName))
				Return True
			End If
		End Using
		Return False
	End Function
	Private Function GetIsMaster() As Boolean
		Dim isMaster As Boolean = False
		If reportDesigner.ReportType = DesignerReportType.Rdl Then
			Dim report As Component = DirectCast(reportDesigner.Report, Component)
			Dim site As ISite = If(report Is Nothing, Nothing, report.Site)
			If site IsNot Nothing Then
				Dim host As IDesignerHost = TryCast(site.GetService(GetType(IDesignerHost)), IDesignerHost)
				If host IsNot Nothing Then
					Dim mcs As IMasterContentService = TryCast(host.GetService(GetType(IMasterContentService)), IMasterContentService)
					isMaster = mcs IsNot Nothing AndAlso mcs.IsMaster
				End If
			End If
		End If
		Return isMaster
	End Function
	Private Function GetSaveFilter(type As DesignerReportType, isMaster As Boolean) As String
		Select Case type
			Case DesignerReportType.Section
				Return My.Resources.Resource.SectionReportFilter
			Case DesignerReportType.Page
				Return My.Resources.Resource.PageReportFilter
			Case DesignerReportType.Rdl
				Return If(isMaster, My.Resources.Resource.RDLReportFilterMaster, My.Resources.Resource.RDLReportFilter)
			Case Else
				Return My.Resources.Resource.SectionReportFilter
		End Select
	End Function
	'Adding DropDownItems to the ToolStripDropDownItem.
	Private Sub CreateFileMenu(ByVal fileMenu As ToolStripDropDownItem)
		fileMenu.DropDownItems.Clear()
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.Resource.NewText, My.Resources.Resource.CmdNewReport, New EventHandler(AddressOf OnNew), (Keys.Control Or Keys.N)))
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.Resource.OpenText, My.Resources.Resource.CmdOpen, New EventHandler(AddressOf OnOpen), (Keys.Control Or Keys.O)))
		
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.Resource.LoadFromServer, My.Resources.Resource.CmdOpenFromServer, New EventHandler(AddressOf OnLoadFromServer)))
		
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.Resource.SaveText, My.Resources.Resource.CmdSave, New EventHandler(AddressOf OnSave), (Keys.Control Or Keys.S)))
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.Resource.SaveAsText, My.Resources.Resource.CmdSaveAs, New EventHandler(AddressOf OnSaveAs)))
		
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.Resource.SaveToServer, My.Resources.Resource.CmdSaveToServer, New EventHandler(AddressOf OnSaveToServer)))
		
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.Resource.ExportText, My.Resources.Resource.export, New EventHandler(AddressOf OnExport), (Keys.Control Or Keys.E)))
		fileMenu.DropDownItems.Add(New ToolStripSeparator())
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.Resource.ExitText, Nothing, New EventHandler(AddressOf OnExit)))
		'
	End Sub
	'Click "New" to open a new report.
	Private Sub OnNew(ByVal sender As Object, ByVal e As EventArgs)
		If ConfirmSaveChanges() Then
			reportDesigner.ExecuteAction(DesignerAction.NewReport)
			EnableTabs()
		End If
	End Sub
	'Click "Open" to open an existing report.
	Private Sub OnOpen(ByVal sender As Object, ByVal e As EventArgs)
		If Not ConfirmSaveChanges() Then
			Return
		End If
		Using dlg As New OpenFileDialog()
			dlg.Filter = My.Resources.Resource.OpenFileFilter
			If (dlg.ShowDialog()).Equals(DialogResult.OK) Then
				_reportName = dlg.FileName
				reportDesigner.LoadReport(New FileInfo(dlg.FileName))
				EnableTabs()
			End If
		End Using
	End Sub
	'Click "Save" to save a report.
	Private Sub OnSave(ByVal sender As Object, ByVal e As EventArgs)
		If (PerformSave()) Then
			SetTitle()
		End If
	End Sub
	'Click "Save as" to save a report with a name.
	Private Sub OnSaveAs(ByVal sender As Object, ByVal e As EventArgs)
		If (PerformSaveAs()) Then
			SetTitle()
		End If
	End Sub
	Private Sub OnExit(ByVal sender As Object, ByVal e As EventArgs)
		Close()
	End Sub
	'Checking whether modifications have been made to the report loaded to the designer.
	Private Function ConfirmSaveChanges() As Boolean
		If reportDesigner.IsDirty Then
			 
			Dim result As DialogResult = MessageBox.Show(My.Resources.Resource.ReportDirtyMessage, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
			
			'
			If result = DialogResult.Cancel Then
				Return False
			ElseIf result = DialogResult.Yes Then
				Return PerformSave()
			End If
		End If
		Return True
	End Function
	Private Sub AppendToolStrips(ByVal row As Integer, ByVal toolStrips As IList(Of ToolStrip))
		Dim topToolStripPanel As ToolStripPanel = toolStripContainer.TopToolStripPanel
		Dim num As Integer = toolStrips.Count
		While Threading.Interlocked.Decrement(num) >= 0
			topToolStripPanel.Join(toolStrips(num), row)
		End While
	End Sub
	Private Function CreateReportToolbar() As ToolStrip
		Return New ToolStrip(New ToolStripButton() {CreateToolStripButton(My.Resources.Resource.NewText, My.Resources.Resource.CmdNewReport, New EventHandler(AddressOf OnNew), My.Resources.Resource.NewText), EndUserDesigner.CreateToolStripButton(My.Resources.Resource.OpenText, My.Resources.Resource.CmdOpen, New EventHandler(AddressOf OnOpen), My.Resources.Resource.OpenText), EndUserDesigner.CreateToolStripButton(My.Resources.Resource.SaveText, My.Resources.Resource.CmdSave, New EventHandler(AddressOf OnSave), My.Resources.Resource.SaveText)})
	End Function
	Private Shared Function CreateToolStripButton(ByVal text As String, ByVal image As Drawing.Image, ByVal handler As EventHandler, ByVal toolTip As String) As ToolStripButton
		Return New ToolStripButton(text, image, handler) With { _
		 .DisplayStyle = ToolStripItemDisplayStyle.Image, _
			.ToolTipText = toolTip, _
		 .DoubleClickEnabled = True _
		}
	End Function
	Private Sub OnExport(ByVal sender As Object, ByVal e As EventArgs)
		Dim exportForm As New ExportForm(reportDesigner.ReportType, reportDesigner.Report, reportDesigner.ReportViewer)
		exportForm.ShowDialog()
	End Sub
	Private Shared Sub LoadTools(ByVal toolbox As IToolboxService, ByVal reportType As DesignerReportType)
		If reportType = DesignerReportType.Section Then
			'Add Data Providers.
			For Each type As Type In New Type() {GetType(System.Data.DataSet), GetType(DataView), GetType(OleDb.OleDbConnection), GetType(OleDb.OleDbDataAdapter), GetType(Odbc.OdbcConnection), GetType(Odbc.OdbcDataAdapter), _
			 GetType(SqlClient.SqlConnection), GetType(SqlClient.SqlDataAdapter)}
				toolbox.AddToolboxItem(New ToolboxItem(type), My.Resources.Resource.ToolBoxData)
			Next
		End If
	End Sub
	Private Sub EnableTabs()
		LoadTools(reportToolbox, reportDesigner.ReportType)
		reportToolbox.Reorder(reportDesigner)
		reportToolbox.EnsureCategories()
		If reportDesigner.ReportType = DesignerReportType.Section Then
			reportToolbox.ChangeVisibilityCategory(My.Resources.Resource.ToolBoxData, True)
			reportToolbox.EnableCategory(My.Resources.Resource.ToolBoxData, True)
		End If
		reportToolbox.Refresh()
	End Sub
	Private Sub reportDesigner_LayoutChanged(ByVal sender As System.Object, ByVal e As GrapeCity.ActiveReports.Design.LayoutChangedArgs)
		If e.Type = LayoutChangeType.ReportLoad OrElse e.Type = LayoutChangeType.ReportClear Then
			reportToolbox.Reorder(reportDesigner)
			reportToolbox.EnsureCategories()
			reportToolbox.Refresh()
			RefreshExportEnabled()
			CreateReportExplorer()
			SplitContainerMiddle.Panel2Collapsed = (reportDesigner.ReportType = DesignerReportType.Section)
		End If
		If e.Type = LayoutChangeType.ReportClear Then
			_reportName = Nothing
		End If
		If e.Type = LayoutChangeType.ReportLoad Then
			If Not String.IsNullOrEmpty(_reportName) Then
				If GetIsMaster() Then
					_reportName = Nothing
				End If
			End If
		End If
		SetTitle()
	End Sub
	Private Sub OnEnableExport(ByVal sender As Object, ByVal eventArgs As EventArgs)
		If (_fileMenu.DropDownItems.Count > 0) Then
			_fileMenu.DropDownItems(6).Enabled = reportDesigner.ActiveTab = DesignerTab.Preview
		End If
	End Sub
	Private Sub RefreshExportEnabled()
		RemoveHandler reportDesigner.ActiveTabChanged, AddressOf OnEnableExport
		AddHandler reportDesigner.ActiveTabChanged, AddressOf OnEnableExport
		OnEnableExport(Me, EventArgs.Empty)
	End Sub
	Private Sub CreateReportExplorer()
		If reportDesigner.ReportType = DesignerReportType.Section Then
			If explorerPropertyGridContainer.Panel1.Controls.Contains(reportExplorerTabControl) Then
				reportExplorerTabControl.TabPages(0).SuspendLayout()
				explorerPropertyGridContainer.Panel1.SuspendLayout()
				explorerPropertyGridContainer.Panel1.Controls.Remove(reportExplorerTabControl)
				explorerPropertyGridContainer.Panel1.Controls.Add(reportExplorer)
				reportExplorerTabControl.TabPages(0).ResumeLayout()
				explorerPropertyGridContainer.Panel1.ResumeLayout()
			End If
		ElseIf Not explorerPropertyGridContainer.Panel1.Controls.Contains(reportExplorerTabControl) Then
			reportExplorerTabControl.TabPages(0).SuspendLayout()
			explorerPropertyGridContainer.Panel1.SuspendLayout()
			explorerPropertyGridContainer.Panel1.Controls.Remove(reportExplorer)
			reportExplorerTabControl.TabPages(0).Controls.Add(reportExplorer)
			explorerPropertyGridContainer.Panel1.Controls.Add(reportExplorerTabControl)
			reportExplorerTabControl.TabPages(0).ResumeLayout()
			explorerPropertyGridContainer.Panel1.ResumeLayout()
		End If
	End Sub
	
	'Click "Save to Server" to save a report to the server.
	Private Sub OnSaveToServer()
		reportDesigner.SaveReportToServer()
	End Sub
	'Click "Open from Server" to open a report from the server.
	Private Sub OnLoadFromServer()
		Dim reportName As String = ""
		If reportDesigner.LoadReportFromServer(reportName).Equals(DialogResult.OK) Then
			_reportName = reportName
			SetTitle()
		End If
	End Sub
	
	
	Private Sub ToggleMessageFilter(sender As Object, eventArgs As EventArgs)
		If _filter IsNot Nothing Then
			Application.RemoveMessageFilter(_filter)
			_filter = Nothing
			_toogleFilterMenu.CheckState = CheckState.Unchecked
			Return
		End If
		_filter = New DesignerMessageFilter(reportDesigner)
		Application.AddMessageFilter(_filter)
		_toogleFilterMenu.CheckState = CheckState.Checked
		End Sub
		
	Private Sub OnReportChanged(ByVal sender As Object, ByVal e As EventArgs)
		SetTitle()
	End Sub
	Private Sub SetTitle()
		Text = String.Format("{0}{1} - {2}",
							 If(String.IsNullOrEmpty(_reportName),
								GetDefaultReportName(reportDesigner.ReportType),
								Path.GetFileName(_reportName)),
							 If(reportDesigner.IsDirty, My.Resources.Resource.DirtySign, String.Empty),
							 My.Resources.Resource.Title)
	End Sub
	Private Function GetDefaultReportName(ByVal reportType As DesignerReportType) As String
		Select Case reportType
			Case DesignerReportType.Section
				Return My.Resources.Resource.DefaultReportNameRpx
			Case Else
				Return My.Resources.Resource.DefaultReportNameRdlx
		End Select
	End Function
	
	Private NotInheritable Class DesignerMessageFilter
		Implements IMessageFilter
		Private Const WM_KEYDOWN As Integer = &H100
		Private Const WM_SYSKEYDOWN As Integer = &H104
		Private ReadOnly _designer As Design.Designer
		Public Sub New(designer As Design.Designer)
			_designer = designer
		End Sub
		Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
			If (m.Msg = WM_KEYDOWN OrElse m.Msg = WM_SYSKEYDOWN) AndAlso IsControlMatch(m.HWnd) Then
				Dim keyData = DirectCast(CInt(CLng(m.WParam)), Keys) Or ModifierKeys
				If (keyData And Keys.Control) = Keys.Control Then
					Return True
				End If
			End If
			Return False
		End Function
		Private Function IsControlMatch(handle As IntPtr) As Boolean
			If handle = _designer.Handle Then
				Return True
			End If
			If _designer.Controls.Count = 0 Then
				Return False
			End If
			Return IsChildControlMatch(handle, _designer.Controls)
		End Function
		''' <summary>
		''' Loops through the child controls to see if it's a child control that is sending the message.
		''' </summary>
		''' <remarks>The TypedValueEditor has controls made up of child controls so we need to see if the message is coming from a possible child control</remarks>
		Private Shared Function IsChildControlMatch(handle As IntPtr, controls As Control.ControlCollection) As Boolean
			For Each child As Control In controls
				If child.Handle = handle Then
					Return True
				End If
				If child.Controls.Count > 0 AndAlso IsChildControlMatch(handle, child.Controls) Then
					Return True
				End If
			Next
			Return False
		End Function
	End Class
End Class
