using System.Drawing;
namespace HTML5Viewer.Reports
{
	/// <summary>
	/// Description of rpt2DBar.
	/// 
	/// </summary>
	public partial class rpt2DBar : GrapeCity.ActiveReports.SectionReport
	{
		public rpt2DBar()
		{
			//
			// Required for ActiveReport designer support.
			//
			InitializeComponent();
			
			GrapeCity.ActiveReports.Data.OleDBDataSource dS = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			dS.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["NwindConnectionString"].ConnectionString;
			dS.SQL = "SELECT ShipCountry, SUM(Freight) AS Expr1 FROM Orders GROUP BY ShipCountry";
			ChartControl.DataSource = dS;
		}
	}
}
