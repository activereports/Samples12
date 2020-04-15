using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.Document;
namespace GrapeCity.ActiveReports.Samples.ActiveReportsSilverlightViewer.Web
{
	/// <summary>
	/// 
	/// Summary description for Invoice.
	/// 
	/// 
	/// </summary>
	public partial class CodeReport : GrapeCity.ActiveReports.SectionReport
	{
		// Create member variables for alternating colors of detail rows
		private int detailRowNumber;
		private Color detailRowColor = Color.White;
		private Color detailAlternateRowColor = Color.FromArgb(192, 173, 223);
		public CodeReport()
		{		
			// Required for Windows Form Designer support
			InitializeComponent();
		}
		private void customerGroupHeader_Format(object sender, EventArgs e)
		{
			// Reset the detail row number when a new group begins
			detailRowNumber = 0;
		}
		private void Detail_Format(object sender, EventArgs e)
		{
			// Set alternating row colors
			if (detailRowNumber % 2 == 0)
				this.Detail.BackColor = detailRowColor;
			else
				this.Detail.BackColor = detailAlternateRowColor;
			detailRowNumber++;
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
			GrapeCity.ActiveReports.Data.OleDBDataSource ds = (GrapeCity.ActiveReports.Data.OleDBDataSource)this.DataSource;
			ds.SQL = "SELECT * FROM Invoices WHERE Country = 'USA'"; 
		}
	}
}
