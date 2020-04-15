Imports GrapeCity.ActiveReports.Design
Imports GrapeCity.ActiveReports.Design.Resources
Imports System.Xml
Imports System.IO
Public Class ReportsForm
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		
		' Add any initialization after the InitializeComponent() call. 
		reportDesigner.NewReport(DesignerReportType.Page) 'Sets the designer to create a blank page based report
		'Populating the ToolBox,reportExplorer and Propertygrid
		reportDesigner.Toolbox = reportToolbox 'Attaches the toolbox to the report designer
		reportExplorer.ReportDesigner = reportDesigner 'Attaches the report explorer to the report designer
		reportDesigner.PropertyGrid = propertyGrid 'Attaches the Property Grid to the report designer
		groupEditor.ReportDesigner = reportDesigner
		reportsLibrary.ReportDesigner = reportDesigner
		layerList.ReportDesigner = reportDesigner
		'Populating the Menu.Populating the Menu
		Dim toolStrip As ToolStrip = reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Menu})(0)
		Dim fileMenu As ToolStripDropDownItem = DirectCast(toolStrip.Items(0), ToolStripDropDownItem)
		CreateFileMenu(fileMenu)
		AppendToolStrips(0, New ToolStrip() {toolStrip})
		AppendToolStrips(1, reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Edit, DesignerToolStrips.Undo, DesignerToolStrips.Zoom}))
		AppendToolStrips(1, New ToolStrip() {CreateReportToolbar()})
		AppendToolStrips(2, reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Format, DesignerToolStrips.Layout}))
		
	End Sub
	
	'Adding DropDownItems to the ToolStripDropDownItem
	Private Sub CreateFileMenu(ByVal fileMenu As ToolStripDropDownItem)
		fileMenu.DropDownItems.Clear()
		fileMenu.DropDownItems.Add(New ToolStripMenuItem("New", My.Resources.CmdNewReport, New EventHandler(AddressOf OnNew), DirectCast(131150, Keys)))
		fileMenu.DropDownItems.Add(New ToolStripMenuItem("Open", My.Resources.CmdOpen, New EventHandler(AddressOf OnOpen), DirectCast(131151, Keys)))
		fileMenu.DropDownItems.Add(New ToolStripMenuItem("Save", My.Resources.CmdSave, New EventHandler(AddressOf OnSave), DirectCast(131155, Keys)))
		fileMenu.DropDownItems.Add(New ToolStripMenuItem("Save As", My.Resources.CmdSaveAs, New EventHandler(AddressOf OnSaveAs)))
		fileMenu.DropDownItems.Add(New ToolStripSeparator())
		fileMenu.DropDownItems.Add(New ToolStripMenuItem("Exit", Nothing, New EventHandler(AddressOf OnExit)))
	End Sub
	'Getting the Designer to open a new Report on Menu Item "New" click
	Private Sub OnNew(sender As Object, e As EventArgs)
		If ConfirmSaveChanges() Then
			reportDesigner.ExecuteAction(DesignerAction.NewReport)
		End If
	End Sub
	'Getting the Designer to open a Report on Menu Item "Open" click
	Private Sub OnOpen(sender As Object, e As EventArgs)
		If ConfirmSaveChanges() Then
			reportDesigner.ExecuteAction(DesignerAction.FileOpen)
		End If
	End Sub
	'Getting the Designer to Save the Report on Menu Item "Save" click
	Private Sub OnSave(sender As Object, e As EventArgs)
		reportDesigner.ExecuteAction(DesignerAction.FileSave)
	End Sub
	'Getting the Designer to Save the Report on Menu Item "Save As" click
	Private Sub OnSaveAs(sender As Object, e As EventArgs)
		reportDesigner.ExecuteAction(DesignerAction.FileSave)
	End Sub
	Private Sub OnExit(sender As Object, e As EventArgs)
		Close()
	End Sub
	'Checking whether modifications have been made to the report loaded to the designer
	Private Function ConfirmSaveChanges() As Boolean
		If reportDesigner.IsDirty Then
			Dim result As DialogResult = MessageBox.Show("Report has been changed!!Do you wish to save it?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
			If result = DialogResult.Cancel Then
				Return False
			ElseIf result = DialogResult.Yes Then
				Using saveDialog As New SaveFileDialog()
					saveDialog.Filter = "rdlx Files|*.rdlx"
					saveDialog.DefaultExt = ".rdlx"
					saveDialog.InitialDirectory = New DirectoryInfo(Application.ExecutablePath).Parent.Parent.Parent.FullName
					If saveDialog.ShowDialog() = DialogResult.OK Then
						reportDesigner.SaveReport(New FileInfo(saveDialog.FileName))
						reportDesigner.IsDirty = False
					End If
				End Using
			End If
		End If
		Return True
	End Function
	Private Sub AppendToolStrips(row As Integer, toolStrips As IList(Of ToolStrip))
		Dim topToolStripPanel As ToolStripPanel = toolStripContainer.TopToolStripPanel
		Dim num As Integer = toolStrips.Count
		While Threading.Interlocked.Decrement(num) >= 0
			topToolStripPanel.Join(toolStrips(num), row)
		End While
	End Sub
	Private Function CreateReportToolbar() As ToolStrip
		Return New ToolStrip(New ToolStripButton() {CreateToolStripButton("New", My.Resources.CmdNewReport, New EventHandler(AddressOf OnNew), "New"), CreateToolStripButton("Open", My.Resources.CmdOpen, New EventHandler(AddressOf OnOpen), "Open"), CreateToolStripButton("Save", My.Resources.CmdSave, New EventHandler(AddressOf OnSave), "Save")})
	End Function
	Private Shared Function CreateToolStripButton(text As String, image As Image, handler As EventHandler, toolTip As String) As ToolStripButton
		Return New ToolStripButton(text, image, handler) With { _
		 .DisplayStyle = ToolStripItemDisplayStyle.Image, _
			.ToolTipText = toolTip, _
		 .DoubleClickEnabled = True _
		}
	End Function
	
	Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim report As PageReport = LayoutBuilder.BuildReportLayout() 'Loading the layout to a PageReport object
		report = LayoutBuilder.AddDataSetDataSource(report) 'Adding DataSources to the PageReport object
		Dim reportStream As MemoryStream = LayoutBuilder.LoadReportToStream(report) 'Loading the PageReport object to a stream
		  
		reportDesigner.LoadReport(XmlReader.Create(reportStream), DesignerReportType.Page) 'Loading the stream to the designer
		
		'
		'
		'
		report.Dispose()
		reportStream.Dispose()
	End Sub
	
	Private Sub CreateReportExplorer()
		If reportDesigner.ReportType = DesignerReportType.Section Then
			If explorerpropertygridContainer.Panel1.Controls.Contains(reportExplorerTabControl) Then
				reportExplorerTabControl.TabPages(0).SuspendLayout()
				explorerpropertygridContainer.Panel1.SuspendLayout()
				explorerpropertygridContainer.Panel1.Controls.Remove(reportExplorerTabControl)
				explorerpropertygridContainer.Panel1.Controls.Add(reportExplorer)
				reportExplorerTabControl.TabPages(0).ResumeLayout()
				explorerpropertygridContainer.Panel1.ResumeLayout()
			End If
		ElseIf (Not explorerpropertygridContainer.Panel1.Controls.Contains(reportExplorerTabControl)) Then
			reportExplorerTabControl.TabPages(0).SuspendLayout()
			explorerpropertygridContainer.Panel1.SuspendLayout()
			explorerpropertygridContainer.Panel1.Controls.Remove(reportExplorer)
			reportExplorerTabControl.TabPages(0).Controls.Add(reportExplorer)
			explorerpropertygridContainer.Panel1.Controls.Add(reportExplorerTabControl)
			reportExplorerTabControl.TabPages(0).ResumeLayout()
			explorerpropertygridContainer.Panel1.ResumeLayout()
		End If
	End Sub
	Private Sub reportDesigner_LayoutChanged(sender As Object, e As LayoutChangedArgs) Handles reportDesigner.LayoutChanged
		CreateReportExplorer()
	End Sub
	 
End Class
