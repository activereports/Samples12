using System;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	public partial class EmployeeSales : GrapeCity.ActiveReports.SectionReport
	{
		public EmployeeSales()
		{
			InitializeComponent();
			
			Document.Name = "Employee Sales Report";
			
			
		}
		private void EmployeeSales_ReportStart(object sender, EventArgs e)
		{
			
			chtSales.Titles[0].Text = "Sales by Employee for 1997";
			
			
		}
	}
}
