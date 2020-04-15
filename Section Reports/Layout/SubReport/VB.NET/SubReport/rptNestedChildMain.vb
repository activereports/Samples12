Public Class rptNestedChildMain
	Inherits GrapeCity.ActiveReports.SectionReport
	Dim _rpt As rptNestedChildSub
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		Dim dS As New Data.OleDBDataSource()
		dS.ConnectionString = My.Resources.ConnectionString
		dS.SQL = "Select Top 10 * from orders inner join [order details] on orders.orderID = [order details].orderID where orders.employeeID = <%employeeID%> Order By orders.OrderID"
		DataSource = dS
	End Sub
	Private Sub rptNestedChildMain_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		_rpt = New rptNestedChildSub()
		subCustomers.Report = _rpt
	End Sub
End Class
