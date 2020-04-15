namespace GrapeCity.ActiveReports.Samples.SubReport
{
	partial class rptUnboundDSSub
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptUnboundDSSub));
			this.TextBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox2 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox3 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox4 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.TextBox5 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label5 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.GroupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			// 
			// TextBox1
			// 
			resources.ApplyResources(this.TextBox1, "TextBox1");
			this.TextBox1.DataField = "OrderID";
			this.TextBox1.Name = "TextBox1";
			// 
			// TextBox2
			// 
			resources.ApplyResources(this.TextBox2, "TextBox2");
			this.TextBox2.DataField = "OrderDate";
			this.TextBox2.Name = "TextBox2";
			// 
			// TextBox3
			// 
			resources.ApplyResources(this.TextBox3, "TextBox3");
			this.TextBox3.DataField = "ShippedDate";
			this.TextBox3.Name = "TextBox3";
			// 
			// TextBox4
			// 
			resources.ApplyResources(this.TextBox4, "TextBox4");
			this.TextBox4.DataField = "ShipVia";
			this.TextBox4.Name = "TextBox4";
			// 
			// TextBox5
			// 
			resources.ApplyResources(this.TextBox5, "TextBox5");
			this.TextBox5.DataField = "Freight";
			this.TextBox5.Name = "TextBox5";
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			// 
			// Label2
			// 
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.Name = "Label2";
			// 
			// Label3
			// 
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.Name = "Label3";
			// 
			// Label4
			// 
			resources.ApplyResources(this.Label4, "Label4");
			this.Label4.Name = "Label4";
			// 
			// Label5
			// 
			resources.ApplyResources(this.Label5, "Label5");
			this.Label5.Name = "Label5";
			// 
			// Detail
			// 
			this.Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.TextBox1,
			this.TextBox2,
			this.TextBox3,
			this.TextBox4,
			this.TextBox5});
			this.Detail.Height = 0.3326389F;
			this.Detail.Name = "Detail";
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.Label1,
			this.Label2,
			this.Label3,
			this.Label4,
			this.Label5});
			this.GroupHeader1.Height = 0.25F;
			this.GroupHeader1.Name = "GroupHeader1";
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Height = 0.25F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// rptUnboundDSSub
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 5.875F;
			this.Sections.Add(this.GroupHeader1);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox1;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox2;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox3;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox4;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox TextBox5;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader GroupHeader1;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label1;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label2;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label3;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label4;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label5;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1;
	}
}
