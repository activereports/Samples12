using System.Drawing;
namespace GrapeCity.ActiveReports.Samples.Charting
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
			
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;			
			dS.SQL = "SELECT ShipCountry, SUM(Freight) AS Expr1 FROM Orders GROUP BY ShipCountry";
			ChartControl.DataSource = dS;
		}
	}
}
