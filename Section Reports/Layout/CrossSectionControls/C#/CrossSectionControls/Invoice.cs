using System;
using System.Drawing;
namespace GrapeCity.ActiveReports.Samples.CrossSectionControls
{
	/// <summary>
	/// 
	/// Summary description for Invoice.
	/// 
	/// 
	/// </summary>
	public partial class Invoice : GrapeCity.ActiveReports.SectionReport
	{
		// Create member variables for alternating colors of detail rows
		private int _detailRowNumber;
		private Color _detailRowColor = Color.White;
		private Color _detailAlternateRowColor = Color.FromArgb(192, 173, 223);
		public Invoice()
		{		
			// Required for Windows Form Designer support
			InitializeComponent();
		}
		private void customerGroupHeader_Format(object sender, EventArgs e)
		{
			// Reset the detail row number when a new group begins
			_detailRowNumber = 0;
		}
		private void Detail_Format(object sender, EventArgs e)
		{
			// Set alternating row colors
			if (_detailRowNumber % 2 == 0)
				Detail.BackColor = _detailRowColor;
			else
				Detail.BackColor = _detailAlternateRowColor;
			_detailRowNumber++;
		}
		private void customerGroupFooter_Format(object sender, EventArgs e)
		{
			// Calculate the total based on values from textboxes in the group footer.
			double subtotal = Convert.ToDouble(subtotalTextBox.Value);
			double freight = Convert.ToDouble(freightTextBox.Value);
			grandTotalTextBox.Value = String.Format("{0:C}", subtotal + freight);
		}
		private void Invoice_ReportStart(object sender, EventArgs e)
		{
			Data.OleDBDataSource ds = (Data.OleDBDataSource)DataSource;
			
			ds.SQL = "SELECT * FROM Invoices WHERE Country = 'USA'"; 
			
			
		}
	}
}
