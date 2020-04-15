using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.AnnualReport
{
	public partial class ProductSalesByCategory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSalesByCategory));
			this.txtCategory = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Category = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblSales = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.GroupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
		   
			// 
			// txtCategory
			// 
			this.txtCategory.CanGrow = false;
			resources.ApplyResources(this.txtCategory, "txtCategory");
			this.txtCategory.DataField = "CategoryName";
			this.txtCategory.Name = "txtCategory";
			// 
			// txtSales
			// 
			this.txtSales.CanGrow = false;
			resources.ApplyResources(this.txtSales, "txtSales");
			this.txtSales.DataField = "ProductSales";
			this.txtSales.Name = "txtSales";
			// 
			// Category
			// 
			resources.ApplyResources(this.Category, "Category");
			this.Category.Name = "Category";
			// 
			// lblSales
			// 
			resources.ApplyResources(this.lblSales, "lblSales");
			this.lblSales.Name = "lblSales";
			// 
			// Detail
			// 
			this.Detail.CanGrow = false;
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtCategory,
			this.txtSales});
			this.Detail.Height = 0.1875F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.GroupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.Category,
			this.lblSales});
			this.GroupHeader1.Height = 0.1875F;
			this.GroupHeader1.Name = "GroupHeader1";
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Height = 0F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// ProductSalesByCategory
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 2.677083F;
			this.Sections.Add(this.GroupHeader1);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.ReportStart += new System.EventHandler(this.ProductSalesByCategory_ReportStart);
			this.DataInitialize += new System.EventHandler(this.ProductSalesByCategory_DataInitialize);
	   
		}
		private GroupHeader GroupHeader1;
		private Label Category;
		private Label lblSales;
		private Detail Detail;
		private TextBox txtCategory;
		private TextBox txtSales;
		private GroupFooter GroupFooter1;
		#endregion
		
	}
}
