Imports GrapeCity.ActiveReports.Design
Imports GrapeCity.ActiveReports.Design.Resources
Imports System.IO
Imports System.Drawing.Design
Imports GrapeCity.ActiveReports.PageReportModel
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Xml.Linq
Imports System.Linq
Imports GrapeCity.ActiveReports.Export.Pdf.Page
Imports GrapeCity.ActiveReports.Rendering.IO
Public Class ReportsForm
	Dim _fileMenu As ToolStripDropDownItem
	Dim _exportMenuItem As ToolStripMenuItem
	Dim _exportButton As ToolStripButton
	Dim _reportName As String
	Dim _item As ToolStrip = Nothing
	Private Shared _folderPath As String
	Public Shared ReadOnly Property FolderPath() As String
		Get
			Return _folderPath
		End Get
	End Property
	Private Shared _excludeFoldersList As New List(Of String)()
	Public Shared ReadOnly Property ExcludeFoldersList() As List(Of String)
		Get
			Return _excludeFoldersList
		End Get
	End Property
	Private Shared _excludeFilesList As New List(Of String)()
	Public Shared ReadOnly Property ExcludeFilesList() As List(Of String)
		Get
			Return _excludeFilesList
		End Get
	End Property
	'Add nodes to tree view
	Private Sub ListDirectory(ByVal treeView As TreeView, ByVal path As String)
		treeView.Nodes.Clear()
		Dim rootDirectoryInfo As New DirectoryInfo(path)
		For Each directory As DirectoryInfo In rootDirectoryInfo.GetDirectories()
			treeView.Nodes.Add(CreateDirectoryNode(directory))
		Next
	End Sub
	' Traverse Samples Folder and create tree
	Private Shared Function CreateDirectoryNode(ByVal directoryInfo As DirectoryInfo) As TreeNode
		Dim directoryNode As New TreeNode(directoryInfo.Name)
		For Each directory As DirectoryInfo In directoryInfo.GetDirectories()
			Dim dirname As String=directory.FullName
			If Not ExcludeFoldersList.Exists(Function(t) t.ToString() = dirname) Then
				directoryNode.Nodes.Add(CreateDirectoryNode(directory))
			End If
		Next
		For Each file As FileInfo In directoryInfo.GetFiles("*.rpx").Concat(directoryInfo.GetFiles("*.rdlx"))
			Dim filename As String = file.FullName
			If Not ExcludeFilesList.Exists(Function(t) t.ToString() = filename) Then
				Dim reportFileNode As New TreeNode(file.Name)
				reportFileNode.ImageIndex = 2
				reportFileNode.SelectedImageIndex = 2
				reportFileNode.ForeColor = Color.Brown
				reportFileNode.Tag = file.FullName
				directoryNode.Nodes.Add(reportFileNode)
			End If
		Next
		Return directoryNode
	End Function
	Public Sub New()
		Application.EnableVisualStyles()
		' This call is required by the designer.
		InitializeComponent()
		'Add any initialization after the InitializeComponent() call. 
		'Set the ToolBox, ReportExplorer and PropertyGrid in the Designer.
		reportDesigner.Toolbox = reportToolbox 'Attaches the toolbox to the report designer
		reportExplorer.ReportDesigner = reportDesigner 'Attaches the report explorer to the report designer
		AddHandler reportDesigner.LayoutChanged, AddressOf reportDesigner_LayoutChanged
		layerList.ReportDesigner = reportDesigner
		groupEditor.ReportDesigner = reportDesigner
		reportsLibrary.ReportDesigner = reportDesigner
		reportDesigner.PropertyGrid = reportPropertyGrid 'Attaches the Property Grid to the report designer
		'Populate the menu.
		Dim toolstrip As ToolStrip = reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Menu})(0)
		_fileMenu = DirectCast(toolstrip.Items(0), ToolStripDropDownItem)
		CreateFileMenu(_fileMenu)
		AppendToolStrips(0, New ToolStrip() {toolstrip})
		AppendToolStrips(1, reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Edit, DesignerToolStrips.Undo, DesignerToolStrips.Zoom}))
		_item = CreateReportToolbar()
		AppendToolStrips(1, New ToolStrip() {_item})
		AppendToolStrips(2, reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Format, DesignerToolStrips.Layout}))
		LoadTools(reportToolbox)
		AddHandler reportDesigner.ActiveTabChanged, AddressOf OnEnableExport
		CreateReportExplorer()
		Dim loaded As XDocument = XDocument.Load("TreeList.config")
		_folderPath = loaded.Descendants("FolderPath").[Select](Function(t) t.Value.ToString()).ToList()(0)
		Dim reportbasefolder As New DirectoryInfo(FolderPath)
		_excludeFilesList = loaded.Descendants("ExcludeFiles").ToList()(0).Descendants("File").[Select](Function(t) reportbasefolder.FullName + "\" & t.Value.ToString()).ToList()
		_excludeFoldersList = loaded.Descendants("ExcludeFolders").ToList()(0).Descendants("Folder").[Select](Function(t) reportbasefolder.FullName + "\" & t.Value.ToString()).ToList()
	End Sub
	Private Function PerformSave() As Boolean
		If String.IsNullOrEmpty(_reportName) OrElse String.IsNullOrEmpty(System.IO.Path.GetDirectoryName(_reportName)) OrElse Not File.Exists(_reportName) Then
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
	Private Function GetSaveFilter(ByVal type As DesignerReportType, ByVal isMaster As Boolean) As String
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
		_exportMenuItem = New ToolStripMenuItem(My.Resources.Resource.ExportText, Nothing, New EventHandler(AddressOf OnExport), (Keys.Control Or Keys.E))
		_exportMenuItem.Enabled = False
		fileMenu.DropDownItems.Add(_exportMenuItem)
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.Resource.SaveText, My.Resources.Resource.CmdSave, New EventHandler(AddressOf OnSave), (Keys.Control Or Keys.S)))
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.Resource.SaveAsText, My.Resources.Resource.CmdSaveAs, New EventHandler(AddressOf OnSaveAs)))
		fileMenu.DropDownItems.Add(New ToolStripSeparator())
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.Resource.ExitText, Nothing, New EventHandler(AddressOf OnExit)))
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
		PerformSave()
	End Sub
	'Click "Save as" to save a report with a name.
	Private Sub OnSaveAs(ByVal sender As Object, ByVal e As EventArgs)
		PerformSaveAs()
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
		_exportButton = ReportsForm.CreateToolStripButton(My.Resources.Resource.ExportText, Nothing, New EventHandler(AddressOf OnExport), My.Resources.Resource.ExportText, ToolStripItemDisplayStyle.Text)
		_exportButton.Enabled = False
		Return New ToolStrip(New ToolStripButton() {ReportsForm.CreateToolStripButton(My.Resources.Resource.NewText, My.Resources.Resource.CmdNewReport, New EventHandler(AddressOf OnNew), My.Resources.Resource.NewText, ToolStripItemDisplayStyle.Image), ReportsForm.CreateToolStripButton(My.Resources.Resource.OpenText, My.Resources.Resource.CmdOpen, New EventHandler(AddressOf OnOpen), My.Resources.Resource.OpenText, ToolStripItemDisplayStyle.Image), ReportsForm.CreateToolStripButton(My.Resources.Resource.SaveText, My.Resources.Resource.CmdSave, New EventHandler(AddressOf OnSave), My.Resources.Resource.SaveText, ToolStripItemDisplayStyle.Image), _exportButton})
	End Function
	Private Shared Function CreateToolStripButton(ByVal text As String, ByVal image As System.Drawing.Image, ByVal handler As EventHandler, ByVal toolTip As String, ByVal toolStripDisplayStyle As ToolStripItemDisplayStyle) As ToolStripButton
		Return New ToolStripButton(text, image, handler) With { _
	  .DisplayStyle = toolStripDisplayStyle, _
	  .ToolTipText = toolTip, _
	  .DoubleClickEnabled = True, _
	  .Text = text _
	  }
	End Function
	Private Sub OnExport(ByVal sender As Object, ByVal e As EventArgs)
		If DirectCast(reportDesigner.Report, PageReport).Document IsNot Nothing Then
			Dim settings As New Settings()
			settings.HideToolbar = True
			settings.HideMenubar = True
			settings.HideWindowUI = True
			saveFileDialog.Filter = My.Resources.Resource.PDFFilter
			Dim renderingExtension As New PdfRenderingExtension()
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				If File.Exists(saveFileDialog.FileName) Then
					File.Delete(saveFileDialog.FileName)
				End If
				Dim exportfile As New FileStreamProvider(New DirectoryInfo(Path.GetDirectoryName(saveFileDialog.FileName)), Path.GetFileNameWithoutExtension(saveFileDialog.FileName))
				DirectCast(reportDesigner.Report, PageReport).Document.Render(renderingExtension, exportfile, settings)
				MessageBox.Show(My.Resources.Resource.ExportCompleteString)
			End If
		End If
	End Sub
	Private Shared Sub LoadTools(ByVal toolbox As IToolboxService)
		'Add Data Providers.
		For Each type As Type In New Type() {GetType(System.Data.DataSet), GetType(DataView), GetType(OleDb.OleDbConnection), GetType(OleDb.OleDbDataAdapter), GetType(Odbc.OdbcConnection), GetType(Odbc.OdbcDataAdapter), GetType(SqlClient.SqlConnection), GetType(SqlClient.SqlDataAdapter)}
			toolbox.AddToolboxItem(New ToolboxItem(type), My.Resources.Resource.ToolBoxData)
		Next
	End Sub
	Private Sub EnableTabs()
		reportToolbox.Reorder(reportDesigner)
		reportToolbox.EnsureCategories()
		reportToolbox.Refresh()
	End Sub
	Private Sub reportDesigner_LayoutChanged(ByVal sender As System.Object, ByVal e As LayoutChangedArgs)
		If e.Type = LayoutChangeType.ReportLoad OrElse e.Type = LayoutChangeType.ReportClear Then
			reportToolbox.Reorder(reportDesigner)
			reportToolbox.EnsureCategories()
			reportToolbox.Refresh()
			RefreshExportEnabled()
			CreateReportExplorer()
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
	End Sub
	Private Sub OnEnableExport(ByVal sender As Object, ByVal eventArgs As EventArgs)
		If reportDesigner.ReportType <> DesignerReportType.Section Then
			If _exportMenuItem IsNot Nothing Then
				_exportMenuItem.Enabled = reportDesigner.ActiveTab = DesignerTab.Preview
			End If
			If _exportButton IsNot Nothing Then
				_exportButton.Enabled = reportDesigner.ActiveTab = DesignerTab.Preview
			End If
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
	Private Sub ReportsForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		
		treeView.Font = New Font("Arial", 10, FontStyle.Bold)
			  
		'
		If Not String.IsNullOrEmpty(FolderPath) Then
			ListDirectory(treeView, FolderPath)
		End If
	End Sub
	Private Sub treeView_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles treeView.NodeMouseClick
		If (e.Node.Text.ToLower().EndsWith(".rdlx")) OrElse (e.Node.Text.ToLower().EndsWith(".rpx")) Then
			e.Node.ImageIndex = 2
			treeView.SelectedNode = e.Node
			Dim reportFile As New FileInfo(e.Node.Tag.ToString())
			reportDesigner.LoadReport(reportFile)
		Else
			If e.Node.Parent IsNot Nothing Then
				MessageBox.Show(My.Resources.Resource.InvalidFileText)
			End If
		End If
	End Sub
	Private Sub treeView_AfterCollapse(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles treeView.AfterCollapse
		e.Node.ImageIndex = 0
		e.Node.SelectedImageIndex = 0
	End Sub
	Private Sub treeView_AfterExpand(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles treeView.AfterExpand
		e.Node.ImageIndex = 1
		e.Node.SelectedImageIndex = 1
	End Sub
End Class
