namespace GrapeCity.ActiveReports.Samples.AnnualReport
{
	public partial class AnnualReport : GrapeCity.ActiveReports.SectionReport
	{
		public AnnualReport()
		{
			InitializeComponent();
		}
		/// <summary>
		/// ReportStart Event
		/// Use this event to initialize any objects or variables needed while running a report.
		/// Also use this event to set any Subreport control objects to a new instance 
		/// of the report assigned to the Subreport control.
		/// </summary>
		private void AnnualReport_ReportStart(object sender, System.EventArgs eArgs)
		{
			//Set subreport control's Report property to a new report instance.
			srptTop10.Report = new Top10();
			srptProductSales.Report = new ProductSalesByCategory();
		}
	}
}
