using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.XML
{
	public partial class CustomersOrders
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersOrders));
			GrapeCity.ActiveReports.Data.XMLDataSource xmlDataSource1 = new GrapeCity.ActiveReports.Data.XMLDataSource();
			this.txtName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblEMail = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtEMail = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.srptOrders = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.lblOrders = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			// 
			// txtName
			// 
			this.txtName.DataField = "NAME";
			resources.ApplyResources(this.txtName, "txtName");
			this.txtName.Name = "txtName";
			// 
			// txtID
			// 
			this.txtID.DataField = "@id";
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
			this.txtEMail.DataField = "@email";
			resources.ApplyResources(this.txtEMail, "txtEMail");
			this.txtEMail.Name = "txtEMail";
			// 
			// lblName
			// 
			resources.ApplyResources(this.lblName, "lblName");
			this.lblName.Name = "lblName";
			// 
			// srptOrders
			// 
			this.srptOrders.CloseBorder = false;
			this.srptOrders.DataField = "ORDER";
			resources.ApplyResources(this.srptOrders, "srptOrders");
			this.srptOrders.Name = "srptOrders";
			this.srptOrders.Report = null;
			// 
			// lblOrders
			// 
			resources.ApplyResources(this.lblOrders, "lblOrders");
			this.lblOrders.Name = "lblOrders";
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtName,
			this.txtID,
			this.lblID,
			this.lblEMail,
			this.txtEMail,
			this.lblName,
			this.srptOrders,
			this.lblOrders});
			this.Detail.Height = 0.8125F;
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
			// CustomersOrders
			// 
			this.MasterReport = false;
			xmlDataSource1.FileURL = "C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\customer.xml";
			xmlDataSource1.RecordsetPattern = "//CUSTOMER";
			this.DataSource = xmlDataSource1;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
			"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.CustomersOrders_ReportStart);
		}
		#endregion
		public GrapeCity.ActiveReports.Data.XMLDataSource ds;
		private PageHeader PageHeader;
		private Detail Detail;
		private TextBox txtName;
		private TextBox txtID;
		private Label lblID;
		private Label lblEMail;
		private TextBox txtEMail;
		private Label lblName;
		private SubReport srptOrders;
		private Label lblOrders;
		private PageFooter PageFooter;
	}
}
