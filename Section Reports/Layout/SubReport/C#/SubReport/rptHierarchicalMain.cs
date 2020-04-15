using System;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// Description of the outline of the rptHierarchicalMain.
	/// 
	/// </summary>
	public partial class rptHierarchicalMain : GrapeCity.ActiveReports.SectionReport
	{
	  
		rptHierarchicalSub _rpt;
		public rptHierarchicalMain()
		{
			//
			// ActiveReport designer support is required
			//
			//
			InitializeComponent();
		   
		}
		private void Detail_Format(object sender, EventArgs e)
		{
			Subreport1.Report = _rpt;		  
		}
		private void rptHierarchicalMain_ReportStart(object sender, EventArgs e)
		{
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ShapeDataConnectionString;
			dS.SQL = "SHAPE {SELECT CustomerID, CompanyName, Address FROM Customers} APPEND ({SELECT CustomerID, OrderID, Freight, OrderDate, EmployeeID FROM Orders} AS CustomerOrders RELATE CustomerID TO CustomerID)";
			DataSource = dS;
		   
			
			reportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
			
			
			 _rpt=new rptHierarchicalSub();
		   
		}
		private void Detail_BeforePrint(object sender, EventArgs e)
		{
			shape1.Height = Detail.Height - .2f;
		}
		private void rptHierarchicalMain_ReportEnd(object sender, EventArgs e)
		{
			shape1.Height = 0;
		}
	}
}
