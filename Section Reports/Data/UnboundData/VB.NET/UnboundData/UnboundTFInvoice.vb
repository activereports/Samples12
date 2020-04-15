Imports System
Imports System.IO
Imports System.Globalization
Public Class UnboundTFInvoice
	Inherits GrapeCity.ActiveReports.SectionReport
	'DataSource for the report.
	Private _invoiceFileStream As StreamReader
	'Fields Array List
	Private _fieldNameArray() As String
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	'DataInitialize Event
	'Use it to add custom fields to the report's Fields collection. 
	' Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
	' or an unbound report (one that does not depend on a data control to get its records).
	Private Sub UnboundTFInvoice_DataInitialize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataInitialize
		
		Dim i As Integer
		For i = 0 To _fieldNameArray.Length - 1
			Fields.Add(_fieldNameArray(i).ToString())
		Next i
		'Add Calculated Fields
		Fields.Add("DiscountTotal")
	End Sub
	'FetchData Event
	'ActiveReports event that is called during the report run once per
	'row from the dataset.  This event is usually only used in unbound reporting,
	'you would set the Fields collection value to the value from your dataset and
	'advance the next row.  When you run out of data, you should set the
	'FetchEventArgs argument's EOF field to true to tell the report that the report
	'is done with the data.
	Private Sub UnboundTFInvoice_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles MyBase.FetchData
		Try
			Dim currentLine As String = _invoiceFileStream.ReadLine()
			If Not (currentLine Is Nothing) Then
				Dim currentArray As String() = currentLine.Split(New Char() {";"c})
				'Populate the fields used in data binding.
				Dim i As Integer
				For i = 0 To currentArray.Length - 1
					Dim dblVal As Double = 0.0F
					If (Double.TryParse(currentArray(i), NumberStyles.Float, CultureInfo.InvariantCulture, dblVal)) Then
						Fields(_fieldNameArray(i).ToString()).Value = dblVal.ToString(CultureInfo.CurrentCulture)
					Else : Fields(_fieldNameArray(i).ToString()).Value = currentArray(i)
					End If
				Next i
				'Add unbound DiscountTotal field total to instance of the Fields collection (for data binding and summary totaling in the group footer.)
				'Double values are already in CultureInfo.CurrentCulture format.
				Fields("DiscountTotal").Value = Convert.ToDouble(Fields("UnitPrice").Value, CultureInfo.CurrentCulture) * Convert.ToInt32(Me.Fields("Quantity").Value, CultureInfo.InvariantCulture) * Convert.ToDouble(Me.Fields("Discount").Value, CultureInfo.CurrentCulture)
				eArgs.EOF = False
			Else
				eArgs.EOF = True
			End If
		Catch ex As EndOfStreamException
			'If the file stream has reached the end of the data then
			'set the eArgs.EOF flag to true and exit the procedure.
			eArgs.EOF = True
		End Try
	End Sub
	'ReportStart Event
	' Use this event to initialize any objects or variables needed while running a report. 
	' Also use this event to set any Subreport control objects to a new instance 
	'of the report assigned to the Subreport control.
	Private Sub UnboundTFInvoice_ReportEnd(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ReportEnd
		'Close the File Stream
		_invoiceFileStream.Close()
	End Sub
	'<summary>
	' 
	' ReportStart event
	' This event is raised every time when report to be start.
	' 
	' 
	' </summary>
	Private Sub UnboundTFInvoice_ReportStart(sender As Object, e As EventArgs) Handles MyBase.ReportStart
		'Open text file as data source.
		_invoiceFileStream = File.OpenText("..\..\Invoices.txt")
		'Set up the fields used in data binding.
		Dim currentLine As String = _invoiceFileStream.ReadLine()
		_fieldNameArray = currentLine.Split(New Char() {";"c})
	End Sub
End Class
