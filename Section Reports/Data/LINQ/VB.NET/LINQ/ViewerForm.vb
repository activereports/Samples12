Public Class ViewerForm
	'  LINQ to Object
	Private Sub ViewerForm_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
		' To generate a report.
		Dim rpt As New rptLINQtoObject
		arvMain.LoadDocument(rpt)
	End Sub
End Class
