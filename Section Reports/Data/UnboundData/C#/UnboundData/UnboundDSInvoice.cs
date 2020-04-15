using System;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
namespace GrapeCity.ActiveReports.Samples.UnboundData
{
	public partial class UnboundDSInvoice : GrapeCity.ActiveReports.SectionReport
	{
		public UnboundDSInvoice()
		{
			InitializeComponent();
			
		}
		/// <summary>
		/// 
		/// ReportStart event
		/// This event is raised every time when report to be start.
		/// 
		/// 
		/// </summary> 
		void UnboundDSInvoice_ReportStart(object sender, EventArgs e)
		{
			//Dataset to hold data.
			_InvoiceData = new DataSet();
			_InvoiceData.Locale = CultureInfo.InvariantCulture;
			//Database connection populated from the sample Northwind access database
			OleDbConnection _nwindConn = new OleDbConnection(Properties.Resources.ConnectionString);
			//SQL Select command to run against the database
			OleDbCommand _selectCMD = new OleDbCommand("SELECT * FROM Invoices ORDER BY Customers.CompanyName, OrderID", _nwindConn);
			_selectCMD.CommandTimeout = 30;
			//Data adapter used to run the select command.
			OleDbDataAdapter _InvoicesDA = new OleDbDataAdapter();
			_InvoicesDA.SelectCommand = _selectCMD;
			//Fill the DataSet
			_InvoicesDA.Fill(_InvoiceData, "Invoices");
			//Initialize counter to first row of the DataSet.
			_RowCounter = 0;
		}
		//DataSource for the report.
		DataSet _InvoiceData;
		int _RowCounter;
		/// <summary>
		/// DataInitialize Event
		/// Use it to add custom fields to the report's Fields collection. 
		/// Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
		/// or an unbound report (one that does not depend on a data control to get its records).
		/// </summary>
		private void Invoice_DataInitialize(object sender, EventArgs eArgs)
		{
		   
			//Add all the columns from the database as fields for the report.
			for (int i = 0; i < _InvoiceData.Tables[0].Columns.Count; i++)
			{
				Fields.Add(_InvoiceData.Tables[0].Columns[i].ColumnName);
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
			if (_RowCounter == _InvoiceData.Tables[0].Rows.Count)
			{
				//If the reader has reached the end of the data then
				//set the eArgs.EOF flag to true and exit the procedure.
				eArgs.EOF = true;
				return;
			}
			else
			{
				//Populate the fields collection from the DataReader.
				for (int i = 0; i < _InvoiceData.Tables[0].Columns.Count; i++)
				{
					Fields[_InvoiceData.Tables[0].Columns[i].ColumnName].Value = _InvoiceData.Tables[0].Rows[_RowCounter][i];
				}
				//Add unbound DiscountTotal field total to instance of the Fields collection (for data binding and summary totaling in the group footer.)
				Fields["DiscountTotal"].Value =
				Convert.ToDouble(Fields["UnitPrice"].Value, CultureInfo.CurrentCulture) *
				Convert.ToInt32(Fields["Quantity"].Value, CultureInfo.InvariantCulture) *
				Convert.ToDouble(Fields["Discount"].Value, CultureInfo.CurrentCulture);
				//Set row counter.
				eArgs.EOF = false;
				_RowCounter++;
			}
		}
	}
}
