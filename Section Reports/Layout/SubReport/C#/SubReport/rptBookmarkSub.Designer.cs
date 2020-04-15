namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// </summary>
	partial class rptBookmarkSub
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBookmarkSub));
			this.txtProductName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			// 
			// txtProductName
			// 
			this.txtProductName.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.txtProductName, "txtProductName");
			this.txtProductName.DataField = "ProductName";
			this.txtProductName.Name = "txtProductName";
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.txtUnitPrice, "txtUnitPrice");
			this.txtUnitPrice.DataField = "UnitPrice";
			this.txtUnitPrice.Name = "txtUnitPrice";
			// 
			// Detail
			// 
			this.Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProductName,
			this.txtUnitPrice});
			this.Detail.Height = 0.3527778F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// PageHeader
			// 
			this.PageHeader.Height = 0.25F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Height = 0.25F;
			this.PageFooter.Name = "PageFooter";
			// 
			// rptBookmarkSub
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 5F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtProductName;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtUnitPrice;
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter;
	}
}
