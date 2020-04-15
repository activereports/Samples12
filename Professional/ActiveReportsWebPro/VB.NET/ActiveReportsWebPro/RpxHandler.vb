Imports System.IO
Imports System.Web
Imports System.Web.Caching
Imports GrapeCity.ActiveReports.Export.Html
Public Class RpxHandler
	Implements IHttpHandler
	Private Const HandlerCacheExtension As String = ".rpxWeb"
	Public Sub ProcessRequest(context As HttpContext) Implements IHttpHandler.ProcessRequest
		' return image
		Dim keyName As String = Path.GetFileName(context.Request.FilePath)
		Dim cacheItem = DirectCast(context.Cache(keyName), Byte())
		context.Response.BinaryWrite(cacheItem)
	End Sub
	Public ReadOnly Property IsReusable As Boolean Implements IHttpHandler.IsReusable
		Get
			Return True
		End Get
	End Property
	Public NotInheritable Class HtmlOutputHandler
		Implements IOutputHtml
		Private ReadOnly _cache As Cache
		Private ReadOnly _name As String
		Private _mainPageData As Byte()
		Public Sub New(cache As Cache, name As String)
			_cache = cache
			_name = name
		End Sub
		Public Function OutputHtmlData(info As HtmlOutputInfoArgs) As String Implements IOutputHtml.OutputHtmlData
			Dim stream As Stream = info.OutputStream
			Dim dataLen = CInt(stream.Length)
			If dataLen <= 0 Then
				Return String.Empty
			End If
			Dim bytesData = New Byte(dataLen - 1) {}
			stream.Seek(0, SeekOrigin.Begin)
			stream.Read(bytesData, 0, dataLen)
			If info.OutputKind = HtmlOutputKind.HtmlPage Then
				MainPageData = bytesData
				Return _name
			End If
			Dim keyName As String = Guid.NewGuid().ToString() & HandlerCacheExtension
			' 30 seconds should be enough to load all images
			_cache.Insert(keyName, bytesData, Nothing, Cache.NoAbsoluteExpiration, New TimeSpan(0, 0, 30))
			Return keyName
		End Function
		Public Sub Finish() Implements IOutputHtml.Finish
		End Sub
		Public Property MainPageData As Byte()
			Get
				Return _mainPageData
			End Get
			Private Set(value As Byte())
				_mainPageData = value
			End Set
		End Property
	End Class
End Class
