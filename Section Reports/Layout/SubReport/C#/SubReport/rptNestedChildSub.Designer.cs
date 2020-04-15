namespace GrapeCity.ActiveReports.Samples.SubReport
{
	partial class rptNestedChildSub
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptNestedChildSub));
			this.lblContactName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblPhone = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtContactName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtPhone = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.textBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			// 
			// lblContactName
			// 
			resources.ApplyResources(this.lblContactName, "lblContactName");
			this.lblContactName.Name = "lblContactName";
			// 
			// lblPhone
			// 
			resources.ApplyResources(this.lblPhone, "lblPhone");
			this.lblPhone.Name = "lblPhone";
			// 
			// txtContactName
			// 
			resources.ApplyResources(this.txtContactName, "txtContactName");
			this.txtContactName.DataField = "ContactName";
			this.txtContactName.Name = "txtContactName";
			// 
			// txtPhone
			// 
			resources.ApplyResources(this.txtPhone, "txtPhone");
			this.txtPhone.DataField = "Phone";
			this.txtPhone.Name = "txtPhone";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// textBox1
			// 
			resources.ApplyResources(this.textBox1, "textBox1");
			this.textBox1.DataField = "CompanyName";
			this.textBox1.Name = "textBox1";
			// 
			// Detail
			// 
			this.Detail.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblContactName,
			this.lblPhone,
			this.txtContactName,
			this.txtPhone,
			this.label1,
			this.textBox1});
			this.Detail.Height = 0.5F;
			this.Detail.Name = "Detail";
			// 
			// rptNestedChildSub
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6F;
			this.Sections.Add(this.Detail);
			this.ShowParameterUI = false;
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblContactName;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblPhone;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtContactName;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtPhone;
		private GrapeCity.ActiveReports.SectionReportModel.Label label1;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox1;
	}
}
