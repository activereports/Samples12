namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// </summary>
	partial class rptDSRelationChildSub
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptDSRelationChildSub));
			this.txtUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtQuantity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtDiscount = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtOrderID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.DataField = "UnitPrice";
			resources.ApplyResources(this.txtUnitPrice, "txtUnitPrice");
			this.txtUnitPrice.Name = "txtUnitPrice";
			// 
			// txtQuantity
			// 
			this.txtQuantity.DataField = "Quantity";
			resources.ApplyResources(this.txtQuantity, "txtQuantity");
			this.txtQuantity.Name = "txtQuantity";
			// 
			// txtDiscount
			// 
			this.txtDiscount.DataField = "Discount";
			resources.ApplyResources(this.txtDiscount, "txtDiscount");
			this.txtDiscount.Name = "txtDiscount";
			// 
			// txtOrderID
			// 
			this.txtOrderID.DataField = "OrderID";
			resources.ApplyResources(this.txtOrderID, "txtOrderID");
			this.txtOrderID.Name = "txtOrderID";
			// 
			// Detail
			// 
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtUnitPrice,
			this.txtQuantity,
			this.txtDiscount,
			this.txtOrderID});
			this.Detail.Height = 0.2513889F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// rptDSRelationChildSub
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 3F;
			this.Sections.Add(this.Detail);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtUnitPrice;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtQuantity;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtDiscount;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtOrderID;
	}
}
