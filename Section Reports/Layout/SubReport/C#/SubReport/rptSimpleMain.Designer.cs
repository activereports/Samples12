namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// </summary>
	partial class rptSimpleMain
	{
		/// <summary>
	   
		/// </summary>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptSimpleMain));
			this.lblCategoryName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtCategoryName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ctlSubreport = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.textBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			((System.ComponentModel.ISupportInitialize)(this.lblCategoryName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCategoryName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// lblCategoryName
			// 
			resources.ApplyResources(this.lblCategoryName, "lblCategoryName");
			this.lblCategoryName.Name = "lblCategoryName";
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.DataField = "CategoryName";
			resources.ApplyResources(this.txtCategoryName, "txtCategoryName");
			this.txtCategoryName.Name = "txtCategoryName";
			// 
			// ctlSubreport
			// 
			this.ctlSubreport.CloseBorder = false;
			resources.ApplyResources(this.ctlSubreport, "ctlSubreport");
			this.ctlSubreport.Name = "ctlSubreport";
			this.ctlSubreport.Report = null;
			// 
			// textBox1
			// 
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.Name = "textBox1";
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
			this.lblCategoryName,
			this.txtCategoryName,
			this.ctlSubreport});
			this.Detail.Height = 0.75F;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.textBox1});
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.reportInfo1});
			this.PageFooter.Name = "PageFooter";
			// 
			// rptSimpleMain
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
			"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			this.FetchData += new GrapeCity.ActiveReports.SectionReport.FetchEventHandler(this.rptSimpleMain_FetchData);
			this.ReportStart += new System.EventHandler(this.rptSimpleMain_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.lblCategoryName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCategoryName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblCategoryName;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtCategoryName;
		private GrapeCity.ActiveReports.SectionReportModel.SubReport ctlSubreport;
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox1;
		private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo1;
	}
}
