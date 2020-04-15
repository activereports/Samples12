Public Class Top10Customers
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	'Row Count
	'
	Dim _iRow As Integer
	' ReportStart Event
	' Use this event to initialize any objects or variables needed while running a report.
	' Also use this event to set any Subreport control objects to a new instance 
	' of the report assigned to the Subreport control.任意の子レポートを割り当てることができます。
	Private Sub Top10Customers_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		' Set row count to 0.
		' 
		_iRow = 0
		   
		ChartControl1.Titles(1).Text = "Top 10 customers in 1997"
				 
		'
		'Create a dynamic datasource using the sample database.
		Dim ds As New Data.OleDBDataSource()
		ds.ConnectionString = My.Resources.ConnectionString
		ds.SQL = "SELECT TOP 10 Customers.CompanyName, Sum([UnitPrice]*[Quantity]) AS Sales FROM (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID GROUP BY Customers.CompanyName ORDER BY Sum([UnitPrice]*[Quantity]) DESC"
		DataSource = ds
		ChartControl1.DataSource = ds
		
		ChartControl1.ChartAreas(0).Axes("AxisY").LabelFormat = "{0:$#,##0.00}"
		
		'
	End Sub
	'Format Event
	'  ActiveReports raises this event after the data is loaded and bound to the controls contained in a section, 
	'  but before the section is rendered to a page.The Format event is the only event in which you can change
	'   the section's height. Use this section to set or change the properties of any controls or the section itself.
	'  Also use the Format event to pass information, such as an SQL String, to a Subreport.
	Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As EventArgs) Handles Detail.Format
		'  Check _iRow value to see if we need to highlight the row or not._iRowの値を確認し、行をハイライトするかどうかを判別します。
		If _iRow Mod 2 = 0 Then
			Detail.BackColor = Color.White
		Else
			Detail.BackColor = Color.LightYellow
		End If
		_iRow = _iRow + 1
		lblRank.Text = _iRow.ToString(Globalization.CultureInfo.CurrentCulture)
	End Sub
	Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As EventArgs) Handles GroupHeader1.Format
		CType(ChartControl1.DataSource, Data.OleDBDataSource).ConnectionString = CType(DataSource, Data.OleDBDataSource).ConnectionString
	End Sub
End Class
