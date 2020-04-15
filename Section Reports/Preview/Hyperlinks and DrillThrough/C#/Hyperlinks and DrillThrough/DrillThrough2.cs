namespace GrapeCity.ActiveReports.Samples.HyperlinksAndDrillThrough
{
	public partial class DrillThrough2 : GrapeCity.ActiveReports.SectionReport
	{
		public DrillThrough2()
		{
			InitializeComponent();
			//Connect to Sample Database
			//
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;
			dS.SQL = "Select * from [order details] where orderID = <%orderID||1%> order by productid";
			DataSource = dS;
		}
	}
}
