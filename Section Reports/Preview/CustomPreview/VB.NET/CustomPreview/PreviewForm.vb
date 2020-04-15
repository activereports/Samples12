Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
' PreviewForm - child MDI form that loads the ActiveReports Viewer to view a report
' and provides options to export, save and print the generated report.
Public Class PreviewForm
	Inherits Windows.Forms.Form
	
	Private WithEvents tsbSaveRdf As New ToolStripButton("Save")
	
	'
	
	Private WithEvents tsbExport As New ToolStripButton("Export")
	
	'
	' Required designer variable.
	Public Sub New(ByVal doc As Document.SectionDocument, ByVal parentForm As Form)
		MyBase.New()
		'Required for Windows Form Designer support
		InitializeComponent()
		MdiParent = parentForm
		arvMain.Document = doc
		Text = doc.Name
	End Sub
	'Clean up any resources being used.
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If Not (components Is Nothing) Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	Private Sub PreviewForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		' Add custom buttons to the viewer's toolbar.
		Dim ico As New Icon([GetType]().[Module].Assembly.GetManifestResourceStream("GrapeCity.ActiveReports.Samples.CustomPreview.Save16x16.ico"))
		arvMain.Toolbar.ToolStrip.ImageList = New ImageList()
		arvMain.Toolbar.ToolStrip.ImageList.Images.Add("saveicon", ico)
		ico = New Icon([GetType]().[Module].Assembly.GetManifestResourceStream("GrapeCity.ActiveReports.Samples.CustomPreview.Export16x16.ico"))
		arvMain.Toolbar.ToolStrip.ImageList.Images.Add("exporticon", ico)
		Dim ts As ToolStrip = arvMain.Toolbar.ToolStrip
		'Add Save toolstrip button to the toolbar.
		tsbSaveRdf.Image = arvMain.Toolbar.ToolStrip.ImageList.Images("saveicon")
		'Add Export toolstrip button to the toolbar
		tsbExport.Image = arvMain.Toolbar.ToolStrip.ImageList.Images("exporticon")
		ts.Items.Add(tsbSaveRdf)
		ts.Items.Add(New ToolStripSeparator())
		ts.Items.Add(tsbExport)
	End Sub 'PreviewForm_Load
	Private Sub tsbExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbExport.Click
		ExportDocument()
	End Sub
	Private Sub tsbSaveRdf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbSaveRdf.Click
		SaveDocument()
	End Sub
	'Saves out an existing report document to the RDF format.
	Private Sub SaveDocument()
		Dim dialogSave As New SaveFileDialog
		
		dialogSave.Title = "Save Report Document"
		
		'
		
		dialogSave.Filter = "Report Document Files (*.rdf)|*.rdf"
		
		'
		dialogSave.DefaultExt = "rdf"
		dialogSave.AddExtension = True
		If dialogSave.ShowDialog(Me) = DialogResult.OK Then
			If File.Exists(dialogSave.FileName) Then
				
				If MessageBox.Show(Me, "Overwrite Existing File?", "Overwrite", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
					
					'
					Return
				End If
			End If
			arvMain.Document.Save(dialogSave.FileName)
		End If
	End Sub 'SaveDocument
	'Opens the export form to export the current report document.
	Private Sub ExportDocument()
		Dim exportForm As New ExportForm(arvMain.Document)
		exportForm.ShowDialog(Me)
	End Sub 'ExportDocument
	'Call ExportDocument() on mnuExport_Click to to export the
	' current report document.
	Private Sub mnuExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuExport.Click
		ExportDocument()
	End Sub 'mnuExport_Click
	'Call SaveDocument() on mnuSaveDocument_Click to save the 
	' current report document to RDF format.
	Private Sub mnuSaveDocument_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuSaveDocument.Click
		SaveDocument()
	End Sub 'mnuSaveDocument_Click
End Class 'PreviewForm
