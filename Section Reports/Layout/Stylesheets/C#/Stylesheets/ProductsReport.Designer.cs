using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.StyleSheets
{
	public partial class ProductsReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsReport));
			this.lblTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
			this.lblTotalNumber = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtProductCount = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lneReportFooter = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.txtProductName1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtUnitPrice1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.ReportHeader = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
			this.ReportFooter = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.groupHeaderCategory = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.groupFooterCategory = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
		   
			// 
			// lblTitle
			// 
			resources.ApplyResources(this.lblTitle, "lblTitle");
			this.lblTitle.Name = "lblTitle";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// textBox1
			// 
			this.textBox1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.DataField = "CategoryName";
			this.textBox1.Name = "textBox1";
			// 
			// textBox2
			// 
			resources.ApplyResources(this.textBox2, "textBox2");
			this.textBox2.DataField = "ProductName";
			this.textBox2.Name = "textBox2";
			this.textBox2.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Count;
			this.textBox2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// line2
			// 
			resources.ApplyResources(this.line2, "line2");
			this.line2.LineWeight = 2F;
			this.line2.Name = "line2";
			this.line2.X1 = 0F;
			this.line2.X2 = 6.5F;
			this.line2.Y1 = 0F;
			this.line2.Y2 = 0F;
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
			this.txtProductCount.DataField = "ProductName";
			resources.ApplyResources(this.txtProductCount, "txtProductCount");
			this.txtProductCount.Name = "txtProductCount";
			this.txtProductCount.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Count;
			this.txtProductCount.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal;
			// 
			// lneReportFooter
			// 
			resources.ApplyResources(this.lneReportFooter, "lneReportFooter");
			this.lneReportFooter.LineWeight = 2F;
			this.lneReportFooter.Name = "lneReportFooter";
			this.lneReportFooter.X1 = 0.01023622F;
			this.lneReportFooter.X2 = 6.4375F;
			this.lneReportFooter.Y1 = 0F;
			this.lneReportFooter.Y2 = 0F;
			// 
			// line1
			// 
			resources.ApplyResources(this.line1, "line1");
			this.line1.LineWeight = 1F;
			this.line1.Name = "line1";
			this.line1.X1 = 0.021F;
			this.line1.X2 = 6.48975F;
			this.line1.Y1 = 0.471F;
			this.line1.Y2 = 0.471F;
			// 
			// txtProductName1
			// 
			this.txtProductName1.CanShrink = true;
			resources.ApplyResources(this.txtProductName1, "txtProductName1");
			this.txtProductName1.DataField = "ProductName";
			this.txtProductName1.Name = "txtProductName1";
			// 
			// txtUnitPrice1
			// 
			this.txtUnitPrice1.CanShrink = true;
			resources.ApplyResources(this.txtUnitPrice1, "txtUnitPrice1");
			this.txtUnitPrice1.DataField = "UnitPrice";
			this.txtUnitPrice1.Name = "txtUnitPrice1";
			// 
			// Detail
			// 
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProductName1,
			this.txtUnitPrice1});
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
			this.lblTitle});
			this.PageHeader.Height = 0.6668636F;
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
			// groupHeaderCategory
			// 
			this.groupHeaderCategory.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.label2,
			this.label1,
			this.textBox1,
			this.line1});
			this.groupHeaderCategory.DataField = "CategoryID";
			this.groupHeaderCategory.Height = 0.4779445F;
			this.groupHeaderCategory.Name = "groupHeaderCategory";
			// 
			// groupFooterCategory
			// 
			this.groupFooterCategory.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.textBox2,
			this.label3,
			this.line2});
			this.groupFooterCategory.Height = 0.3229167F;
			this.groupFooterCategory.Name = "groupFooterCategory";
			// 
			// ProductsReport
			// 
			this.MasterReport = false;
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Right = 0.5F;
			this.PageSettings.PaperHeight = 11.69028F;
			this.PageSettings.PaperWidth = 8.270139F;
			this.PrintWidth = 6.5F;
			this.Sections.Add(this.ReportHeader);
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.groupHeaderCategory);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.groupFooterCategory);
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
		#endregion
		private Detail Detail;
		private ReportHeader ReportHeader;
		private ReportFooter ReportFooter;
		private Label lblTotalNumber;
		private TextBox txtProductCount;
		private Line lneReportFooter;
		private PageHeader PageHeader;
		private Label lblTitle;
		private PageFooter PageFooter;
		private ReportInfo reportInfo1;
		private GroupHeader groupHeaderCategory;
		private Label label2;
		private Label label1;
		private TextBox textBox1;
		private GroupFooter groupFooterCategory;
		private TextBox textBox2;
		private Label label3;
		private TextBox txtProductName1;
		private TextBox txtUnitPrice1;
		private Line line1;
		private Line line2;
	
	}
}
