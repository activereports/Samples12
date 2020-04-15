using System;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// rptBookmarkMain description overview
	/// 
	/// </summary>
	public partial class rptBookmarkMain : GrapeCity.ActiveReports.SectionReport
	{
		rptBookmarkSub _rpt;
		string _categoryID;
		public rptBookmarkMain()
		{
			//
			// ActiveReport designer support is required.
			//
			//
			InitializeComponent();
		}
		private void rptBookmarkMain_FetchData(object sender, FetchEventArgs eArgs)
		{
			_categoryID = Fields["CategoryID"].Value.ToString();
		}
		private void Detail_Format(object sender, EventArgs e)
		{
			Data.OleDBDataSource subDS = new Data.OleDBDataSource();
			subDS.ConnectionString = ((Data.OleDBDataSource)DataSource).ConnectionString;
			subDS.SQL = "Select * from products where categoryID = " + _categoryID;
			_rpt.DataSource = subDS;
			ctlSubreport.Report = _rpt;
			Detail.AddBookmark(txtCategoryName.Text);
		}
		private void rptBookmarkMain_ReportStart(object sender, EventArgs e)
		{
			_rpt = new rptBookmarkSub();
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;
			dS.SQL = "Select * from categories";
			DataSource = dS;
			
			reportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
			
			
		}
	}
}
