using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the rptBookmarkMain.
	/// 
	/// </summary>
	public partial class rptBookmarkSub : GrapeCity.ActiveReports.SectionReport
	{
		public rptBookmarkSub()
		{
			//
			//ActiveReport designer is required to support
			// 
			//
			InitializeComponent();
		}
		private void Detail_Format(object sender, EventArgs e)
		{
			Detail.AddBookmark(((TextBox)(ParentReport.Sections["Detail"].Controls["txtCategoryName"])).
				Text + "\\" + txtProductName.Text);
		}
	}
}
