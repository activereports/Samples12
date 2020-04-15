Imports GrapeCity.ActiveReports.Extensibility.Data
' <summary>
' Provides the implementation of <see cref="Extensibility.Data.IDataReader"/> for the .NET Framework CSV Data Provider.
' </summary>
Public Class CsvDataProviderFactory
	Inherits DataProviderFactory
	Public Overrides Function CreateCommand() As IDbCommand
		' <summary>
		' Returns a new instance of the <see cref="CsvCommand"/>.
		Return New CsvCommand()
	End Function
	Public Overrides Function CreateConnection() As IDbConnection
		' <summary>
		' Returns a new instance of the <see cref="CsvConnection"/>.
		Return New CsvConnection()
	End Function
End Class
