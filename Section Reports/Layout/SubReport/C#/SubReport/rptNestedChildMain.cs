using System;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the  rptNestedChildMain.
	/// 
	/// </summary>
	public partial class rptNestedChildMain : GrapeCity.ActiveReports.SectionReport
	{
		public rptNestedChildMain()
		{
			//
			// ActiveReport designer support is required.
			//
			//
			InitializeComponent();
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;			
			dS.SQL = "Select Top 10 * from orders inner join [order details] on orders.orderID = [order details].orderID where orders.employeeID = <%employeeID%> Order By orders.OrderID";
			DataSource = dS;
		}
		private void rptNestedChildMain_ReportStart(object sender, EventArgs e)
		{
			rptNestedChildSub rpt = new rptNestedChildSub();
			subCustomers.Report = rpt;
		}
	}
}
