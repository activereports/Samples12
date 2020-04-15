Imports GrapeCity.ActiveReports.Export
Imports GrapeCity.ActiveReports.Document
Public Class SectionExport
	Public Property DisplayName() As String
		Get
			Return _displayName
		End Get
		Set(ByVal value As String)
			_displayName = value
		End Set
	End Property
	Private _displayName As String
	Public Property Filter() As String
		Get
			Return _filter
		End Get
		Set(ByVal value As String)
			_filter = value
		End Set
	End Property
	Private _filter As String
	Public Property DefaultFileName() As String
		Get
			Return _defaultFileName
		End Get
		Set(ByVal value As String)
			_defaultFileName = value
		End Set
	End Property
	Private _defaultFileName As String
	Public Property Settings() As IDocumentExportEx
		Get
			Return _settings
		End Get
		Set(ByVal value As IDocumentExportEx)
			_settings = value
		End Set
	End Property
	Private _settings As IDocumentExportEx
	Public Sub Export(ByVal sectionDocument As SectionDocument, ByVal filePath As String)
		Settings.Export(sectionDocument, filePath)
	End Sub
End Class
