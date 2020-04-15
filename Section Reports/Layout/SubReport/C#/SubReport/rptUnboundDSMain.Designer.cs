namespace GrapeCity.ActiveReports.Samples.SubReport
{
	partial class rptUnboundDSMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptUnboundDSMain));
			this.Label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.SubReport1 = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.Label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.TextBox2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			((System.ComponentModel.ISupportInitialize)(this.Label1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			// 
			// TextBox1
			// 
			this.TextBox1.DataField = "CustomerID";
			resources.ApplyResources(this.TextBox1, "TextBox1");
			this.TextBox1.Name = "TextBox1";
			// 
			// SubReport1
			// 
			this.SubReport1.CloseBorder = false;
			resources.ApplyResources(this.SubReport1, "SubReport1");
			this.SubReport1.Name = "SubReport1";
			this.SubReport1.Report = null;
			// 
			// Label2
			// 
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.Name = "Label2";
			// 
			// TextBox2
			// 
			this.TextBox2.DataField = "CompanyName";
			resources.ApplyResources(this.TextBox2, "TextBox2");
			this.TextBox2.Name = "TextBox2";
			// 
			// Label3
			// 
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.Name = "Label3";
			// 
			// textBox3
			// 
			resources.ApplyResources(this.textBox3, "textBox3");
			this.textBox3.Name = "textBox3";
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
			this.Label1,
			this.TextBox1,
			this.SubReport1,
			this.Label2,
			this.TextBox2,
			this.Label3});
			this.Detail.Height = 1.21875F;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.textBox3});
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.reportInfo1});
			this.PageFooter.Name = "PageFooter";
			// 
			// rptUnboundDSMain
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
			this.ReportStart += new System.EventHandler(this.rptUnboundDSMain_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.Label1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Label3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox1;
		private GrapeCity.ActiveReports.SectionReportModel.SubReport SubReport1;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label2;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox2;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label3;
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox3;
		private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo1;
	}
}
