namespace GrapeCity.ActiveReports.Samples.SubReport
{
	partial class rptParamSub
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptParamSub));
			this.txtProductName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCategoryName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.ghProducts = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
	
			// 
			// txtProductName
			// 
			this.txtProductName.DataField = "ProductName";
			resources.ApplyResources(this.txtProductName, "txtProductName");
			this.txtProductName.Name = "txtProductName";
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.DataField = "CategoryName";
			resources.ApplyResources(this.txtCategoryName, "txtCategoryName");
			this.txtCategoryName.Name = "txtCategoryName";
			// 
			// Detail
			// 
			this.Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(178)))), ((int)(((byte)(170)))));
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProductName});
			this.Detail.Height = 0.375F;
			this.Detail.Name = "Detail";
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
			// ghProducts
			// 
			this.ghProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ghProducts.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtCategoryName});
			this.ghProducts.DataField = "CategoryName";
			this.ghProducts.Height = 0.3125F;
			this.ghProducts.Name = "ghProducts";
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Height = 0F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// rptParamSub
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 5.93F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.ghProducts);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.ReportStart += new System.EventHandler(this.rptParamSub_ReportStart);
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtProductName;
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader ghProducts;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtCategoryName;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1;
	}
}
