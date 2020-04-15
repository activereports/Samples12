using System;
using System.Collections;
namespace GrapeCity.ActiveReports.Samples.DataFieldExpressions
{
	public partial class DataFieldExpressionsReport : GrapeCity.ActiveReports.SectionReport
	{
		private int _index;
		private ArrayList _details;
		public DataFieldExpressionsReport()
		{
			InitializeComponent();		   
		}
		
		/// <summary>
		/// DataInitialize Event
		/// Use it to add custom fields to the report's Fields collection. 
		/// Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
		/// or an unbound report (one that does not depend on a data control to get its records).
		/// </summary>
		private void DataFieldExpressions_DataInitialize(object sender, System.EventArgs eArgs)
		{
			Fields.Add("ProductName");
			Fields.Add("UnitPrice");
			Fields.Add("Quantity");			
		}
		/// <summary>
		/// 
		/// FetchData Event
		/// This event is raised every time a new record is processed. 
		/// The FetchData has an EOF parameter indicating whether the FetchData event 
		/// should be raised. When working with bound reports (reports using a DataControl), 
		/// the EOF parameter is automatically set by the report; however, when working with 
		/// unbound reports this parameter needs to be controlled manually.
		/// 
		/// 
		/// </summary>
		private void DataFieldExpressions_FetchData(object sender, FetchEventArgs eArgs)
		{
			if (_index >= _details.Count - 1)
			{
				eArgs.EOF = true;
				return;
			}
			else
			{
				eArgs.EOF = false;
			}
			OrderDetail row = (OrderDetail)_details[++_index];
			Fields["ProductName"].Value = row.productName;
			Fields["UnitPrice"].Value = row.unitPrice;
			Fields["Quantity"].Value = row.quantity;
		}
		/// <summary>
		/// 
		/// ReportStart event
		/// This event is raised every time when report to be start.
		/// 
		/// 
		/// </summary>		
		void DataFieldExpressionsReport_ReportStart(object sender, EventArgs e)
		{
			// Test data
			_details = new ArrayList();
			_details.Add(new OrderDetail("A", 10.00, 2));
			_details.Add(new OrderDetail("B", 0.12, 1));
			_details.Add(new OrderDetail("C", 5.92, 3));
			_index = -1;
		}
	}
}
