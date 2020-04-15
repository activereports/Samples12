Public Class Invoice
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		Document.Name = "Invoice ActiveReport"
		Dim oDS As New Data.OleDBDataSource
		oDS.ConnectionString = My.Resources.ConnectionString
		oDS.SQL = "SELECT * FROM Invoices ORDER BY Customers.CompanyName, OrderID"
		DataSource = oDS
	End Sub
	
	Public ds As Data.OleDBDataSource
End Class
