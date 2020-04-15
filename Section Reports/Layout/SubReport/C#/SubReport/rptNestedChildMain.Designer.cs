namespace GrapeCity.ActiveReports.Samples.SubReport
{
	partial class rptNestedChildMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptNestedChildMain));
			this.lblOrderDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProductID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblQuantity = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblOrderID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtOrderDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtProductID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtQuantity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtOrderID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.subCustomers = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.groupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.groupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			this.groupHeader2 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.groupFooter2 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			// 
			// lblOrderDate
			// 
			resources.ApplyResources(this.lblOrderDate, "lblOrderDate");
			this.lblOrderDate.Name = "lblOrderDate";
			// 
			// lblProductID
			// 
			resources.ApplyResources(this.lblProductID, "lblProductID");
			this.lblProductID.Name = "lblProductID";
			// 
			// lblQuantity
			// 
			resources.ApplyResources(this.lblQuantity, "lblQuantity");
			this.lblQuantity.Name = "lblQuantity";
			// 
			// lblOrderID
			// 
			resources.ApplyResources(this.lblOrderID, "lblOrderID");
			this.lblOrderID.Name = "lblOrderID";
			// 
			// txtOrderDate
			// 
			this.txtOrderDate.DataField = "OrderDate";
			resources.ApplyResources(this.txtOrderDate, "txtOrderDate");
			this.txtOrderDate.Name = "txtOrderDate";
			// 
			// txtProductID
			// 
			this.txtProductID.DataField = "ProductID";
			resources.ApplyResources(this.txtProductID, "txtProductID");
			this.txtProductID.Name = "txtProductID";
			// 
			// txtQuantity
			// 
			this.txtQuantity.DataField = "Quantity";
			resources.ApplyResources(this.txtQuantity, "txtQuantity");
			this.txtQuantity.Name = "txtQuantity";
			// 
			// txtOrderID
			// 
			this.txtOrderID.DataField = "orders.OrderID";
			resources.ApplyResources(this.txtOrderID, "txtOrderID");
			this.txtOrderID.Name = "txtOrderID";
			// 
			// subCustomers
			// 
			this.subCustomers.CloseBorder = false;
			resources.ApplyResources(this.subCustomers, "subCustomers");
			this.subCustomers.Name = "subCustomers";
			this.subCustomers.Report = null;
			// 
			// Detail
			// 
			this.Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProductID,
			this.txtQuantity});
			this.Detail.Height = 0.2500004F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// groupHeader1
			// 
			this.groupHeader1.BackColor = System.Drawing.Color.LightGray;
			this.groupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblOrderID,
			this.txtOrderID,
			this.lblOrderDate,
			this.txtOrderDate});
			this.groupHeader1.DataField = "orders.OrderID";
			this.groupHeader1.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All;
			this.groupHeader1.Height = 0.25F;
			this.groupHeader1.Name = "groupHeader1";
			// 
			// groupFooter1
			// 
			this.groupFooter1.Height = 0.25F;
			this.groupFooter1.Name = "groupFooter1";
			this.groupFooter1.Visible = false;
			// 
			// groupHeader2
			// 
			this.groupHeader2.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.subCustomers,
			this.lblProductID,
			this.lblQuantity});
			this.groupHeader2.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All;
			this.groupHeader2.Height = 0.896F;
			this.groupHeader2.Name = "groupHeader2";
			// 
			// groupFooter2
			// 
			this.groupFooter2.Height = 0.25F;
			this.groupFooter2.Name = "groupFooter2";
			this.groupFooter2.Visible = false;
			// 
			// rptNestedChildMain
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6F;
			this.Script = resources.GetString("$this.Script");
			this.Sections.Add(this.groupHeader1);
			this.Sections.Add(this.groupHeader2);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.groupFooter2);
			this.Sections.Add(this.groupFooter1);
			this.ShowParameterUI = false;
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.ReportStart += new System.EventHandler(this.rptNestedChildMain_ReportStart);
		  
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblOrderDate;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblProductID;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblQuantity;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblOrderID;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtOrderDate;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtProductID;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtQuantity;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtOrderID;
		private GrapeCity.ActiveReports.SectionReportModel.SubReport subCustomers;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader groupHeader1;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter groupFooter1;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader groupHeader2;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter groupFooter2;
	}
}
