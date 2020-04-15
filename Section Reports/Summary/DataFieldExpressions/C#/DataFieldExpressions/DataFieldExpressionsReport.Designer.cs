using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.DataFieldExpressions
{
	public partial class DataFieldExpressionsReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataFieldExpressionsReport));
			this.txtProductName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtQuantity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtExtendedPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblProductName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblQuantity = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblExtendedPrice = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblNote = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
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
			// txtQuantity
			// 
			this.txtQuantity.DataField = "Quantity";
			resources.ApplyResources(this.txtQuantity, "txtQuantity");
			this.txtQuantity.Name = "txtQuantity";
			// 
			// txtExtendedPrice
			// 
			this.txtExtendedPrice.DataField = "=UnitPrice*Quantity";
			resources.ApplyResources(this.txtExtendedPrice, "txtExtendedPrice");
			this.txtExtendedPrice.Name = "txtExtendedPrice";
			// 
			// lblProductName
			// 
			resources.ApplyResources(this.lblProductName, "lblProductName");
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// lblUnitPrice
			// 
			resources.ApplyResources(this.lblUnitPrice, "lblUnitPrice");
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// lblQuantity
			// 
			resources.ApplyResources(this.lblQuantity, "lblQuantity");
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// lblExtendedPrice
			// 
			resources.ApplyResources(this.lblExtendedPrice, "lblExtendedPrice");
			this.lblExtendedPrice.Name = "lblExtendedPrice";
			this.lblExtendedPrice.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// lblNote
			// 
			resources.ApplyResources(this.lblNote, "lblNote");
			this.lblNote.Name = "lblNote";
			// 
			// Detail
			// 
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProductName,
			this.txtUnitPrice,
			this.txtQuantity,
			this.txtExtendedPrice});
			this.Detail.Height = 0.3222222F;
			this.Detail.Name = "Detail";
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblProductName,
			this.lblUnitPrice,
			this.lblQuantity,
			this.lblExtendedPrice,
			this.lblNote});
			this.PageHeader.Height = 1.134722F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Height = 0.15625F;
			this.PageFooter.Name = "PageFooter";
			// 
			// DataFieldExpressionsReport
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.5F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.FetchData += new GrapeCity.ActiveReports.SectionReport.FetchEventHandler(this.DataFieldExpressions_FetchData);
			this.DataInitialize += new System.EventHandler(this.DataFieldExpressions_DataInitialize);
			this.ReportStart += DataFieldExpressionsReport_ReportStart;
		}
		#endregion
		private PageHeader PageHeader;
		private Label lblProductName;
		private Label lblUnitPrice;
		private Label lblQuantity;
		private Label lblExtendedPrice;
		private Label lblNote;
		private Detail Detail;
		private TextBox txtProductName;
		private TextBox txtUnitPrice;
		private TextBox txtQuantity;
		private TextBox txtExtendedPrice;
		private PageFooter PageFooter;
	}
}
