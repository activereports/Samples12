Public Class rpt2DBar
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		Dim ds As New Data.OleDBDataSource()
		ds.ConnectionString = My.Resources.ConnectionString
		
		ds.SQL = "SELECT ShipCountry, SUM(Freight) AS Expr1 FROM Orders GROUP BY ShipCountry"
		ChartControl.DataSource = ds
		'
		'
		'
		'
		'
		'
	End Sub
End Class
