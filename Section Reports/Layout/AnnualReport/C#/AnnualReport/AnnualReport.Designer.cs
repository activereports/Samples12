using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.AnnualReport
{
	public partial class AnnualReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnualReport));
			this.srptTop10 = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.lblTop10Products = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTop10Customers = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblNorthWind = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTraders = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblAnnualReport = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.PageBreak1 = new GrapeCity.ActiveReports.SectionReportModel.PageBreak();
			this.shpYellowBackground = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.lblMessage1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblMessageHdr1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblMessage2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblMessage3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblAnnualReportTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblARYears = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblMessageHdr2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblMessageHdr3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblMessage4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.imgCompanyLogo = new GrapeCity.ActiveReports.SectionReportModel.Picture();
			this.srptProductSales = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.ReportHeader = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
			this.ReportFooter = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
		
			// 
			// srptTop10
			// 
			this.srptTop10.CloseBorder = false;
			resources.ApplyResources(this.srptTop10, "srptTop10");
			this.srptTop10.Name = "srptTop10";
			this.srptTop10.Report = null;
			// 
			// lblTop10Products
			// 
			resources.ApplyResources(this.lblTop10Products, "lblTop10Products");
			this.lblTop10Products.Name = "lblTop10Products";
			// 
			// lblTop10Customers
			// 
			resources.ApplyResources(this.lblTop10Customers, "lblTop10Customers");
			this.lblTop10Customers.Name = "lblTop10Customers";
			// 
			// lblNorthWind
			// 
			resources.ApplyResources(this.lblNorthWind, "lblNorthWind");
			this.lblNorthWind.Name = "lblNorthWind";
			// 
			// lblTraders
			// 
			resources.ApplyResources(this.lblTraders, "lblTraders");
			this.lblTraders.Name = "lblTraders";
			// 
			// lblAnnualReport
			// 
			resources.ApplyResources(this.lblAnnualReport, "lblAnnualReport");
			this.lblAnnualReport.Name = "lblAnnualReport";
			// 
			// PageBreak1
			// 
			resources.ApplyResources(this.PageBreak1, "PageBreak1");
			this.PageBreak1.Name = "PageBreak1";
			this.PageBreak1.Size = new System.Drawing.SizeF(6.5F, 0.05555556F);
			// 
			// shpYellowBackground
			// 
			this.shpYellowBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.shpYellowBackground, "shpYellowBackground");
			this.shpYellowBackground.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Transparent;
			this.shpYellowBackground.Name = "shpYellowBackground";
			this.shpYellowBackground.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, null, null, null, null);
			// 
			// lblMessage1
			// 
			resources.ApplyResources(this.lblMessage1, "lblMessage1");
			this.lblMessage1.Name = "lblMessage1";
			// 
			// lblMessageHdr1
			// 
			resources.ApplyResources(this.lblMessageHdr1, "lblMessageHdr1");
			this.lblMessageHdr1.Name = "lblMessageHdr1";
			// 
			// lblMessage2
			// 
			resources.ApplyResources(this.lblMessage2, "lblMessage2");
			this.lblMessage2.Name = "lblMessage2";
			// 
			// lblMessage3
			// 
			resources.ApplyResources(this.lblMessage3, "lblMessage3");
			this.lblMessage3.Name = "lblMessage3";
			// 
			// lblAnnualReportTitle
			// 
			resources.ApplyResources(this.lblAnnualReportTitle, "lblAnnualReportTitle");
			this.lblAnnualReportTitle.Name = "lblAnnualReportTitle";
			// 
			// lblARYears
			// 
			resources.ApplyResources(this.lblARYears, "lblARYears");
			this.lblARYears.Name = "lblARYears";
			// 
			// lblMessageHdr2
			// 
			resources.ApplyResources(this.lblMessageHdr2, "lblMessageHdr2");
			this.lblMessageHdr2.Name = "lblMessageHdr2";
			// 
			// lblMessageHdr3
			// 
			resources.ApplyResources(this.lblMessageHdr3, "lblMessageHdr3");
			this.lblMessageHdr3.Name = "lblMessageHdr3";
			// 
			// lblMessage4
			// 
			resources.ApplyResources(this.lblMessage4, "lblMessage4");
			this.lblMessage4.Name = "lblMessage4";
			// 
			// imgCompanyLogo
			// 
			this.imgCompanyLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.imgCompanyLogo, "imgCompanyLogo");
			this.imgCompanyLogo.ImageData = ((System.IO.Stream)(resources.GetObject("imgCompanyLogo.ImageData")));
			this.imgCompanyLogo.LineColor = System.Drawing.Color.Black;
			this.imgCompanyLogo.Name = "imgCompanyLogo";
			// 
			// srptProductSales
			// 
			this.srptProductSales.CloseBorder = false;
			resources.ApplyResources(this.srptProductSales, "srptProductSales");
			this.srptProductSales.Name = "srptProductSales";
			this.srptProductSales.Report = null;
			// 
			// Detail
			// 
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.srptTop10,
			this.lblTop10Products,
			this.lblTop10Customers});
			this.Detail.Height = 2.375F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// ReportHeader
			// 
			this.ReportHeader.CanGrow = false;
			this.ReportHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblNorthWind,
			this.lblTraders,
			this.lblAnnualReport,
			this.PageBreak1,
			this.shpYellowBackground,
			this.lblMessage1,
			this.lblMessageHdr1,
			this.lblMessage2,
			this.lblMessage3,
			this.lblAnnualReportTitle,
			this.lblARYears,
			this.lblMessageHdr2,
			this.lblMessageHdr3,
			this.lblMessage4,
			this.imgCompanyLogo,
			this.srptProductSales});
			this.ReportHeader.Height = 15.25F;
			this.ReportHeader.Name = "ReportHeader";
			this.ReportHeader.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After;
			// 
			// ReportFooter
			// 
			this.ReportFooter.CanGrow = false;
			this.ReportFooter.Height = 0F;
			this.ReportFooter.KeepTogether = true;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// PageHeader
			// 
			this.PageHeader.CanGrow = false;
			this.PageHeader.Height = 0F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.CanGrow = false;
			this.PageFooter.Height = 0F;
			this.PageFooter.Name = "PageFooter";
			// 
			// AnnualReport
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.5F;
			this.Sections.Add(this.ReportHeader);
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.Sections.Add(this.ReportFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.ReportStart += new System.EventHandler(this.AnnualReport_ReportStart);
	   
		}
		private ReportHeader ReportHeader;
		private Label lblNorthWind;
		private Label lblTraders;
		private Label lblAnnualReport;
		private PageBreak PageBreak1;
		private Shape shpYellowBackground;
		private Label lblMessage1;
		private Label lblMessageHdr1;
		private Label lblMessage2;
		private Label lblMessage3;
		private Label lblAnnualReportTitle;
		private Label lblARYears;
		private Label lblMessageHdr2;
		private Label lblMessageHdr3;
		private Label lblMessage4;
		private Picture imgCompanyLogo;
		private SubReport srptProductSales;
		private PageHeader PageHeader;
		private Detail Detail;
		private SubReport srptTop10;
		private Label lblTop10Products;
		private Label lblTop10Customers;
		private PageFooter PageFooter;
		private ReportFooter ReportFooter;
		#endregion
	}
}
