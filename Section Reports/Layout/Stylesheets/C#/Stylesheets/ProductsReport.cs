namespace GrapeCity.ActiveReports.Samples.StyleSheets
{
	partial class ProductsReport : GrapeCity.ActiveReports.SectionReport
	{
		public ProductsReport()
		{
			InitializeComponent();
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;
			dS.SQL = "Select Products.ProductName, Products.UnitPrice, Products.CategoryID, categories.CategoryName FROM Products, Categories WHERE Products.CategoryID = Categories.CategoryID Order By Categories.CategoryID;";
			DataSource = dS;
		}
	}
}
