Public Class rptHierarchicalMain
	Inherits GrapeCity.ActiveReports.SectionReport
	Dim _rpt As rptHierarchicalSub
	Dim _ds As Data.OleDBDataSource
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	Private Sub Detail_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail.Format
		Subreport1.Report = _rpt
	End Sub
	Private Sub rptHierarchicalMain_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		_rpt = New rptHierarchicalSub()
		Dim dS As New Data.OleDBDataSource()
		dS.ConnectionString = My.Resources.ShapeDataConnectionString
		dS.SQL = "SHAPE {SELECT CustomerID, CompanyName, Address FROM Customers} APPEND ({SELECT CustomerID, OrderID, Freight, OrderDate, EmployeeID FROM Orders} AS CustomerOrders RELATE CustomerID TO CustomerID)"
		DataSource = dS
		
		ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
		
		'
	End Sub
	Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As EventArgs) Handles Detail.BeforePrint
		Shape1.Height = Detail.Height - 0.2F
	End Sub
	Private Sub rptHierarchicalMain_ReportEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportEnd
		Shape1.Height = 0
	End Sub
End Class
