using System.Drawing;
namespace GrapeCity.ActiveReports.Samples.AnnualReport
{
	public partial class Top10Customers : GrapeCity.ActiveReports.SectionReport
	{
		//Row Count
		private int _iRow;
		
		public Top10Customers()
		{
			InitializeComponent();
		}
		/// <summary>
		/// ReportStart Event
		/// Use this event to initialize any objects or variables needed while running a report.
		/// Also use this event to set any Subreport control objects to a new instance 
		/// of the report assigned to the Subreport control.
		/// </summary>
		private void Top10Customers_ReportStart(object sender, System.EventArgs eArgs)
		{
			//Set row count to 0.
			_iRow = 0;
			
			ChartControl1.Titles[1].Text = "Top 10 customers in 1997";  
			//Create dynamic datasource using sample database
			Data.OleDBDataSource ds = new Data.OleDBDataSource();
			ds.ConnectionString = Properties.Resources.ConnectionString;
			
			ds.SQL = "SELECT TOP 10 Customers.CompanyName, Sum([UnitPrice]*[Quantity]) AS Sales FROM (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID GROUP BY Customers.CompanyName ORDER BY Sum([UnitPrice]*[Quantity]) DESC";
			DataSource = ds;
			ChartControl1.DataSource = ds;
			
			ChartControl1.ChartAreas[0].Axes["AxisY"].LabelFormat = "{0:$#,##0.00}";
			
			
		}
		/// <summary>
		/// Format Event
		/// ActiveReports raises this event after the data is loaded and bound to the controls contained in a section, 
		/// but before the section is rendered to a page.The Format event is the only event in which you can change
		///  the section's height. Use this section to set or change the properties of any controls or the section itself.
		/// Also use the Format event to pass information, such as an SQL String, to a Subreport.
		/// </summary>
		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
			// Check _iRow value to see if we need to highlight the row or not.
			if (_iRow % 2 == 0)
				Detail.BackColor = Color.Transparent;
			else
				Detail.BackColor = Color.LightYellow;
			_iRow++;
			lblRank.Text = _iRow.ToString(System.Globalization.CultureInfo.CurrentCulture);
		}
		/// <summary>
		/// Format Event
		/// ActiveReports raises this event after the data is loaded and bound to the controls contained in a section, 
		/// but before the section is rendered to a page.The Format event is the only event in which you can change
		///  the section's height. Use this section to set or change the properties of any controls or the section itself.
		/// Also use the Format event to pass information, such as an SQL String, to a Subreport.
		/// </summary>
		private void GroupHeader1_Format(object sender, System.EventArgs e)
		{
			//Set the chart's DataSource to the Report's DataSource
			((Data.OleDBDataSource)ChartControl1.DataSource).ConnectionString = ((Data.OleDBDataSource)DataSource).ConnectionString;
		}
	}
}
