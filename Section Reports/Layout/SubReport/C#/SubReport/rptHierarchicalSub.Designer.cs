namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// </summary>
	partial class rptHierarchicalSub
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptHierarchicalSub));
			this.txtOrderDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtOrderID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtFreight = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblOrderDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblOrderID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblFreight = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.ghOrders = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFreight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFreight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// txtOrderDate
			// 
			this.txtOrderDate.CanShrink = true;
			this.txtOrderDate.DataField = "OrderDate";
			resources.ApplyResources(this.txtOrderDate, "txtOrderDate");
			this.txtOrderDate.Name = "txtOrderDate";
			// 
			// txtOrderID
			// 
			this.txtOrderID.CanShrink = true;
			this.txtOrderID.DataField = "OrderID";
			resources.ApplyResources(this.txtOrderID, "txtOrderID");
			this.txtOrderID.Name = "txtOrderID";
			// 
			// txtFreight
			// 
			this.txtFreight.CanShrink = true;
			this.txtFreight.DataField = "Freight";
			resources.ApplyResources(this.txtFreight, "txtFreight");
			this.txtFreight.Name = "txtFreight";
			// 
			// lblOrderDate
			// 
			resources.ApplyResources(this.lblOrderDate, "lblOrderDate");
			this.lblOrderDate.Name = "lblOrderDate";
			// 
			// lblOrderID
			// 
			resources.ApplyResources(this.lblOrderID, "lblOrderID");
			this.lblOrderID.Name = "lblOrderID";
			// 
			// lblFreight
			// 
			resources.ApplyResources(this.lblFreight, "lblFreight");
			this.lblFreight.Name = "lblFreight";
			// 
			// Detail
			// 
			this.Detail.CanShrink = true;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtOrderDate,
			this.txtOrderID,
			this.txtFreight});
			this.Detail.Height = 0.291F;
			this.Detail.Name = "Detail";
			// 
			// ghOrders
			// 
			this.ghOrders.CanShrink = true;
			this.ghOrders.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblOrderDate,
			this.lblOrderID,
			this.lblFreight});
			this.ghOrders.DataField = "CustomerID";
			this.ghOrders.Height = 0.3013889F;
			this.ghOrders.Name = "ghOrders";
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.CanShrink = true;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// rptHierarchicalSub
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6F;
			this.Script = resources.GetString("$this.Script");
			this.Sections.Add(this.ghOrders);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
						"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFreight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFreight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtOrderDate;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtOrderID;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtFreight;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader ghOrders;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblOrderDate;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblOrderID;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblFreight;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1;
	}
}
