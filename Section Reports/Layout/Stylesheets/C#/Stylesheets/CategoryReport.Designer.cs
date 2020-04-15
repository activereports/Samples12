using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.StyleSheets
{
	public partial class CategoryReport
	{
  protected override void Dispose(bool disposing)
	{
	if (disposing)
	  {
	  }
	base.Dispose(disposing);
	}
	  
		#region ActiveReports Designer generated code
	   
	   
		
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryReport));
			this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProductName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lnePageHeader1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lnePageHeader2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.txtAvgUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCategory = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
			this.lblTotalNumber = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtProductCount = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lneReportFooter = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.ReportHeader = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
			this.ReportFooter = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this.label1.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
			// 
			// lblUnitPrice
			// 
			resources.ApplyResources(this.lblUnitPrice, "lblUnitPrice");
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
			// 
			// lblProductName
			// 
			resources.ApplyResources(this.lblProductName, "lblProductName");
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// lblTitle
			// 
			resources.ApplyResources(this.lblTitle, "lblTitle");
			this.lblTitle.Name = "lblTitle";
			// 
			// lnePageHeader1
			// 
			resources.ApplyResources(this.lnePageHeader1, "lnePageHeader1");
			this.lnePageHeader1.LineWeight = 2F;
			this.lnePageHeader1.Name = "lnePageHeader1";
			this.lnePageHeader1.X1 = 0F;
			this.lnePageHeader1.X2 = 6.583465F;
			this.lnePageHeader1.Y1 = 1F;
			this.lnePageHeader1.Y2 = 1F;
			// 
			// lnePageHeader2
			// 
			resources.ApplyResources(this.lnePageHeader2, "lnePageHeader2");
			this.lnePageHeader2.LineWeight = 2F;
			this.lnePageHeader2.Name = "lnePageHeader2";
			this.lnePageHeader2.X1 = 0F;
			this.lnePageHeader2.X2 = 6.583465F;
			this.lnePageHeader2.Y1 = 1.2F;
			this.lnePageHeader2.Y2 = 1.2F;
			// 
			// txtAvgUnitPrice
			// 
			this.txtAvgUnitPrice.CanShrink = true;
			resources.ApplyResources(this.txtAvgUnitPrice, "txtAvgUnitPrice");
			this.txtAvgUnitPrice.DataField = "AvgUnitPrice";
			this.txtAvgUnitPrice.Name = "txtAvgUnitPrice";
			this.txtAvgUnitPrice.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 4, 0);
			// 
			// txtCategory
			// 
			this.txtCategory.CanShrink = true;
			resources.ApplyResources(this.txtCategory, "txtCategory");
			this.txtCategory.DataField = "CategoryName";
			this.txtCategory.Name = "txtCategory";
			// 
			// textBox1
			// 
			this.textBox1.CanShrink = true;
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.DataField = "ProductCount";
			this.textBox1.Name = "textBox1";
			this.textBox1.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 4, 0);
			// 
			// reportInfo1
			// 
			this.reportInfo1.FormatString = "{PageNumber} / {PageCount}";
			resources.ApplyResources(this.reportInfo1, "reportInfo1");
			this.reportInfo1.Name = "reportInfo1";
			// 
			// lblTotalNumber
			// 
			resources.ApplyResources(this.lblTotalNumber, "lblTotalNumber");
			this.lblTotalNumber.Name = "lblTotalNumber";
			// 
			// txtProductCount
			// 
			resources.ApplyResources(this.txtProductCount, "txtProductCount");
			this.txtProductCount.DataField = "CategoryID";
			this.txtProductCount.Name = "txtProductCount";
			this.txtProductCount.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Count;
			this.txtProductCount.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal;
			// 
			// lneReportFooter
			// 
			resources.ApplyResources(this.lneReportFooter, "lneReportFooter");
			this.lneReportFooter.LineWeight = 2F;
			this.lneReportFooter.Name = "lneReportFooter";
			this.lneReportFooter.X1 = 0F;
			this.lneReportFooter.X2 = 6.635433F;
			this.lneReportFooter.Y1 = 0F;
			this.lneReportFooter.Y2 = 0F;
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtAvgUnitPrice,
			this.txtCategory,
			this.textBox1});
			this.Detail.Height = 0.2F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// ReportHeader
			// 
			this.ReportHeader.Height = 0F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// ReportFooter
			// 
			this.ReportFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblTotalNumber,
			this.txtProductCount,
			this.lneReportFooter});
			this.ReportFooter.Height = 0.9256945F;
			this.ReportFooter.KeepTogether = true;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// PageHeader
			// 
			this.PageHeader.CanGrow = false;
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.label1,
			this.lblUnitPrice,
			this.lblProductName,
			this.lblTitle,
			this.lnePageHeader1,
			this.lnePageHeader2});
			this.PageHeader.Height = 1.2F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.CanGrow = false;
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.reportInfo1});
			this.PageFooter.Height = 0.2F;
			this.PageFooter.Name = "PageFooter";
			// 
			// CategoryReport
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Right = 0.5F;
			this.PageSettings.PaperHeight = 11.69028F;
			this.PageSettings.PaperWidth = 8.270139F;
			this.PrintWidth = 6.583465F;
			this.Sections.Add(this.ReportHeader);
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.Sections.Add(this.ReportFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 204", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
			"lic; ddo-char-set: 204", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-weight: bold; ddo-char-set: 204; font-size: 10pt", "Heading3", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; color: Black; ddo-char-set: 204; font-size: 8pt", "DetailRecord", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; color: Black; background-color: LightSteelBlue; ddo-char-set: 204; font-size:" +
			" 22pt", "ReportTitle", "Normal"));
	 
		}
		private Detail Detail;
		private TextBox txtAvgUnitPrice;
		private TextBox txtCategory;
		private TextBox textBox1;
		private ReportHeader ReportHeader;
		private ReportFooter ReportFooter;
		private Label lblTotalNumber;
		private TextBox txtProductCount;
		private Line lneReportFooter;
		private PageHeader PageHeader;
		private Label label1;
		private Label lblUnitPrice;
		private Label lblProductName;
		private Label lblTitle;
		private Line lnePageHeader1;
		private Line lnePageHeader2;
		private PageFooter PageFooter;
		private ReportInfo reportInfo1;
		#endregion
		
	}
}
