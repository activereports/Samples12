using System;
using System.Data.OleDb;
using System.Globalization;
namespace GrapeCity.ActiveReports.Samples.UnboundData
{
	public partial class UnboundDRInvoice : GrapeCity.ActiveReports.SectionReport
	{
		public UnboundDRInvoice()
		{
			InitializeComponent();
		}
		OleDbConnection _nwindConn;
		//DataReader to use to read the data.
		OleDbDataReader _InvoiceDataReader;
		/// <summary>
		/// DataInitialize Event
		/// Use it to add custom fields to the report's Fields collection. 
		/// Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
		/// or an unbound report (one that does not depend on a data control to get its records).
		/// </summary>
		private void Invoice_DataInitialize(object sender, EventArgs eArgs)
		{
			
			//Add all the columns from the database as fields for the report.
			for (int i = 0; i < _InvoiceDataReader.FieldCount; i++)
			{
				Fields.Add(_InvoiceDataReader.GetName(i));
			}
			//Add calculated fields
			Fields.Add("DiscountTotal");
		}
		/// <summary>
		/// FetchData Event
		/// This event is raised every time a new record is processed. The FetchData has an EOF parameter
		/// indicating whether the FetchData event should be raised.  When working with bound 
		/// reports (reports using a DataControl), the EOF parameter is automatically set by the report;
		/// however, when working with unbound reports this parameter needs to be controlled manually.
		/// </summary>
		private void Invoice_FetchData(object sender, FetchEventArgs eArgs)
		{
			if (!_InvoiceDataReader.Read())
			{
				//If the reader has reached the end of the data then
				//set the eArgs.EOF flag to true and exit the procedure.
				eArgs.EOF = true;
				return;
			}
			else
			{
				//Populate the fields collection from the DataReader.
				for (int i = 0; i < _InvoiceDataReader.FieldCount; i++)
				{
					Fields[_InvoiceDataReader.GetName(i)].Value = _InvoiceDataReader[i];
				}
				//Add unbound DiscountTotal field total to instance of the Fields collection (for data binding and summary totaling in the group footer.)
				Fields["DiscountTotal"].Value =
				   Convert.ToDouble(Fields["UnitPrice"].Value, CultureInfo.CurrentCulture) *
				   Convert.ToInt32(Fields["Quantity"].Value, CultureInfo.InvariantCulture) *
				   Convert.ToDouble(Fields["Discount"].Value, CultureInfo.CurrentCulture);
				//Set eArgs to false.
				eArgs.EOF = false;
			}
		}
		/// <summary>
		/// ReportEnd Event
		/// This event is raised after the report finishes processing. Use this event to 
		/// close or free any objects that you were using while running a report in unbound mode,
		/// or to display information or messages to the end user. This
		/// event can also be used to export reports.
		/// </summary>
		private void UnboundDRInvoice_UnboundDSInvoice_ReportEnd(object sender, EventArgs eArgs)
		{
			//Close the database connection.
			_nwindConn.Close();
		}
		/// <summary>
		/// 
		/// ReportStart event
		/// This event is raised every time when report to be start.
		/// 
		/// 
		/// </summary> 
		private void UnboundDRInvoice_ReportStart(object sender, EventArgs e)
		{
			//Database connection populated from the sample Northwind access database
			_nwindConn = new OleDbConnection(Properties.Resources.ConnectionString);
			//SQL Select command to run against the database.
			OleDbCommand _selectCMD = new OleDbCommand("SELECT * FROM Invoices ORDER BY Customers.CompanyName, OrderID", _nwindConn);
			_selectCMD.CommandTimeout = 30;
			//Open the database connection and execute the reader
			_nwindConn.Open();
			_InvoiceDataReader = _selectCMD.ExecuteReader();
		}
	}
}
