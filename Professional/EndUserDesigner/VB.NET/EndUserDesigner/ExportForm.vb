Imports System.Collections.Generic
Imports System.Windows.Forms
Imports GrapeCity.ActiveReports.Export.Html.Page
Imports GrapeCity.ActiveReports.Rendering.IO
Imports System.IO
Imports GrapeCity.ActiveReports.Export.Image.Page
Imports GrapeCity.ActiveReports.Export.Pdf.Page
Imports GrapeCity.ActiveReports.Export.Rdf
Imports GrapeCity.ActiveReports.Export.Word.Page
Imports GrapeCity.ActiveReports.Export.Xml.Page
Imports GrapeCity.ActiveReports.Export.Excel.Page
Imports GrapeCity.ActiveReports.Design
Imports GrapeCity.ActiveReports.Export.Excel.Section
Imports System.Xml
Imports GrapeCity.ActiveReports.Extensibility.Rendering.IO
Imports GrapeCity.ActiveReports.Export.Text.Page
Public Class ExportForm
	Dim _reportType As DesignerReportType
	Dim _report As Object
	Private ReadOnly _reportViewer As Viewer.Win.Viewer
	Dim _sectionReport As New SectionReport()
	Public Sub New(ByVal ReportType As DesignerReportType, ByVal Report As Object, ByVal reportViewer As GrapeCity.ActiveReports.Viewer.Win.Viewer)
		_reportType = ReportType
		_report = Report
		_reportViewer = reportViewer
		InitializeComponent()
	End Sub
	Private Sub AddPageReportExportTypes()
		Dim pageExports As New List(Of PageExport)()
		Dim isFpl As Boolean = _reportType = DesignerReportType.Page
		Dim imageRenderingExtension As ImageRenderingExtension = New ImageRenderingExtension()
		Dim wordRenderingExtension As WordRenderingExtension = New WordRenderingExtension()
		Dim htmlRenderingExtension As HtmlRenderingExtension = New HtmlRenderingExtension()
		Dim pdfRenderingExtension As PdfRenderingExtension = New PdfRenderingExtension()
		Dim xmlRenderingExtension As XmlRenderingExtension = New XmlRenderingExtension()
		Dim excelRenderingExtension As ExcelRenderingExtension = New ExcelRenderingExtension()
        Dim csvRenderingExtension As CsvRenderingExtension = New CsvRenderingExtension()
		pageExports.Add(New PageExport() With { _
			.DisplayName = My.Resources.Resource.PageCsvString, _
			.DefaultFileName = My.Resources.Resource.CsvFileName, _
			.Settings = csvRenderingExtension.GetSupportedSettings(isFpl), _
			.Filter = My.Resources.Resource.CsvFilter, _
			.RenderingExtension = csvRenderingExtension _
		})
		pageExports.Add(New PageExport() With { _
			.DisplayName = My.Resources.Resource.PageImageString, _
			.DefaultFileName = My.Resources.Resource.ImageFileName, _
			.Settings = imageRenderingExtension.GetSupportedSettings(isFpl), _
			.Filter = My.Resources.Resource.ImageFilter, _
			.RenderingExtension = imageRenderingExtension _
		})
		pageExports.Add(New PageExport() With { _
			.DisplayName = My.Resources.Resource.PageWordString, _
			.DefaultFileName = My.Resources.Resource.WordFileName, _
			.Settings = wordRenderingExtension.GetSupportedSettings(isFpl), _
			.Filter = My.Resources.Resource.WordFilter, _
			.RenderingExtension = wordRenderingExtension _
		})
		pageExports.Add(New PageExport() With { _
			.DisplayName = My.Resources.Resource.PageHTMLString, _
			.DefaultFileName = My.Resources.Resource.HTMLFileName, _
			.Settings = htmlRenderingExtension.GetSupportedSettings(isFpl), _
			.Filter = My.Resources.Resource.HTMLFilter, _
			.RenderingExtension = htmlRenderingExtension _
		})
		pageExports.Add(New PageExport() With { _
			.DisplayName = My.Resources.Resource.PagePDFString, _
			.DefaultFileName = My.Resources.Resource.PDFFileName, _
			.Settings = pdfRenderingExtension.GetSupportedSettings(isFpl), _
			.Filter = My.Resources.Resource.PDFFilter, _
			.RenderingExtension = pdfRenderingExtension _
		})
		pageExports.Add(New PageExport() With { _
			.DisplayName = My.Resources.Resource.PageRDFString, _
			.DefaultFileName = My.Resources.Resource.RDFFileName, _
			.Settings = New Export.Rdf.Settings(), _
			.Filter = My.Resources.Resource.RdfFilter, _
			.RenderingExtension = New RdfRenderingExtension() _
		})
		pageExports.Add(New PageExport() With { _
			.DisplayName = My.Resources.Resource.PageXMLString, _
			.DefaultFileName = My.Resources.Resource.XMLFileName, _
			.Settings = xmlRenderingExtension.GetSupportedSettings(isFpl), _
			.Filter = My.Resources.Resource.XmlFilter, _
			.RenderingExtension = xmlRenderingExtension _
		})
		pageExports.Add(New PageExport() With { _
			.DisplayName = If((_reportType = DesignerReportType.Rdl), My.Resources.Resource.PageExcelRE, My.Resources.Resource.PageExcelString), _
			.DefaultFileName = My.Resources.Resource.ExcelFileName, _
			.Settings = excelRenderingExtension.GetSupportedSettings(isFpl), _
			.Filter = My.Resources.Resource.ExcelFilter, _
			.RenderingExtension = excelRenderingExtension _
		})
		cmbExportFormat.DataSource = pageExports
		cmbExportFormat.DisplayMember = "DisplayName"
		cmbExportFormat.SelectedIndex = 0
	End Sub
	Private Sub AddSectionReportExportTypes()
		Dim sectionExports As New List(Of SectionExport)()
		sectionExports.Add(New SectionExport() With { _
			.DisplayName = My.Resources.Resource.SectionHTMLString, _
			.Filter = My.Resources.Resource.HTMLFilter, _
			.DefaultFileName = My.Resources.Resource.HTMLFileName, _
			.Settings = New Export.Html.Section.HtmlExport() _
		})
		sectionExports.Add(New SectionExport() With { _
			.DisplayName = My.Resources.Resource.SectionPDFString, _
			.Filter = My.Resources.Resource.PDFFilter, _
			.DefaultFileName = My.Resources.Resource.PDFFileName, _
			.Settings = New Export.Pdf.Section.PdfExport() _
		})
		sectionExports.Add(New SectionExport() With { _
			.DisplayName = My.Resources.Resource.SectionRTFString, _
			.Filter = My.Resources.Resource.RtfFilter, _
			.DefaultFileName = My.Resources.Resource.RtfFileName, _
			.Settings = New Export.Word.Section.RtfExport() _
		})
		sectionExports.Add(New SectionExport() With { _
			.DisplayName = My.Resources.Resource.SectionTIFFString, _
			.Filter = My.Resources.Resource.TiffFilter, _
			.DefaultFileName = My.Resources.Resource.TiffFileName, _
			.Settings = New Export.Image.Tiff.Section.TiffExport() _
		})
		sectionExports.Add(New SectionExport() With { _
			.DisplayName = My.Resources.Resource.SectionPlainTextString, _
			.Filter = My.Resources.Resource.TextFilter, _
			.DefaultFileName = My.Resources.Resource.TextFileName, _
			.Settings = New Export.Xml.Section.TextExport() _
		})
		sectionExports.Add(New SectionExport() With { _
			.DisplayName = My.Resources.Resource.SectionExcelString, _
			.Filter = My.Resources.Resource.ExcelFilter, _
			.DefaultFileName = My.Resources.Resource.ExcelFileName, _
			.Settings = New Export.Excel.Section.XlsExport() _
		})
		cmbExportFormat.DataSource = sectionExports
		cmbExportFormat.DisplayMember = "DisplayName"
		cmbExportFormat.SelectedIndex = 0
	End Sub
	Private Sub ExportForm_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
		If _reportType = DesignerReportType.Section Then
			AddSectionReportExportTypes()
		End If
		If (_reportType = DesignerReportType.Page) OrElse (_reportType = DesignerReportType.Rdl) Then
			AddPageReportExportTypes()
		End If
	End Sub
	Private Sub cmbExportFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbExportFormat.SelectedIndexChanged
		If (_reportType = DesignerReportType.Page) OrElse (_reportType = DesignerReportType.Rdl) Then
			exportPropertyGrid.SelectedObject = DirectCast(cmbExportFormat.SelectedItem, PageExport).Settings
		End If
		If _reportType = DesignerReportType.Section Then
			exportPropertyGrid.SelectedObject = DirectCast(cmbExportFormat.SelectedItem, SectionExport).Settings
		End If
	End Sub
	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCancel.Click
		Hide()
	End Sub
	Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnOk.Click
		Select Case _reportType
			Case DesignerReportType.Section
				exportSaveFileDialog.Filter = DirectCast(cmbExportFormat.SelectedItem, SectionExport).Filter
				exportSaveFileDialog.FileName = DirectCast(cmbExportFormat.SelectedItem, SectionExport).DefaultFileName
				If TypeOf exportPropertyGrid.SelectedObject Is XlsExport Then
					Select Case DirectCast(exportPropertyGrid.SelectedObject, XlsExport).FileFormat
						Case Export.Excel.Section.FileFormat.Xlsx
							exportSaveFileDialog.FileName = My.Resources.Resource.Excel2007FileName
							exportSaveFileDialog.Filter = My.Resources.Resource.Excel2007Filter
							Exit Select
					End Select
				End If
				If exportSaveFileDialog.ShowDialog() = DialogResult.OK Then
					RunSectionReport()
					If File.Exists(exportSaveFileDialog.FileName) Then
						File.Delete(exportSaveFileDialog.FileName)
					End If
					DirectCast(cmbExportFormat.SelectedItem, SectionExport).Export(_sectionReport.Document, exportSaveFileDialog.FileName)
					MessageBox.Show(DirectCast(cmbExportFormat.SelectedItem, SectionExport).DisplayName + " " + My.Resources.Resource.ExportCompleteString)
					Hide()
				End If
				Exit Select
			Case DesignerReportType.Page, DesignerReportType.Rdl
				exportSaveFileDialog.AddExtension = False
				exportSaveFileDialog.Filter = DirectCast(cmbExportFormat.SelectedItem, PageExport).Filter
				exportSaveFileDialog.FileName = DirectCast(cmbExportFormat.SelectedItem, PageExport).DefaultFileName
				If TypeOf exportPropertyGrid.SelectedObject Is Export.Image.Page.Settings Then
					Dim settings As Export.Image.Page.Settings = DirectCast(exportPropertyGrid.SelectedObject, Export.Image.Page.Settings)
					exportSaveFileDialog.FileName = DirectCast(cmbExportFormat.SelectedItem, PageExport).DefaultFileName + "." & settings.ImageType.ToString().ToLower()
				End If
				If TypeOf exportPropertyGrid.SelectedObject Is Export.Word.Page.Settings Then
					Select Case DirectCast(exportPropertyGrid.SelectedObject, Export.Word.Page.Settings).FileFormat
						Case Export.Word.Page.FileFormat.OOXML
							exportSaveFileDialog.FileName = My.Resources.Resource.Word2007FileName
							exportSaveFileDialog.Filter = My.Resources.Resource.Word2007Filter
							Exit Select
					End Select
				End If
				If TypeOf exportPropertyGrid.SelectedObject Is ExcelRenderingExtensionSettings Then
					Select Case DirectCast(exportPropertyGrid.SelectedObject, ExcelRenderingExtensionSettings).FileFormat
						Case Export.Excel.Page.FileFormat.Xlsx
							exportSaveFileDialog.FileName = My.Resources.Resource.Excel2007FileName
							exportSaveFileDialog.Filter = My.Resources.Resource.Excel2007Filter
							Exit Select
					End Select
				End If
				If exportSaveFileDialog.ShowDialog() = DialogResult.OK Then
					If File.Exists(exportSaveFileDialog.FileName) Then
						File.Delete(exportSaveFileDialog.FileName)
					End If
					Dim export As PageExport = DirectCast(cmbExportFormat.SelectedItem, PageExport)
					Dim StreamProvider As StreamProvider = New FileStreamProvider(New DirectoryInfo(Path.GetDirectoryName(exportSaveFileDialog.FileName)), Path.GetFileNameWithoutExtension(exportSaveFileDialog.FileName))
					_reportViewer.Render(export.RenderingExtension, StreamProvider, export.Settings.GetSettings())
					MessageBox.Show(DirectCast(cmbExportFormat.SelectedItem, PageExport).DisplayName + " " + My.Resources.Resource.ExportCompleteString)
					Hide()
				End If
				Exit Select
		End Select
	End Sub
	Private Sub RunSectionReport()
		Dim memoryStream As New MemoryStream()
		memoryStream.Position = 0
		Using writer As XmlWriter = XmlWriter.Create(memoryStream)
			DirectCast(_report, SectionReport).SaveLayout(writer)
		End Using
		memoryStream.Position = 0
		Using reader As XmlReader = XmlReader.Create(memoryStream)
			_sectionReport.LoadLayout(reader)
		End Using
		_sectionReport.Run()
	End Sub
End Class
