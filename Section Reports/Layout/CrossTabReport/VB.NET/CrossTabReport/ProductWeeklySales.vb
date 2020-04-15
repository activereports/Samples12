Public Class ProductWeeklySales
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	Private _iCurrWk As Integer
	Private _iCurrMth As Integer
	Private _iCurrQtr As Integer
	Private _iCurrYr As Integer
	Private _sProductName As String
	'ReportStart Event
	' Use this event to initialize any objects or variables needed while running a report. 
	' Also use this event to set any Subreport control objects to a new instance 
	' of the report assigned to the Subreport control.
	Private Sub ProductWeeklySales_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
		'Set report orientation to Landscape
		PageSettings.Orientation = ActiveReports.Document.Section.PageOrientation.Landscape
		'Set the report variables
		_iCurrWk = 23
		_iCurrMth = 6
		_iCurrQtr = 2
		
		_iCurrYr = 1996
		
		'
	End Sub
	'DataInitialize Event
	' Use it to add custom fields to the report's Fields collection. 
	' Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
	' or an unbound report (one that does not depend on a data control to get its records).
	Private Sub ProductWeeklySales_DataInitialize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataInitialize
		'Assign report data source to the sample database
		Dim ds As New Data.OleDBDataSource()
		ds.ConnectionString = My.Resources.ConnectionString
		ds.SQL = "SELECT DISTINCTROW Categories.CategoryID, Categories.CategoryName, Products.ProductName, Orders.OrderDate, Sum([Order Details Extended].ExtendedPrice) AS ProductSales, Sum([Order Details Extended].Quantity) AS ProductUnits FROM Categories INNER JOIN (Products INNER JOIN (Orders INNER JOIN [Order Details Extended] ON Orders.OrderID = [Order Details Extended].OrderID) ON Products.ProductID = [Order Details Extended].ProductID) ON Categories.CategoryID = Products.CategoryID GROUP BY Categories.CategoryID, Categories.CategoryName, Products.ProductName, Orders.OrderDate ORDER BY Categories.CategoryName, Products.ProductName"
		DataSource = ds
		'Add unbound Fields to Fields collection
		Fields.Add("WkUnits")
		Fields.Add("WkSales")
		Fields.Add("MTDUnits")
		Fields.Add("MTDSales")
		Fields.Add("QTDUnits")
		Fields.Add("QTDSales")
		Fields.Add("PQTDSales")
		Fields.Add("YTDUnits")
		Fields.Add("YTDSales")
	End Sub
	'FetchData Event
	' This event is raised every time a new record is processed.
	'The FetchData has an EOF parameter indicating whether the FetchData event
	' should be raised. When working with bound reports (reports using a DataControl), the EOF 
	' parameter is automatically set by the report; however, when working with unbound
	'  reports this parameter needs to be controlled manually.t
	Private Sub ProductWeeklySales_FetchData(ByVal sender As Object, ByVal eArgs As GrapeCity.ActiveReports.SectionReport.FetchEventArgs) Handles MyBase.FetchData
		Dim iWk As Integer
		Dim iMth As Integer
		Dim iQtr As Integer
		Dim iYr As Integer
		Dim dOrderDate As DateTime
		Dim dUnits As Double
		Dim decSales As Decimal
		'Set holder variables
		dOrderDate = CType(Fields("OrderDate").Value, DateTime)
		dUnits = CType(Fields("ProductUnits").Value, Double)
		decSales = CType(Fields("ProductSales").Value, Decimal)
		'Set unbound fields to 0 to initalize them for the row
		Fields("WkUnits").Value = 0
		Fields("WkSales").Value = 0
		Fields("MTDUnits").Value = 0
		Fields("MTDSales").Value = 0
		Fields("QTDUnits").Value = 0
		Fields("QTDSales").Value = 0
		Fields("PQTDSales").Value = 0
		Fields("YTDUnits").Value = 0
		Fields("YTDSales").Value = 0
		Dim c As New Globalization.CultureInfo("en-US")
		'Set the week and month values from the current active row.
		iWk = c.Calendar.GetWeekOfYear(dOrderDate, Globalization.CalendarWeekRule.FirstDay, System.DayOfWeek.Sunday)
		iMth = dOrderDate.Month
		'Set the current quarter for the active database row.
		If iWk <= 13 Then
			iQtr = 1
		ElseIf iWk <= 26 Then
			iQtr = 2
		ElseIf iWk <= 39 Then
			iQtr = 3
		Else
			iQtr = 4
		End If
		iYr = dOrderDate.Year
		'Set Field values according to the data calculated.
		If iWk = _iCurrWk And iYr = _iCurrYr Then
			'Set the footer fields data values
			Fields("WkUnits").Value = dUnits
			Fields("WkSales").Value = decSales
		End If
		If iMth = _iCurrMth And iYr = _iCurrYr Then
			Fields("MTDUnits").Value = dUnits
			Fields("MTDSales").Value = decSales
		End If
		If iQtr = _iCurrQtr And iYr = _iCurrYr Then
			Fields("QTDUnits").Value = dUnits
			Fields("QTDSales").Value = decSales
		End If
		If iQtr = _iCurrQtr And iYr = _iCurrYr - 1 Then
			Fields("PQTDSales").Value = decSales
		End If
		If iYr = _iCurrYr Then
			Fields("YTDUnits").Value = dUnits
			Fields("YTDSales").Value = decSales
		End If
	End Sub
	'Format Event
	' ActiveReports raises this event after the data is loaded and bound to the controls contained in a section, 
	' but before the section is rendered to a page.The Format event is the only event in which you can change
	'  the section's height. Use this section to set or change the properties of any controls or the section itself.
	' Also use the Format event to pass information, such as an SQL String, to a Subreport.
	Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As EventArgs) Handles Detail.Format
		'Assign current product name to holder.
		_sProductName = txtDetProduct.Text
	End Sub
	'Format Event
	' ActiveReports raises this event after the data is loaded and bound to the controls contained in a section, 
	' but before the section is rendered to a page.The Format event is the only event in which you can change
	'  the section's height. Use this section to set or change the properties of any controls or the section itself.
	' Also use the Format event to pass information, such as an SQL String, to a Subreport.
	Private Sub gfCategory_Format(ByVal sender As System.Object, ByVal e As EventArgs) Handles gfCategory.Format
		txtCatPQTDChange.Value = CType(txtCatQTDSales.Value, Double) - CType(txtCatPQTDSales.Value, Double)
		'If value is negative, highlight in red
		If CType(txtCatPQTDChange.Value, Double) < 0 Then
			txtCatPQTDChange.BackColor = Color.Red
		Else
			txtCatPQTDChange.BackColor = Color.Transparent
		End If
	End Sub
	Private Sub gfProduct_Format(ByVal sender As System.Object, ByVal e As EventArgs) Handles gfProduct.Format
		'Assign product name from holder
		txtProduct.Text = _sProductName
		txtPQTDChange.Value = CType(txtQTDSales.Value, Double) - CType(txtPQTDSales.Value, Double)
		'If value is negative, highlight in red
		If CType(txtPQTDChange.Value, Double) < 0 Then
			txtPQTDChange.BackColor = Color.Red
		Else
			txtPQTDChange.BackColor = Color.Transparent
		End If
	End Sub
End Class
