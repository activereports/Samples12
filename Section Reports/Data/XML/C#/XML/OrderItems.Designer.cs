using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.XML
{
	public partial class OrderItems
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderItems));
			this.txtISBN = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtTitle = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtPRICE = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblISBN = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lneSep = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lblPrice = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtOrderTotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.ghOrderItems = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.gfOrderItems = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			
			// 
			// txtISBN
			// 
			resources.ApplyResources(this.txtISBN, "txtISBN");
			this.txtISBN.DataField = "@isbn";
			this.txtISBN.Name = "txtISBN";
			// 
			// txtTitle
			// 
			resources.ApplyResources(this.txtTitle, "txtTitle");
			this.txtTitle.DataField = "TITLE";
			this.txtTitle.Name = "txtTitle";
			// 
			// txtPRICE
			// 
			resources.ApplyResources(this.txtPRICE, "txtPRICE");
			this.txtPRICE.DataField = "PRICE";
			this.txtPRICE.Name = "txtPRICE";
			// 
			// lblISBN
			// 
			resources.ApplyResources(this.lblISBN, "lblISBN");
			this.lblISBN.Name = "lblISBN";
			// 
			// lblTitle
			// 
			resources.ApplyResources(this.lblTitle, "lblTitle");
			this.lblTitle.Name = "lblTitle";
			// 
			// lneSep
			// 
			resources.ApplyResources(this.lneSep, "lneSep");
			this.lneSep.LineWeight = 1F;
			this.lneSep.Name = "lneSep";
			this.lneSep.X1 = 0F;
			this.lneSep.X2 = 6.0625F;
			this.lneSep.Y1 = 0.1875F;
			this.lneSep.Y2 = 0.1875F;
			// 
			// lblPrice
			// 
			resources.ApplyResources(this.lblPrice, "lblPrice");
			this.lblPrice.Name = "lblPrice";
			// 
			// txtOrderTotal
			// 
			resources.ApplyResources(this.txtOrderTotal, "txtOrderTotal");
			this.txtOrderTotal.DataField = "PRICE";
			this.txtOrderTotal.Name = "txtOrderTotal";
			this.txtOrderTotal.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// Detail
			// 
			this.Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtISBN,
			this.txtTitle,
			this.txtPRICE});
			this.Detail.Height = 0.1875F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// ghOrderItems
			// 
			this.ghOrderItems.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblISBN,
			this.lblTitle,
			this.lblPrice,
			this.lneSep});
			this.ghOrderItems.Height = 0.2076389F;
			this.ghOrderItems.KeepTogether = true;
			this.ghOrderItems.Name = "ghOrderItems";
			// 
			// gfOrderItems
			// 
			this.gfOrderItems.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtOrderTotal});
			this.gfOrderItems.Height = 0.1875F;
			this.gfOrderItems.KeepTogether = true;
			this.gfOrderItems.Name = "gfOrderItems";
			// 
			// OrderItems
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.0625F;
			this.Sections.Add(this.ghOrderItems);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.gfOrderItems);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
		}
		#endregion
		private GroupHeader ghOrderItems;
		private Label lblISBN;
		private Label lblTitle;
		private Line lneSep;
		private Label lblPrice;
		private Detail Detail;
		private TextBox txtISBN;
		private TextBox txtTitle;
		private TextBox txtPRICE;
		private GroupFooter gfOrderItems;
		private TextBox txtOrderTotal;
	}
}
