Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports GrapeCity.ActiveReports.Data
'Demonstrates viewer control customization, export filters, 
' mail merge and groups.
Public Class CustomPreviewForm
	Inherits System.Windows.Forms.Form
	
	'Holds connection string to the sample database.
	Private connectString As String
	Public Sub New()
		MyBase.New()
		'Required for Windows Form Designer support
		InitializeComponent()
		Me.connectString = My.Resources.ConnectionString
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
	
	'The main entry point for the application.
	<STAThread()> _
	Shared Sub Main()
		Application.Run(New CustomPreviewForm())
	End Sub 'Main
	'ShowReport - takes the supplied SectionReport object and loads it into
	' the PreviewForm for viewing.
	Private Sub ShowReport(ByVal rpt As GrapeCity.ActiveReports.SectionReport)
		Dim _tmp As Cursor = Me.Cursor
		Me.Cursor = Cursors.WaitCursor
		Try
			' Make the sure the connection string points to the correct file location.
			Dim _ds As OleDBDataSource = CType(rpt.DataSource, OleDBDataSource)
			_ds.ConnectionString = Me.connectString
			' Create a new instance of the preview form.
			Dim _viewerForm As New PreviewForm(rpt.Document, Me)
			_viewerForm.Show()
			rpt.Run(True)
		Catch ex As ReportException
			MessageBox.Show(ex.ToString())
		Finally
			Me.Cursor = _tmp
		End Try
	End Sub 'ShowReport
	'mnuFileOpen_Click - Used to open a generated report file (RDF) and display it.
	Private Sub mnuFileOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click
		
		dlgOpenFile.Filter = "ActiveReports Document Files (*.rdf)|*.rdf"
		
		'
		dlgOpenFile.FileName = ""
		dlgOpenFile.CheckFileExists = True
		
		dlgOpenFile.Title = "Open a Report Document File"
		
		'
		If dlgOpenFile.ShowDialog(Me) = DialogResult.OK Then
			If File.Exists(dlgOpenFile.FileName) Then
				'Load the RDF file.
				Dim doc As New GrapeCity.ActiveReports.Document.SectionDocument
				doc.Load(dlgOpenFile.FileName)
				' Open a new Preview Form.
				Dim _viewerForm As New PreviewForm(doc, Me)
				_viewerForm.Show()
			End If
		End If
	End Sub
	'mnuFileExit_Click - exits the application
	Private Sub mnuFileExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
		Application.Exit()
	End Sub
	'mnuRCatalog_Click - Loads the Catalog report into a new child
	' preview form
	'preview form
	Private Sub mnuRCatalog_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRCatalog.Click
		Me.ShowReport(New Catalog)
	End Sub
	'mnuRCustomerLabels_Click - Loads the Customer Labels report into
	' a new child preview form.
	Private Sub mnuRCustomerLabels_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRCustomerLabels.Click
		Me.ShowReport(New CustomerLabels)
	End Sub
	'mnuREmployeeProfiles_Click - loads the Employee Profiles report
	' into a new child preview form.
	Private Sub mnuREmployeeProfiles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuREmployeeProfiles.Click
		Me.ShowReport(New EmployeeProfiles)
	End Sub
	'mnuRInvoice_Click - loads the Invoice report into a new child
	' preview form.
	Private Sub mnuRInvoice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRInvoice.Click
		Me.ShowReport(New Invoice)
	End Sub 'mnuRInvoice_Click
	'mnuRLetter_Click - loads the Letter report into a new child
	' preview form
	Private Sub mnuRLetter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRLetter.Click
		Me.ShowReport(New Letter)
	End Sub
	'mnuEmpSales_Click - loads the Employee Sales report into a new MDI child window 
	Private Sub mnuEmpSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEmpSales.Click
		Me.ShowReport(New EmployeeSales)
	End Sub
	Private Sub MenuSpreadBuilderitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuSpreadBuilderitem.Click
		Dim sfd As New SaveFileDialog()	 ' Create a new instance of the Save File dialog.
		Dim sr As System.IO.StreamReader
		Dim tmpCursor As Cursor = Me.Cursor ' // Change the cursor.カーソルを変更します。
		Dim strFileName As String = Application.StartupPath & "\..\..\Sample.csv"
		
		sfd.Title = "Creating an Excel file by SpreadBuilder API"
		
		'
		'Name of the file for initial display.
		sfd.FileName = "SpreadBuilder.xls"
		sfd.Filter = "Excel 97-2003 |*.xls"
		If sfd.ShowDialog() <> DialogResult.OK Then
			Exit Sub
		End If
		Try
			Me.Cursor = Cursors.WaitCursor
			Application.DoEvents()
			' Load the CSV file.
			
			sr = New System.IO.StreamReader(strFileName)
			
			'
			' Add a sheet in the workbook collection.
			Dim sb As New GrapeCity.SpreadBuilder.Workbook()
			sb.Sheets.AddNew()
			With sb.Sheets(0)
				
				.Name = "CITY List"
				
				'
				'  Set the properties of the sheet name and column
				.Columns(0).Width = 1440
				.Columns(1).Width = 1440 * 2
				.Columns(2).Width = 1440
				.Columns(3).Width = 1440 * 4
				.Rows(0).Height = CInt(1440 / 4)
				'Sets the row header
				
				.Cell(0, 0).SetValue("Code")
				
				'
				
				.Cell(0, 1).SetValue("Name")
				
				'
				
				.Cell(0, 2).SetValue("PostalCode")
				
				'
				
				.Cell(0, 3).SetValue("Location")
				
				'
				'Together to set the format of the header line
				
				.Cells(.Cell(0, 0), .Cell(0, 3)).FontName = "MS PGothic"
				
				'
				.Cells(.Cell(0, 0), .Cell(0, 3)).FontSize = 11
				.Cells(.Cell(0, 0), .Cell(0, 3)).FontBold = True
				.Cells(.Cell(0, 0), .Cell(0, 3)).ForeColor = Color.White
				.Cells(.Cell(0, 0), .Cell(0, 3)).FillColor = Color.Navy
				.Cells(.Cell(0, 0), .Cell(0, 3)).Alignment = GrapeCity.SpreadBuilder.Style.HorzAlignments.Center
				.Cells(.Cell(0, 0), .Cell(0, 3)).VertAlignment = GrapeCity.SpreadBuilder.Style.VertAlignments.Center
				.Cells(.Cell(0, 0), .Cell(0, 3)).BorderTopStyle = GrapeCity.SpreadBuilder.Style.BorderLineStyle.Medium
				.Cells(.Cell(0, 1), .Cell(0, 3)).BorderLeftStyle = GrapeCity.SpreadBuilder.Style.BorderLineStyle.Thin
				'Sets the formatting of some of the cells in the header line 
				.Cell(0, 0).BorderLeftStyle = GrapeCity.SpreadBuilder.Style.BorderLineStyle.Medium
				.Cell(0, 3).BorderRightStyle = GrapeCity.SpreadBuilder.Style.BorderLineStyle.Medium
			End With
			'Read the contents of a CSV file line by line
			Dim iRec As Integer = 1
			While sr.Peek() > -1
				' set the properties and values​ for Column,rows and cells.
				Dim thisLine As String = sr.ReadLine
				Dim thisArray() As String = thisLine.Split(New String() {","}, StringSplitOptions.None)
				'  Dim thisArray() As String = thisLine.Split(",")
				' Set the properties and values ​for column, rows and cells.
				'(Set the height of the line)
				With sb.Sheets(0)
					.Rows(0).Height = CInt(1440 / 4)
					'  (Set the value)
					.Cell(iRec, 0).SetValue(thisArray(0).ToString().Replace(Chr(34), ""))
					.Cell(iRec, 1).SetValue(thisArray(1).ToString().Replace(Chr(34), ""))
					.Cell(iRec, 2).SetValue(thisArray(3).ToString().Replace(Chr(34), ""))
					.Cell(iRec, 3).SetValue(thisArray(2).ToString().Replace(Chr(34), ""))
					' (Set a border)
					.Cells(.Cell(iRec, 0), .Cell(iRec, 3)).BorderBottomStyle = GrapeCity.SpreadBuilder.Style.BorderLineStyle.Thin
					.Cells(.Cell(iRec, 1), .Cell(iRec, 3)).BorderLeftStyle = GrapeCity.SpreadBuilder.Style.BorderLineStyle.Dotted
					.Cell(iRec, 0).BorderLeftStyle = GrapeCity.SpreadBuilder.Style.BorderLineStyle.Medium
					.Cell(iRec, 3).BorderRightStyle = GrapeCity.SpreadBuilder.Style.BorderLineStyle.Medium
					'  (To change the format, one per line)
					If (iRec Mod 2) = 0 Then
						.Cells(.Cell(iRec, 0), .Cell(iRec, 3)).FillColor = Color.LightCyan
					Else
						.Cells(.Cell(iRec, 0), .Cell(iRec, 3)).FillColor = Color.PaleTurquoise
					End If
				End With
				' Increments the counter.
				iRec += 1
			End While
			With sb.Sheets(0)
				' Set the format of the data section summary
				'(For all data)
				
				.Cells(.Cell(1, 0), .Cell(iRec - 1, 3)).FontName = "MS PGothic"
				
				'
				.Cells(.Cell(1, 0), .Cell(iRec - 1, 3)).FontSize = 10
				.Cells(.Cell(1, 0), .Cell(iRec - 1, 3)).VertAlignment = GrapeCity.SpreadBuilder.Style.VertAlignments.Center
				' (Only the third row and first column)
				.Cells(.Cell(1, 0), .Cell(iRec - 1, 0)).Alignment = GrapeCity.SpreadBuilder.Style.HorzAlignments.Center
				.Cells(.Cell(1, 2), .Cell(iRec - 1, 2)).Alignment = GrapeCity.SpreadBuilder.Style.HorzAlignments.Center
				' (Only the last line)
				.Cells(.Cell(iRec - 1, 0), .Cell(iRec - 1, 3)).BorderBottomStyle = GrapeCity.SpreadBuilder.Style.BorderLineStyle.Medium
			End With
			'Save the workbook to an Excel file.
			sb.Save(sfd.FileName)
			sr.Close()
			' Save the workbook to an Excel file.
			
			MessageBox.Show("File has been saved to:" & sfd.FileName, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
			
			'
		Catch ex As Exception
			MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			' Replace the cursor.
			Me.Cursor = tmpCursor
			Application.DoEvents()
		End Try
	End Sub
End Class
