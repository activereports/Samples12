Public Class ProductsReport 
	Public Sub New()
		InitializeComponent()
		Dim ds As New Data.OleDBDataSource
		ds.ConnectionString = My.Resources.ConnectionString
		ds.SQL = "Select Products.ProductName, Products.UnitPrice, Products.CategoryID, categories.CategoryName FROM Products, Categories WHERE Products.CategoryID = Categories.CategoryID Order By Categories.CategoryID;"
		DataSource = ds
	End Sub
End Class
