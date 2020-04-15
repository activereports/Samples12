Imports GrapeCity.ActiveReports.Design
Imports GrapeCity.ActiveReports.Design.Resources
Imports System.IO
Public Class DesignerForm
	Dim WithEvents _helpButton As ToolStripButton = New ToolStripButton()
	Dim _helperForm As New HelperForm()
	Private Sub UnifiedDesignerForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
		
		_helpButton.Text = "Help"
		
		'
		reportDesigner.LoadReport(New FileInfo("CustomTileProvider.rdlx"))
		_helperForm.Show()
	End Sub
	Private Sub _helpButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles _helpButton.Click
		_helperForm.Show()
	End Sub
	Public Sub New()
		InitializeComponent()
		reportDesigner.NewReport(DesignerReportType.Page) 'Sets the designer to create a blank page based report
		'Populating the ToolBox,reportExplorer and Propertygrid
		reportDesigner.Toolbox = reportToolbox 'Attaches the toolbox to the report designer
		reportExplorer.ReportDesigner = reportDesigner 'Attaches the report explorer to the report designer
		groupEditor.ReportDesigner = reportDesigner
		layerList.ReportDesigner = reportDesigner
		reportDesigner.PropertyGrid = propertyGrid 'Attaches the Property Grid to the report designer
		reportsLibrary.ReportDesigner = reportDesigner
		'Populating the menu.
		Dim toolStrip As ToolStrip = reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Menu})(0)
		toolStrip.Items.Add(_helpButton)
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
		
		fileMenu.DropDownItems.Add(New ToolStripMenuItem("New", My.Resources.CmdNewReport, New EventHandler(AddressOf OnNew), (Keys.Control Or Keys.N)))
		fileMenu.DropDownItems.Add(New ToolStripMenuItem("Open", My.Resources.CmdOpen, New EventHandler(AddressOf OnOpen), (Keys.Control Or Keys.O)))
		fileMenu.DropDownItems.Add(New ToolStripMenuItem("Save", My.Resources.CmdSave, New EventHandler(AddressOf OnSave), (Keys.Control Or Keys.S)))
		fileMenu.DropDownItems.Add(New ToolStripMenuItem("Save As", My.Resources.CmdSaveAs, New EventHandler(AddressOf OnSaveAs)))
		fileMenu.DropDownItems.Add(New ToolStripSeparator())
		fileMenu.DropDownItems.Add(New ToolStripMenuItem("Exit", Nothing, New EventHandler(AddressOf OnExit)))
		
		'
	End Sub
	'Getting the Designer to open a new Report on Menu Item "New" click
	Private Sub OnNew(ByVal sender As Object, ByVal e As EventArgs)
		If ConfirmSaveChanges() Then
			reportDesigner.ExecuteAction(DesignerAction.NewReport)
		End If
	End Sub
	'Getting the Designer to open a Report on Menu Item "Open" click
	Private Sub OnOpen(ByVal sender As Object, ByVal e As EventArgs)
		If ConfirmSaveChanges() Then
			reportDesigner.ExecuteAction(DesignerAction.FileOpen)
		End If
	End Sub
	'Getting the Designer to Save the Report on Menu Item "Save" click
	Private Sub OnSave(ByVal sender As Object, ByVal e As EventArgs)
		reportDesigner.ExecuteAction(DesignerAction.FileSave)
	End Sub
	'Getting the Designer to Save the Report on Menu Item "Save As" click
	Private Sub OnSaveAs(ByVal sender As Object, ByVal e As EventArgs)
		reportDesigner.ExecuteAction(DesignerAction.FileSave)
	End Sub
	Private Sub OnExit(ByVal sender As Object, ByVal e As EventArgs)
		Close()
	End Sub
	'Checking whether modifications have been made to the report loaded to the designer
	Private Function ConfirmSaveChanges() As Boolean
		If reportDesigner.IsDirty Then
			
			Dim result As DialogResult = MessageBox.Show("Report has been changed!!Do you wish to save it?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
			
			'
			If result = DialogResult.Cancel Then
				Return False
			ElseIf result = DialogResult.Yes Then
				Using saveDialog As New SaveFileDialog()
					
					saveDialog.Filter = "rdlx files|*.rdlx"
					
					'
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
	Private Sub AppendToolStrips(ByVal row As Integer, ByVal toolStrips As IList(Of ToolStrip))
		Dim topToolStripPanel As ToolStripPanel = ToolStripContainer.TopToolStripPanel
		Dim num As Integer = toolStrips.Count
		While Threading.Interlocked.Decrement(num) >= 0
			topToolStripPanel.Join(toolStrips(num), row)
		End While
	End Sub
	Private Function CreateReportToolbar() As ToolStrip
		Return New ToolStrip(New ToolStripButton() {CreateToolStripButton("New", My.Resources.CmdNewReport, New EventHandler(AddressOf OnNew), "New"), DesignerForm.CreateToolStripButton("Open", My.Resources.CmdOpen, New EventHandler(AddressOf OnOpen), "Open"), DesignerForm.CreateToolStripButton("Save", My.Resources.CmdSave, New EventHandler(AddressOf OnSave), "Save")})
	End Function
	Private Shared Function CreateToolStripButton(ByVal text As String, ByVal image As Image, ByVal handler As EventHandler, ByVal toolTip As String) As ToolStripButton
		Return New ToolStripButton(text, image, handler) With { _
		 .DisplayStyle = ToolStripItemDisplayStyle.Image, _
			.ToolTipText = toolTip, _
		 .DoubleClickEnabled = True _
		}
	End Function
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
			'
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
