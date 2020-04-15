using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.XML
{
	public partial class OrdersLeveled
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersLeveled));
			GrapeCity.ActiveReports.Data.XMLDataSource xmlDataSource1 = new GrapeCity.ActiveReports.Data.XMLDataSource();
			this.txtISBN = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtTitle = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtPRICE = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblEMail = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtEMail = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblCustomerTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtCustomerTotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtOrderNumber = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtOrderDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblISBN = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lneSep = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lblPrice = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblOrderTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtOrderTotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.ghCustomers = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.gfCustomers = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			this.ghOrders = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.gfOrders = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			// 
			// txtISBN
			// 
			this.txtISBN.DataField = "@isbn";
			resources.ApplyResources(this.txtISBN, "txtISBN");
			this.txtISBN.Name = "txtISBN";
			// 
			// txtTitle
			// 
			this.txtTitle.DataField = "TITLE";
			resources.ApplyResources(this.txtTitle, "txtTitle");
			this.txtTitle.Name = "txtTitle";
			// 
			// txtPRICE
			// 
			this.txtPRICE.DataField = "PRICE";
			resources.ApplyResources(this.txtPRICE, "txtPRICE");
			this.txtPRICE.Name = "txtPRICE";
			// 
			// txtName
			// 
			this.txtName.DataField = "../../NAME";
			resources.ApplyResources(this.txtName, "txtName");
			this.txtName.Name = "txtName";
			// 
			// txtID
			// 
			this.txtID.DataField = "../../@id";
			resources.ApplyResources(this.txtID, "txtID");
			this.txtID.Name = "txtID";
			// 
			// lblID
			// 
			resources.ApplyResources(this.lblID, "lblID");
			this.lblID.Name = "lblID";
			// 
			// lblEMail
			// 
			resources.ApplyResources(this.lblEMail, "lblEMail");
			this.lblEMail.Name = "lblEMail";
			// 
			// txtEMail
			// 
			this.txtEMail.DataField = "../../@email";
			resources.ApplyResources(this.txtEMail, "txtEMail");
			this.txtEMail.Name = "txtEMail";
			// 
			// lblName
			// 
			resources.ApplyResources(this.lblName, "lblName");
			this.lblName.Name = "lblName";
			// 
			// lblCustomerTotal
			// 
			resources.ApplyResources(this.lblCustomerTotal, "lblCustomerTotal");
			this.lblCustomerTotal.Name = "lblCustomerTotal";
			// 
			// txtCustomerTotal
			// 
			this.txtCustomerTotal.DataField = "PRICE";
			resources.ApplyResources(this.txtCustomerTotal, "txtCustomerTotal");
			this.txtCustomerTotal.Name = "txtCustomerTotal";
			this.txtCustomerTotal.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtOrderNumber
			// 
			this.txtOrderNumber.DataField = "../NUMBER";
			resources.ApplyResources(this.txtOrderNumber, "txtOrderNumber");
			this.txtOrderNumber.Name = "txtOrderNumber";
			// 
			// txtOrderDate
			// 
			this.txtOrderDate.DataField = "../DATE";
			resources.ApplyResources(this.txtOrderDate, "txtOrderDate");
			this.txtOrderDate.Name = "txtOrderDate";
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
			this.lneSep.Y1 = 0.4375F;
			this.lneSep.Y2 = 0.4375F;
			// 
			// lblPrice
			// 
			resources.ApplyResources(this.lblPrice, "lblPrice");
			this.lblPrice.Name = "lblPrice";
			// 
			// lblOrderTotal
			// 
			resources.ApplyResources(this.lblOrderTotal, "lblOrderTotal");
			this.lblOrderTotal.Name = "lblOrderTotal";
			// 
			// txtOrderTotal
			// 
			this.txtOrderTotal.DataField = "PRICE";
			resources.ApplyResources(this.txtOrderTotal, "txtOrderTotal");
			this.txtOrderTotal.Name = "txtOrderTotal";
			this.txtOrderTotal.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtISBN,
			this.txtTitle,
			this.txtPRICE});
			this.Detail.Height = 0.1875F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// PageHeader
			// 
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Name = "PageFooter";
			// 
			// ghCustomers
			// 
			this.ghCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ghCustomers.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtName,
			this.txtID,
			this.lblID,
			this.lblEMail,
			this.txtEMail,
			this.lblName});
			this.ghCustomers.DataField = "../../@id";
			this.ghCustomers.Height = 0.3958333F;
			this.ghCustomers.KeepTogether = true;
			this.ghCustomers.Name = "ghCustomers";
			// 
			// gfCustomers
			// 
			this.gfCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.gfCustomers.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblCustomerTotal,
			this.txtCustomerTotal});
			this.gfCustomers.KeepTogether = true;
			this.gfCustomers.Name = "gfCustomers";
			this.gfCustomers.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After;
			// 
			// ghOrders
			// 
			this.ghOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ghOrders.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtOrderNumber,
			this.txtOrderDate,
			this.lblISBN,
			this.lblTitle,
			this.lneSep,
			this.lblPrice});
			this.ghOrders.DataField = "../NUMBER";
			this.ghOrders.Height = 0.4784722F;
			this.ghOrders.KeepTogether = true;
			this.ghOrders.Name = "ghOrders";
			// 
			// gfOrders
			// 
			this.gfOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.gfOrders.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblOrderTotal,
			this.txtOrderTotal});
			this.gfOrders.Height = 0.1875F;
			this.gfOrders.KeepTogether = true;
			this.gfOrders.Name = "gfOrders";
			// 
			// OrdersLeveled
			// 
			this.MasterReport = false;
			xmlDataSource1.FileURL = "C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\customer.xml";
			xmlDataSource1.RecordsetPattern = "//ITEM";
			this.DataSource = xmlDataSource1;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.ghCustomers);
			this.Sections.Add(this.ghOrders);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.gfOrders);
			this.Sections.Add(this.gfCustomers);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
			"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
		}
		#endregion
		public GrapeCity.ActiveReports.Data.XMLDataSource ds;
		private PageHeader PageHeader;
		private GroupHeader ghCustomers;
		private TextBox txtName;
		private TextBox txtID;
		private Label lblID;
		private Label lblEMail;
		private TextBox txtEMail;
		private Label lblName;
		private GroupHeader ghOrders;
		private TextBox txtOrderNumber;
		private TextBox txtOrderDate;
		private Label lblISBN;
		private Label lblTitle;
		private Line lneSep;
		private Label lblPrice;
		private Detail Detail;
		private TextBox txtISBN;
		private TextBox txtTitle;
		private TextBox txtPRICE;
		private GroupFooter gfOrders;
		private Label lblOrderTotal;
		private TextBox txtOrderTotal;
		private GroupFooter gfCustomers;
		private Label lblCustomerTotal;
		private TextBox txtCustomerTotal;
		private PageFooter PageFooter;
		
	}
}
