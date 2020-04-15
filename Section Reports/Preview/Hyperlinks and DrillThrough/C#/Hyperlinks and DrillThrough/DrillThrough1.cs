namespace GrapeCity.ActiveReports.Samples.HyperlinksAndDrillThrough
{
	public partial class DrillThrough1 : GrapeCity.ActiveReports.SectionReport
	{
		public DrillThrough1()
		{
			InitializeComponent();
			//Connect to Sample Database
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;
			dS.SQL = "Select * from orders where customerID = '<%customerID%>' order by orderdate";
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
			//
			txtOrderID.HyperLink = "DrillThrough2:" + txtOrderID.Text;
		}
	}
}
