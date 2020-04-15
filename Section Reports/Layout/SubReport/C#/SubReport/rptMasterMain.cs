using System;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the  rptMasterMain.
	/// 
	/// </summary>
	public partial class rptMasterMain : GrapeCity.ActiveReports.SectionReport
	{
		rptMasterSub _rpt;
		public rptMasterMain()
		{
			//
			// ActiveReport designer support is required
			//
			//
			InitializeComponent();
		}
		private void Detail_Format(object sender, EventArgs e)
		{
			ctlSubreport.Report = _rpt;
		}
		private void rptMasterMain_ReportStart(object sender, EventArgs e)
		{
			_rpt = new rptMasterSub();
			
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;			
			dS.SQL = "Select top 50 * from orders";
			DataSource = dS;
			
			reportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
			
			
		}
	}
}
