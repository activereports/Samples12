Public Class rptMasterSub
	Inherits GrapeCity.ActiveReports.SectionReport
	Dim _ds As GrapeCity.ActiveReports.Data.OleDBDataSource
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		Dim dS As New Data.OleDBDataSource()
		dS.ConnectionString = My.Resources.ConnectionString
		dS.SQL = "Select * from [order details] inner join products on [order details].productid = products.productID where [order details].orderID = <%OrderID%>"
		DataSource = dS
	End Sub
End Class
