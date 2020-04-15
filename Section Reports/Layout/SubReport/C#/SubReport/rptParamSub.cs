using System;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the  rptParamSub.
	/// 
	/// </summary>
	public partial class rptParamSub : GrapeCity.ActiveReports.SectionReport
	{
		public rptParamSub()
		{
			//
			// ActiveReport designer support is required.
			//
			//
			InitializeComponent();
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;			
			dS.SQL = "SELECT * FROM products INNER JOIN categories ON products.categoryid = categories.categoryid WHERE products.supplierID = <%SupplierID%>";
			DataSource = dS;
		}
		private void rptParamSub_ReportStart(object sender, EventArgs e)
		{
			ShowParameterUI = false;
		}
	}
}
