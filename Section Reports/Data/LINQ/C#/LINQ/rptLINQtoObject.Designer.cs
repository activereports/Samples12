namespace GrapeCity.ActiveReports.Samples.LINQ
{
	/// <summary>
	///A description of the overview of the rptLINQtoObject. 
	/// </summary>
	partial class rptLINQtoObject
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
			}
			base.Dispose(disposing);
		}
		
		#region ActiveReport Designer generated code
		
		
		/// <summary>
		/// Required method for Designer support. The contents of this method
		/// Please do not change in the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptLINQtoObject));
			this.TextBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox6 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox7 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox8 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			((System.ComponentModel.ISupportInitialize)(this.TextBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// TextBox1
			// 
			this.TextBox1.DataField = "ID";
			resources.ApplyResources(this.TextBox1, "TextBox1");
			this.TextBox1.Name = "TextBox1";
			// 
			// TextBox2
			// 
			this.TextBox2.DataField = "Name";
			resources.ApplyResources(this.TextBox2, "TextBox2");
			this.TextBox2.Name = "TextBox2";
			// 
			// TextBox3
			// 
			this.TextBox3.DataField = "Age";
			resources.ApplyResources(this.TextBox3, "TextBox3");
			this.TextBox3.Name = "TextBox3";
			// 
			// TextBox4
			// 
			this.TextBox4.DataField = "city";
			resources.ApplyResources(this.TextBox4, "TextBox4");
			this.TextBox4.Name = "TextBox4";
			// 
			// TextBox5
			// 
			resources.ApplyResources(this.TextBox5, "TextBox5");
			this.TextBox5.Name = "TextBox5";
			// 
			// TextBox6
			// 
			resources.ApplyResources(this.TextBox6, "TextBox6");
			this.TextBox6.Name = "TextBox6";
			// 
			// TextBox7
			// 
			resources.ApplyResources(this.TextBox7, "TextBox7");
			this.TextBox7.Name = "TextBox7";
			// 
			// TextBox8
			// 
			resources.ApplyResources(this.TextBox8, "TextBox8");
			this.TextBox8.Name = "TextBox8";
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.TextBox1,
			this.TextBox2,
			this.TextBox3,
			this.TextBox4});
			this.Detail.Height = 0.40625F;
			this.Detail.Name = "Detail";
			// 
			// PageHeader
			// 
			this.PageHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.TextBox5,
			this.TextBox6,
			this.TextBox7,
			this.TextBox8});
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Name = "PageFooter";
			// 
			// rptLINQtoObject
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
			this.ReportStart += new System.EventHandler(this.rptLINQtoObject_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.TextBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TextBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox1;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox2;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox3;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox4;
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox5;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox6;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox7;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox8;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter;
	}
}
