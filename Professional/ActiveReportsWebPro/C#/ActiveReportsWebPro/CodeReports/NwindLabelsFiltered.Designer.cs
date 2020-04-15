namespace GrapeCity.ActiveReports.Samples.Web.Professional.CodeReports
{
	/// <summary>
	/// Summary description for NwindLabelsFiltered.
	/// </summary>
	partial class NwindLabelsFiltered
	{
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
			}
			base.Dispose(disposing);
		}
		#region ActiveReport Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NwindLabelsFiltered));
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
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			// 
			// lblNorthWind
			// 
			resources.ApplyResources(this.lblNorthWind, "lblNorthWind");
			this.lblNorthWind.Name = "lblNorthWind";
			// 
			// lblTraders
			// 
			this.lblTraders.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTraders.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.ThickSolid;
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
			this.Detail.ColumnSpacing = 0F;
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
			this.Detail.Height = 1.487F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// PageHeader
			// 
			this.PageHeader.CanGrow = false;
			this.PageHeader.Height = 0F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.CanGrow = false;
			this.PageFooter.Height = 0.25F;
			this.PageFooter.Name = "PageFooter";
			// 
			// NwindLabelsFiltered
			// 
			this.MasterReport = false;
			oleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\Nwind.mdb;Persist Security Info=False";
			oleDBDataSource1.SQL = "Select * From Customers WHERE Country=\'<%Country|Country:||S%>\'";
			this.DataSource = oleDBDataSource1;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.5F;
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 186", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold; font-style: italic; ddo-char-set: 186", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 186", "Heading3", "Normal"));
		}
		#endregion
		private SectionReportModel.Detail Detail;
		private SectionReportModel.Label lblNorthWind;
		private SectionReportModel.Label lblTraders;
		private SectionReportModel.Label lblAddr1;
		private SectionReportModel.Label lblAddr2;
		private SectionReportModel.Line linSep1;
		private SectionReportModel.TextBox txtName;
		private SectionReportModel.TextBox txtAddress;
		private SectionReportModel.TextBox txtCity;
		private SectionReportModel.TextBox txtRegion;
		private SectionReportModel.TextBox txtPostalCode;
		private SectionReportModel.TextBox txtCountry;
		private SectionReportModel.PageHeader PageHeader;
		private SectionReportModel.PageFooter PageFooter;
	}
}
