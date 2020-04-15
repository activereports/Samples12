namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// </summary>
	partial class rptDSRelationParent
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptDSRelationParent));
			this.SubReport1 = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.lblCategoryName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProduct = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblOrderDetails = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtCategoryName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.ghCategories = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			this.groupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.groupFooter2 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
		  
			// 
			// SubReport1
			// 
			this.SubReport1.CloseBorder = false;
			resources.ApplyResources(this.SubReport1, "SubReport1");
			this.SubReport1.Name = "SubReport1";
			this.SubReport1.Report = null;
			// 
			// lblCategoryName
			// 
			resources.ApplyResources(this.lblCategoryName, "lblCategoryName");
			this.lblCategoryName.Name = "lblCategoryName";
			// 
			// lblProduct
			// 
			this.lblProduct.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lblProduct.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.lblProduct, "lblProduct");
			this.lblProduct.Name = "lblProduct";
			// 
			// lblOrderDetails
			// 
			this.lblOrderDetails.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lblOrderDetails.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.lblOrderDetails, "lblOrderDetails");
			this.lblOrderDetails.Name = "lblOrderDetails";
			// 
			// txtCategoryName
			// 
			resources.ApplyResources(this.txtCategoryName, "txtCategoryName");
			this.txtCategoryName.DataField = "CategoryName";
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
			this.SubReport1});
			this.Detail.Height = 0.53125F;
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
			// ghCategories
			// 
			this.ghCategories.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtCategoryName});
			this.ghCategories.DataField = "CategoryName";
			this.ghCategories.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All;
			this.ghCategories.Height = 0.25F;
			this.ghCategories.Name = "ghCategories";
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Height = 0.25F;
			this.GroupFooter1.Name = "GroupFooter1";
			this.GroupFooter1.Visible = false;
			// 
			// groupHeader1
			// 
			this.groupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblCategoryName,
			this.lblProduct,
			this.lblOrderDetails});
			this.groupHeader1.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All;
			this.groupHeader1.Height = 0.25F;
			this.groupHeader1.Name = "groupHeader1";
			this.groupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage;
			// 
			// groupFooter2
			// 
			this.groupFooter2.Height = 0.25F;
			this.groupFooter2.Name = "groupFooter2";
			// 
			// rptDSRelationParent
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.groupHeader1);
			this.Sections.Add(this.ghCategories);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.Sections.Add(this.groupFooter2);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.ReportStart += new System.EventHandler(this.rptDSRelationParent_ReportStart);
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.SubReport SubReport1;
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblCategoryName;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblProduct;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblOrderDetails;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader ghCategories;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtCategoryName;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox1;
		private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo1;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader groupHeader1;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter groupFooter2;
	}
}
