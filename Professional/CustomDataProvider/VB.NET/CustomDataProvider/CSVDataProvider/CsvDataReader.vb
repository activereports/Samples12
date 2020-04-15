Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Globalization
' <summary>
' Provides the implementation of <see cref="Extensibility.Data.IDataReader"/> for the .NET Framework CSV Data Provider.
' </summary>
Friend Class CsvDataReader
	Implements Extensibility.Data.IDataReader
	Private _typeLookup As New Hashtable(New myCultureComparer(New CultureInfo("en")))
	
	'
	Private _columnLookup As New Hashtable()
	Private _columns As Object()
	Private _textReader As TextReader
	Private _currentRow As Object()
	'The regular expressions are set to be pre-compiled to make it faster. 
	'Properties are read-only to avoid multi-threading so no one can change any properties on these objects.
	Private Shared ReadOnly _rxDataRow As New Regex(",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))", RegexOptions.Compiled)
	'Used to parse the data rows.
	Private Shared ReadOnly _rxHeaderRow As New Regex("(?<fieldName>(\w*\s*)*)\((?<fieldType>\w*)\)", RegexOptions.Compiled)
	'Used to parse the header rows.
	Public Sub New(ByVal textReader As TextReader)
		_textReader = textReader
		ParseCommandText()
	End Sub
	Private Sub ParseCommandText()
		If (_textReader.Peek() = -1) Then
			Return
			'Command text is empty or at the end already.
		End If
		FillTypeLookup()
		If (Not ParseHeader(_textReader.ReadLine())) Then
		End If
	End Sub
	Private Function ParseHeader(ByVal header As String) As Boolean
		Dim fieldName As String
		Dim index As Integer = 0
		If (header.IndexOf("(") = -1) Then
			Return False
		End If
		Dim matches As MatchCollection = _rxHeaderRow.Matches(header)
		_columns = New Object(matches.Count - 1) {}
		For Each matchVar As Match In matches
			fieldName = matchVar.Groups("fieldName").Value
			Dim fieldType As Type = GetFieldTypeFromString(matchVar.Groups("fieldType").Value)
			CType(_columns, Array).SetValue(New CsvColumn(fieldName, fieldType), index)
			_columnLookup.Add(fieldName, index)
			index += 1
		Next
		Return True
	End Function
	Private Sub FillTypeLookup()
		_typeLookup.Add("string", GetType(String))
		_typeLookup.Add("byte", GetType(Byte))
		_typeLookup.Add("boolean", GetType(Boolean))
		_typeLookup.Add("datetime", GetType(DateTime))
		_typeLookup.Add("decimal", GetType(Decimal))
		_typeLookup.Add("double", GetType(Double))
		_typeLookup.Add("int16", GetType(Int16))
		_typeLookup.Add("int32", GetType(Int32))
		_typeLookup.Add("int", GetType(Int32))
		_typeLookup.Add("integer", GetType(Int32))
		_typeLookup.Add("int64", GetType(Int64))
		_typeLookup.Add("sbyte", GetType(SByte))
		_typeLookup.Add("single", GetType(Single))
		_typeLookup.Add("time", GetType(DateTime))
		_typeLookup.Add("date", GetType(DateTime))
		_typeLookup.Add("uint16", GetType(UInt16))
		_typeLookup.Add("uint32", GetType(UInt32))
		_typeLookup.Add("uint64", GetType(UInt64))
	End Sub
	Public Function Read() As Boolean Implements Extensibility.Data.IDataReader.Read
		If (_textReader.Peek() > -1) Then
			ParseDataRow(_textReader.ReadLine())
		Else
			Return False
		End If
		Return True
	End Function
	Public ReadOnly Property FieldCount() As Integer Implements Extensibility.Data.IDataRecord.FieldCount
		Get
			If (_columns) Is Nothing Then
				_columns = New Object(0) {}
			End If
			Return CType(_columns, Array).Length
		End Get
	End Property
	Public Function GetData(ByVal fieldIndex As Integer) As Extensibility.Data.IDataReader _
		Implements Extensibility.Data.IDataRecord.GetData
		Throw New NotSupportedException()
	End Function
	Public Function GetFieldType(ByVal i As Integer) As System.Type _
		Implements Extensibility.Data.IDataRecord.GetFieldType
		If (i > CType(_columns, Array).Length - 1) Then
			Return Nothing
		End If
		Return CType(CType(_columns, Array).GetValue(i), CsvColumn).DataType
	End Function
	Public Function GetName(ByVal i As Integer) As String Implements Extensibility.Data.IDataRecord.GetName
		If (i > CType(_columns, Array).Length - 1) Then
			Return String.Empty
		End If
		Return CType(CType(_columns, Array).GetValue(i), CsvColumn).FieldName
	End Function
	Public Function GetOrdinal(ByVal name As String) As Integer _
		Implements Extensibility.Data.IDataRecord.GetOrdinal
		Dim value As Object = _columnLookup(name)
		If (value Is Nothing) Then
			Throw New IndexOutOfRangeException("name")
		End If
		Return CInt(value)
	End Function
	Public Function GetValue(ByVal i As Integer) As Object Implements Extensibility.Data.IDataRecord.GetValue
		If (i > (CType(_columns, Array).Length - 1)) Then
			Return Nothing
		End If
		Return _currentRow.GetValue(i)
	End Function
	Private disposedValue As Boolean = False
	' IDisposable
	Protected Overridable Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If _textReader IsNot Nothing Then
				_textReader.Close()
			End If
		End If
		_typeLookup = Nothing
		_columnLookup = Nothing
		_columns = Nothing
		_currentRow = Nothing
	End Sub
	
