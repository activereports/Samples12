Imports System.IO
Imports GrapeCity.ActiveReports.Extensibility.Rendering.IO
Imports GrapeCity.ActiveReports.Rendering.IO
Public Class RdlxHandler
	Implements IHttpHandler
	Public Const HandlerCacheExtension As String = ".rdlxWeb"
	Public Sub ProcessRequest(context As HttpContext) Implements IHttpHandler.ProcessRequest
		' return image
		Dim keyName = Path.GetFileName(context.Request.FilePath)
		Dim cacheItem = context.Cache(keyName)
		context.Response.BinaryWrite(DirectCast(cacheItem, Byte()))
	End Sub
	Public ReadOnly Property IsReusable As Boolean Implements IHttpHandler.IsReusable
		Get
			Return True
		End Get
	End Property
	Public NotInheritable Class HtmlStreamProvider
		Inherits MemoryStreamProvider
		Protected Overrides Function GetStreamUri(extension As String) As Uri
			Dim uri As Uri = MyBase.GetStreamUri(extension)
			Return New Uri(uri.OriginalString + HandlerCacheExtension, UriKind.Relative)
		End Function
		Public Sub CacheImages(cache As Cache)
			For Each secondaryStreamInfo As StreamInfo In GetSecondaryStreams()
				Dim secondaryStream = DirectCast(secondaryStreamInfo.OpenStream(), MemoryStream)
				' 30 seconds should be enough to load all images
				cache.Insert(secondaryStreamInfo.Uri.OriginalString, secondaryStream.ToArray(), Nothing, cache.NoAbsoluteExpiration, New TimeSpan(0, 0, 30))
			Next
		End Sub
	End Class
End Class
