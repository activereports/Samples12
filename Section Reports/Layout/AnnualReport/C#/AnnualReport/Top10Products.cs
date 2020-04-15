using System.Drawing;
namespace GrapeCity.ActiveReports.Samples.AnnualReport
{
	public partial class Top10Products : GrapeCity.ActiveReports.SectionReport
	{
		//Row Count
		private int _iRow;
		
		public Top10Products()
		{
			InitializeComponent();
		}
		/// <summary>
		/// ReportStart Event
		/// Use this event to initialize any objects or variables needed while running a report.
		/// Also use this event to set any Subreport control objects to a new instance 
		/// of the report assigned to the Subreport control.
		/// </summary>
		private void Top10Products_ReportStart(object sender, System.EventArgs eArgs)
		{
			//Set row count to 0.
			_iRow = 0;
			
			chtProducts.Titles[1].Text = "Top 10 Products in 1997";
			
			
			Data.OleDBDataSource ds = new Data.OleDBDataSource();
			ds.ConnectionString = Properties.Resources.ConnectionString;
			
			ds.SQL = "SELECT TOP 10 Products.ProductName, Sum([Order Details].[UnitPrice]*[Order Details].[Quantity]) AS Sales FROM Products INNER JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID GROUP BY Products.ProductName ORDER BY Sum([Order Details].[UnitPrice]*[Order Details].[Quantity]) DESC";
			DataSource = ds;
			chtProducts.DataSource = ds;
			
			chtProducts.ChartAreas[0].Axes["AxisY"].LabelFormat = "{0:$#,##0.00}";
			
			
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
				Detail.BackColor = Color.White;
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
		private void GroupHeader1_Format(object sender, System.EventArgs eArgs)
		{
			//Set the chart's data source to the report's data source.
			((Data.OleDBDataSource)chtProducts.DataSource).ConnectionString = ((Data.OleDBDataSource)DataSource).ConnectionString;
		}
	}
}
