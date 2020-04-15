using System.Drawing;
namespace GrapeCity.ActiveReports.Samples.AnnualReport
{
	public partial class ProductSalesByCategory : GrapeCity.ActiveReports.SectionReport
	{
		//Row Count
		private int _iRow;
		
		public ProductSalesByCategory()
		{
			InitializeComponent();
		}
		/// <summary>
		/// ReportStart Event
		/// Use this event to initialize any objects or variables needed while running a report.
		/// Also use this event to set any Subreport control objects to a new instance 
		/// of the report assigned to the Subreport control.
		/// </summary>
		private void ProductSalesByCategory_ReportStart(object sender, System.EventArgs eArgs)
		{
			//Set row count to 0.
			_iRow = 0;
		}
		/// <summary>
		/// DataInitialize Event
		/// Use it to add custom fields to the report's Fields collection. 
		/// Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
		/// or an unbound report (one that does not depend on a data control to get its records).
		/// </summary>
		private void ProductSalesByCategory_DataInitialize(object sender, System.EventArgs eArgs)
		{
			//Create dynamic datasource using sample database
			Data.OleDBDataSource ds = new Data.OleDBDataSource();
			ds.ConnectionString = Properties.Resources.ConnectionString;
			
			ds.SQL = "SELECT DISTINCTROW Categories.CategoryName, Sum([Order Details Extended].ExtendedPrice) AS ProductSales FROM Categories INNER JOIN (Products INNER JOIN (Orders INNER JOIN [Order Details Extended] ON Orders.OrderID = [Order Details Extended].OrderID) ON Products.ProductID = [Order Details Extended].ProductID) ON Categories.CategoryID = Products.CategoryID WHERE (((Orders.OrderDate) Between #1/1/95# And #12/31/95#)) GROUP BY Categories.CategoryName ORDER BY Categories.CategoryName";
			DataSource = ds;
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
				Detail.BackColor = Color.LightYellow;
			else
				Detail.BackColor = Color.Transparent;
			_iRow++;
		}
	}
}
