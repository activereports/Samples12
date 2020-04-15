namespace GrapeCity.ActiveReports.Samples.AnnualReport
{
	public partial class Top10 : GrapeCity.ActiveReports.SectionReport
	{
		public Top10()
		{
			InitializeComponent();
		}
		/// <summary>
		/// ReportStart Event
		/// Use this event to initialize any objects or variables needed while running a report.
		/// Also use this event to set any Subreport control objects to a new instance 
		/// of the report assigned to the Subreport control.
		/// </summary>
		private void Top10_ReportStart(object sender, System.EventArgs eArgs)
		{
			srptTop10Products.Report = new Top10Products();
			srptTop10Customers.Report = new Top10Customers();
		}
	}
}
