Public Class DataFieldExpressionsReport
	Inherits GrapeCity.ActiveReports.SectionReport
	Private index As Integer
	Private details As ArrayList
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	'DataInitialize Event
	' Use it to add custom fields to the report's Fields collection. 
	' Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
	' or an unbound report (one that does not depend on a data control to get its records).
	Private Sub DataFieldExpressionsReport_DataInitialize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataInitialize
		Fields.Add("ProductName")
		Fields.Add("UnitPrice")
		Fields.Add("Quantity")
	End Sub
	' FetchData Event
	'  This event is raised every time a new record is processed. 
	'  The FetchData has an EOF parameter indicating whether the FetchData event 
	'  should be raised. When working with bound reports (reports using a DataControl), 
	'  the EOF parameter is automatically set by the report; however, when working with 
	'  unbound reports this parameter needs to be controlled manually.
	'  
	'  
	Private Sub DataFieldExpressionsReport_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles MyBase.FetchData
		If index >= details.Count - 1 Then
			eArgs.EOF = True
			Return
		Else
			eArgs.EOF = False
		End If
		index = index + 1
		Dim row As OrderDetail = CType(details(index), OrderDetail)
		Fields("ProductName").Value = row.productName
		Fields("UnitPrice").Value = row.unitPrice
		Fields("Quantity").Value = row.quantity
	End Sub
	'<summary>
	' 
	' ReportStart event
	' This event is raised every time when report to be start.
	' 
	' 
	' </summary>	 
	Private Sub DataFieldExpressionsReport_ReportStart(sender As Object, e As EventArgs) Handles MyBase.ReportStart
		'Test data
		details = New ArrayList()
		details.Add(New OrderDetail("A", 10.0, 2))
		details.Add(New OrderDetail("B", 0.12, 1))
		details.Add(New OrderDetail("C", 5.92, 3))
		index = -1
	End Sub
End Class
