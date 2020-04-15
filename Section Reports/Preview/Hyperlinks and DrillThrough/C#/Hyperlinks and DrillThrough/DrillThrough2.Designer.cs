using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.HyperlinksAndDrillThrough
{
	public partial class DrillThrough2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrillThrough2));
			this.txtOrderID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtProductID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtQuantity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtDiscount = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblOrderID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProductID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblQuantity = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDiscount = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.cscBorder = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.groupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.groupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			// 
			// txtOrderID
			// 
			this.txtOrderID.DataField = "OrderID";
			resources.ApplyResources(this.txtOrderID, "txtOrderID");
			this.txtOrderID.Name = "txtOrderID";
			this.txtOrderID.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
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
			// lblOrderID
			// 
			resources.ApplyResources(this.lblOrderID, "lblOrderID");
			this.lblOrderID.Name = "lblOrderID";
			this.lblOrderID.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
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
			// cscBorder
			// 
			this.cscBorder.BackColor = System.Drawing.Color.Gainsboro;
			this.cscBorder.Bottom = 0F;
			resources.ApplyResources(this.cscBorder, "cscBorder");
			this.cscBorder.LineColor = System.Drawing.Color.Purple;
			this.cscBorder.LineWeight = 3F;
			this.cscBorder.Name = "cscBorder";
			this.cscBorder.Right = 6.5F;
			// 
			// Detail
			// 
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtOrderID,
			this.txtProductID,
			this.txtUnitPrice,
			this.txtQuantity,
			this.txtDiscount});
			this.Detail.Height = 0.2F;
			this.Detail.Name = "Detail";
			// 
			// groupHeader1
			// 
			this.groupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblOrderID,
			this.lblProductID,
			this.lblUnitPrice,
			this.lblQuantity,
			this.lblDiscount,
			this.cscBorder});
			this.groupHeader1.Height = 0.25F;
			this.groupHeader1.Name = "groupHeader1";
			this.groupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage;
			// 
			// groupFooter1
			// 
			this.groupFooter1.Height = 0.2F;
			this.groupFooter1.Name = "groupFooter1";
			// 
			// DrillThrough2
			// 
			this.MasterReport = false;
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.5F;
			this.Sections.Add(this.groupHeader1);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.groupFooter1);
			this.ShowParameterUI = false;
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
		}
		#endregion
		private GroupHeader groupHeader1;
		private GroupFooter groupFooter1;
		private CrossSectionBox cscBorder;
		public GrapeCity.ActiveReports.Data.OleDBDataSource ds;
		private Label lblOrderID;
		private Label lblProductID;
		private Label lblUnitPrice;
		private Label lblQuantity;
		private Label lblDiscount;
		private Detail Detail;
		private TextBox txtOrderID;
		private TextBox txtProductID;
		private TextBox txtUnitPrice;
		private TextBox txtQuantity;
		private TextBox txtDiscount;
	   
		
	}
}
