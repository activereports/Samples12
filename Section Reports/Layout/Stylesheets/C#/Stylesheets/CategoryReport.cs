namespace GrapeCity.ActiveReports.Samples.StyleSheets
{
	partial class CategoryReport : GrapeCity.ActiveReports.SectionReport
	{
		public CategoryReport()
		{
			InitializeComponent();
			Data.OleDBDataSource dS = new Data.OleDBDataSource();
			dS.ConnectionString = Properties.Resources.ConnectionString;
			dS.SQL = "Select Categories.CategoryID, categories.CategoryName, Avg(Products.UnitPrice) as AvgUnitPrice, Count(Categories.CategoryID) as ProductCount FROM Products, Categories WHERE Products.CategoryID = Categories.CategoryID GROUP BY Categories.CategoryID, categories.CategoryName;";
			DataSource = dS;
		}
	}
}
