using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.CategorySelection
{
	public partial class CategoryProducts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryProducts));
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			this.txtProductName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblTotalNumber = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtProductCount = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lneReportFooter = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lblUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProductName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtCategory = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lnePageHeader1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lnePageHeader2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.ReportHeader = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
			this.ReportFooter = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			((System.ComponentModel.ISupportInitialize)(this.txtProductName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUnitPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProductName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// txtProductName
			// 
			this.txtProductName.DataField = "ProductName";
			resources.ApplyResources(this.txtProductName, "txtProductName");
			this.txtProductName.Name = "txtProductName";
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.DataField = "UnitPrice";
			resources.ApplyResources(this.txtUnitPrice, "txtUnitPrice");
			this.txtUnitPrice.Name = "txtUnitPrice";
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
			this.lneReportFooter.X1 = 0F;
			this.lneReportFooter.X2 = 6.4375F;
			this.lneReportFooter.Y1 = 0F;
			this.lneReportFooter.Y2 = 0F;
			// 
			// lblUnitPrice
			// 
			resources.ApplyResources(this.lblUnitPrice, "lblUnitPrice");
			this.lblUnitPrice.Name = "lblUnitPrice";
			// 
			// lblProductName
			// 
			resources.ApplyResources(this.lblProductName, "lblProductName");
			this.lblProductName.Name = "lblProductName";
			// 
			// lblTitle
			// 
			resources.ApplyResources(this.lblTitle, "lblTitle");
			this.lblTitle.Name = "lblTitle";
			// 
			// txtCategory
			// 
			this.txtCategory.DataField = "CategoryName";
			resources.ApplyResources(this.txtCategory, "txtCategory");
			this.txtCategory.Name = "txtCategory";
			// 
			// lnePageHeader1
			// 
			resources.ApplyResources(this.lnePageHeader1, "lnePageHeader1");
			this.lnePageHeader1.LineWeight = 2F;
			this.lnePageHeader1.Name = "lnePageHeader1";
			this.lnePageHeader1.X1 = 0.063F;
			this.lnePageHeader1.X2 = 6.438F;
			this.lnePageHeader1.Y1 = 0.7500001F;
			this.lnePageHeader1.Y2 = 0.7500001F;
			// 
			// lnePageHeader2
			// 
			resources.ApplyResources(this.lnePageHeader2, "lnePageHeader2");
			this.lnePageHeader2.LineWeight = 2F;
			this.lnePageHeader2.Name = "lnePageHeader2";
			this.lnePageHeader2.X1 = 0.062F;
			this.lnePageHeader2.X2 = 6.437F;
			this.lnePageHeader2.Y1 = 0.95F;
			this.lnePageHeader2.Y2 = 0.95F;
			// 
			// reportInfo1
			// 
			this.reportInfo1.FormatString = "{PageNumber} / {PageCount}";
			resources.ApplyResources(this.reportInfo1, "reportInfo1");
			this.reportInfo1.Name = "reportInfo1";
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProductName,
			this.txtUnitPrice});
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
			this.ReportFooter.Height = 0.5194445F;
			this.ReportFooter.KeepTogether = true;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// PageHeader
			// 
			this.PageHeader.CanGrow = false;
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblUnitPrice,
			this.lblProductName,
			this.lblTitle,
			this.txtCategory,
			this.lnePageHeader1,
			this.lnePageHeader2});
			this.PageHeader.Height = 0.95F;
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
			// CategoryProducts
			// 
			this.MasterReport = false;
			oleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\NWIND.MDB";
			oleDBDataSource1.SQL = "";
			this.DataSource = oleDBDataSource1;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.Sections.Add(this.ReportHeader);
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.Sections.Add(this.ReportFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
			"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			((System.ComponentModel.ISupportInitialize)(this.txtProductName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUnitPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProductName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		private ReportInfo reportInfo1;
		private ReportHeader ReportHeader;
		private PageHeader PageHeader;
		private Label lblUnitPrice;
		private Label lblProductName;
		private Label lblTitle;
		private TextBox txtCategory;
		private Line lnePageHeader1;
		private Line lnePageHeader2;
		private Detail Detail;
		private TextBox txtProductName;
		private TextBox txtUnitPrice;
		private PageFooter PageFooter;
		private ReportFooter ReportFooter;
		private Label lblTotalNumber;
		private TextBox txtProductCount;
		private Line lneReportFooter;
	}
}
