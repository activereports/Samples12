namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// </summary>
	partial class rptDSRelationChildMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptDSRelationChildMain));
			this.SubReport1 = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.lblOrderID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblQuantity = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDiscount = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtProductName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.ghProducts = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
	   
			// 
			// SubReport1
			// 
			this.SubReport1.CloseBorder = false;
			resources.ApplyResources(this.SubReport1, "SubReport1");
			this.SubReport1.Name = "SubReport1";
			this.SubReport1.Report = null;
			// 
			// lblOrderID
			// 
			resources.ApplyResources(this.lblOrderID, "lblOrderID");
			this.lblOrderID.Name = "lblOrderID";
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lblUnitPrice.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.lblUnitPrice, "lblUnitPrice");
			this.lblUnitPrice.Name = "lblUnitPrice";
			// 
			// lblQuantity
			// 
			this.lblQuantity.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lblQuantity.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.lblQuantity, "lblQuantity");
			this.lblQuantity.Name = "lblQuantity";
			// 
			// lblDiscount
			// 
			this.lblDiscount.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lblDiscount.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.lblDiscount, "lblDiscount");
			this.lblDiscount.Name = "lblDiscount";
			// 
			// txtProductName
			// 
			this.txtProductName.DataField = "ProductName";
			resources.ApplyResources(this.txtProductName, "txtProductName");
			this.txtProductName.Name = "txtProductName";
			// 
			// Detail
			// 
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.SubReport1,
			this.lblOrderID,
			this.lblUnitPrice,
			this.lblQuantity,
			this.lblDiscount});
			this.Detail.Height = 0.197F;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// ghProducts
			// 
			this.ghProducts.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProductName});
			this.ghProducts.DataField = "ProductName";
			this.ghProducts.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.FirstDetail;
			this.ghProducts.Height = 0.3736111F;
			this.ghProducts.Name = "ghProducts";
			this.ghProducts.UnderlayNext = true;
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Height = 0.1666667F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// rptDSRelationChildMain
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 4.6F;
			this.Sections.Add(this.ghProducts);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.ReportStart += new System.EventHandler(this.rptDSRelationChildMain_ReportStart);
	 
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.SubReport SubReport1;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblOrderID;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblUnitPrice;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblQuantity;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblDiscount;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader ghProducts;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtProductName;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1;
	}
}
