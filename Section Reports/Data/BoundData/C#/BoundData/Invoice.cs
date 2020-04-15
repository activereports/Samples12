namespace GrapeCity.ActiveReports.Samples.BoundData
{
	public partial class Invoice : GrapeCity.ActiveReports.SectionReport
	{
		public Invoice()
		{
			InitializeComponent();
			Document.Name = "Invoice ActiveReport";
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;
			dS.SQL = "SELECT * FROM Invoices ORDER BY Customers.CompanyName, OrderID";
			DataSource = dS;
		}
	}
}
