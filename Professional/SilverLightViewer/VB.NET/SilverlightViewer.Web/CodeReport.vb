Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System.Drawing
Public Class CodeReport
	' Create member variables for alternating colors of detail rows
	Private DetailRowNumber As Integer
	Private DetailRowColor As Color = Color.White
	Private DetailAlternateRowColor As Color = Color.FromArgb(192, 173, 223)
	Private Sub customerGroupHeader_Format(ByVal sender As Object, ByVal e As EventArgs)
		' Reset the detail row number when a new group begins
		DetailRowNumber = 0
	End Sub
	Private Sub Detail_Format(ByVal sender As Object, ByVal e As EventArgs)
		' Set alternating row colors
		If (DetailRowNumber Mod 2 = 0) Then
			Detail.BackColor = DetailRowColor
		Else
			Detail.BackColor = DetailAlternateRowColor
		End If
		DetailRowNumber += 1
	End Sub
	Private Sub customerGroupFooter_Format(ByVal sender As Object, ByVal e As EventArgs)
		' Calculate the total based on values from textboxes in the group footer.
		Me.grandTotalTextBox.Text = String.Format("{0:C}", CType(Me.freightTextBox.Value, Double) + CType(Me.subtotalTextBox.Value, Double))
	End Sub
	Private Sub Invoice_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
		Dim ds As GrapeCity.ActiveReports.Data.OleDBDataSource = CType(Me.DataSource, GrapeCity.ActiveReports.Data.OleDBDataSource)
		ds.SQL = "SELECT * FROM Invoices WHERE Country = 'USA'"
	End Sub
End Class
