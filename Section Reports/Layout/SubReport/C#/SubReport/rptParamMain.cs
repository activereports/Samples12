using System;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the rptParamMain
	/// 
	/// </summary>
	public partial class rptParamMain : GrapeCity.ActiveReports.SectionReport
	{
		rptParamSub _rpt;
		public rptParamMain()
		{
			//
			// ActiveReport designer support is required
			//
			//
			InitializeComponent();
		}
		private void Detail_Format(object sender, EventArgs e)
		{
			SubReport1.Report = _rpt;
		}
		private void rptParamMain_ReportStart(object sender, EventArgs e)
		{
			_rpt = new rptParamSub();
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;			
			dS.SQL = "Select * from suppliers order by country";
			DataSource = dS;
			
			reportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
			
			
		}
	}
}
