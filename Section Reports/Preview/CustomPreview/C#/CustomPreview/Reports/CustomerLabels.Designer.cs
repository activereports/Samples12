using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	public partial class CustomerLabels
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLabels));
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			this.lblNorthWind = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTraders = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblAddr1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblAddr2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.linSep1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.txtName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtAddress = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtRegion = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtPostalCode = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCountry = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			((System.ComponentModel.ISupportInitialize)(this.lblNorthWind)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTraders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAddr1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAddr2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRegion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPostalCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCountry)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// lblNorthWind
			// 
			resources.ApplyResources(this.lblNorthWind, "lblNorthWind");
			this.lblNorthWind.Name = "lblNorthWind";
			// 
			// lblTraders
			// 
			resources.ApplyResources(this.lblTraders, "lblTraders");
			this.lblTraders.Name = "lblTraders";
			// 
			// lblAddr1
			// 
			resources.ApplyResources(this.lblAddr1, "lblAddr1");
			this.lblAddr1.Name = "lblAddr1";
			// 
			// lblAddr2
			// 
			resources.ApplyResources(this.lblAddr2, "lblAddr2");
			this.lblAddr2.Name = "lblAddr2";
			// 
			// linSep1
			// 
			resources.ApplyResources(this.linSep1, "linSep1");
			this.linSep1.LineWeight = 2F;
			this.linSep1.Name = "linSep1";
			this.linSep1.X1 = 0.0625F;
			this.linSep1.X2 = 3.1875F;
			this.linSep1.Y1 = 0.625F;
			this.linSep1.Y2 = 0.625F;
			// 
			// txtName
			// 
			this.txtName.CanGrow = false;
			this.txtName.DataField = "CompanyName";
			resources.ApplyResources(this.txtName, "txtName");
			this.txtName.Name = "txtName";
			// 
			// txtAddress
			// 
			this.txtAddress.DataField = "Address";
			resources.ApplyResources(this.txtAddress, "txtAddress");
			this.txtAddress.Name = "txtAddress";
			// 
			// txtCity
			// 
			this.txtCity.CanGrow = false;
			this.txtCity.DataField = "City";
			resources.ApplyResources(this.txtCity, "txtCity");
			this.txtCity.Name = "txtCity";
			// 
			// txtRegion
			// 
			this.txtRegion.CanGrow = false;
			this.txtRegion.DataField = "Region";
			resources.ApplyResources(this.txtRegion, "txtRegion");
			this.txtRegion.Name = "txtRegion";
			// 
			// txtPostalCode
			// 
			this.txtPostalCode.CanGrow = false;
			this.txtPostalCode.DataField = "PostalCode";
			resources.ApplyResources(this.txtPostalCode, "txtPostalCode");
			this.txtPostalCode.Name = "txtPostalCode";
			// 
			// txtCountry
			// 
			this.txtCountry.CanGrow = false;
			this.txtCountry.DataField = "Country";
			resources.ApplyResources(this.txtCountry, "txtCountry");
			this.txtCountry.Name = "txtCountry";
			// 
			// Detail
			// 
			this.Detail.ColumnCount = 2;
			this.Detail.ColumnDirection = GrapeCity.ActiveReports.SectionReportModel.ColumnDirection.AcrossDown;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblNorthWind,
			this.lblTraders,
			this.lblAddr1,
			this.lblAddr2,
			this.linSep1,
			this.txtName,
			this.txtAddress,
			this.txtCity,
			this.txtRegion,
			this.txtPostalCode,
			this.txtCountry});
			this.Detail.Height = 1.462F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// CustomerLabels
			// 
			this.MasterReport = false;
			oleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\NWIND.MDB;Persist Security Info=False";
			oleDBDataSource1.SQL = "Select * from Customers";
			this.DataSource = oleDBDataSource1;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.5F;
			this.Sections.Add(this.Detail);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
			"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			((System.ComponentModel.ISupportInitialize)(this.lblNorthWind)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTraders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAddr1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblAddr2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRegion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPostalCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCountry)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		public GrapeCity.ActiveReports.Data.OleDBDataSource ds = null;
		private Detail Detail;
		private Label lblNorthWind;
		private Label lblTraders;
		private Label lblAddr1;
		private Label lblAddr2;
		private Line linSep1;
		private TextBox txtName;
		private TextBox txtAddress;
		private TextBox txtCity;
		private TextBox txtRegion;
		private TextBox txtPostalCode;
		private TextBox txtCountry;
	}
}
