namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the  rptMasterSub.
	/// 
	/// </summary>
	public partial class rptMasterSub : GrapeCity.ActiveReports.SectionReport
	{
		public rptMasterSub()
		{
			//
			// ActiveReport designer support is required
			//
			//
			InitializeComponent();
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;
			dS.SQL = "Select * from [order details] inner join products on [order details].productid = products.productID where [order details].orderID = <%OrderID%>";
			DataSource = dS;
		}
	}
}
