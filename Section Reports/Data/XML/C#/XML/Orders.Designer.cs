using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.XML
{
	public partial class Orders
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
			GrapeCity.ActiveReports.Data.XMLDataSource xmlDataSource1 = new GrapeCity.ActiveReports.Data.XMLDataSource();
			this.txtOrderNumber = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtOrderDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.srptItems = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.lblItems = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// txtOrderNumber
			// 
			this.txtOrderNumber.DataField = "NUMBER";
			resources.ApplyResources(this.txtOrderNumber, "txtOrderNumber");
			this.txtOrderNumber.Name = "txtOrderNumber";
			// 
			// txtOrderDate
			// 
			this.txtOrderDate.DataField = "DATE";
			resources.ApplyResources(this.txtOrderDate, "txtOrderDate");
			this.txtOrderDate.Name = "txtOrderDate";
			// 
			// srptItems
			// 
			this.srptItems.CloseBorder = false;
			this.srptItems.DataField = "ITEM";
			resources.ApplyResources(this.srptItems, "srptItems");
			this.srptItems.Name = "srptItems";
			this.srptItems.Report = null;
			// 
			// lblItems
			// 
			resources.ApplyResources(this.lblItems, "lblItems");
			this.lblItems.Name = "lblItems";
			// 
			// Detail
			// 
			this.Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtOrderNumber,
			this.txtOrderDate,
			this.srptItems,
			this.lblItems});
			this.Detail.Height = 0.4159722F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// Orders
			// 
			this.MasterReport = false;
			xmlDataSource1.FileURL = "C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\customer.xml";
			xmlDataSource1.RecordsetPattern = "//ORDER";
			this.DataSource = xmlDataSource1;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.Sections.Add(this.Detail);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
			"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.Orders_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.txtOrderNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		public GrapeCity.ActiveReports.Data.XMLDataSource ds;
		private Detail Detail;
		private TextBox txtOrderNumber;
		private TextBox txtOrderDate;
		private SubReport srptItems;
		private Label lblItems;
	}
}
