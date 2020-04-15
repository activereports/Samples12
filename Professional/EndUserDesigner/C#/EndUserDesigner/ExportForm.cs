using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GrapeCity.ActiveReports.Export.Html.Page;
using GrapeCity.ActiveReports.Export.Text.Page;
using GrapeCity.ActiveReports.Extensibility.Rendering.IO;
using GrapeCity.ActiveReports.Rendering.IO;
using System.IO;
using GrapeCity.ActiveReports.Export.Image.Page;
using GrapeCity.ActiveReports.Export.Pdf.Page;
using GrapeCity.ActiveReports.Export.Rdf;
using GrapeCity.ActiveReports.Export.Word.Page;
using GrapeCity.ActiveReports.Export.Xml.Page;
using GrapeCity.ActiveReports.Export.Excel.Page;
using GrapeCity.ActiveReports.Design;
using GrapeCity.ActiveReports.Export.Excel.Section;
using System.Xml;
namespace GrapeCity.ActiveReports.Samples.EndUserDesigner
{
	public partial class ExportForm : Form
	{
		readonly DesignerReportType _reportType;
		readonly object _report;
		private readonly Viewer.Win.Viewer _reportViewer;
		readonly SectionReport _sectionReport = new SectionReport();
		public ExportForm(DesignerReportType reportType, object report, Viewer.Win.Viewer reportViewer)
		{
			_reportType = reportType;
			_report = report;
			_reportViewer = reportViewer;
			InitializeComponent();
		}
		void AddPageReportExportTypes()
		{
			List<PageExport> pageExports = new List<PageExport>();
			bool isFpl = _reportType == DesignerReportType.Page;
			var imageRenderingExtension = new ImageRenderingExtension();
			var wordRenderingExtension = new WordRenderingExtension();
			var htmlRenderingExtension = new HtmlRenderingExtension();
			var pdfRenderingExtension = new PdfRenderingExtension();
			var xmlRenderingExtension = new XmlRenderingExtension();
			var excelRenderingExtension = new ExcelRenderingExtension();
			var csvRenderingExtension = new CsvRenderingExtension();
			pageExports.Add(new PageExport
			{
				DisplayName = Properties.Resources.PageCsvString,
				DefaultFileName = Properties.Resources.CsvFileName,
				Settings = csvRenderingExtension.GetSupportedSettings(isFpl),
				Filter = Properties.Resources.CsvFilter,
				RenderingExtension = csvRenderingExtension,
			});
			pageExports.Add(new PageExport
			{
				DisplayName = Properties.Resources.PageImageString,
				DefaultFileName = Properties.Resources.ImageFileName,
				Settings = imageRenderingExtension.GetSupportedSettings(isFpl),
				Filter = Properties.Resources.ImageFilter,
				RenderingExtension = imageRenderingExtension,
			});
			pageExports.Add(new PageExport
			{
				DisplayName = Properties.Resources.PageWordString,
				DefaultFileName = Properties.Resources.WordFileName,
				Settings = wordRenderingExtension.GetSupportedSettings(isFpl),
				Filter = Properties.Resources.WordFilter,
				RenderingExtension = wordRenderingExtension,
			});
			pageExports.Add(new PageExport
			{
				DisplayName = Properties.Resources.PageHTMLString,
				DefaultFileName = Properties.Resources.HTMLFileName,
				Settings = htmlRenderingExtension.GetSupportedSettings(isFpl),
				Filter = Properties.Resources.HTMLFilter,
				RenderingExtension = htmlRenderingExtension,
			});
			pageExports.Add(new PageExport
			{
				DisplayName = Properties.Resources.PagePDFString,
				DefaultFileName = Properties.Resources.PDFFileName,
				Settings = pdfRenderingExtension.GetSupportedSettings(isFpl),
				Filter = Properties.Resources.PDFFilter,
				RenderingExtension = pdfRenderingExtension,
			});
			pageExports.Add(new PageExport
			{
				DisplayName = Properties.Resources.PageRDFString,
				DefaultFileName = Properties.Resources.RDFFileName,
				Settings = new Export.Rdf.Settings(),
				Filter = Properties.Resources.RdfFilter,
				RenderingExtension = new RdfRenderingExtension(),
			});
			pageExports.Add(new PageExport
			{
				DisplayName = Properties.Resources.PageXMLString,
				DefaultFileName = Properties.Resources.XMLFileName,
				Settings = xmlRenderingExtension.GetSupportedSettings(isFpl),
				Filter = Properties.Resources.XmlFilter,
				RenderingExtension = xmlRenderingExtension,
			});
			pageExports.Add(new PageExport
			{
				DisplayName = (_reportType == DesignerReportType.Rdl) ? Properties.Resources.PageExcelRE : Properties.Resources.PageExcelString,
				DefaultFileName = Properties.Resources.ExcelFileName,
				Settings = excelRenderingExtension.GetSupportedSettings(isFpl),
				Filter = Properties.Resources.ExcelFilter,
				RenderingExtension = excelRenderingExtension,
			});
			cmbExportFormat.DataSource = pageExports;
			cmbExportFormat.DisplayMember = "DisplayName";
			cmbExportFormat.SelectedIndex = 0;
		}
		void AddSectionReportExportTypes()
		{
			List<SectionExport> sectionExports = new List<SectionExport>();
			sectionExports.Add(new SectionExport
			{
				DisplayName = Properties.Resources.SectionHTMLString,
				Filter = Properties.Resources.HTMLFilter,
				DefaultFileName = Properties.Resources.HTMLFileName,
				Settings = new Export.Html.Section.HtmlExport()
			});
			sectionExports.Add(new SectionExport
			{
				DisplayName = Properties.Resources.SectionPDFString,
				Filter = Properties.Resources.PDFFilter,
				DefaultFileName = Properties.Resources.PDFFileName,
				Settings = new Export.Pdf.Section.PdfExport()
			});
			sectionExports.Add(new SectionExport
			{
				DisplayName = Properties.Resources.SectionRTFString,
				Filter = Properties.Resources.RtfFilter,
				DefaultFileName = Properties.Resources.RtfFileName,
				Settings = new Export.Word.Section.RtfExport()
			});
			sectionExports.Add(new SectionExport
			{
				DisplayName = Properties.Resources.SectionTIFFString,
				Filter = Properties.Resources.TiffFilter,
				DefaultFileName = Properties.Resources.TiffFileName,
				Settings = new Export.Image.Tiff.Section.TiffExport()
			});
			sectionExports.Add(new SectionExport
			{
				DisplayName = Properties.Resources.SectionPlainTextString,
				Filter = Properties.Resources.TextFilter,
				DefaultFileName = Properties.Resources.TextFileName,
				Settings = new Export.Xml.Section.TextExport()
			});
			sectionExports.Add(new SectionExport
			{
				DisplayName = Properties.Resources.SectionExcelString,
				Filter = Properties.Resources.ExcelFilter,
				DefaultFileName = Properties.Resources.ExcelFileName,
				Settings = new XlsExport()
			});
			cmbExportFormat.DataSource = sectionExports;
			cmbExportFormat.DisplayMember = "DisplayName";
			cmbExportFormat.SelectedIndex = 0;
		}
		private void ExportForm_Load(object sender, EventArgs e)
		{
			if (_reportType == DesignerReportType.Section)
			{
				AddSectionReportExportTypes();
			}
			if ((_reportType == DesignerReportType.Page) || (_reportType == DesignerReportType.Rdl))
			{
				AddPageReportExportTypes();
			}
		}
		private void cmbExportFormat_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((_reportType == DesignerReportType.Page) || (_reportType == DesignerReportType.Rdl))
			{
				exportPropertyGrid.SelectedObject = ((PageExport)cmbExportFormat.SelectedItem).Settings;
			}
			if (_reportType == DesignerReportType.Section)
			{
				exportPropertyGrid.SelectedObject = ((SectionExport)cmbExportFormat.SelectedItem).Settings;
			}
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Hide();
		}
		private void btnOk_Click(object sender, EventArgs e)
		{
			switch (_reportType)
			{
				case DesignerReportType.Section:
					exportSaveFileDialog.Filter = ((SectionExport)cmbExportFormat.SelectedItem).Filter;
					exportSaveFileDialog.FileName = ((SectionExport)cmbExportFormat.SelectedItem).DefaultFileName;
					if (exportPropertyGrid.SelectedObject is XlsExport)
					{
						switch (((XlsExport)exportPropertyGrid.SelectedObject).FileFormat)
						{
							case Export.Excel.Section.FileFormat.Xlsx:
								exportSaveFileDialog.FileName = Properties.Resources.Excel2007FileName;
								exportSaveFileDialog.Filter = Properties.Resources.Excel2007Filter;
								break;
						}
					}
					if (exportSaveFileDialog.ShowDialog() == DialogResult.OK)
					{
						RunSectionReport();
						if (File.Exists(exportSaveFileDialog.FileName))
						{
							File.Delete(exportSaveFileDialog.FileName);
						}
						((SectionExport)cmbExportFormat.SelectedItem).Export(_sectionReport.Document, exportSaveFileDialog.FileName);
						MessageBox.Show(((SectionExport)cmbExportFormat.SelectedItem).DisplayName + " " + Properties.Resources.ExportCompleteString);
						Hide();
					}
					break;
				case DesignerReportType.Page:
				case DesignerReportType.Rdl:
					exportSaveFileDialog.AddExtension = false;
					exportSaveFileDialog.Filter = ((PageExport)cmbExportFormat.SelectedItem).Filter;
					exportSaveFileDialog.FileName = ((PageExport)cmbExportFormat.SelectedItem).DefaultFileName;
					if (exportPropertyGrid.SelectedObject is Export.Image.Page.Settings)
					{
						Export.Image.Page.Settings _settings = (Export.Image.Page.Settings)exportPropertyGrid.SelectedObject;
						exportSaveFileDialog.FileName = ((PageExport)cmbExportFormat.SelectedItem).DefaultFileName + "." + _settings.ImageType.ToString().ToLower();
					}
					if (exportPropertyGrid.SelectedObject is Export.Word.Page.Settings &&
						((Export.Word.Page.Settings)exportPropertyGrid.SelectedObject).FileFormat ==
							Export.Word.Page.FileFormat.OOXML)
					{
						exportSaveFileDialog.FileName = Properties.Resources.Word2007FileName;
						exportSaveFileDialog.Filter = Properties.Resources.Word2007Filter;
					}
					if (exportPropertyGrid.SelectedObject is ExcelRenderingExtensionSettings &&
						((ExcelRenderingExtensionSettings) exportPropertyGrid.SelectedObject).FileFormat ==
							Export.Excel.Page.FileFormat.Xlsx)
					{
						exportSaveFileDialog.FileName = Properties.Resources.Excel2007FileName;
						exportSaveFileDialog.Filter = Properties.Resources.Excel2007Filter;
					}
					if (exportSaveFileDialog.ShowDialog() == DialogResult.OK)
					{
						if (File.Exists(exportSaveFileDialog.FileName))
						{
							File.Delete(exportSaveFileDialog.FileName);
						}
						PageExport tempQualifier = ((PageExport)cmbExportFormat.SelectedItem);
						string filePath = exportSaveFileDialog.FileName;
						StreamProvider StreamProvider = new FileStreamProvider(new DirectoryInfo(Path.GetDirectoryName(filePath)), Path.GetFileNameWithoutExtension(filePath));
						_reportViewer.Render(tempQualifier.RenderingExtension, StreamProvider, tempQualifier.Settings.GetSettings());
						MessageBox.Show(((PageExport)cmbExportFormat.SelectedItem).DisplayName + " " + Properties.Resources.ExportCompleteString);
						Hide();
					}
					break;
			}
		}
		void RunSectionReport()
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Position = 0;
			using (XmlWriter writer = XmlWriter.Create(memoryStream))
			{
				((SectionReport)_report).SaveLayout(writer);
			}
			memoryStream.Position = 0;
			using (XmlReader reader = XmlReader.Create(memoryStream))
			{
				_sectionReport.LoadLayout(reader);
			}
			_sectionReport.Run();
		}
	}
}
