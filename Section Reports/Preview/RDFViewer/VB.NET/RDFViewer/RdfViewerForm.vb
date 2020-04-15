Imports System
Imports System.Windows.Forms
Imports System.IO
'Demonstrates customizing the WinForms viewer control toolbar, loading report 
'document files (RDF) and using the export filters.
Public Class RdfViewerForm
	Inherits System.Windows.Forms.Form
	Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		'Add any initialization after the InitializeComponent() call
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If Not (components Is Nothing) Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	'The main entry point for the application.
	<STAThread()> _
	Shared Sub Main()
		Application.Run(New RdfViewerForm())
	End Sub 'Main
	'ReportDoc - used to get the current loaded document object.
	'Returns: Current Document object loaded into the viewer control.
	Public ReadOnly Property ReportDoc() As Document.SectionDocument
		Get
			Return arvMain.Document
		End Get
	End Property
	'openFileDialog_FileOk -  Loads selected file into the viewer control.
	Private Sub dlgOpenFile_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dlgOpenFile.FileOk
		If dlgOpenFile.FileName.Length <> 0 Then
			arvMain.LoadDocument(dlgOpenFile.FileName)
		End If
	End Sub 'dlgOpenFile_FileOk
	Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
		
		dlgOpenFile.Filter = "ActiveReports Report File(*.rdf)|*.rdf"
		
		'
		dlgOpenFile.InitialDirectory = Application.StartupPath + "..\..\..\..\RDFs"
		dlgOpenFile.ShowDialog()
	End Sub
	Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ExportToolStripMenuItem.Click
		If arvMain.Document.Pages.Count = 0 Then
			
			MessageBox.Show("Please Select a Report to Export", "Export Denied")
			
			'
		Else
			Dim frm As New ExportForm(arvMain.Document)
			frm.ShowDialog()
		End If
	End Sub
	Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles PrintToolStripMenuItem.Click
		If arvMain.Document.Pages.Count > 0 Then
			arvMain.Document.Print()
		End If
	End Sub
	Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
		Application.Exit()
	End Sub
	Private Sub TableOfContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles TableOfContentsToolStripMenuItem.Click
		arvMain.Sidebar.TocPanel.Width = 200
		If TableOfContentsToolStripMenuItem.Checked Then
			arvMain.Sidebar.Visible = True
		Else
			arvMain.Sidebar.Visible = False
		End If
	End Sub
	Private Sub ToolbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ToolbarToolStripMenuItem.Click
		arvMain.Toolbar.ToolStrip.Visible = Not arvMain.Toolbar.ToolStrip.Visible
	End Sub
End Class
