' <summary>
' Provides the implementation of <see cref="IDbConnection"/> for the .NET Framework CSV Data Provider.
' </summary>
Public NotInheritable Class CsvConnection
	Implements Extensibility.Data.IDbConnection
	' <summary>
	' Creates new instance of <see cref="CsvConnection"/> class.
	' </summary>
	Private _localizedName As String
	' <summary>
	' Creates new instance of <see cref="CsvConnection"/> class.
	' </summary>
	' <param name="localizeName">The localized name for the <see cref="CsvConnection"/> instance.</param>
	Public Sub New()
		_localizedName = "Csv"
	End Sub
	Public Sub New(ByVal localizeName As String)
		_localizedName = localizeName
	End Sub
	
#Region " IDbConnection Members"
	
	'
	' <summary>
	'Gets or sets the string used to open the connection to the data source.
	'</summary>
	'<remarks>We don't use it for Csv Data Provider.</remarks>
	Public Property ConnectionString() As String Implements Extensibility.Data.IDbConnection.ConnectionString
		Get
			Return String.Empty
		End Get
		Set(ByVal value As String)
		End Set
	End Property
	' <summary>
	' Gets the time to wait while trying to establish a connection before terminating the attempt and generating an error.
	' </summary>
	' <remarks>We don't use it for Csv Data Provider.</remarks>
	Public ReadOnly Property ConnectionTimeout() As Integer _
		Implements Extensibility.Data.IDbConnection.ConnectionTimeout
		Get
			Throw New NotImplementedException()
		End Get
	End Property
	' <summary>
	' Opens a data source connection.
	' </summary>
	' <remarks>We don't use it for Csv Data Provider.</remarks>
	Public Function BeginTransaction() As Extensibility.Data.IDbTransaction _
		Implements Extensibility.Data.IDbConnection.BeginTransaction
		Return Nothing
	End Function
	Public Sub Open() Implements Extensibility.Data.IDbConnection.Open
	End Sub
	' <summary>
	'Closes the connection to the data source.
	' </summary>
	Public Sub Close() Implements Extensibility.Data.IDbConnection.Close
		Dispose()
	End Sub
	Public Function CreateCommand() As Extensibility.Data.IDbCommand _
		Implements Extensibility.Data.IDbConnection.CreateCommand
		Return New CsvCommand(String.Empty)
	End Function
	Public Property DataProviderService() As Extensibility.Data.IDataProviderService _
		Implements Extensibility.Data.IDbConnection.DataProviderService
		Get
			Return Nothing
		End Get
		Set(ByVal value As Extensibility.Data.IDataProviderService)
		End Set
	End Property
#End Region
	
#Region " IExtension Members "
	
	'
	' <summary>
	' Gets the localized name of the <see cref="CsvConnection"/>.
	' </summary>
	Public ReadOnly Property LocalizedName() As String Implements Extensibility.IExtension.LocalizedName
		Get
			Return _localizedName
		End Get
	End Property
	' <summary>
	' Specifies any configuration information for this extension.
	' </summary>
	' <param name="configurationSettings">A <see cref="NameValueCollection"/> of the settings.</param>
	Public Sub SetConfiguration(ByVal configurationSettings As Specialized.NameValueCollection) _
			Implements Extensibility.IExtension.SetConfiguration
	End Sub
#End Region
	
#Region "IDisposable Members"
	
	'
	Public Sub Dispose() Implements IDisposable.Dispose
		' Allows an Object to attempt to free resources and perform other cleanup operations before the Object is reclaimed by garbage collection.
		Dispose(True)
		GC.SuppressFinalize(Me)
	End Sub
	Protected Sub Dispose(ByVal disposing As Boolean)
	End Sub
#End Region
End Class
