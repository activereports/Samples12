namespace GrapeCity.ActiveReports.Samples.SubReport
{
	partial class rptHierarchicalMain
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
			}
			base.Dispose(disposing);
		}
		
		#region  ActiveReports Designer generated code
		
		
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptHierarchicalMain));
			this.txtCustomerID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCompanyName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtAddress = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Subreport1 = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.shape1 = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
			this.textBox2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			((System.ComponentModel.ISupportInitialize)(this.txtCustomerID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCompanyName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.CanShrink = true;
			this.txtCustomerID.DataField = "CustomerID";
			resources.ApplyResources(this.txtCustomerID, "txtCustomerID");
			this.txtCustomerID.Name = "txtCustomerID";
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.CanShrink = true;
			this.txtCompanyName.DataField = "CompanyName";
			resources.ApplyResources(this.txtCompanyName, "txtCompanyName");
			this.txtCompanyName.Name = "txtCompanyName";
			// 
			// txtAddress
			// 
			this.txtAddress.CanShrink = true;
			this.txtAddress.DataField = "Address";
			resources.ApplyResources(this.txtAddress, "txtAddress");
			this.txtAddress.Name = "txtAddress";
			// 
			// Subreport1
			// 
			this.Subreport1.CloseBorder = false;
			this.Subreport1.DataField = "CustomerOrders";
			resources.ApplyResources(this.Subreport1, "Subreport1");
			this.Subreport1.Name = "Subreport1";
			this.Subreport1.Report = null;
			// 
			// shape1
			// 
			resources.ApplyResources(this.shape1, "shape1");
			this.shape1.Name = "shape1";
			this.shape1.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, null, null, null, null);
			// 
			// reportInfo1
			// 
			this.reportInfo1.CanShrink = true;
			this.reportInfo1.FormatString = null;
			resources.ApplyResources(this.reportInfo1, "reportInfo1");
			this.reportInfo1.Name = "reportInfo1";
			// 
			// textBox2
			// 
			resources.ApplyResources(this.textBox2, "textBox2");
			this.textBox2.Name = "textBox2";
			// 
			// Detail
			// 
			this.Detail.CanShrink = true;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtCustomerID,
			this.txtCompanyName,
			this.txtAddress,
			this.Subreport1,
			this.shape1});
			this.Detail.Height = 0.8947502F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			this.Detail.BeforePrint += new System.EventHandler(this.Detail_BeforePrint);
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.textBox2});
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.CanShrink = true;
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.reportInfo1});
			this.PageFooter.Height = 0.573F;
			this.PageFooter.Name = "PageFooter";
			// 
			// rptHierarchicalMain
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.083667F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
						"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.rptHierarchicalMain_ReportStart);
			this.ReportEnd += new System.EventHandler(this.rptHierarchicalMain_ReportEnd);
			((System.ComponentModel.ISupportInitialize)(this.txtCustomerID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCompanyName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtCustomerID;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtCompanyName;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtAddress;
		private GrapeCity.ActiveReports.SectionReportModel.SubReport Subreport1;
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter;
		private GrapeCity.ActiveReports.SectionReportModel.Shape shape1;
		private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo1;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox2;
	}
}
