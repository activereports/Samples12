using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	public partial class Letter
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Letter));
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			this.txtOrderID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtOrderDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtSubtotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.imgLogo = new GrapeCity.ActiveReports.SectionReportModel.Picture();
			this.lblNorthwind = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTraders = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lneTitle = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lblNWAddress = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtTotalOrders = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblOrderID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblOrderDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblAmount = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.rtbMain = new GrapeCity.ActiveReports.SectionReportModel.RichTextBox();
			this.txtCompanyName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtContactName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtAddress = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtRegion = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCountry = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtPostalCode = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblYours = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblNTAP = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.ghCustomerID = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.gfCustomerID = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSubtotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNorthwind)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTraders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNWAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalOrders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCompanyName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtContactName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRegion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCountry)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPostalCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblYours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNTAP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// txtOrderID
			// 
			this.txtOrderID.DataField = "OrderID";
			resources.ApplyResources(this.txtOrderID, "txtOrderID");
			this.txtOrderID.Name = "txtOrderID";
			// 
			// txtOrderDate
			// 
			this.txtOrderDate.DataField = "OrderDate";
			resources.ApplyResources(this.txtOrderDate, "txtOrderDate");
			this.txtOrderDate.Name = "txtOrderDate";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.DataField = "Subtotal";
			resources.ApplyResources(this.txtSubtotal, "txtSubtotal");
			this.txtSubtotal.Name = "txtSubtotal";
			// 
			// imgLogo
			// 
			this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.imgLogo, "imgLogo");
			this.imgLogo.ImageData = ((System.IO.Stream)(resources.GetObject("imgLogo.ImageData")));
			this.imgLogo.LineColor = System.Drawing.Color.Black;
			this.imgLogo.LineWeight = 1F;
			this.imgLogo.Name = "imgLogo";
			this.imgLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom;
			// 
			// lblNorthwind
			// 
			resources.ApplyResources(this.lblNorthwind, "lblNorthwind");
			this.lblNorthwind.Name = "lblNorthwind";
			// 
			// lblTraders
			// 
			resources.ApplyResources(this.lblTraders, "lblTraders");
			this.lblTraders.Name = "lblTraders";
			// 
			// lneTitle
			// 
			resources.ApplyResources(this.lneTitle, "lneTitle");
			this.lneTitle.LineWeight = 10F;
			this.lneTitle.Name = "lneTitle";
			this.lneTitle.X1 = 5.1F;
			this.lneTitle.X2 = 6.375F;
			this.lneTitle.Y1 = 0.4375F;
			this.lneTitle.Y2 = 0.4375F;
			// 
			// lblNWAddress
			// 
			resources.ApplyResources(this.lblNWAddress, "lblNWAddress");
			this.lblNWAddress.Name = "lblNWAddress";
			// 
			// txtTotalOrders
			// 
			this.txtTotalOrders.DataField = "Subtotal";
			resources.ApplyResources(this.txtTotalOrders, "txtTotalOrders");
			this.txtTotalOrders.Name = "txtTotalOrders";
			this.txtTotalOrders.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			this.txtTotalOrders.Visible = false;
			// 
			// lblOrderID
			// 
			resources.ApplyResources(this.lblOrderID, "lblOrderID");
			this.lblOrderID.Name = "lblOrderID";
			// 
			// lblOrderDate
			// 
			resources.ApplyResources(this.lblOrderDate, "lblOrderDate");
			this.lblOrderDate.Name = "lblOrderDate";
			// 
			// lblAmount
			// 
			resources.ApplyResources(this.lblAmount, "lblAmount");
			this.lblAmount.Name = "lblAmount";
			// 
			// rtbMain
			// 
			this.rtbMain.AutoReplaceFields = true;
			this.rtbMain.Font = new System.Drawing.Font("Arial", 10F);
			resources.ApplyResources(this.rtbMain, "rtbMain");
			this.rtbMain.Name = "rtbMain";
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.CanGrow = false;
			this.txtCompanyName.DataField = "CompanyName";
			resources.ApplyResources(this.txtCompanyName, "txtCompanyName");
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.Visible = false;
			// 
			// txtContactName
			// 
			this.txtContactName.CanGrow = false;
			this.txtContactName.DataField = "ContactName";
			resources.ApplyResources(this.txtContactName, "txtContactName");
			this.txtContactName.Name = "txtContactName";
			this.txtContactName.Visible = false;
			// 
			// txtAddress
			// 
			this.txtAddress.CanGrow = false;
			this.txtAddress.DataField = "Address";
			resources.ApplyResources(this.txtAddress, "txtAddress");
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Visible = false;
			// 
			// txtCity
			// 
			this.txtCity.CanGrow = false;
			this.txtCity.DataField = "City";
			resources.ApplyResources(this.txtCity, "txtCity");
			this.txtCity.Name = "txtCity";
			this.txtCity.Visible = false;
			// 
			// txtRegion
			// 
			this.txtRegion.CanGrow = false;
			this.txtRegion.DataField = "Region";
			resources.ApplyResources(this.txtRegion, "txtRegion");
			this.txtRegion.Name = "txtRegion";
			this.txtRegion.Visible = false;
			// 
			// txtCountry
			// 
			this.txtCountry.CanGrow = false;
			this.txtCountry.DataField = "Country";
			resources.ApplyResources(this.txtCountry, "txtCountry");
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Visible = false;
			// 
			// txtPostalCode
			// 
			this.txtPostalCode.CanGrow = false;
			this.txtPostalCode.DataField = "PostalCode";
			resources.ApplyResources(this.txtPostalCode, "txtPostalCode");
			this.txtPostalCode.Name = "txtPostalCode";
			this.txtPostalCode.Visible = false;
			// 
			// lblYours
			// 
			resources.ApplyResources(this.lblYours, "lblYours");
			this.lblYours.Name = "lblYours";
			// 
			// lblNTAP
			// 
			resources.ApplyResources(this.lblNTAP, "lblNTAP");
			this.lblNTAP.Name = "lblNTAP";
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtOrderID,
			this.txtOrderDate,
			this.txtSubtotal});
			this.Detail.Height = 0.1979167F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// PageHeader
			// 
			this.PageHeader.CanGrow = false;
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.imgLogo,
			this.lblNorthwind,
			this.lblTraders,
			this.lneTitle});
			this.PageHeader.Height = 0.9375F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.CanGrow = false;
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblNWAddress});
			this.PageFooter.Name = "PageFooter";
			// 
			// ghCustomerID
			// 
			this.ghCustomerID.CanShrink = true;
			this.ghCustomerID.ColumnLayout = false;
			this.ghCustomerID.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtTotalOrders,
			this.lblOrderID,
			this.lblOrderDate,
			this.lblAmount,
			this.rtbMain,
			this.txtCompanyName,
			this.txtContactName,
			this.txtAddress,
			this.txtCity,
			this.txtRegion,
			this.txtCountry,
			this.txtPostalCode});
			this.ghCustomerID.DataField = "CustomerID";
			this.ghCustomerID.Height = 2.510417F;
			this.ghCustomerID.KeepTogether = true;
			this.ghCustomerID.Name = "ghCustomerID";
			this.ghCustomerID.Format += new System.EventHandler(this.ghCustomerID_Format);
			this.ghCustomerID.BeforePrint += new System.EventHandler(this.ghCustomerID_BeforePrint);
			// 
			// gfCustomerID
			// 
			this.gfCustomerID.ColumnLayout = false;
			this.gfCustomerID.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblYours,
			this.lblNTAP});
			this.gfCustomerID.Height = 0.7381945F;
			this.gfCustomerID.KeepTogether = true;
			this.gfCustomerID.Name = "gfCustomerID";
			this.gfCustomerID.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After;
			// 
			// Letter
			// 
			this.MasterReport = false;
			oleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\Nwind.mdb;Persist Security Info=False";
			oleDBDataSource1.SQL = resources.GetString("oleDBDataSource1.SQL");
			this.DataSource = oleDBDataSource1;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.5F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.ghCustomerID);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.gfCustomerID);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
			"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			((System.ComponentModel.ISupportInitialize)(this.txtOrderID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSubtotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNorthwind)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTraders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNWAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalOrders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCompanyName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtContactName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRegion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCountry)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPostalCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblYours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNTAP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		public GrapeCity.ActiveReports.Data.OleDBDataSource ds = null;
		private PageHeader PageHeader;
		private Picture imgLogo;
		private Label lblNorthwind;
		private Label lblTraders;
		private Line lneTitle;
		private GroupHeader ghCustomerID;
		private TextBox txtTotalOrders;
		private Label lblOrderID;
		private Label lblOrderDate;
		private Label lblAmount;
		private RichTextBox rtbMain;
		private TextBox txtCompanyName;
		private TextBox txtContactName;
		private TextBox txtAddress;
		private TextBox txtCity;
		private TextBox txtRegion;
		private TextBox txtCountry;
		private TextBox txtPostalCode;
		private Detail Detail;
		private TextBox txtOrderID;
		private TextBox txtOrderDate;
		private TextBox txtSubtotal;
		private GroupFooter gfCustomerID;
		private Label lblYours;
		private Label lblNTAP;
		private PageFooter PageFooter;
		private Label lblNWAddress;
	}
}
