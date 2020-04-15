using System;
using System.Data;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the rptUnboundDSMain.
	/// 
	/// </summary>
	public partial class rptUnboundDSMain : GrapeCity.ActiveReports.SectionReport
	{
		rptUnboundDSSub _rpt;
		public rptUnboundDSMain()
		{
			//
			// ActiveReport designer support is required.
			//
			//
			InitializeComponent();
		}
		private void Detail_Format(object sender, EventArgs e)
		{
			// Create a DataView from the Orders table in the DataSet.
			//
			DataSet ds = new DataSet();
			ds = (DataSet)DataSource;
			DataView dv = new DataView(ds.Tables["Orders"]);
			dv.RowFilter = "CustomerID='" + TextBox1.Text + "'";
			// Orders data to bind to the report.
			//
		
			_rpt.DataSource = dv;
		   
			// Show the Orders report in the SubReport1 control.
			//
			SubReport1.Report = _rpt;
		}
		private void rptUnboundDSMain_ReportStart(object sender, EventArgs e)
		{
			_rpt = new rptUnboundDSSub();
			
			reportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
			
			
		}
	}
}
