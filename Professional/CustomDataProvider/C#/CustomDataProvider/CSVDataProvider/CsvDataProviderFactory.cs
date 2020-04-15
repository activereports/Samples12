using GrapeCity.ActiveReports.Samples.CustomDataProvider.CsvDataProvider;
using GrapeCity.ActiveReports.Extensibility.Data;
namespace GrapeCity.ActiveReports.Samples.CustomDataProvider.CSVDataProvider
{
	/// <summary>
	/// Implements <see cref="DataProviderFactory"/> for .NET Framework CSV Data Provider.
	/// </summary>
	public class CsvDataProviderFactory : DataProviderFactory
	{
		/// <summary>
		/// Creates a new instance of the <see cref="CsvDataProviderFactory"/> class.
		/// </summary>
		public CsvDataProviderFactory()
		{
		}
		/// <summary>
		/// Returns a new instance of the <see cref="CsvCommand"/>.
		/// </summary>
		public override IDbCommand CreateCommand()
		{
			return new CsvCommand();
		}
		/// <summary>
		/// Returns a new instance of the <see cref="CsvConnection"/>.
		/// </summary>
		public override IDbConnection CreateConnection()
		{
			return new CsvConnection();
		}
	}
}
