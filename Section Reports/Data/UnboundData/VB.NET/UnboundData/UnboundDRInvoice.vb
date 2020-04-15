Imports System
Imports System.Data.OleDb
Imports System.Globalization
Public Class UnboundDRInvoice
	Inherits GrapeCity.ActiveReports.SectionReport
	'Database connection populated from the sample Northwind access database
	Private _nwindConn As OleDbConnection
	'DataReader to use to read the data.
	Private _invoiceDataReader As OleDbDataReader
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	'DataInitialize Event
	' Use it to add custom fields to the report's Fields collection. 
	' Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
	' or an unbound report (one that does not depend on a data control to get its records).
	Private Sub UnboundDRInvoice_DataInitialize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataInitialize
	   
		'Add all the columns from the database as fields for the report.
		Dim i As Integer
		For i = 0 To _invoiceDataReader.FieldCount - 1
			Fields.Add(_invoiceDataReader.GetName(i))
		Next i
		'Add calculated fields
		Fields.Add("DiscountTotal")
	End Sub
	'FetchData Event
	'This event is raised every time a new record is processed. The FetchData has an EOF parameter
	' indicating whether the FetchData event should be raised.  When working with bound 
	' reports (reports using a DataControl), the EOF parameter is automatically set by the report;
	' however, when working with unbound reports this parameter needs to be controlled manually.
	Private Sub UnboundDRInvoice_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles MyBase.FetchData
		If Not _invoiceDataReader.Read() Then
			'If the reader has reached the end of the data then
			'set the eArgs.EOF flag to true and exit the procedure.
			eArgs.EOF = True
			Return
		Else
			'Populate the fields collection from the DataReader.
			Dim i As Integer
			For i = 0 To _invoiceDataReader.FieldCount - 1
				Fields(_invoiceDataReader.GetName(i)).Value = _invoiceDataReader(i)
			Next i
			'Add unbound DiscountTotal field total to instance of the Fields collection (for data binding and summary totaling in the group footer.)
			Fields("DiscountTotal").Value = Convert.ToDouble(Fields("UnitPrice").Value, CultureInfo.CurrentCulture) * Convert.ToInt32(Me.Fields("Quantity").Value, CultureInfo.InvariantCulture) * Convert.ToDouble(Me.Fields("Discount").Value, CultureInfo.CurrentCulture)
			'Set eArgs to false
			eArgs.EOF = False
		End If
	End Sub
	'ReportEnd Event
	' This event is raised after the report finishes processing. Use this event to 
	' close or free any objects that you were using while running a report in unbound mode,
	' or to display information or messages to the end user. This
	' event can also be used to export reports.
	Private Sub UnboundDRInvoice_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ReportEnd
		'Close the database connection.
		_nwindConn.Close()
	End Sub
	'<summary>
	' 
	' ReportStart event
	' This event is raised every time when report to be start.
	' 
	' 
	' </summary> 
	Private Sub UnboundDRInvoice_ReportStart(sender As Object, e As EventArgs) Handles MyBase.ReportStart
		'Database connection populated from the sample Northwind access database
		_nwindConn = New OleDbConnection(My.Resources.ConnectionString)
		'SQL Select command to run against the database.
		Dim selectCMD As New OleDbCommand("SELECT * FROM Invoices ORDER BY Customers.CompanyName, OrderID", _nwindConn)
		selectCMD.CommandTimeout = 30
		'Open the database connection and execute the reader
		_nwindConn.Open()
		_invoiceDataReader = selectCMD.ExecuteReader()
	End Sub
End Class
