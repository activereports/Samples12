Public Class ProductSalesByCategory
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
	' of the report assigned to the Subreport control.
	Private Sub ProductSalesByCategory_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
		' Set row count to 0.
		' 
		_iRow = 0
	End Sub
	'  DataInitialize Event
	'  Use it to add custom fields to the report's Fields collection. 
	'  Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
	'  or an unbound report (one that does not depend on a data control to get its records).
	Private Sub ProductSalesByCategory_DataInitialize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
		'Create dynamic datasource using sample databaseサンプルデータベースを使用し、動的なデータソースを作成します。
		Dim ds As New Data.OleDBDataSource()
		ds.ConnectionString = My.Resources.ConnectionString
		ds.SQL = "SELECT DISTINCTROW Categories.CategoryName, Sum([Order Details Extended].ExtendedPrice) AS ProductSales FROM Categories INNER JOIN (Products INNER JOIN (Orders INNER JOIN [Order Details Extended] ON Orders.OrderID = [Order Details Extended].OrderID) ON Products.ProductID = [Order Details Extended].ProductID) ON Categories.CategoryID = Products.CategoryID WHERE (((Orders.OrderDate) Between #1/1/95# And #12/31/95#)) GROUP BY Categories.CategoryName ORDER BY Categories.CategoryName"
		DataSource = ds
	End Sub
	'  Format Event
	'  ActiveReports raises this event after the data is loaded and bound to the controls contained in a section, 
	'  but before the section is rendered to a page.The Format event is the only event in which you can change
	'   the section's height. Use this section to set or change the properties of any controls or the section itself.
	'  Also use the Format event to pass information, such as an SQL String, to a Subreport.
	Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
		' Check _iRow value to see if we need to highlight the row or not.
		If _iRow Mod 2 = 0 Then
			Detail.BackColor = Color.LightYellow
		Else
			Detail.BackColor = Color.Transparent
		End If
		_iRow = _iRow + 1
	End Sub
End Class
