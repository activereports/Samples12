Imports System.IO
Public Class StyleSheetsForm
	Private externalStyleSheet As String = ""
	Private Sub buttonChooseExtStyle_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles buttonChooseExtStyle.Click
		'Select an external stylsheet to apply.
		Dim openFileDialog As FileDialog = New OpenFileDialog()
		
		openFileDialog.Filter = "Style sheet|*.reportstyle"
		
		'
		openFileDialog.InitialDirectory = New FileInfo(Me.GetType().Assembly.Location).DirectoryName
		openFileDialog.CheckFileExists = True
		If openFileDialog.ShowDialog(Me) = DialogResult.OK Then
			Dim styleSheetFile As FileInfo = New FileInfo(openFileDialog.FileName)
			externalStyleSheet = styleSheetFile.FullName
			
			radioButtonExternalStyleSheet.Text = "External stylesheet: " + styleSheetFile.Name
			
			'
			radioButtonExternalStyleSheet.Checked = True
		End If
	End Sub
	Private Sub buttonRunReport_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles buttonRunReport.Click
		Dim report As SectionReport = Nothing
		'Select the report in the viewer.
		If radioButtonProductListReport.Checked Then
			report = New ProductsReport()
		ElseIf radioButtonCategoriesReport.Checked Then
			report = New CategoryReport()
		End If
		'Apply stylesheet on the report.
		Dim outputFolder As String
		outputFolder = New FileInfo(Me.GetType().Assembly.Location).DirectoryName & "\"
		Dim styleSheet As String = ""
		If radioButtonClassicStyle.Checked Then
			styleSheet = outputFolder & "Classic.reportstyle"
		ElseIf radioButtonColoredStyle.Checked Then
			styleSheet = outputFolder & "Colored.reportstyle"
		ElseIf externalStyleSheet <> "" Then
			styleSheet = externalStyleSheet
		End If
		If styleSheet <> "" Then
			report.LoadStyles(styleSheet)
		End If
		reportViewer.LoadDocument(report)
	End Sub
End Class
