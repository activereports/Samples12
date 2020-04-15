Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Xml
Imports GrapeCity.ActiveReports
Imports GrapeCity.ActiveReports.Design
Imports GrapeCity.ActiveReports.Design.Resources
Imports GrapeCity.ActiveReports.Samples.ReportWizard.MetaData
Imports GrapeCity.ActiveReports.Samples.ReportWizard.UI
Imports GrapeCity.ActiveReports.Samples.ReportWizard.UI.WizardSteps
Namespace UI
	Partial Public Class ReportsForm
		Inherits Form
		Private Shared availableReports As List(Of ReportMetaData)
		Public Shared ReadOnly Property AvailableReportTemplates() As IEnumerable(Of ReportMetaData)
			Get
				Return availableReports
			End Get
		End Property
		Private Shared state As ReportWizardState
		Private reportDefinition As PageReport
		Public Sub New()
			InitializeComponent()
		End Sub
		'Adding DropDownItems to the ToolStripDropDownItem
		
		Private Sub CreateFileMenu(ByVal fileMenu As ToolStripDropDownItem)
			fileMenu.DropDownItems.Clear()
			fileMenu.DropDownItems.Add(New ToolStripMenuItem("New", GrapeCity.ActiveReports.Samples.ReportWizard.Resources.CmdNewReport, AddressOf Me.OnNew, CType(131150, Keys)))
			fileMenu.DropDownItems.Add(New ToolStripMenuItem("Open", GrapeCity.ActiveReports.Samples.ReportWizard.Resources.CmdOpen, AddressOf Me.OnOpen, CType(131151, Keys)))
			fileMenu.DropDownItems.Add(New ToolStripMenuItem("Save", GrapeCity.ActiveReports.Samples.ReportWizard.Resources.CmdSave, AddressOf Me.OnSave, CType(131155, Keys)))
			fileMenu.DropDownItems.Add(New ToolStripMenuItem("Save As", GrapeCity.ActiveReports.Samples.ReportWizard.Resources.CmdSaveAs, AddressOf Me.OnSaveAs))
			fileMenu.DropDownItems.Add(New ToolStripSeparator())
			fileMenu.DropDownItems.Add(New ToolStripMenuItem("Exit", Nothing, AddressOf Me.OnExit))
		End Sub
		Private Function CreateReportToolbar() As ToolStrip
			Return New ToolStrip(New ToolStripButton() {ReportsForm.CreateToolStripButton("New", GrapeCity.ActiveReports.Samples.ReportWizard.Resources.CmdNewReport, AddressOf Me.OnNew, "New"), ReportsForm.CreateToolStripButton("Open", GrapeCity.ActiveReports.Samples.ReportWizard.Resources.CmdOpen, AddressOf Me.OnOpen, "Open"), ReportsForm.CreateToolStripButton("Save", GrapeCity.ActiveReports.Samples.ReportWizard.Resources.CmdSave, AddressOf Me.OnSave, "Save")})
		End Function
		Private Shared Function CreateToolStripButton(ByVal text As String, ByVal image As Image, ByVal handler As EventHandler, ByVal toolTip As String) As ToolStripButton
			Return New ToolStripButton(text, image, handler)
		End Function
		'Getting the Designer to open a new Report on Menu Item "New" click
		Private Sub OnNew(ByVal sender As Object, ByVal e As EventArgs)
			If Me.ConfirmSaveChanges() Then
				Me.userDesignerControl1.ExecuteAction(DesignerAction.NewReport)
			End If
		End Sub
		'Getting the Designer to open a Report on Menu Item "Open" click
		Private Sub OnOpen(ByVal sender As Object, ByVal e As EventArgs)
			If Me.ConfirmSaveChanges() Then
				Me.userDesignerControl1.ExecuteAction(DesignerAction.FileOpen)
			End If
		End Sub
		'Getting the Designer to Save the Report on Menu Item "Save" click
		Private Sub OnSave(ByVal sender As Object, ByVal e As EventArgs)
			Me.userDesignerControl1.ExecuteAction(DesignerAction.FileSave)
		End Sub
		'Getting the Designer to Save the Report on Menu Item "Save As" click
		Private Sub OnSaveAs(ByVal sender As Object, ByVal e As EventArgs)
			Me.userDesignerControl1.ExecuteAction(DesignerAction.FileSave)
		End Sub
		Private Sub OnExit(ByVal sender As Object, ByVal e As EventArgs)
			MyBase.Close()
		End Sub
		'Checking whether modifications have been made to the report loaded to the designer
		Private Function ConfirmSaveChanges() As Boolean
			If Me.userDesignerControl1.IsDirty Then
				Dim dialogresult As DialogResult = MessageBox.Show("Report has been changed!!Do you wish to save it?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
				If (dialogresult).Equals(dialogresult.Cancel) Then
					Return False
				ElseIf (dialogresult).Equals(dialogresult.Yes) Then
					Using _savedialog As New SaveFileDialog()
						_savedialog.Filter = "rdlx files|*.rdlx"
						_savedialog.DefaultExt = ".rdlx"
						_savedialog.InitialDirectory = New DirectoryInfo(Application.ExecutablePath).Parent.Parent.Parent.FullName
						If (_savedialog.ShowDialog()).Equals(dialogresult.OK) Then
							Me.userDesignerControl1.SaveReport(New System.IO.FileInfo(_savedialog.FileName))
							Me.userDesignerControl1.IsDirty = False
						End If
					End Using
				End If
			End If
			Return True
		End Function
		Private Sub AppendToolStrips(ByVal row As Integer, ByVal toolStrips As IList(Of ToolStrip))
			Dim topToolStripPanel As ToolStripPanel = Me.toolStripContainer1.TopToolStripPanel
			Dim num As Integer = toolStrips.Count
			While System.Threading.Interlocked.Decrement(num) >= 0
				topToolStripPanel.Join(toolStrips(num), row)
			End While
		End Sub
		
	   
		Private Shared Function SaveReportToStream(ByVal def As PageReport) As Stream
			Dim stream As New MemoryStream()
			Using writer As XmlWriter = XmlWriter.Create(stream)
				If def IsNot Nothing Then
					def.Save(writer)
				End If
			End Using
			stream.Position = 0
			Return stream
		End Function
		Private Shared Sub SetupTemplates()
			availableReports = New List(Of ReportMetaData)()
			Dim doc As New XmlDocument()
			doc.Load("Reports.xml")
			For Each reportNode As XmlNode In doc.SelectNodes("//reports/report")
				availableReports.Add(LoadReportMetaData(reportNode))
			Next
		End Sub
		Private Shared Function LoadReportMetaData(ByVal node As XmlNode) As ReportMetaData
			Dim data As New ReportMetaData()
			data.Title = node.Attributes("title").Value
			data.MasterReportFile = node.Attributes("filename").Value
			Dim fields As XmlNodeList = node.SelectNodes("fields/field")
			For Each fieldNode As XmlNode In fields
				Dim field As FieldMetaData = LoadFieldMetaData(fieldNode)
				data.Fields.Add(field.Name, field)
			Next
			Return data
		End Function
		Private Shared Function LoadFieldMetaData(ByVal node As XmlNode) As FieldMetaData
			Dim data As New FieldMetaData()
			data.Name = node.Attributes("name").Value
			data.Title = node.Attributes("title").Value
			data.PreferredWidth = node.Attributes("width").Value
			data.IsNumeric = node.Attributes("datatype").Value = "number"
			Dim attr As XmlAttribute = node.Attributes("format")
			If Not (attr) Is Nothing Then
				data.FormatString = attr.Value
			End If
			attr = node.Attributes("summarizable")
			If Not (attr) Is Nothing Then
				data.AllowTotaling = Convert.ToBoolean(attr.Value)
			End If
			attr = node.Attributes("summaryFunction")
			If Not (attr) Is Nothing Then
				data.SummaryFunction = attr.Value
			End If
			Return data
		End Function
		Private Shared Function CreateWizard() As WizardDialog
			state = New ReportWizardState()
			state.AvailableMasterReports.AddRange(AvailableReportTemplates)
			Dim dlg As New WizardDialog(state)
			dlg.Steps.Add(New SelectMasterReport())
			dlg.Steps.Add(New SelectGroupingFields())
			dlg.Steps.Add(New SelectOutputFields())
			dlg.Steps.Add(New SelectSummaryOptions())
			Return dlg
		End Function
		Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
			SetupTemplates()
			Dim wizard As WizardDialog = CreateWizard()
			Dim res As DialogResult = wizard.ShowDialog()
			If res.Equals(DialogResult.OK) Then
				
				Me.groupEditor.ReportDesigner = Me.userDesignerControl1
				Me.reportsLibrary.ReportDesigner = Me.userDesignerControl1
				
				Me.reportDefinition = LayoutBuilder.BuildReport(state)
				
				Me.userDesignerControl1.NewReport(DesignerReportType.Page)
				''Sets the designer to create a blank page based report
				''Populating the ToolBox,reportExplorer and Propertygrid
				Me.userDesignerControl1.Toolbox = Me.reportToolbox
				''Attaches the toolbox to the report designer
				Me.reportExplorer.ReportDesigner = Me.userDesignerControl1
				''Attaches the report explorer to the report designer
				Me.userDesignerControl1.PropertyGrid = Me.reportpropertyGrid
				layerList.ReportDesigner = userDesignerControl1
				''Attaches the Property Grid to the report designer
				''Populating the MenuPopulating the Menu
				Dim toolstrip As ToolStrip = Me.userDesignerControl1.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Menu})(0)
				Dim filemenu As ToolStripDropDownItem = CType(toolstrip.Items(0), ToolStripDropDownItem)
				Me.CreateFileMenu(filemenu)
				Me.AppendToolStrips(0, New ToolStrip() {toolstrip})
				Me.AppendToolStrips(1, Me.userDesignerControl1.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Edit, DesignerToolStrips.Undo, DesignerToolStrips.Zoom}))
				Dim item As ToolStrip = Me.CreateReportToolbar()
				Me.AppendToolStrips(1, New List(Of ToolStrip)())
				Me.AppendToolStrips(2, Me.userDesignerControl1.CreateToolStrips(New DesignerToolStrips() {DesignerToolStrips.Format, DesignerToolStrips.Layout}))
				
				Using stream As Stream = SaveReportToStream(reportDefinition)
					
					Dim xmlReader As XmlReader = xmlReader.Create(stream)
					userDesignerControl1.LoadReport(xmlReader, GrapeCity.ActiveReports.Design.DesignerReportType.Page)
					
					'
				End Using
			Else
				BeginInvoke(New MethodInvoker(AddressOf Me.Close))
			End If
		   
		End Sub
		
		Private Sub CreateReportExplorer()
			If userDesignerControl1.ReportType = DesignerReportType.Section Then
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
		Private Sub reportDesigner_LayoutChanged(sender As Object, e As LayoutChangedArgs) Handles userDesignerControl1.LayoutChanged
			CreateReportExplorer()
		End Sub
		
	End Class
End Namespace
