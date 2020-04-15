Public Class rptParamSub
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		Dim dS As New Data.OleDBDataSource()
		dS.ConnectionString = My.Resources.ConnectionString
		dS.SQL = "SELECT * FROM products INNER JOIN categories ON products.categoryid = categories.categoryid WHERE products.supplierID = <%SupplierID%>"
		DataSource = dS
	End Sub
	Private Sub rptChild_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		ShowParameterUI = False
	End Sub
End Class
