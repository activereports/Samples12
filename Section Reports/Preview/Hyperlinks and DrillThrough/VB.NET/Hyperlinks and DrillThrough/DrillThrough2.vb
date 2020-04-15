Public Class DrillThrough2
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		'Connect to Sample Database
		'
		DataSource = New Data.OleDBDataSource()
		CType(DataSource, Data.OleDBDataSource).ConnectionString = My.Resources.ConnectionString
		
		CType(DataSource, Data.OleDBDataSource).SQL = "Select * from [order details] where orderID = <%param:orderID||1%> order by productid"
		Dim paramOrderID As New SectionReportModel.Parameter()
		paramOrderID.Key = "orderID"
	End Sub
	Public ds As GrapeCity.ActiveReports.Data.OleDBDataSource
End Class
