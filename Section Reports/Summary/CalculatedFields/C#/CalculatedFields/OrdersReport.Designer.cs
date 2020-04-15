using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.CalculatedFields
{
	public partial class OrdersReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersReport));
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			this.txtProductID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtQuantity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtDiscount = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtExtendedPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblMaxPagesSet = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblProductID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblQuantity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblDiscount = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblExtendedPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblTotalExtendedPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtTotalExtendedPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.ghOrderID = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.gfOrderID = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			((System.ComponentModel.ISupportInitialize)(this.txtProductID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExtendedPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMaxPagesSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProductID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUnitPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDiscount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblExtendedPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalExtendedPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalExtendedPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// txtProductID
			// 
			this.txtProductID.DataField = "ProductID";
			resources.ApplyResources(this.txtProductID, "txtProductID");
			this.txtProductID.Name = "txtProductID";
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
			// txtDiscount
			// 
			this.txtDiscount.DataField = "Discount";
			resources.ApplyResources(this.txtDiscount, "txtDiscount");
			this.txtDiscount.Name = "txtDiscount";
			// 
			// txtExtendedPrice
			// 
			this.txtExtendedPrice.DataField = "ExtendedPrice";
			resources.ApplyResources(this.txtExtendedPrice, "txtExtendedPrice");
			this.txtExtendedPrice.Name = "txtExtendedPrice";
			// 
			// lblMaxPagesSet
			// 
			resources.ApplyResources(this.lblMaxPagesSet, "lblMaxPagesSet");
			this.lblMaxPagesSet.Name = "lblMaxPagesSet";
			// 
			// TextBox1
			// 
			this.TextBox1.DataField = "OrderID";
			resources.ApplyResources(this.TextBox1, "TextBox1");
			this.TextBox1.Name = "TextBox1";
			// 
			// TextBox6
			// 
			resources.ApplyResources(this.TextBox6, "TextBox6");
			this.TextBox6.Name = "TextBox6";
			this.TextBox6.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// lblProductID
			// 
			resources.ApplyResources(this.lblProductID, "lblProductID");
			this.lblProductID.Name = "lblProductID";
			// 
			// lblUnitPrice
			// 
			resources.ApplyResources(this.lblUnitPrice, "lblUnitPrice");
			this.lblUnitPrice.Name = "lblUnitPrice";
			// 
			// lblQuantity
			// 
			resources.ApplyResources(this.lblQuantity, "lblQuantity");
			this.lblQuantity.Name = "lblQuantity";
			// 
			// lblDiscount
			// 
			resources.ApplyResources(this.lblDiscount, "lblDiscount");
			this.lblDiscount.Name = "lblDiscount";
			// 
			// lblExtendedPrice
			// 
			resources.ApplyResources(this.lblExtendedPrice, "lblExtendedPrice");
			this.lblExtendedPrice.Name = "lblExtendedPrice";
			// 
			// lblTotalExtendedPrice
			// 
			resources.ApplyResources(this.lblTotalExtendedPrice, "lblTotalExtendedPrice");
			this.lblTotalExtendedPrice.Name = "lblTotalExtendedPrice";
			this.lblTotalExtendedPrice.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// txtTotalExtendedPrice
			// 
			this.txtTotalExtendedPrice.DataField = "ExtendedPrice";
			resources.ApplyResources(this.txtTotalExtendedPrice, "txtTotalExtendedPrice");
			this.txtTotalExtendedPrice.Name = "txtTotalExtendedPrice";
			this.txtTotalExtendedPrice.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group;
			this.txtTotalExtendedPrice.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// Detail
			// 
			this.Detail.CanShrink = true;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProductID,
			this.txtUnitPrice,
			this.txtQuantity,
			this.txtDiscount,
			this.txtExtendedPrice});
			this.Detail.Height = 0.34375F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// PageHeader
			// 
			this.PageHeader.Height = 0F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblMaxPagesSet});
			this.PageFooter.Height = 0.5729167F;
			this.PageFooter.Name = "PageFooter";
			// 
			// ghOrderID
			// 
			this.ghOrderID.CanShrink = true;
			this.ghOrderID.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.TextBox1,
			this.TextBox6,
			this.lblProductID,
			this.lblUnitPrice,
			this.lblQuantity,
			this.lblDiscount,
			this.lblExtendedPrice});
			this.ghOrderID.DataField = "OrderID";
			this.ghOrderID.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.FirstDetail;
			this.ghOrderID.Height = 0.6354167F;
			this.ghOrderID.Name = "ghOrderID";
			// 
			// gfOrderID
			// 
			this.gfOrderID.CanShrink = true;
			this.gfOrderID.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblTotalExtendedPrice,
			this.txtTotalExtendedPrice});
			this.gfOrderID.Height = 0.3222222F;
			this.gfOrderID.Name = "gfOrderID";
			// 
			// OrdersReport
			// 
			this.MasterReport = false;
			oleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\NWIND.MDB;Persist Security Info=False";
			oleDBDataSource1.SQL = "SELECT * FROM [Order Details] ORDER BY OrderID";
			this.DataSource = oleDBDataSource1;
			this.MaxPages = ((long)(10));
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.5F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.ghOrderID);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.gfOrderID);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
			"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			this.FetchData += new GrapeCity.ActiveReports.SectionReport.FetchEventHandler(this.OrdersReport_FetchData);
			this.DataInitialize += new System.EventHandler(this.OrdersReport_DataInitialize);
			((System.ComponentModel.ISupportInitialize)(this.txtProductID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExtendedPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblMaxPagesSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProductID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUnitPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDiscount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblExtendedPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalExtendedPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalExtendedPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		public GrapeCity.ActiveReports.Data.OleDBDataSource ds;
		private PageHeader PageHeader;
		private GroupHeader ghOrderID;
		private TextBox TextBox1;
		private TextBox TextBox6;
		private TextBox lblProductID;
		private TextBox lblUnitPrice;
		private TextBox lblQuantity;
		private TextBox lblDiscount;
		private TextBox lblExtendedPrice;
		private Detail Detail;
		private TextBox txtProductID;
		private TextBox txtUnitPrice;
		private TextBox txtQuantity;
		private TextBox txtDiscount;
		private TextBox txtExtendedPrice;
		private GroupFooter gfOrderID;
		private TextBox lblTotalExtendedPrice;
		private TextBox txtTotalExtendedPrice;
		private PageFooter PageFooter;
		private Label lblMaxPagesSet;
		
		
	}
}
