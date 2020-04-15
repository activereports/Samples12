Imports System.IO
Imports GrapeCity.ActiveReports.Extensibility.Data
' <summary>
' Provides the implementation of <see cref="IDbCommand"/> for the .NET Framework CSV Data Provider.
' </summary>
Public NotInheritable Class CsvCommand
	Implements Extensibility.Data.IDbCommand
	Private _commandText As String
	Private _connection As IDbConnection
	Private _commandTimeout As Integer
	Private _commandType As CommandType
	' <summary>
	' Creates new instance of <see cref="CsvCommand"/> class.
	' </summary>
	Public Sub New(ByVal commandText As String)
		Me.New(commandText, Nothing)
	End Sub
	' <summary>
	' Creates new instance of <see cref="CsvCommand"/> class with the text of the command.
	' </summary>
	' <param name="commandText">The text of the command.</param>
	Public Sub New()
		Me.New(String.Empty)
	End Sub
	' <summary>
	' Creates a new instance of <see cref="CsvCommand"/> class with the text of the command.
	' </summary>
	' <param name="commandText">The text of the command.</param>
	' <param name="connection">A <see cref="CsvConnection"/> that represents the connection to a data source.</param>
	Public Sub New(ByVal commandText As String, ByVal connection As CsvConnection)
		_commandText = commandText
		_connection = connection
	End Sub
	Public Sub Cancel() Implements IDbCommand.Cancel
		Throw New NotImplementedException()
	End Sub
	Public Function CreateParameter() As IDataParameter Implements IDbCommand.CreateParameter
		Throw New NotImplementedException()
	End Function
	Public Function ExecuteReader() As IDataReader Implements IDbCommand.ExecuteReader
		Return ExecuteReader(CommandBehavior.SchemaOnly)
	End Function
	' <summary>
	' Sends the <see cref="CommandText"/> to the <see cref="CsvConnection"/>, and builds an <see cref="CsvDataReader"/> using one of the <see cref="CommandBehavior"/> values.
	' </summary>
	' <param name="behavior">One of the <see cref="CommandBehavior"/> values.</param>
	' <returns>An <see cref="CsvDataReader"/> object.</returns>
	Public Function ExecuteReader(ByVal behavior As CommandBehavior) As IDataReader _
		Implements IDbCommand.ExecuteReader
		Return New CsvDataReader(New StringReader(_commandText))
	End Function
	' <summary>
	' Returns the command text with the parameters expanded into constants.
	' </summary>
	' <returns>The string represents the command text with the parameters expanded into constants.</returns>
	Public Function GenerateRewrittenCommandText() As String Implements IDbCommand.GenerateRewrittenCommandText
		Return _commandText
	End Function
	' <summary>
	' Gets or sets the command to execute at the data source.
	' </summary>
	Public Property CommandText() As String Implements IDbCommand.CommandText
		Get
			Return _commandText
		End Get
		Set(ByVal value As String)
			_commandText = value
		End Set
	End Property
   	' <summary>
	' Gets or sets the wait time before terminating an attempt to execute a command and generating an error.
	' </summary>
	Public Property CommandTimeout() As Integer Implements IDbCommand.CommandTimeout
		Get
			Return _commandTimeout
		End Get
		Set(ByVal value As Integer)
			_commandTimeout = value
		End Set
	End Property
	' <summary>
	' Gets or sets a value indicating how the <see cref="CommandText"/> property is interpreted.
	' </summary>
	' <remarks><We don't use it for Csv Data Provider.</remarks> 
	Public Property CommandType() As CommandType Implements IDbCommand.CommandType
		Get
			Return _commandType
		End Get
		Set(ByVal value As CommandType)
			_commandType = value
		End Set
	End Property
	Public ReadOnly Property Parameters() As IDataParameterCollection Implements IDbCommand.Parameters
		Get
			Throw New NotImplementedException()
		End Get
	End Property
	Public Property Transaction() As IDbTransaction Implements IDbCommand.Transaction
		Get
			Throw New NotImplementedException()
		End Get
		Set(ByVal value As IDbTransaction)
			Throw New NotImplementedException()
		End Set
	End Property
	Public Sub Dispose() Implements IDisposable.Dispose
		If (Not _connection Is Nothing) Then
			_connection.Dispose()
			_connection = Nothing
		End If
		GC.SuppressFinalize(Me)
	End Sub
End Class
