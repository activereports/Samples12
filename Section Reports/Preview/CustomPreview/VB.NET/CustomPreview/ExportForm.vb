Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.IO
Imports GrapeCity.ActiveReports.Export.Excel.Section
Public Class ExportForm
	Dim _sectionDocument As Document.SectionDocument
	Public Sub New(ByVal sectionDocument As Document.SectionDocument)
		_sectionDocument = sectionDocument
		InitializeComponent()
	End Sub
	Private Sub AddSectionReportExportTypes()
		Dim sectionExport As New List(Of SectionExport)()
		sectionExport.Add(New SectionExport() With { _
			.DisplayName = My.Resources.SectionHTMLString, _
			.Filter = My.Resources.HTMLFilter, _
			.DefaultFileName = My.Resources.HTMLFileName, _
			.Settings = New Export.Html.Section.HtmlExport() _
		})
		sectionExport.Add(New SectionExport() With { _
			.DisplayName = My.Resources.SectionPDFString, _
			.Filter = My.Resources.PDFFilter, _
			.DefaultFileName = My.Resources.PDFFileName, _
			.Settings = New Export.Pdf.Section.PdfExport() _
		})
		sectionExport.Add(New SectionExport() With { _
			.DisplayName = My.Resources.SectionRTFString, _
			.Filter = My.Resources.RtfFilter, _
			.DefaultFileName = My.Resources.RtfFileName, _
			.Settings = New Export.Word.Section.RtfExport() _
		})
		sectionExport.Add(New SectionExport() With { _
			.DisplayName = My.Resources.SectionTIFFString, _
			.Filter = My.Resources.TiffFilter, _
			.DefaultFileName = My.Resources.TiffFileName, _
			.Settings = New Export.Image.Tiff.Section.TiffExport() _
		})
		sectionExport.Add(New SectionExport() With { _
			.DisplayName = My.Resources.SectionPlainTextString, _
			.Filter = My.Resources.TextFilter, _
			.DefaultFileName = My.Resources.TextFileName, _
			.Settings = New Export.Xml.Section.TextExport() _
		})
		sectionExport.Add(New SectionExport() With { _
			.DisplayName = My.Resources.SectionExcelString, _
			.Filter = My.Resources.ExcelFilter, _
			.DefaultFileName = My.Resources.ExcelFileName, _
			.Settings = New Export.Excel.Section.XlsExport() _
		})
		cmbExportFormat.DataSource = sectionExport
		cmbExportFormat.DisplayMember = "DisplayName"
		cmbExportFormat.SelectedIndex = 0
	End Sub
	Private Sub ExportForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		AddSectionReportExportTypes()
	End Sub
	Private Sub cmbExportFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbExportFormat.SelectedIndexChanged
		exportPropertyGrid.SelectedObject = DirectCast(cmbExportFormat.SelectedItem, SectionExport).Settings
	End Sub
	Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
		Me.Hide()
	End Sub
	Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click
		exportSaveFileDialog.Filter = DirectCast(cmbExportFormat.SelectedItem, SectionExport).Filter
		exportSaveFileDialog.FileName = DirectCast(cmbExportFormat.SelectedItem, SectionExport).DefaultFileName
		If TypeOf exportPropertyGrid.SelectedObject Is XlsExport Then
			Select Case DirectCast(exportPropertyGrid.SelectedObject, XlsExport).FileFormat
				Case Export.Excel.Section.FileFormat.Xlsx
					exportSaveFileDialog.FileName = My.Resources.Excel2007FileName
					exportSaveFileDialog.Filter = My.Resources.Excel2007Filter
					Exit Select
			End Select
		End If
		If exportSaveFileDialog.ShowDialog() = DialogResult.OK Then
			If File.Exists(exportSaveFileDialog.FileName) Then
				File.Delete(exportSaveFileDialog.FileName)
			End If
			DirectCast(cmbExportFormat.SelectedItem, SectionExport).Export(_sectionDocument, exportSaveFileDialog.FileName)
			MessageBox.Show(DirectCast(cmbExportFormat.SelectedItem, SectionExport).DisplayName + " " + My.Resources.ExportCompleteString)
			Hide()
		End If
	End Sub
End Class
