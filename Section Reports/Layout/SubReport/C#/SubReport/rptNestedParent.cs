using System;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the rptNestedParent.
	/// 
	/// </summary>
	public partial class rptNestedParent : GrapeCity.ActiveReports.SectionReport
	{
		rptNestedChildMain rpt;
		public rptNestedParent()
		{
			//
			// ActiveReport designer support is required.
			//
			//
			InitializeComponent();
		}
		private void Detail_Format(object sender, EventArgs e)
		{
			subOrders.Report = rpt;
		}
		private void rptNestedParent_ReportStart(object sender, EventArgs e)
		{
			rpt = new rptNestedChildMain();
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;
			dS.SQL = "Select * from employees";
			DataSource = dS;
			
			reportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
			
			
		}
	}
}
