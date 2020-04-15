Imports System
Imports System.IO
Imports System.Globalization
Public Class UnboundDAInvoice
	Inherits GrapeCity.ActiveReports.SectionReport
	'DataSource for the report
	Dim _invoiceFileStream As StreamReader
	'Fields array list.
	Dim _fieldNameArray() As String
	'Data array list and counter.
	Dim _invoiceDataArray()() As String
	Dim _rowCounter As Integer
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	'DataInitialize Event
	' Use it to add custom fields to the report's Fields collection. 
	' Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
	' or an unbound report (one that does not depend on a data control to get its records).
	Private Sub UnboundDAInvoice_DataInitialize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataInitialize
		Dim i As Integer
		For i = 0 To _fieldNameArray.Length - 1
			Fields.Add(_fieldNameArray(i).ToString())
		Next i
		'Add calculated Fields.
		Fields.Add("DiscountTotal")
	End Sub
	'FetchData Event
	' This event is raised every time a new record is processed. The FetchData has an EOF parameter
	' indicating whether the FetchData event should be raised.  When working with bound 
	' reports (reports using a DataControl), the EOF parameter is automatically set by the report;
	' however, when working with unbound reports this parameter needs to be controlled manually.
	Private Sub UnboundDAInvoice_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles MyBase.FetchData
		If _rowCounter > _invoiceDataArray.GetUpperBound(0) Then
			'No More records EOF = true
			eArgs.EOF = True
			Return
		End If
		Dim currentArray As String() = _invoiceDataArray(_rowCounter)
		'Populate the fields used in data binding.
		Dim i As Integer
		If Not (currentArray Is Nothing) Then
			For i = 0 To currentArray.Length - 1
				Dim dblVal As Double = 0.0F
				If (Double.TryParse(currentArray(i), NumberStyles.Float, CultureInfo.InvariantCulture, dblVal)) Then
					Fields(_fieldNameArray(i).ToString()).Value = dblVal.ToString(CultureInfo.CurrentCulture)
				Else : Fields(_fieldNameArray(i).ToString()).Value = currentArray(i)
				End If
			Next i
		End If
		
		'Add unbound DiscountTotal field total to instance of the Fields collection (for data binding and summary totaling in the group footer.)
		Fields("DiscountTotal").Value = Convert.ToDouble(Me.Fields("UnitPrice").Value, CultureInfo.CurrentCulture) * Convert.ToInt32(Me.Fields("Quantity").Value, CultureInfo.InvariantCulture) * Convert.ToDouble(Me.Fields("Discount").Value, CultureInfo.CurrentCulture)
		'It is important to set EOF to False if there are more records
		'otherwise the default True value will be used and the report*/
		_rowCounter += 1
		eArgs.EOF = False
	End Sub
	'<summary>
	' 
	' ReportStart event
	' This event is raised every time when report to be start.
	' 
	' 
	' </summary> 
	Private Sub UnboundDAInvoice_ReportStart(sender As Object, e As EventArgs) Handles MyBase.ReportStart
		'Open text file as data source.
		_invoiceFileStream = File.OpenText("..\..\Invoices.txt")
		'Set up the fields used in data binding.
		Dim currentLine As String = _invoiceFileStream.ReadLine()
		_fieldNameArray = currentLine.Split(New Char() {";"c})
		'Get row count from text file.
		_rowCounter = 0
		Dim fileHasData As Boolean = True
		While fileHasData
			currentLine = _invoiceFileStream.ReadLine()
			If currentLine.Length <> 0 Then
				_rowCounter += 1
			Else
				fileHasData = False
			End If
		End While
		'Reset data stream.
		_invoiceFileStream.Close()
		_invoiceFileStream = File.OpenText("..\..\Invoices.txt")
		_invoiceDataArray = New String(_rowCounter)() {}
		'Read fields list line.
		currentLine = _invoiceFileStream.ReadLine()
		Dim i As Integer
		'Populate the data array from text file.
		For i = 0 To _rowCounter - 1
			currentLine = _invoiceFileStream.ReadLine()
			'Populate the fields used in data binding.
			_invoiceDataArray(i) = New String(_fieldNameArray.Length) {}
			_invoiceDataArray(i) = currentLine.Split(New Char() {";"c})
		Next i
		'Close file stream.
		_invoiceFileStream.Close()
		_rowCounter = 0
	End Sub
End Class
