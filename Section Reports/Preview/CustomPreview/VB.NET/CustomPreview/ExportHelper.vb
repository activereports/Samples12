Imports GrapeCity.ActiveReports.Export
Imports GrapeCity.ActiveReports.Document
Public Class SectionExport
	Public Property DisplayName() As String
		Get
			Return _DisplayName
		End Get
		Set(value As String)
			_DisplayName = value
		End Set
	End Property
	Private _DisplayName As String
	Public Property Filter() As String
		Get
			Return _Filter
		End Get
		Set(value As String)
			_Filter = value
		End Set
	End Property
	Private _Filter As String
	Public Property DefaultFileName() As String
		Get
			Return _DefaultFileName
		End Get
		Set(value As String)
			_DefaultFileName = value
		End Set
	End Property
	Private _DefaultFileName As String
	Public Property Settings() As IDocumentExportEx
		Get
			Return _Settings
		End Get
		Set(value As IDocumentExportEx)
			_Settings = value
		End Set
	End Property
	Private _Settings As IDocumentExportEx
	Public Sub Export(sectionDocument As SectionDocument, filePath As String)
		Settings.Export(sectionDocument, filePath)
	End Sub
End Class
