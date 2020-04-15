namespace GrapeCity.ActiveReports.Sample.Inheritance
{
	/// <summary>
	/// A description of the overview of the rptDesignChild.
	/// </summary>
	public partial class rptDesignChild : Inheritance.rptDesignBase
	{
		public rptDesignChild()
		{
			//
			// Designer support is required to ActiveReport.
			//
			InitializeComponent();
		}
		private void rptDesignChild_ReportStart(object sender, System.EventArgs e)
		{
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			oleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\NWIND.MDB;Persist Security Info=False";
			oleDBDataSource1.SQL = "Select * from Customers Order By Val(CustomerID)";
			this.DataSource = oleDBDataSource1;
		}
	}
}
