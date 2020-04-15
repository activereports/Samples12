Public Class rpt3DPie
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		'
		'
	End Sub
	'Variable for setting the direction of rotation
	'
	Public boClockWise As Boolean = True   '(True:Clockwise,False:anti-clockwise) 
	Private Sub rpt3DPieChart_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		'Set the data source in the graph.
		'
		Dim dt As DataTable = New DataTable()
		'Please change the datasource path if required
		'		
		Dim constr As String = My.Resources.ConnectionString
		Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder()
		sb.Append("SELECT DISTINCTROW Categories.CategoryName, ")
		sb.Append("Sum(CCur([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100) AS ProductSales, ")
		sb.Append("Employees.EmployeeID FROM Employees INNER JOIN ((Categories INNER JOIN Products ")
		sb.Append("ON Categories.CategoryID = Products.CategoryID) INNER JOIN ")
		sb.Append("(Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ")
		sb.Append("ON Products.ProductID = [Order Details].ProductID) ")
		sb.Append("ON Employees.EmployeeID = Orders.EmployeeID ")
		sb.Append("WHERE (((Orders.ShippedDate) Between #1/1/1995# And #12/31/1995#)) ")
		sb.Append("GROUP BY Categories.CategoryName, Employees.EmployeeID HAVING Employees.EmployeeID = 1")
		Using conn As New OleDb.OleDbConnection(constr)
			Dim adp As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sb.ToString(), conn)
			conn.Open()
			adp.Fill(dt)
			conn.Close()
		End Using
		ChartSalesCategories.DataSource = dt
		'Sets the direction of rotation.
		'
		ChartSalesCategories.Series(0).Properties("Clockwise") = boClockWise
	End Sub
	
End Class
