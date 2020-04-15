using System;
using System.Drawing;
namespace GrapeCity.ActiveReports.Samples.Charting
{
	public partial class rptCandle : GrapeCity.ActiveReports.SectionReport
	{
		public rptCandle()
		{
			//
			// Required for ActiveReport designer support.
			//
			InitializeComponent();
		}
		private void rptCandle_ReportStart(object sender, EventArgs e)
		{
			
			ChartControl.ChartAreas[0].Axes["AxisX"].Labels.Add("Monday");
			ChartControl.ChartAreas[0].Axes["AxisX"].Labels.Add("Tuesday");
			ChartControl.ChartAreas[0].Axes["AxisX"].Labels.Add("Wednesday");
			ChartControl.ChartAreas[0].Axes["AxisX"].Labels.Add("Thursday");
			ChartControl.ChartAreas[0].Axes["AxisX"].Labels.Add("Friday");
			
			
		}
	}
}