#Region " IDisposable Support "
	
	'
	Public Sub Dispose() Implements IDisposable.Dispose
		Dispose(True)
		GC.SuppressFinalize(Me)
	End Sub
#End Region
	Protected Overrides Sub Finalize()
		Try
			Dispose(False)
		Finally
			MyBase.Finalize()
		End Try
	End Sub
	Private Function GetFieldTypeFromString(ByVal fieldType As String) As Type
		If (_typeLookup.Contains(fieldType)) Then
			Return CType(_typeLookup(fieldType), Type)
		End If
		Return GetType(String)
	End Function
	Private Function ParseDataRow(ByVal dataRow As String) As Boolean
		Dim index As Integer = 0
		Dim tempData As String() = _rxDataRow.Split(dataRow)
		_currentRow = New Object(tempData.Length) {}
		If (tempData.Length <> CType(_columns, Array).Length) Then
			
			Dim _
				errorMsg As String = _
					String.Format(CultureInfo.InvariantCulture, _
								   "Invalid row '{0}'. The row does not contain the same number of data columns as the table header definition.", _
								   dataRow)
			
			'
			Throw New InvalidOperationException(errorMsg)
		End If
		For i As Integer = 0 To tempData.Length - 1
			Dim value As String = tempData(i)
			If (value.Length > 1) Then
				If (value.IndexOf(""""c, 0) = 0 And value.IndexOf(""""c, 1) = (value.Length - 1)) Then
					value = value.Substring(1, value.Length - 2)
				End If
			End If
			_currentRow.SetValue(ConvertValue(GetFieldType(index), value), index)
			index += 1
		Next
		Return True
	End Function
	' <summary>
	' Returns a type based on the string value passed in from the header text string. If not match is found a string type is returned.
	' </summary>
	' <param name="typevar">String value from the header command text string.</param>
	Function ConvertValue(ByVal typevar As Type, ByVal originalValue As String) As Object
		Dim fieldType As Type = typevar
		Dim invariantCulture As CultureInfo = CultureInfo.InvariantCulture
		Try
			If (originalValue = """""" Or originalValue = " ") Then
				Return String.Empty
			ElseIf (originalValue = "") Then
				Return DBNull.Value
			ElseIf (originalValue = "DBNull") Then
				Return DBNull.Value
			ElseIf (fieldType.Equals(GetType(String))) Then
				Return originalValue.Trim()
			ElseIf (fieldType.Equals(GetType(Int32))) Then
				originalValue.ToCharArray()
				Return Convert.ToInt32(originalValue, invariantCulture)
			ElseIf (fieldType.Equals(GetType(Boolean))) Then
				Return Convert.ToBoolean(originalValue, invariantCulture)
			ElseIf (fieldType.Equals(GetType(DateTime))) Then
				Return Convert.ToDateTime(originalValue, invariantCulture)
			ElseIf (fieldType.Equals(GetType(Decimal))) Then
				Return Convert.ToDecimal(originalValue, invariantCulture)
			ElseIf (fieldType.Equals(GetType(Double))) Then
				Return Convert.ToDouble(originalValue, invariantCulture)
			ElseIf (fieldType.Equals(GetType(Int16))) Then
				Return Convert.ToInt16(originalValue, invariantCulture)
			ElseIf (fieldType.Equals(GetType(Int64))) Then
				Return Convert.ToInt64(originalValue, invariantCulture)
			ElseIf (fieldType.Equals(GetType(Single))) Then
				Return Convert.ToSingle(originalValue, invariantCulture)
			ElseIf (fieldType.Equals(GetType(Byte))) Then
				Return Convert.ToByte(originalValue, invariantCulture)
			ElseIf (fieldType.Equals(GetType(SByte))) Then
				Return Convert.ToSByte(originalValue, invariantCulture)
			ElseIf (fieldType.Equals(GetType(UInt16))) Then
				Return Convert.ToUInt16(originalValue, invariantCulture)
			ElseIf (fieldType.Equals(GetType(UInt32))) Then
				Return Convert.ToUInt32(originalValue, invariantCulture)
			ElseIf (fieldType.Equals(GetType(UInt64))) Then
				Return Convert.ToUInt64(originalValue, invariantCulture)
			End If
		Catch ex As Exception
			
			Throw _
				New InvalidOperationException( _
											   String.Format( _
															  "Input value '{0}' could not be converted to the type '{1}'.", _
															  originalValue, typevar), ex)
			
			'
		End Try
		Return DBNull.Value
	End Function
	Class myCultureComparer
		Implements IEqualityComparer
		Public myComparer As CaseInsensitiveComparer
		Public Sub New()
			myComparer = CaseInsensitiveComparer.DefaultInvariant
		End Sub
		Public Sub New(myCulture As CultureInfo)
			myComparer = New CaseInsensitiveComparer(myCulture)
		End Sub
		Public Shadows Function Equals(x As Object, y As Object) As Boolean Implements System.Collections.IEqualityComparer.Equals
			If myComparer.Compare(x, y) = 0 Then
				Return True
			Else
				Return False
			End If
		End Function
		Public Shadows Function GetHashCode(obj As Object) As Integer Implements System.Collections.IEqualityComparer.GetHashCode
			Return obj.ToString().ToLower().GetHashCode()
		End Function
	End Class
End Class
