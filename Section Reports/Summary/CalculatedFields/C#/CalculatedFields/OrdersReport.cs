using System;
using System.Globalization;
namespace GrapeCity.ActiveReports.Samples.CalculatedFields
{
	public partial class OrdersReport : GrapeCity.ActiveReports.SectionReport
	{
		public OrdersReport()
		{
			InitializeComponent();
		}
		/// <summary>
		/// DataInitialize Event
		/// Use it to add custom fields to the report's Fields collection. 
		/// Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
		/// or an unbound report (one that does not depend on a data control to get its records).
		/// </summary>
		private void OrdersReport_DataInitialize(object sender, EventArgs eArgs)
		{
			((Data.OleDBDataSource)DataSource).ConnectionString = Properties.Resources.ConnectionString;			
			Fields.Add("ExtendedPrice");
		}
		
		//<summary>
		// FetchData Event
		// This event is raised every time a new record is processed. The FetchData has an EOF parameter 
		// indicating whether the FetchData event should be raised.　When working with bound reports (reports using a DataControl), 
		// the EOF parameter is automatically set by the report; however, when working with unbound reports 
		// this parameter needs to be controlled manually.
		// </summary>
		private void OrdersReport_FetchData(object sender, FetchEventArgs eArgs)
		{
			// Gather the value to be calculated from the bound data base.
			double quantity = Convert.ToDouble(Fields["Quantity"].Value, CultureInfo.CurrentCulture);
			double unitPrice = Convert.ToDouble(Fields["UnitPrice"].Value, CultureInfo.CurrentCulture);
			double discount = Convert.ToDouble(Fields["Discount"].Value, CultureInfo.CurrentCulture);
			// Perform the calculation for the calculated field.
			Fields["ExtendedPrice"].Value = ((quantity * unitPrice) - (quantity * unitPrice * discount));
		}
	}
}
