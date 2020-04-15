Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Public Class UnboundDSInvoice
	Inherits GrapeCity.ActiveReports.SectionReport
	'DataSource for the report.
	Private _invoiceData As DataSet
	Private _rowCounter As Integer
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	'DataInitialize Event
	' Use it to add custom fields to the report's Fields collection. 
	' Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
	' or an unbound report (one that does not depend on a data control to get its records).
	Private Sub UnboundDSInvoice_DataInitialize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataInitialize
		
		'Add all the columns from the database as fields for the report.
		Dim i As Integer
		For i = 0 To (_invoiceData.Tables(0).Columns.Count) - 1
			Fields.Add(_invoiceData.Tables(0).Columns(i).ColumnName)
		Next i
		'Add calculated fields
		Fields.Add("DiscountTotal")
	End Sub
	'FetchData Event
	' This event is raised every time a new record is processed. The FetchData has an EOF parameter
	' indicating whether the FetchData event should be raised.  When working with bound 
	' reports (reports using a DataControl), the EOF parameter is automatically set by the report;
	' however, when working with unbound reports this parameter needs to be controlled manually.
	Private Sub UnboundDSInvoice_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles MyBase.FetchData
		If _rowCounter = _invoiceData.Tables(0).Rows.Count Then
			'If the reader has reached the end of the data then
			'set the eArgs.EOF flag to true and exit the procedure.
			eArgs.EOF = True
			Return
		Else
			'Populate the fields collection from the DataReader.
			Dim i As Integer
			For i = 0 To (_invoiceData.Tables(0).Columns.Count) - 1
				Fields(_invoiceData.Tables(0).Columns(i).ColumnName).Value = _invoiceData.Tables(0).Rows(_rowCounter)(i)
			Next i
			'Add unbound DiscountTotal field total to instance of the Fields collection (for data binding and summary totaling in the group footer.)
			Fields("DiscountTotal").Value = Convert.ToDouble(Fields("UnitPrice").Value, CultureInfo.CurrentCulture) * Convert.ToInt32(Me.Fields("Quantity").Value, CultureInfo.InvariantCulture) * Convert.ToDouble(Me.Fields("Discount").Value, CultureInfo.CurrentCulture)
			'Set row counter.
			eArgs.EOF = False
			_rowCounter += 1
		End If
	End Sub
	'<summary>
	' 
	' ReportStart event
	' This event is raised every time when report to be start.
	' 
	' 
	' </summary> 
	Private Sub UnboundDSInvoice_ReportStart(sender As Object, e As EventArgs) Handles MyBase.ReportStart
		'Dataset to hold data.
		_invoiceData = New DataSet()
		_invoiceData.Locale = CultureInfo.InvariantCulture
		'Database connection populated from the sample Northwind access database
		Dim nwindConn As New OleDbConnection(My.Resources.ConnectionString)
		'SQL Select command to run against the database
		Dim selectCMD As New OleDbCommand("SELECT * FROM Invoices ORDER BY Customers.CompanyName, OrderID", nwindConn)
		selectCMD.CommandTimeout = 30
		'Data adapter used to run the select command.
		Dim invoicesDA As New OleDbDataAdapter()
		invoicesDA.SelectCommand = selectCMD
		'Fill the DataSet
		invoicesDA.Fill(_invoiceData, "Invoices")
		'Initialize counter to first row of the DataSet.
		_rowCounter = 0
	End Sub
End Class
