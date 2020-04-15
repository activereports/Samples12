Imports System.IO
Public Class MainForm
	' Loads and shows the report.
	Private Sub btnCSV_Click(sender As System.Object, e As System.EventArgs) Handles btnCSV.Click
		Const settingForNoHeaderDelimited As String = "ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued"
		
		Const settingForNoHeaderFixed As String = "ProductID[9],ProductName[32],SupplierID[10],CategoryID[10],QuantityPerUnit[20],UnitPrice[9],UnitsInStock[12],UnitsOnOrder[12],ReorderLevel[12],Discontinued[12]"
		Const settingForHeaderExistsFixed As String = "[9],[32],[10],[10],[20],[9],[12],[12],[12],[12]"
		
		'
		'
		Dim connectionString = String.Empty
		If rbtnNoHeaderComma.Checked Then
			connectionString = String.Format("Path={0};Encoding={1};TextQualifier="";ColumnsSeparator=,;RowsSeparator=\r\n;Columns={2}",
											 My.Resources.PathToFileNoHeaderComma, My.Resources.CSVEncoding, settingForNoHeaderDelimited)
		ElseIf rbtnHeaderTab.Checked Then
			connectionString = String.Format("Path={0};Encoding={1};TextQualifier="";ColumnsSeparator=" & vbTab & ";RowsSeparator=\r\n;HasHeaders=True",
											 My.Resources.PathToFileHeaderTab, My.Resources.CSVEncoding)
		ElseIf rbtnHeader.Checked Then
			connectionString = String.Format("Path={0};Encoding={1};Columns={2};HasHeaders=True",
											 My.Resources.PathToFileHeader, My.Resources.CSVEncoding, settingForHeaderExistsFixed)
		ElseIf rbtnNoHeader.Checked Then
			connectionString = String.Format("Path={0};Encoding={1};Columns={2}",
											 My.Resources.PathToFileNoHeader, My.Resources.CSVEncoding, settingForNoHeaderFixed)
		End If
		Dim report = New PageReport(New FileInfo("..\..\Reports\StockList.rdlx"))
		Dim connectionProps = report.Report.DataSources(0).ConnectionProperties
		connectionProps.DataProvider = "CSV"
		connectionProps.ConnectString = connectionString
		arvMain.ReportViewer.LoadDocument(report.Document)
	End Sub
End Class
