Public Class CategoryReport
	Public Sub New()
		InitializeComponent()
		Dim ds As New Data.OleDBDataSource
		ds.ConnectionString = My.Resources.ConnectionString
		ds.SQL = "Select Categories.CategoryID, categories.CategoryName, Avg(Products.UnitPrice) as AvgUnitPrice, Count(Categories.CategoryID) as ProductCount FROM Products, Categories WHERE Products.CategoryID = Categories.CategoryID GROUP BY Categories.CategoryID, categories.CategoryName;"
		DataSource = ds
	End Sub
End Class
