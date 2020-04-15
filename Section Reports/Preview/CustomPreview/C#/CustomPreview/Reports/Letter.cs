using System;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	partial class Letter : GrapeCity.ActiveReports.SectionReport
	{
		public Letter()
		{
			InitializeComponent();
			
			Document.Name = "Letter Report";
			
			
		}
		/// <summary>
		/// Format Event
		/// ActiveReports raises this event after the data is loaded and bound to the controls contained in a section, 
		/// but before the section is rendered to a page.The Format event is the only event in which you can change
		///  the section's height. Use this section to set or change the properties of any controls or the section itself.
		/// Also use the Format event to pass information, such as an SQL String, to a Subreport.
		/// </summary>
		private void ghCustomerID_Format(object sender, EventArgs eArgs)
		{
			rtbMain.ReplaceField("CompanyName", txtCompanyName.Text);
			rtbMain.ReplaceField("ContactName", txtContactName.Text);
			rtbMain.ReplaceField("AddressLine", txtAddress.Text);
			rtbMain.ReplaceField("City", txtCity.Text);
			rtbMain.ReplaceField("Region", txtRegion.Text);
			rtbMain.ReplaceField("Country", txtCountry.Text);
			rtbMain.ReplaceField("PostalCode", txtPostalCode.Text);
			rtbMain.ReplaceField("Date", DateTime.Now.ToLongDateString());
		}
		/// <summary>
		/// BeforePrint Event
		/// ActiveReports raises this event before the section is rendered to a page.
		/// Use this event to modify the control's values before printing.
		/// The changes made here do not effect the height of the section.
		/// </summary>
		private void ghCustomerID_BeforePrint(object sender, EventArgs eArgs)
		{
			// Totals are not calculated until the section is ready to print, 
			// so update the total fields in the rich textbox in the BeforePrint event.
			rtbMain.ReplaceField("TotalOrders", txtTotalOrders.Text);
		}
	}
}
