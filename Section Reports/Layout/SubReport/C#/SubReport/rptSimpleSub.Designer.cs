namespace GrapeCity.ActiveReports.Samples.SubReport
{
	partial class rptSimpleSub
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptSimpleSub));
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			this.txtProductName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.barcode1 = new GrapeCity.ActiveReports.SectionReportModel.Barcode();
			this.line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.groupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.groupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			// 
			// txtProductName
			// 
			resources.ApplyResources(this.txtProductName, "txtProductName");
			this.txtProductName.DataField = "ProductName";
			this.txtProductName.Name = "txtProductName";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// barcode1
			// 
			this.barcode1.DataField = "ProductName";
			this.barcode1.Font = new System.Drawing.Font("Courier New", 8F);
			resources.ApplyResources(this.barcode1, "barcode1");
			this.barcode1.Name = "barcode1";
			this.barcode1.QuietZoneBottom = 0F;
			this.barcode1.QuietZoneLeft = 0F;
			this.barcode1.QuietZoneRight = 0F;
			this.barcode1.QuietZoneTop = 0F;
			// 
			// line1
			// 
			resources.ApplyResources(this.line1, "line1");
			this.line1.LineColor = System.Drawing.Color.LightSkyBlue;
			this.line1.LineWeight = 1F;
			this.line1.Name = "line1";
			this.line1.X1 = 0F;
			this.line1.X2 = 4.6F;
			this.line1.Y1 = 0.447F;
			this.line1.Y2 = 0.447F;
			// 
			// Detail
			// 
			this.Detail.BackColor = System.Drawing.Color.AliceBlue;
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProductName,
			this.barcode1,
			this.line1});
			this.Detail.Height = 0.4891667F;
			this.Detail.Name = "Detail";
			// 
			// groupHeader1
			// 
			this.groupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.label1});
			this.groupHeader1.Height = 0.25F;
			this.groupHeader1.Name = "groupHeader1";
			// 
			// groupFooter1
			// 
			this.groupFooter1.Height = 0.25F;
			this.groupFooter1.Name = "groupFooter1";
			// 
			// rptSimpleSub
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			oleDBDataSource1.ConnectionString = "";
			oleDBDataSource1.SQL = "Select * from";
			this.DataSource = oleDBDataSource1;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 4.6F;
			this.Sections.Add(this.groupHeader1);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.groupFooter1);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
	  
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtProductName;
		private GrapeCity.ActiveReports.SectionReportModel.Barcode barcode1;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader groupHeader1;
		private GrapeCity.ActiveReports.SectionReportModel.Label label1;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter groupFooter1;
		private GrapeCity.ActiveReports.SectionReportModel.Line line1;
	}
}
