using System.Drawing;
using System.Globalization;
namespace GrapeCity.ActiveReports.Samples.CrossTabReport
{
	public partial class ProductWeeklySales : GrapeCity.ActiveReports.SectionReport
	{
		public ProductWeeklySales()
		{
			InitializeComponent();
		}
		/// <summary>
		/// ReportStart Event
		/// Use this event to initialize any objects or variables needed while running a report. 
		/// Also use this event to set any Subreport control objects to a new instance 
		/// of the report assigned to the Subreport control.
		/// </summary>
		private void ProductWeeklySales_ReportStart(object sender, System.EventArgs eArgs)
		{
			//To initalize any custom variables, or set subreport objects to new.
			PageSettings.Orientation = ActiveReports.Document.Section.PageOrientation.Landscape;
			//Set the report variables.
			_iCurrWk = 23;
			_iCurrMth = 6;
			_iCurrQtr = 2;
			
			_iCurrYr = 1996;
			
			
			_iLastYr = _iCurrYr - 1;
		}
		/// <summary>
		/// DataInitialize Event
		/// Use it to add custom fields to the report's Fields collection. 
		/// Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
		/// or an unbound report (one that does not depend on a data control to get its records).
		/// </summary>
		private void ProductWeeklySales_DataInitialize(object sender, System.EventArgs eArgs)
		{
			//Assign report data source to the sample database
			Data.OleDBDataSource ds = new Data.OleDBDataSource();
			ds.ConnectionString = Properties.Resources.ConnectionString;			
			ds.SQL = "SELECT DISTINCTROW Categories.CategoryID, Categories.CategoryName, Products.ProductName, Orders.OrderDate, Sum([Order Details Extended].ExtendedPrice) AS ProductSales, Sum([Order Details Extended].Quantity) AS ProductUnits FROM Categories INNER JOIN (Products INNER JOIN (Orders INNER JOIN [Order Details Extended] ON Orders.OrderID = [Order Details Extended].OrderID) ON Products.ProductID = [Order Details Extended].ProductID) ON Categories.CategoryID = Products.CategoryID GROUP BY Categories.CategoryID, Categories.CategoryName, Products.ProductName, Orders.OrderDate ORDER BY Categories.CategoryName, Products.ProductName";
			DataSource = ds;
			//Add unbound Fields to Fields collection
			Fields.Add("WkUnits");
			Fields.Add("WkSales");
			Fields.Add("MTDUnits");
			Fields.Add("MTDSales");
			Fields.Add("QTDUnits");
			Fields.Add("QTDSales");
			Fields.Add("PQTDSales");
			Fields.Add("YTDUnits");
			Fields.Add("YTDSales");
		}
		/// <summary>
		/// FetchData Event
		/// This event is raised every time a new record is processed.
		/// The FetchData has an EOF parameter indicating whether the FetchData event
		/// should be raised. When working with bound reports (reports using a DataControl), the EOF 
		/// parameter is automatically set by the report; however, when working with unbound
		///  reports this parameter needs to be controlled manually.t
		/// </summary>
		private void ProductWeeklySales_FetchData(object sender, FetchEventArgs eArgs)
		{
			int iWk;
			int iMth;
			int iQtr;
			int iYr;
			System.DateTime dOrderDate;
			double dUnits;
			decimal decSales;
			//Set holder variables
			dOrderDate = (System.DateTime)Fields["OrderDate"].Value;
			dUnits = (double)Fields["ProductUnits"].Value;
			decSales = (decimal)Fields["ProductSales"].Value;
			//Set unbound fields to 0 to initalize them for the row
			Fields["WkUnits"].Value = 0;
			Fields["WkSales"].Value = 0;
			Fields["MTDUnits"].Value = 0;
			Fields["MTDSales"].Value = 0;
			Fields["QTDUnits"].Value = 0;
			Fields["QTDSales"].Value = 0;
			Fields["PQTDSales"].Value = 0;
			Fields["YTDUnits"].Value = 0;
			Fields["YTDSales"].Value = 0;
			
			CultureInfo c = new CultureInfo("en-US");
			
			
			//Set the week and month values from the current active row.
			iWk = c.Calendar.GetWeekOfYear(dOrderDate, CalendarWeekRule.FirstDay, System.DayOfWeek.Sunday);
			iMth = dOrderDate.Month;
			//Set the current quarter for the active database row.
			if (iWk <= 13)
				iQtr = 1;
			else if (iWk <= 26)
				iQtr = 2;
			else if (iWk <= 39)
				iQtr = 3;
			else
				iQtr = 4;
			iYr = dOrderDate.Year;
			//Set Field values according to the data calculated.
			if (iWk == _iCurrWk && iYr == _iCurrYr)
			{
				//Set the footer fields data values
				Fields["WkUnits"].Value = dUnits;
				Fields["WkSales"].Value = decSales;
			}
			if (iMth == _iCurrMth && iYr == _iCurrYr)
			{
				Fields["MTDUnits"].Value = dUnits;
				Fields["MTDSales"].Value = decSales;
			}
			if (iQtr == _iCurrQtr && iYr == _iCurrYr)
			{
				Fields["QTDUnits"].Value = dUnits;
				Fields["QTDSales"].Value = decSales;
			}
			if (iQtr == _iCurrQtr && iYr == _iCurrYr - 1)
			{
				Fields["PQTDSales"].Value = decSales;
			}
			if (iYr == _iCurrYr)
			{
				Fields["YTDUnits"].Value = dUnits;
				Fields["YTDSales"].Value = decSales;
			}
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
			//Assign current product name to holder.
			_sProductName = txtDetProduct.Text;
		}
		private void gfCategory_Format(object sender, System.EventArgs eArgs)
		{
			txtCatPQTDChange.Value = (double)txtCatQTDSales.Value - (double)txtCatPQTDSales.Value;
			//If value is negative, highlight in red
			if ((double)txtCatPQTDChange.Value < 0)
				txtCatPQTDChange.BackColor = Color.Red;
			else
				txtCatPQTDChange.BackColor = Color.Transparent;
		}
		/// <summary>
		/// Format Event
		/// ActiveReports raises this event after the data is loaded and bound to the controls contained in a section, 
		/// but before the section is rendered to a page.The Format event is the only event in which you can change
		///  the section's height. Use this section to set or change the properties of any controls or the section itself.
		/// Also use the Format event to pass information, such as an SQL String, to a Subreport.
		/// </summary>
		private void gfProduct_Format(object sender, System.EventArgs eArgs)
		{
			//Assign product name from holder
			txtProduct.Text = _sProductName;
			txtPQTDChange.Value = (double)txtQTDSales.Value - (double)txtPQTDSales.Value;
			//If value is negative, highlight in red
			if ((double)txtPQTDChange.Value < 0)
				txtPQTDChange.BackColor = Color.Red;
			else
				txtPQTDChange.BackColor = Color.Transparent;
		}
	}
}
