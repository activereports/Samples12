Public Class Invoice
	' Create member variables for alternating colors of detail rows
	Private _detailRowNumber As Integer
	Private ReadOnly _detailRowColor As Color = Color.White
	Private ReadOnly _detailAlternateRowColor As Color = Color.FromArgb(192, 173, 223)
	Private Sub customerGroupHeader_Format(ByVal sender As Object, ByVal e As EventArgs) Handles customerGroupHeader.Format
		' Reset the detail row number when a new group begins
		_detailRowNumber = 0
	End Sub
	Private Sub Detail_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail.Format
		' Set alternating row colors
		If (_detailRowNumber Mod 2 = 0) Then
			Detail.BackColor = _detailRowColor
		Else
			Detail.BackColor = _detailAlternateRowColor
		End If
		_detailRowNumber += 1
	End Sub
	Private Sub customerGroupFooter_Format(ByVal sender As Object, ByVal e As EventArgs) Handles customerGroupFooter.Format
		' Calculate the total based on values from textboxes in the group footer.
		grandTotalTextBox.Text = String.Format("{0:C}", CType(freightTextBox.Value, Double) + CType(subtotalTextBox.Value, Double))
	End Sub
	Private Sub Invoice_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		Dim ds As Data.OleDBDataSource = CType(DataSource, Data.OleDBDataSource)
		
		ds.SQL = "SELECT * FROM Invoices WHERE Country = 'USA'"
		
		'
	End Sub
End Class
