namespace GrapeCity.ActiveReports.Samples.SubReport
{
	partial class rptNestedParent
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptNestedParent));
			this.subOrders = new GrapeCity.ActiveReports.SectionReportModel.SubReport();
			this.lblEmployeeID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblExtension = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblLastName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblFirstName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtEmployeeID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtExtension = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtLastName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtFirstName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.textBox1 = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.reportInfo1 = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.ghEmployees = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			// 
			// subOrders
			// 
			this.subOrders.CloseBorder = false;
			resources.ApplyResources(this.subOrders, "subOrders");
			this.subOrders.Name = "subOrders";
			this.subOrders.Report = null;
			// 
			// lblEmployeeID
			// 
			resources.ApplyResources(this.lblEmployeeID, "lblEmployeeID");
			this.lblEmployeeID.Name = "lblEmployeeID";
			// 
			// lblExtension
			// 
			resources.ApplyResources(this.lblExtension, "lblExtension");
			this.lblExtension.Name = "lblExtension";
			// 
			// lblLastName
			// 
			resources.ApplyResources(this.lblLastName, "lblLastName");
			this.lblLastName.Name = "lblLastName";
			// 
			// lblFirstName
			// 
			resources.ApplyResources(this.lblFirstName, "lblFirstName");
			this.lblFirstName.Name = "lblFirstName";
			// 
			// txtEmployeeID
			// 
			resources.ApplyResources(this.txtEmployeeID, "txtEmployeeID");
			this.txtEmployeeID.DataField = "EmployeeID";
			this.txtEmployeeID.Name = "txtEmployeeID";
			// 
			// txtExtension
			// 
			resources.ApplyResources(this.txtExtension, "txtExtension");
			this.txtExtension.DataField = "Extension";
			this.txtExtension.Name = "txtExtension";
			// 
			// txtLastName
			// 
			resources.ApplyResources(this.txtLastName, "txtLastName");
			this.txtLastName.DataField = "LastName";
			this.txtLastName.Name = "txtLastName";
			// 
			// txtFirstName
			// 
			resources.ApplyResources(this.txtFirstName, "txtFirstName");
			this.txtFirstName.DataField = "FirstName";
			this.txtFirstName.Name = "txtFirstName";
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
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.subOrders});
			this.Detail.Height = 0.75F;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// PageHeader
			// 
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.textBox1});
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.reportInfo1});
			this.PageFooter.Name = "PageFooter";
			// 
			// ghEmployees
			// 
			this.ghEmployees.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ghEmployees.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblEmployeeID,
			this.lblExtension,
			this.lblLastName,
			this.lblFirstName,
			this.txtEmployeeID,
			this.txtExtension,
			this.txtLastName,
			this.txtFirstName});
			this.ghEmployees.DataField = "EmployeeID";
			this.ghEmployees.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All;
			this.ghEmployees.Height = 0.5104167F;
			this.ghEmployees.KeepTogether = true;
			this.ghEmployees.Name = "ghEmployees";
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.BackColor = System.Drawing.Color.Navy;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// rptNestedParent
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.ghEmployees);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.ReportStart += new System.EventHandler(this.rptNestedParent_ReportStart);
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.SubReport subOrders;
		private GrapeCity.ActiveReports.SectionReportModel.PageHeader PageHeader;
		private GrapeCity.ActiveReports.SectionReportModel.PageFooter PageFooter;
		private GrapeCity.ActiveReports.SectionReportModel.GroupHeader ghEmployees;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblEmployeeID;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblExtension;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblLastName;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblFirstName;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtEmployeeID;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtExtension;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtLastName;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox txtFirstName;
		private GrapeCity.ActiveReports.SectionReportModel.GroupFooter GroupFooter1;
		private GrapeCity.ActiveReports.SectionReportModel.TextBox textBox1;
		private GrapeCity.ActiveReports.SectionReportModel.ReportInfo reportInfo1;
	}
}
