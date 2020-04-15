namespace GrapeCity.ActiveReports.Samples.SubReport
{
	partial class rptParamMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptParamMain));
			this.TextBox2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SubReport1 = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.TextBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.ghSuppliers = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			((System.ComponentModel.ISupportInitialize)(this.TextBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// TextBox2
			// 
			this.TextBox2.DataField = "CompanyName";
			resources.ApplyResources(this.TextBox2, "TextBox2");
			this.TextBox2.Name = "TextBox2";
			// 
			// TextBox3
			// 
			this.TextBox3.DataField = "ContactName";
			resources.ApplyResources(this.TextBox3, "TextBox3");
			this.TextBox3.Name = "TextBox3";
			// 
			// TextBox4
			// 
			this.TextBox4.DataField = "Phone";
			resources.ApplyResources(this.TextBox4, "TextBox4");
			this.TextBox4.Name = "TextBox4";
			// 
			// SubReport1
			// 
			this.SubReport1.CloseBorder = false;
			resources.ApplyResources(this.SubReport1, "SubReport1");
			this.SubReport1.Name = "SubReport1";
			this.SubReport1.Report = null;
			// 
			// TextBox1
			// 
			this.TextBox1.DataField = "Country";
			resources.ApplyResources(this.TextBox1, "TextBox1");
			this.TextBox1.Name = "TextBox1";
			// 
			// textBox5
			// 
			resources.ApplyResources(this.textBox5, "textBox5");
			this.textBox5.Name = "textBox5";
			// 
			// reportInfo1
			// 
			this.reportInfo1.FormatString = null;
			resources.ApplyResources(this.reportInfo1, "reportInfo1");
			this.reportInfo1.Name = "reportInfo1";
			// 
			// Detail
			// 
			this.Detail.CanShrink = true;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.TextBox2,
			this.TextBox3,
			this.TextBox4,
			this.SubReport1});
			this.Detail.Height = 1.290278F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.textBox5});
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.reportInfo1});
			this.PageFooter.Name = "PageFooter";
			// 
			// ghSuppliers
			// 
			this.ghSuppliers.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.TextBox1});
			this.ghSuppliers.DataField = "Country";
			this.ghSuppliers.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.FirstDetail;
			this.ghSuppliers.Height = 0.2291667F;
			this.ghSuppliers.Name = "ghSuppliers";
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// rptParamMain
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.ghSuppliers);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.ReportStart += new System.EventHandler(this.rptParamMain_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.TextBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox2;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox3;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox4;
		private GrapeCity.ActiveReports.SectionReportModel.SubReport SubReport1;
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader ghSuppliers;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox1;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox5;
		private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo1;
	}
}
