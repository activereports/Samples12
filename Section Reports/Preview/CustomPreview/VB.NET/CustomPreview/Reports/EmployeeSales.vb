Public Class EmployeeSales
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		
		Document.Name = "Employee Sales Report"
		
		'
	End Sub
	Public ds As Data.OleDBDataSource
	Private Sub EmployeeSales_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		
		chtSales.Titles(0).Text = "Sales by Employee for 1997"
		
		'
	End Sub
End Class
