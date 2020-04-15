using System;
using System.Data;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the rptDSRelationChildMain.
	/// 
	/// </summary>
	public partial class rptDSRelationChildMain : GrapeCity.ActiveReports.SectionReport
	{
		rptDSRelationChildSub _rpt;
		int _cnt;
		public rptDSRelationChildMain()
		{
			//
			// ActiveReport Designer support is required.
			// 
			//
			InitializeComponent();
		}
		private void Detail_Format(object sender, EventArgs e)
		{
			DataRow[] drc = ((DataRow[])DataSource);
			//Gets an array of child DataRow objects that are associated with the name of the relationship "ProductsOrderDetails" and set the DataSource of the sub-report.
			//
			_rpt.DataSource = drc[_cnt].GetChildRows("ProductsOrderDetails");
			SubReport1.Report = _rpt;
			_cnt++;
		}
		private void rptDSRelationChildMain_ReportStart(object sender, EventArgs e)
		{
			_cnt = 0;
			_rpt = new rptDSRelationChildSub();
		   
		}
	}
}
