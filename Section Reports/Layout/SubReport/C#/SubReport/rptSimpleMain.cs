using System;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the rptSimpleMain.
	/// 
	/// </summary>
	public partial class rptSimpleMain : GrapeCity.ActiveReports.SectionReport
	{
		rptSimpleSub _rpt;
		string _categoryID;
		public rptSimpleMain()
		{
			//
			// ActiveReport designer support is required.
			// 
			//
			InitializeComponent();
		}
		private void rptSimpleMain_FetchData(object sender, FetchEventArgs eArgs)
		{
			// Gets the criteria for data to be output to the sub report.
			// 
			_categoryID = Fields["CategoryID"].Value.ToString();
		}
		private void Detail_Format(object sender, EventArgs e)
		{
			//SQL statement to set the connection string for the data source of the subreport.
			//
		 
			Data.OleDBDataSource subDS = new Data.OleDBDataSource();
			subDS.ConnectionString = ((Data.OleDBDataSource)(DataSource)).ConnectionString;
			subDS.SQL = "SELECT * FROM products WHERE categoryID = " + _categoryID;
			_rpt.DataSource = subDS;
			ctlSubreport.Report = _rpt;
			//Sets the sub-report object to the subreport control.
			// 
		}
		private void rptSimpleMain_ReportStart(object sender, EventArgs e)
		{
			_rpt = new rptSimpleSub();
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;			
			dS.SQL = "Select * from categories";
			DataSource = dS;
			
			reportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
			
			
		}
	}
}
