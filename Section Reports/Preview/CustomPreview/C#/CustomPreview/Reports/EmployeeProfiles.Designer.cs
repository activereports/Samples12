using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	public partial class EmployeeProfiles
	{
  protected override void Dispose(bool disposing)
	{
	if (disposing)
	  {
	  }
	base.Dispose(disposing);
	}
	  
		#region ActiveReports Designer generated code
	   
	   
		
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeProfiles));
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			this.txtEmployeeID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtTitle = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtHireDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtAddress = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtRegion = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtPostalCode = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCountry = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtHomePhone = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtExtension = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtNotes = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblTitle2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblAddress = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblCityRegion = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblPostalCode = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblCountry = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblExtension = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblHomePhone = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblHireDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblNotes = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblBirthDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtBirthDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtDescription = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.picture1 = new GrapeCity.ActiveReports.SectionReportModel.Picture();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			((System.ComponentModel.ISupportInitialize)(this.txtEmployeeID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHireDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRegion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPostalCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCountry)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHomePhone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExtension)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTitle2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCityRegion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPostalCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCountry)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblExtension)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblHomePhone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblHireDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNotes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBirthDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBirthDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// txtEmployeeID
			// 
			this.txtEmployeeID.DataField = "EmployeeID";
			resources.ApplyResources(this.txtEmployeeID, "txtEmployeeID");
			this.txtEmployeeID.Name = "txtEmployeeID";
			// 
			// txtTitle
			// 
			this.txtTitle.DataField = "Title";
			resources.ApplyResources(this.txtTitle, "txtTitle");
			this.txtTitle.Name = "txtTitle";
			// 
			// txtHireDate
			// 
			this.txtHireDate.DataField = "HireDate";
			resources.ApplyResources(this.txtHireDate, "txtHireDate");
			this.txtHireDate.Name = "txtHireDate";
			// 
			// txtAddress
			// 
			this.txtAddress.DataField = "Address";
			resources.ApplyResources(this.txtAddress, "txtAddress");
			this.txtAddress.Name = "txtAddress";
			// 
			// txtCity
			// 
			this.txtCity.DataField = "City";
			resources.ApplyResources(this.txtCity, "txtCity");
			this.txtCity.Name = "txtCity";
			// 
			// txtRegion
			// 
			this.txtRegion.DataField = "Region";
			resources.ApplyResources(this.txtRegion, "txtRegion");
			this.txtRegion.Name = "txtRegion";
			// 
			// txtPostalCode
			// 
			this.txtPostalCode.DataField = "PostalCode";
			resources.ApplyResources(this.txtPostalCode, "txtPostalCode");
			this.txtPostalCode.Name = "txtPostalCode";
			// 
			// txtCountry
			// 
			this.txtCountry.DataField = "Country";
			resources.ApplyResources(this.txtCountry, "txtCountry");
			this.txtCountry.Name = "txtCountry";
			// 
			// txtHomePhone
			// 
			this.txtHomePhone.DataField = "HomePhone";
			resources.ApplyResources(this.txtHomePhone, "txtHomePhone");
			this.txtHomePhone.Name = "txtHomePhone";
			// 
			// txtExtension
			// 
			this.txtExtension.DataField = "Extension";
			resources.ApplyResources(this.txtExtension, "txtExtension");
			this.txtExtension.Name = "txtExtension";
			// 
			// txtNotes
			// 
			this.txtNotes.DataField = "Notes";
			resources.ApplyResources(this.txtNotes, "txtNotes");
			this.txtNotes.Name = "txtNotes";
			// 
			// lblTitle2
			// 
			resources.ApplyResources(this.lblTitle2, "lblTitle2");
			this.lblTitle2.Name = "lblTitle2";
			this.lblTitle2.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
			// 
			// lblAddress
			// 
			resources.ApplyResources(this.lblAddress, "lblAddress");
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
			// 
			// lblCityRegion
			// 
			resources.ApplyResources(this.lblCityRegion, "lblCityRegion");
			this.lblCityRegion.Name = "lblCityRegion";
			this.lblCityRegion.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
			// 
			// lblPostalCode
			// 
			resources.ApplyResources(this.lblPostalCode, "lblPostalCode");
			this.lblPostalCode.Name = "lblPostalCode";
			this.lblPostalCode.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
			// 
			// lblCountry
			// 
			resources.ApplyResources(this.lblCountry, "lblCountry");
			this.lblCountry.Name = "lblCountry";
			this.lblCountry.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
			// 
			// lblExtension
			// 
			resources.ApplyResources(this.lblExtension, "lblExtension");
			this.lblExtension.Name = "lblExtension";
			this.lblExtension.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
			// 
			// lblHomePhone
			// 
			resources.ApplyResources(this.lblHomePhone, "lblHomePhone");
			this.lblHomePhone.Name = "lblHomePhone";
			this.lblHomePhone.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
			// 
			// lblHireDate
			// 
			resources.ApplyResources(this.lblHireDate, "lblHireDate");
			this.lblHireDate.Name = "lblHireDate";
			this.lblHireDate.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
			// 
			// lblNotes
			// 
			resources.ApplyResources(this.lblNotes, "lblNotes");
			this.lblNotes.Name = "lblNotes";
			this.lblNotes.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
			// 
			// lblID
			// 
			resources.ApplyResources(this.lblID, "lblID");
			this.lblID.Name = "lblID";
			// 
			// lblBirthDate
			// 
			resources.ApplyResources(this.lblBirthDate, "lblBirthDate");
			this.lblBirthDate.Name = "lblBirthDate";
			this.lblBirthDate.Padding = new GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0);
			// 
			// txtBirthDate
			// 
			this.txtBirthDate.DataField = "BirthDate";
			resources.ApplyResources(this.txtBirthDate, "txtBirthDate");
			this.txtBirthDate.Name = "txtBirthDate";
			// 
			// txtName
			// 
			this.txtName.DataField = "Name";
			resources.ApplyResources(this.txtName, "txtName");
			this.txtName.Name = "txtName";
			// 
			// lblTitle
			// 
			resources.ApplyResources(this.lblTitle, "lblTitle");
			this.lblTitle.Name = "lblTitle";
			// 
			// txtDescription
			// 
			resources.ApplyResources(this.txtDescription, "txtDescription");
			this.txtDescription.Name = "txtDescription";
			// 
			// picture1
			// 
			this.picture1.DataField = "Photo";
			resources.ApplyResources(this.picture1, "picture1");
			this.picture1.ImageData = null;
			this.picture1.Name = "picture1";
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtEmployeeID,
			this.txtTitle,
			this.txtHireDate,
			this.txtAddress,
			this.txtCity,
			this.txtRegion,
			this.txtPostalCode,
			this.txtCountry,
			this.txtHomePhone,
			this.txtExtension,
			this.txtNotes,
			this.lblTitle2,
			this.lblAddress,
			this.lblCityRegion,
			this.lblPostalCode,
			this.lblCountry,
			this.lblExtension,
			this.lblHomePhone,
			this.lblHireDate,
			this.lblNotes,
			this.lblID,
			this.lblBirthDate,
			this.txtBirthDate,
			this.txtName,
			this.picture1});
			this.Detail.Height = 2.575333F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.BeforePrint += new System.EventHandler(this.Detail_BeforePrint);
			// 
			// PageHeader
			// 
			this.PageHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblTitle,
			this.txtDescription});
			this.PageHeader.Height = 0.5625F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.CanGrow = false;
			this.PageFooter.Height = 0F;
			this.PageFooter.Name = "PageFooter";
			// 
			// EmployeeProfiles
			// 
			this.MasterReport = false;
			oleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\NWIND.MDB";
			oleDBDataSource1.SQL = "SELECT * FROM employees ORDER BY LastName, FirstName";
			this.DataSource = oleDBDataSource1;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
			"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			this.FetchData += new GrapeCity.ActiveReports.SectionReport.FetchEventHandler(this.EmployeeProfiles_FetchData);
			this.ReportStart += new System.EventHandler(this.EmployeeProfiles_ReportStart);
			this.DataInitialize += new System.EventHandler(this.EmployeeProfiles_DataInitialize);
			((System.ComponentModel.ISupportInitialize)(this.txtEmployeeID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTitle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHireDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRegion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPostalCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCountry)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHomePhone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExtension)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTitle2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCityRegion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPostalCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblCountry)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblExtension)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblHomePhone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblHireDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNotes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBirthDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBirthDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		private Detail Detail;
		private TextBox txtEmployeeID;
		private TextBox txtTitle;
		private TextBox txtHireDate;
		private TextBox txtAddress;
		private TextBox txtCity;
		private TextBox txtRegion;
		private TextBox txtPostalCode;
		private TextBox txtCountry;
		private TextBox txtHomePhone;
		private TextBox txtExtension;
		private TextBox txtNotes;
		private Label lblTitle2;
		private Label lblAddress;
		private Label lblCityRegion;
		private Label lblPostalCode;
		private Label lblCountry;
		private Label lblExtension;
		private Label lblHomePhone;
		private Label lblHireDate;
		private Label lblNotes;
		private Label lblID;
		private Label lblBirthDate;
		private TextBox txtBirthDate;
		private TextBox txtName;
		private PageHeader PageHeader;
		private Label lblTitle;
		private TextBox txtDescription;
		private Picture picture1;
		private PageFooter PageFooter;
		public GrapeCity.ActiveReports.Data.OleDBDataSource ds = null;
	}
}
