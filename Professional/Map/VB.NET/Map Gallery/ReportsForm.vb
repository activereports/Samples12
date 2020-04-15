Imports GrapeCity.ActiveReports.Design
Imports GrapeCity.ActiveReports.Design.Resources
Imports System.IO
Imports System.Drawing.Design
Imports System.Xml
Public Class ReportsForm
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
	Private Sub ListDirectory(treeView As TreeView, path As String)
		treeView.Nodes.Clear()
		Dim rootDirectoryInfo = New DirectoryInfo(path)
		For Each directory As DirectoryInfo In rootDirectoryInfo.GetDirectories()
			treeView.Nodes.Add(CreateDirectoryNode(directory))
		Next
	End Sub
	' Traverse Samples Folder and create tree
	Private Shared Function CreateDirectoryNode(directoryInfo As DirectoryInfo) As TreeNode
		Dim directoryNode = New TreeNode(directoryInfo.Name)
		For Each directory As DirectoryInfo In directoryInfo.GetDirectories()
			Dim dirname As String = directory.FullName
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
	Private Shared Sub LoadTools(ByVal toolbox As IToolboxService)
		'Add Data Providers.
		For Each type As Type In New Type() {GetType(DataSet), GetType(DataView), GetType(OleDb.OleDbConnection), GetType(OleDb.OleDbDataAdapter), GetType(Odbc.OdbcConnection), GetType(Odbc.OdbcDataAdapter), GetType(SqlClient.SqlConnection), GetType(SqlClient.SqlDataAdapter)}
			toolbox.AddToolboxItem(New ToolboxItem(type), My.Resources.ToolBoxData)
		Next
	End Sub
	' Folder Localization
	Private Sub FolderLocalization()
		Dim strReplace As New Hashtable()
		Dim reader As New StreamReader(New FileStream("..\..\MapGallery.config", FileMode.Open, FileAccess.Read, FileShare.Read))
		Dim doc As New XmlDocument()
		Dim xmlIn As String = reader.ReadToEnd()
		reader.Close()
		doc.LoadXml(xmlIn)
		For Each child As XmlNode In doc.ChildNodes(1).ChildNodes
			If child.Name.Equals("Localization") Then
				For Each node As XmlNode In child.ChildNodes
					If node.Name.Equals("ReplaceName") Then
						strReplace.Add(node.Attributes("OriginalName").Value, node.Attributes("ReplaceWith").Value)
					End If
				Next
			End If
		Next
		For i As Integer = 0 To treeView.Nodes.Count - 1
			For Each entry As DictionaryEntry In strReplace
				If treeView.Nodes(i).Text.Equals(entry.Key.ToString()) Then
					treeView.Nodes(i).Text = entry.Value.ToString()
				End If
			Next
		Next
	End Sub
	Private Sub ReportsForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
		
		treeView.Font = New Font("Arial", 10, FontStyle.Bold)
			  
		'
		If Not String.IsNullOrEmpty(FolderPath) Then
			ListDirectory(treeView, FolderPath)
		End If
		FolderLocalization()
	End Sub
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		'Add any initialization after the InitializeComponent() call
		'Populate the ToolBox, ReportExplorer and PropertyGrid
		reportDesigner.Toolbox = reportToolbox 'Attach the Toolbox to the report designer
		reportExplorer.ReportDesigner = reportDesigner 'Attach the Report Explorer to the report designer
		reportDesigner.PropertyGrid = reportPropertyGrid 'Attach the Property Grid to the report designer
		layerList.ReportDesigner = reportDesigner
		groupEditor.ReportDesigner = reportDesigner
		reportsLibrary.ReportDesigner = reportDesigner
		'Create a toolstrip to be used as a menu.
		CreateReportExplorer()
		Dim toolstrip As ToolStrip = Me.reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Menu})(0)
		Dim filemenu As ToolStripDropDownItem = DirectCast(toolstrip.Items(0), ToolStripDropDownItem)
		CreateFileMenu(filemenu)
		AppendToolStrips(0, New ToolStrip() {toolstrip})
		AppendToolStrips(1, reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Edit, DesignerToolStrips.Undo, DesignerToolStrips.Zoom}))
		AppendToolStrips(2, reportDesigner.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Format, DesignerToolStrips.Layout}))
		reportDesigner.NewReport(DesignerReportType.Page)
		LoadTools(reportToolbox)
		' load config settings
		Dim loaded As XDocument = XDocument.Load("MapGallery.config")
		_folderPath = loaded.Descendants("FolderPath").[Select](Function(t) t.Value.ToString()).ToList()(0)
		Dim reportbasefolder As New DirectoryInfo(FolderPath)
		_excludeFilesList = loaded.Descendants("ExcludeFiles").ToList()(0).Descendants("File").[Select](Function(t) reportbasefolder.FullName + "\" & t.Value.ToString()).ToList()
		_excludeFoldersList = loaded.Descendants("ExcludeFolders").ToList()(0).Descendants("Folder").[Select](Function(t) reportbasefolder.FullName + "\" & t.Value.ToString()).ToList()
	End Sub
	'Adding DropDownItems to the ToolStripDropDownItem
	Private Sub CreateFileMenu(ByVal fileMenu As ToolStripDropDownItem)
		fileMenu.DropDownItems.Clear()
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.NewText, My.Resources.CmdNewReport, New EventHandler(AddressOf OnNew), (Keys.Control Or Keys.N)))
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.OpenText, My.Resources.CmdOpen, New EventHandler(AddressOf OnOpen), (Keys.Control Or Keys.O)))
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.SaveText, My.Resources.CmdSave, New EventHandler(AddressOf OnSave), (Keys.Control Or Keys.S)))
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.SaveAsText, My.Resources.CmdSaveAs, New EventHandler(AddressOf OnSaveAs)))
		fileMenu.DropDownItems.Add(New ToolStripSeparator())
		fileMenu.DropDownItems.Add(New ToolStripMenuItem(My.Resources.ExitText, Nothing, New EventHandler(AddressOf OnExit)))
	End Sub
	'Click the "New" button to open a new report.
	Private Sub OnNew(ByVal sender As Object, ByVal e As EventArgs)
		If ConfirmSaveChanges() Then
			reportDesigner.ExecuteAction(DesignerAction.NewReport)
		End If
	End Sub
	'Click the "Open" button to open an existing report.
	Private Sub OnOpen(ByVal sender As Object, ByVal e As EventArgs)
		If ConfirmSaveChanges() Then
			reportDesigner.ExecuteAction(DesignerAction.FileOpen)
		End If
	End Sub
	'Click the "Save" button to save your report.
	Private Sub OnSave(ByVal sender As Object, ByVal e As EventArgs)
		reportDesigner.ExecuteAction(DesignerAction.FileSave)
	End Sub
	'Click the "Save As" button to open the Save As dialog.
	Private Sub OnSaveAs(ByVal sender As Object, ByVal e As EventArgs)
		reportDesigner.ExecuteAction(DesignerAction.FileSave)
	End Sub
	Private Sub OnExit(ByVal sender As Object, ByVal e As EventArgs)
		Close()
	End Sub
	'Check whether modifications have been made to the report loaded in the designer
	Private Function ConfirmSaveChanges() As Boolean
		If reportDesigner.IsDirty Then
			Dim result As DialogResult = MessageBox.Show(My.Resources.ReportDirtyMessage, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
			If result = DialogResult.Cancel Then
				Return False
			ElseIf result = DialogResult.Yes Then
				Using saveDialog As New SaveFileDialog()
					saveDialog.Filter = "rdlx files|*.rdlx"
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
		Dim topToolStripPanel As ToolStripPanel = toolStripContainer.TopToolStripPanel
		Dim num As Integer = toolStrips.Count
		While Threading.Interlocked.Decrement(num) >= 0
			topToolStripPanel.Join(toolStrips(num), row)
		End While
	End Sub
	Private Sub treeView_AfterCollapse(ByVal sender As System.Object, ByVal e As Windows.Forms.TreeViewEventArgs) Handles treeView.AfterCollapse
		e.Node.ImageIndex = 0
		e.Node.SelectedImageIndex = 0
	End Sub
	Private Sub treeView_AfterExpand(ByVal sender As System.Object, ByVal e As Windows.Forms.TreeViewEventArgs) Handles treeView.AfterExpand
		e.Node.ImageIndex = 1
		e.Node.SelectedImageIndex = 1
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
			'
			'
			'
			reportExplorerTabControl.TabPages(0).SuspendLayout()
			explorerPropertyGridContainer.Panel1.SuspendLayout()
			explorerPropertyGridContainer.Panel1.Controls.Remove(reportExplorer)
			reportExplorerTabControl.TabPages(0).Controls.Add(reportExplorer)
			explorerPropertyGridContainer.Panel1.Controls.Add(reportExplorerTabControl)
			reportExplorerTabControl.TabPages(0).ResumeLayout()
			explorerPropertyGridContainer.Panel1.ResumeLayout()
		End If
	End Sub
	Private Sub reportDesigner_LayoutChanged(sender As Object, e As LayoutChangedArgs) Handles reportDesigner.LayoutChanged
		CreateReportExplorer()
	End Sub
	'Handle click on Tree Node
	Private Sub treeView_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles treeView.NodeMouseClick
		If (e.Node.Text.ToLower().EndsWith(".rdlx")) OrElse (e.Node.Text.ToLower().EndsWith(".rpx")) Then
			e.Node.ImageIndex = 2
			treeView.SelectedNode = e.Node
			Dim reportFile As New FileInfo(e.Node.Tag.ToString())
			reportDesigner.LoadReport(reportFile)
		Else
			If e.Node.Parent IsNot Nothing Then
				MessageBox.Show(My.Resources.InvalidFileText)
			End If
		End If
	End Sub
End Class
