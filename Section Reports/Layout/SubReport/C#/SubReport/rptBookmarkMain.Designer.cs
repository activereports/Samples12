namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// </summary>
	partial class rptBookmarkMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBookmarkMain));
			this.lblProducts = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lbllblCategoryName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ctlSubreport = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.txtCategoryName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			// 
			// lblProducts
			// 
			resources.ApplyResources(this.lblProducts, "lblProducts");
			this.lblProducts.Name = "lblProducts";
			// 
			// lbllblCategoryName
			// 
			this.lbllblCategoryName.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.lbllblCategoryName, "lbllblCategoryName");
			this.lbllblCategoryName.Name = "lbllblCategoryName";
			// 
			// ctlSubreport
			// 
			this.ctlSubreport.CloseBorder = false;
			resources.ApplyResources(this.ctlSubreport, "ctlSubreport");
			this.ctlSubreport.Name = "ctlSubreport";
			this.ctlSubreport.Report = null;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.txtCategoryName.DataField = "CategoryName";
			resources.ApplyResources(this.txtCategoryName, "txtCategoryName");
			this.txtCategoryName.Name = "txtCategoryName";
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
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblProducts,
			this.lbllblCategoryName,
			this.ctlSubreport,
			this.txtCategoryName});
			this.Detail.Height = 1.790972F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.textBox1});
			this.PageHeader.Height = 0.25F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.reportInfo1});
			this.PageFooter.Height = 0.25F;
			this.PageFooter.Name = "PageFooter";
			// 
			// rptBookmarkMain
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
			this.FetchData += new GrapeCity.ActiveReports.SectionReport.FetchEventHandler(this.rptBookmarkMain_FetchData);
			this.ReportStart += new System.EventHandler(this.rptBookmarkMain_ReportStart);
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblProducts;
		private GrapeCity.ActiveReports.SectionReportModel.Label lbllblCategoryName;
		private GrapeCity.ActiveReports.SectionReportModel.SubReport ctlSubreport;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtCategoryName;
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox1;
		private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo1;
	}
}
