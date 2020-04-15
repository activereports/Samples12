using System;
using System.IO;
using System.Globalization;
namespace GrapeCity.ActiveReports.Samples.UnboundData
{
	public partial class UnboundDAInvoice : GrapeCity.ActiveReports.SectionReport
	{
		public UnboundDAInvoice()
		{
			InitializeComponent();
		}
		//DataSource for the report
		StreamReader _InvoiceFileStream;
		//Fields array list.
		string [] _FieldNameArray;
		//Data array list and counter.
		string [][] _InvoiceDataArray;
		int _RowCounter;
		/// <summary>
		/// DataInitialize Event
		/// Use it to add custom fields to the report's Fields collection. 
		/// Custom fields can be added to a bound report (one that uses a Data Control to connect and retrieve records)
		/// or an unbound report (one that does not depend on a data control to get its records).
		/// </summary>
		private void Invoice_DataInitialize(object sender, EventArgs eArgs)
		{
			for (int i = 0; i < _FieldNameArray.Length; i++)
				Fields.Add(_FieldNameArray[i]);
			//Add calculated Fields.
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
			if (_RowCounter > _InvoiceDataArray.GetUpperBound(0))
			{
				eArgs.EOF = true;
				return;
			}
			string[] _CurrentArray = _InvoiceDataArray[_RowCounter];
			//Populate the fields used in data binding.
			for (int i = 0; i < _CurrentArray.Length; i++)
			{
				double dblVal;
				Fields[_FieldNameArray[i]].Value =
					(Double.TryParse(_CurrentArray[i], NumberStyles.Float,
					CultureInfo.InvariantCulture, out dblVal))
					? dblVal.ToString(CultureInfo.CurrentCulture)
					: _CurrentArray[i];
			}
			//Add unbound DiscountTotal field total to instance of the Fields collection (for data binding and summary totaling in the group footer.)
			Fields["DiscountTotal"].Value =
				Convert.ToDouble(Fields["UnitPrice"].Value, CultureInfo.CurrentCulture) *
				Convert.ToInt32(Fields["Quantity"].Value, CultureInfo.InvariantCulture) *
				Convert.ToDouble(Fields["Discount"].Value, CultureInfo.CurrentCulture);
			/*It is important to set EOF to False if there are more records
			otherwise the default True value will be used and the report*/
			_RowCounter++;
			eArgs.EOF = false;
		}
		/// <summary>
		/// 
		/// ReportStart event
		/// This event is raised every time when report to be start.
		/// 
		/// 
		/// </summary> 
		private void UnboundDAInvoice_ReportStart(object sender, EventArgs e)
		{
			//Open text file as data source.
			_InvoiceFileStream = File.OpenText(@"..\..\Invoices.txt");
			//Set up the fields used in data binding.
			string _CurrentLine = _InvoiceFileStream.ReadLine();
			_FieldNameArray = _CurrentLine.Split(new char[] { ';' });
			
			//Get row count from text file.
			_RowCounter = 0;
			bool _FileHasData = true;
			while (_FileHasData)
			{
				_CurrentLine = _InvoiceFileStream.ReadLine();
				if (_CurrentLine.Length != 0)
					_RowCounter++;
				else
					_FileHasData = false;
			}
			//Reset data stream.
			_InvoiceFileStream.Close();
			_InvoiceFileStream = File.OpenText(@"..\..\Invoices.txt");
			_InvoiceDataArray = new String[_RowCounter][];
			//Read fields list line.
			_CurrentLine = _InvoiceFileStream.ReadLine();
			//Populate the data array from text file.
			for (int i = 0; i < _RowCounter; i++)
			{
				_CurrentLine = _InvoiceFileStream.ReadLine();
				//Populate the fields used in data binding.
				_InvoiceDataArray[i] = new string[_FieldNameArray.Length];
				_InvoiceDataArray[i] = _CurrentLine.Split(new char[] { ';' });
			}
			//Close file stream.
			_InvoiceFileStream.Close();
			_RowCounter = 0;
		}
	}
}
