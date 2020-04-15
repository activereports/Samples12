using System;
using System.Data;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the rptDSRelationParent.
	/// 
	/// </summary>
	public partial class rptDSRelationParent : GrapeCity.ActiveReports.SectionReport
	{
		int _cnt;
		rptDSRelationChildMain rpt = null;
		public rptDSRelationParent()
		{
			//
			// ActiveReport designer support is required.
			//
			//
			InitializeComponent();
		   
		}
		private void Detail_Format(object sender, EventArgs e)
		{
			//The tables in DataSet ("Categories") to get the DataRow included.
			//
			//The number of minutes that included DataRow Detail section, this is kept in the output.
			//
			DataRow drCategories = null;
			if (((DataSet)DataSource).Tables["Categories"].Rows.Count > _cnt)
			{
				drCategories = ((DataSet)DataSource).Tables["Categories"].Rows[_cnt];
				_cnt++;
			}
			//Gets an array of child DataRow objects that are associated with the name of that relationship "CategoriesProducts" and sets the DataSource of the sub-report.
			//			
			rpt.DataSource = drCategories.GetChildRows(((DataSet)DataSource).Relations["CategoriesProducts"]);
			SubReport1.Report = rpt;
		}
		private void rptDSRelationParent_ReportStart(object sender, EventArgs e)
		{
			_cnt = 0;
			rpt = new rptDSRelationChildMain();
			
			reportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
			
			
		}
	}
}
