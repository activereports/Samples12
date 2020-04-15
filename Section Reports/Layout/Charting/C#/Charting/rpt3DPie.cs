using System;
using System.Drawing;
namespace GrapeCity.ActiveReports.Samples.Charting
{
	public partial class rpt3DPie : GrapeCity.ActiveReports.SectionReport
	{
		//  Variable for setting the direction of rotation.
		public bool boClockWise = true; //(True:Clockwise, False:anti-clockwise) 
		
		public rpt3DPie()
		{
			//
			// Required for ActiveReport designer support.
			//
			InitializeComponent();
			
		}
		private void rpt3DPie_ReportStart(object sender, EventArgs e)
		{
			// Set the data source in the chart.
			System.Data.DataTable dt = new System.Data.DataTable();
			// Change the datasource path if required.
			string constr = Properties.Resources.ConnectionString;
			   
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("SELECT DISTINCTROW Categories.CategoryName, ");
			sb.Append("Sum(CCur([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100) AS ProductSales, ");
			sb.Append("Employees.EmployeeID FROM Employees INNER JOIN ((Categories INNER JOIN Products ");
			sb.Append("ON Categories.CategoryID = Products.CategoryID) INNER JOIN ");
			sb.Append("(Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ");
			sb.Append("ON Products.ProductID = [Order Details].ProductID) ");
			sb.Append("ON Employees.EmployeeID = Orders.EmployeeID ");
			sb.Append("WHERE (((Orders.ShippedDate) Between #1/1/1995# And #12/31/1995#)) ");
			sb.Append("GROUP BY Categories.CategoryName, Employees.EmployeeID HAVING Employees.EmployeeID = 1");
			using (System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection(constr))
			{
				System.Data.OleDb.OleDbDataAdapter adp = new System.Data.OleDb.OleDbDataAdapter(sb.ToString(), conn);
				conn.Open();
				adp.Fill(dt);
				conn.Close();
			}
			ChartSalesCategories.DataSource = dt;
			// Set the direction of rotation.
			ChartSalesCategories.Series[0].Properties["Clockwise"] = boClockWise;
		}
	}
}
