Imports GrapeCity.ActiveReports.Export.Html.Section
Public Class CustomExportHtml
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
		Dim rpt = New SectionReport()
		Dim xtr As System.Xml.XmlTextReader = New System.Xml.XmlTextReader(Server.MapPath("~") + "\RpxReports\NwindLabels.rpx")
		rpt.LoadLayout(xtr)
		xtr.Close()
		Try
			rpt.Run(False)
		Catch eRunReport As ReportException
			'Failure running report, just report the error to the user:
			Response.Clear()
			
			Response.Write("<h1>Error running report:</h1>")
			
			'
			Response.Write(eRunReport.ToString())
			Return
		End Try
		' Used when the page output is already getting created.
		Response.Buffer = True
		' Clear the output contents from the buffer stream.
		Response.ClearContent()
		' Clear any headers from the buffer stream (such as the content type for an HTML page).
		Response.ClearHeaders()
		' Notify the browser that cache should not be created.
		Response.Cache.SetCacheability(HttpCacheability.NoCache)
		' Specify the appropriate viewer for the browser.
		Response.ContentType = "text/html"
		' Create an instance of the HTMLExport class.
		Dim html As New HtmlExport()
		html.IncludeHtmlHeader = True
		Dim output As New RpxHandler.HtmlOutputHandler(Cache, "Custom HTML")
		html.Export(rpt.Document, output, String.Empty)
		Response.BinaryWrite(output.MainPageData)
		' Send all buffered content to the client
		Response.End()
	End Sub
End Class
