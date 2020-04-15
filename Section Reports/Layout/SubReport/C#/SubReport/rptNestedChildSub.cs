namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the rptNestedChildSub
	/// 
	/// </summary>
	public partial class rptNestedChildSub : GrapeCity.ActiveReports.SectionReport
	{
		public rptNestedChildSub()
		{
			//
			// ActiveReport designer support is required.
			//
			//
			InitializeComponent();
			Data.OleDBDataSource dS = new Data.OleDBDataSource();			
			dS.ConnectionString = Properties.Resources.ConnectionString;			
			dS.SQL = "Select * from customers where customerID = '<%CustomerID%>' ";
			DataSource = dS;
		}
	}
}
