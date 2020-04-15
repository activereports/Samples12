namespace GrapeCity.ActiveReports.Samples.SubReport
{
	partial class rptMasterSub
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptMasterSub));
			this.txtOrderID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtProductName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtProductID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtQuantity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtDiscount = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblOrderID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProductID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProductName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblQuantity = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDiscount = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProductID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProductName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDiscount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// txtOrderID
			// 
			this.txtOrderID.CanShrink = true;
			this.txtOrderID.DataField = "OrderID";
			resources.ApplyResources(this.txtOrderID, "txtOrderID");
			this.txtOrderID.Name = "txtOrderID";
			// 
			// txtProductName
			// 
			this.txtProductName.CanShrink = true;
			this.txtProductName.DataField = "ProductName";
			resources.ApplyResources(this.txtProductName, "txtProductName");
			this.txtProductName.Name = "txtProductName";
			// 
			// txtProductID
			// 
			this.txtProductID.CanShrink = true;
			this.txtProductID.DataField = "products.ProductID";
			resources.ApplyResources(this.txtProductID, "txtProductID");
			this.txtProductID.Name = "txtProductID";
			// 
			// txtQuantity
			// 
			this.txtQuantity.CanShrink = true;
			this.txtQuantity.DataField = "Quantity";
			resources.ApplyResources(this.txtQuantity, "txtQuantity");
			this.txtQuantity.Name = "txtQuantity";
			// 
			// txtDiscount
			// 
			this.txtDiscount.CanShrink = true;
			this.txtDiscount.DataField = "Discount";
			resources.ApplyResources(this.txtDiscount, "txtDiscount");
			this.txtDiscount.Name = "txtDiscount";
			// 
			// lblOrderID
			// 
			resources.ApplyResources(this.lblOrderID, "lblOrderID");
			this.lblOrderID.Name = "lblOrderID";
			// 
			// lblProductID
			// 
			resources.ApplyResources(this.lblProductID, "lblProductID");
			this.lblProductID.Name = "lblProductID";
			// 
			// lblProductName
			// 
			resources.ApplyResources(this.lblProductName, "lblProductName");
			this.lblProductName.Name = "lblProductName";
			// 
			// lblQuantity
			// 
			resources.ApplyResources(this.lblQuantity, "lblQuantity");
			this.lblQuantity.Name = "lblQuantity";
			// 
			// lblDiscount
			// 
			resources.ApplyResources(this.lblDiscount, "lblDiscount");
			this.lblDiscount.Name = "lblDiscount";
			// 
			// Detail
			// 
			this.Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.Detail.CanShrink = true;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtOrderID,
			this.txtProductName,
			this.txtProductID,
			this.txtQuantity,
			this.txtDiscount,
			this.lblOrderID,
			this.lblProductID,
			this.lblProductName,
			this.lblQuantity,
			this.lblDiscount});
			this.Detail.Height = 0.5104167F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// PageHeader
			// 
			this.PageHeader.Height = 0F;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Visible = false;
			// 
			// PageFooter
			// 
			this.PageFooter.Height = 0F;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Visible = false;
			// 
			// rptMasterSub
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.ShowParameterUI = false;
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
						"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			((System.ComponentModel.ISupportInitialize)(this.txtOrderID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProductID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProductName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDiscount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtOrderID;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtProductName;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtProductID;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtQuantity;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtDiscount;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblOrderID;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblProductID;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblProductName;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblQuantity;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblDiscount;
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter;
	}
}
