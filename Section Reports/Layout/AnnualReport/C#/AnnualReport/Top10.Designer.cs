using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.AnnualReport
{
	public partial class Top10
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Top10));
			this.srptTop10Customers = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.srptTop10Products = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
		   
			// 
			// srptTop10Customers
			// 
			this.srptTop10Customers.CloseBorder = false;
			resources.ApplyResources(this.srptTop10Customers, "srptTop10Customers");
			this.srptTop10Customers.Name = "srptTop10Customers";
			this.srptTop10Customers.Report = null;
			// 
			// srptTop10Products
			// 
			this.srptTop10Products.CloseBorder = false;
			resources.ApplyResources(this.srptTop10Products, "srptTop10Products");
			this.srptTop10Products.Name = "srptTop10Products";
			this.srptTop10Products.Report = null;
			// 
			// Detail
			// 
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.srptTop10Customers,
			this.srptTop10Products});
			this.Detail.Height = 2.3125F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// Top10
			// 
			this.MasterReport = false;
			this.PageSettings.Margins.Left = 0.5F;
			this.PageSettings.Margins.Right = 0.5F;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.489583F;
			this.Sections.Add(this.Detail);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
					  "l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal")); 
			this.ReportStart += new System.EventHandler(this.Top10_ReportStart);
		  
		}
		private Detail Detail;
		private SubReport srptTop10Customers;
		private SubReport srptTop10Products;
		#endregion
		
	}
}
