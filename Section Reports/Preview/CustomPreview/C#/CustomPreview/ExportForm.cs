using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using GrapeCity.ActiveReports.Export.Excel.Section;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	public partial class ExportForm : Form
	{
		readonly Document.SectionDocument _sectionDocument;
		public ExportForm(Document.SectionDocument sectionDocument)
		{
			_sectionDocument = sectionDocument;
			InitializeComponent();
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
			AddSectionReportExportTypes();
		}
		private void cmbExportFormat_SelectedIndexChanged(object sender, EventArgs e)
		{
			exportPropertyGrid.SelectedObject = ((SectionExport)cmbExportFormat.SelectedItem).Settings;
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Hide();
		}
		private void btnOk_Click(object sender, EventArgs e)
		{
			exportSaveFileDialog.Filter = ((SectionExport)cmbExportFormat.SelectedItem).Filter;
			exportSaveFileDialog.FileName = ((SectionExport)cmbExportFormat.SelectedItem).DefaultFileName;
			if (exportPropertyGrid.SelectedObject is XlsExport)
			{
				switch (((XlsExport)exportPropertyGrid.SelectedObject).FileFormat)
				{
					case FileFormat.Xlsx:
						exportSaveFileDialog.FileName = Properties.Resources.Excel2007FileName;
						exportSaveFileDialog.Filter = Properties.Resources.Excel2007Filter;
						break;
				}
			}
			if (exportSaveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (File.Exists(exportSaveFileDialog.FileName))
				{
					File.Delete(exportSaveFileDialog.FileName);
				}
				((SectionExport)cmbExportFormat.SelectedItem).Export(_sectionDocument, exportSaveFileDialog.FileName);
				MessageBox.Show(((SectionExport)cmbExportFormat.SelectedItem).DisplayName + " " + Properties.Resources.ExportCompleteString);
				Hide();
			}
		}
	}
}
