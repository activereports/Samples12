Imports System
Imports System.Globalization
Public Class OrdersReport
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	' DataInitialize Event
	'  Use it to add custom fields to the report's Fields collection. 
	'  Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
	'  or an unbound report (one that does not depend on a data control to get its records).
	Private Sub OrdersReport_DataInitialize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataInitialize
		CType(DataSource, Data.OleDBDataSource).ConnectionString = My.Resources.ConnectionString
		Fields.Add("ExtendedPrice")
	End Sub
	' FetchData Event
	' This event is raised every time a new record is processed. The FetchData has an EOF parameter 
	' indicating whether the FetchData event should be raised.　When working with bound reports (reports using a DataControl), 
	' the EOF parameter is automatically set by the report; however, when working with unbound reports 
	' this parameter needs to be controlled manually.
	Private Sub OrdersReport_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles MyBase.FetchData
		' Gather the value to be calculated from the bound data base.
		Dim quantity As Double = Convert.ToDouble(Fields("Quantity").Value, CultureInfo.CurrentCulture)
		Dim unitPrice As Double = Convert.ToDouble(Fields("UnitPrice").Value, CultureInfo.CurrentCulture)
		Dim discount As Double = Convert.ToDouble(Fields("Discount").Value, CultureInfo.CurrentCulture)
		' Perform the calculation for the calculated field.
		Fields("ExtendedPrice").Value = quantity * unitPrice - quantity * unitPrice * discount
	End Sub
	Public ds As Data.OleDBDataSource
End Class
