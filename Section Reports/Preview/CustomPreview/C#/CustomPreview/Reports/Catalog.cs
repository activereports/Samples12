namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	partial class Catalog : GrapeCity.ActiveReports.SectionReport
	{
		public Catalog()
		{
			InitializeComponent();
			
			Document.Name = "Catalog Report";
			
			
		}
		/// <summary>
		/// BeforePrint Event
		/// ActiveReports raises this event before the section is rendered to a page.
		/// Use this event to modify the control's values before printing.
		/// The changes made here do not effect the height of the section.
		/// </summary>
		private void PageFooter_BeforePrint(object sender, System.EventArgs eArgs)
		{
			int pg = PageNumber;
			
			lblPage.Text = "Page " + pg.ToString(System.Globalization.CultureInfo.CurrentCulture);
			
			
		}
	}
}
