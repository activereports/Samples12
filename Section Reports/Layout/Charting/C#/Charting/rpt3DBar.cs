using System;
using System.Drawing;
namespace GrapeCity.ActiveReports.Samples.Charting
{
	public partial class rpt3DBar : GrapeCity.ActiveReports.SectionReport
	{
		public rpt3DBar()
		{
			//
			// Required for ActiveReport designer support.
			//
			InitializeComponent();
			
		}
		private void rpt3DBar_ReportStart(object sender, EventArgs e)
		{
			// Create a series.
			Chart.Series s = new Chart.Series();
			s.Type = Chart.ChartType.Bar3D;
			// If the path of the mdb is different, please change below.
			string m_cnnString = Properties.Resources.ConnectionString;
			
			System.Data.OleDb.OleDbDataAdapter oDBAdapter;
			// Create a DataSet.
			System.Data.DataSet oDS;
			oDBAdapter = new System.Data.OleDb.OleDbDataAdapter("SELECT * from Orders WHERE OrderDate < #08/17/1994#", m_cnnString);
			oDS = new System.Data.DataSet();
			oDBAdapter.Fill(oDS, "Orders");
			// Setting each of the properties for DataSource, ValueMembersY and ValueMembersX.
			ChartControl1.DataSource = oDS;
			ChartControl1.Series.Add(s);
			ChartControl1.Series[0].ValueMembersY = oDS.Tables["Orders"].Columns[7].ColumnName;
			ChartControl1.Series[0].ValueMemberX = oDS.Tables["Orders"].Columns[8].ColumnName;
			// Set the angle on the label to avoid overlapping.
			ChartControl1.ChartAreas[0].Axes[0].LabelFont.Angle = -90;
		}
	}
}
