using System;
using System.IO;
using System.Globalization;
namespace GrapeCity.ActiveReports.Samples.UnboundData
{
	public partial class UnboundTFInvoice : GrapeCity.ActiveReports.SectionReport
	{
		public UnboundTFInvoice()
		{
			InitializeComponent();
		}
		//DataSource for the report.
		StreamReader _InvoiceFileStream;
		//Fields Array List
		string [] _FieldNameArray;
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
			try
			{
				string _CurrentLine = _InvoiceFileStream.ReadLine();
				if (_CurrentLine != null)
				{
					string[] _CurrentArray = _CurrentLine.Split(new char[] { ';' });
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
					//Double values are already in CultureInfo.CurrentCulture format.
					Fields["DiscountTotal"].Value =
						Convert.ToDouble(Fields["UnitPrice"].Value, CultureInfo.CurrentCulture) *
						Convert.ToInt32(Fields["Quantity"].Value, CultureInfo.InvariantCulture) *
						Convert.ToDouble(Fields["Discount"].Value, CultureInfo.CurrentCulture);
					eArgs.EOF = false;
				}
				else
				{
					eArgs.EOF = true;
				}
			}
			catch (EndOfStreamException)
			{
				//If the file stream has reached the end of the data then
				//set the eArgs.EOF flag to true and exit the procedure.
				eArgs.EOF = true;
			}
		}
		/// <summary>
		/// ReportStart Event
		/// Use this event to initialize any objects or variables needed while running a report. 
		/// Also use this event to set any Subreport control objects to a new instance 
		/// of the report assigned to the Subreport control.
		/// </summary>
		private void UnboundTFInvoice_ReportEnd(object sender, EventArgs eArgs)
		{
			_InvoiceFileStream.Close();
		}
		/// <summary>
		/// 
		/// ReportStart event
		/// This event is raised every time when report to be start.
		/// 
		/// 
		/// </summary> 
		private void UnboundTFInvoice_ReportStart(object sender, EventArgs e)
		{
			//Open text file as data source.
			_InvoiceFileStream = File.OpenText(@"..\..\Invoices.txt");
			//Set up the fields used in data binding.
			string _CurrentLine = _InvoiceFileStream.ReadLine();
			_FieldNameArray = _CurrentLine.Split(new char[] { ';' });
		}
	}
}
