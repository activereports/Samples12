namespace GrapeCity.ActiveReports.Samples.XML
{
	public partial class CustomersOrders : GrapeCity.ActiveReports.SectionReport
	{
		public CustomersOrders()
		{
			InitializeComponent();
		}
		/// <summary>
		/// ReportStart Event
		/// Use this event to initialize any objects or variables needed while running a report. 
		/// Also use this event to set any Subreport control objects to a new instance 
		/// of the report assigned to the Subreport control.
		/// </summary>
		private void CustomersOrders_ReportStart(object sender, System.EventArgs eArgs)
		{
			//Create the subrepot in this event instead of  
			//setting it in the Detail Format Event everytime. 
			srptOrders.Report = new Orders();
		}
	}
}
