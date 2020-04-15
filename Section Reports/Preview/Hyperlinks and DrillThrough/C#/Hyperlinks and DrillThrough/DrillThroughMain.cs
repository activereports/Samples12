namespace GrapeCity.ActiveReports.Samples.HyperlinksAndDrillThrough
{
	public partial class DrillThroughMain : GrapeCity.ActiveReports.SectionReport
	{
		public DrillThroughMain()
		{
			InitializeComponent();
		}
		/// <summary>
		/// DataInitialize Event
		/// Use it to add custom fields to the report's Fields collection. 
		/// Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
		/// or an unbound report (one that does not depend on a data control to get its records).
		/// </summary>
		private void DrillThroughMain_DataInitialize(object sender, System.EventArgs eArgs)
		{
			//Connect to the sample database
		   
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;			
			dS.SQL = "Select * from customers order by customerID";
			DataSource = dS;
		}
		/// <summary>
		/// BeforePrint Event
		/// ActiveReports raises this event before the section is rendered to a page.
		/// Use this event to modify the control's values before printing.
		/// The changes made here do not effect the height of the section.
		/// </summary>
		private void Detail_BeforePrint(object sender, System.EventArgs eArgs)
		{
			//Assign the hyperlink value to the Text value
			txtCustomerID.HyperLink = "DrillThrough1:" + txtCustomerID.Text;
		}
	}
}
