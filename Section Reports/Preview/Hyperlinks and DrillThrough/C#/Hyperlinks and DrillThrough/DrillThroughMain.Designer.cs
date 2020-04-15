using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.HyperlinksAndDrillThrough
{
	public partial class DrillThroughMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrillThroughMain));
			this.txtCustomerID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCompanyName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtContactName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblCustomer = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblCompanyName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblContactName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.cscBorder = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			// 
			// txtCustomerID
			// 
			resources.ApplyResources(this.txtCustomerID, "txtCustomerID");
			this.txtCustomerID.DataField = "CustomerID";
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// txtCompanyName
			// 
			resources.ApplyResources(this.txtCompanyName, "txtCompanyName");
			this.txtCompanyName.DataField = "CompanyName";
			this.txtCompanyName.Name = "txtCompanyName";
			// 
			// txtContactName
			// 
			resources.ApplyResources(this.txtContactName, "txtContactName");
			this.txtContactName.DataField = "ContactName";
			this.txtContactName.Name = "txtContactName";
			// 
			// lblCustomer
			// 
			resources.ApplyResources(this.lblCustomer, "lblCustomer");
			this.lblCustomer.Name = "lblCustomer";
			this.lblCustomer.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// lblCompanyName
			// 
			resources.ApplyResources(this.lblCompanyName, "lblCompanyName");
			this.lblCompanyName.Name = "lblCompanyName";
			// 
			// lblContactName
			// 
			resources.ApplyResources(this.lblContactName, "lblContactName");
			this.lblContactName.Name = "lblContactName";
			// 
			// cscBorder
			// 
			this.cscBorder.BackColor = System.Drawing.Color.Thistle;
			this.cscBorder.Bottom = 0F;
			resources.ApplyResources(this.cscBorder, "cscBorder");
			this.cscBorder.LineColor = System.Drawing.Color.Purple;
			this.cscBorder.LineWeight = 3F;
			this.cscBorder.Name = "cscBorder";
			this.cscBorder.Right = 6.5F;
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtCustomerID,
			this.txtCompanyName,
			this.txtContactName});
			this.Detail.Height = 0.2388889F;
			this.Detail.Name = "Detail";
			this.Detail.RepeatToFill = true;
			this.Detail.BeforePrint += new System.EventHandler(this.Detail_BeforePrint);
			// 
			// PageHeader
			// 
			this.PageHeader.CanShrink = true;
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblCustomer,
			this.lblCompanyName,
			this.lblContactName,
			this.cscBorder});
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Height = 0F;
			this.PageFooter.Name = "PageFooter";
			// 
			// DrillThroughMain
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.DataInitialize += new System.EventHandler(this.DrillThroughMain_DataInitialize);
		}
		#endregion
		private CrossSectionBox cscBorder;
		public GrapeCity.ActiveReports.Data.OleDBDataSource ds;
		private PageHeader PageHeader;
		private Label lblCustomer;
		private Label lblCompanyName;
		private Label lblContactName;
		private Detail Detail;
		private TextBox txtCustomerID;
		private TextBox txtCompanyName;
		private TextBox txtContactName;
		private PageFooter PageFooter;
		
	}
}
