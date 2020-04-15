using System;
using System.Collections.Specialized;
using GrapeCity.ActiveReports.Extensibility.Data;
namespace GrapeCity.ActiveReports.Samples.CustomDataProvider.CsvDataProvider
{
	/// <summary>
	/// Provides the implementation of <see cref="IDbConnection"/> for the .NET Framework CSV Data Provider.
	/// </summary>
	public sealed class CsvConnection : IDbConnection
	{
		private string _localizedName;
		/// <summary>
		/// Creates new instance of <see cref="CsvConnection"/> class.
		/// </summary>
		public CsvConnection()
		{
			_localizedName = "Csv";
		}
		/// <summary>
		/// Creates new instance of <see cref="CsvConnection"/> class.
		/// </summary>
		/// <param name="localizeName">The localized name for the <see cref="CsvConnection"/> instance.</param>
		public CsvConnection(string localizeName)
		{
			_localizedName = localizeName;
		}
		
		#region IDbConnection Members
		
		
		/// <summary>
		/// Gets or sets the string used to open the connection to the data source.
		/// </summary>
		/// <remarks>We don't use it for Csv Data Provider.</remarks>
		public string ConnectionString
		{
			get { return string.Empty; }
			set { }
		}
		/// <summary>
		/// Gets the time to wait while trying to establish a connection before terminating the attempt and generating an error.
		/// </summary>
		/// <remarks>We don't use it for Csv Data Provider.</remarks>
		public int ConnectionTimeout
		{
			get { throw new NotImplementedException(); }
		}
		/// <summary>
		/// Begins a data source transaction.
		/// </summary>
		/// <returns>An object representing the new transaction.</returns>
		/// <remarks>We don't use it for Csv Data Provider.</remarks>
		public IDbTransaction BeginTransaction()
		{
			return null;
		}
		/// <summary>
		/// Opens a data source connection.
		/// </summary>
		/// <remarks>We don't use it for Csv Data Provider.</remarks>
		public void Open()
		{
		}
		/// <summary>
		/// Closes the connection to the data source.
		/// </summary>
		public void Close()
		{
			Dispose();
		}
		public IDbCommand CreateCommand()
		{
			return new CsvCommand(string.Empty);
		}
		#pragma warning disable 612, 618
		public IDataProviderService DataProviderService
		{
			get { return null; }
			set { }
		}
		#pragma warning restore 612, 618
		#endregion
		
		#region IDisposable Members
		
		
		/// <summary>
		/// Releases the resources used by the <see cref="CsvConnection"/>.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		private void Dispose(bool disposing)
		{
		}
		/// <summary>
		/// Allows an Object to attempt to free resources and perform other cleanup operations before the Object is reclaimed by garbage collection.
		/// </summary>
		~CsvConnection()
		{
			Dispose(false);
		}
		#endregion
		
		#region IExtension Members
		
		
		/// <summary>
		/// Gets the localized name of the <see cref="CsvConnection"/>.
		/// </summary>
		public string LocalizedName
		{
			get { return _localizedName; }
		}
		/// <summary>
		/// Specifies any configuration information for this extension.
		/// </summary>
		/// <param name="configurationSettings">A <see cref="NameValueCollection"/> of the settings.</param>
		public void SetConfiguration(NameValueCollection configurationSettings)
		{
		}
		#endregion
	}
}
