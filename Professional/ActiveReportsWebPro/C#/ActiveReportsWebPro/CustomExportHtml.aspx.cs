using System;
using System.Web;
using GrapeCity.ActiveReports.Export.Html.Section;
namespace GrapeCity.ActiveReports.Samples.Web.Professional
{
	/// <summary>
	/// CustomExportHtml - Showcases the use of our HTML Export over the web.
	/// </summary>
	public partial class CustomExportHtml : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			SectionReport rpt = new SectionReport();
			System.Xml.XmlTextReader xtr = new System.Xml.XmlTextReader(Server.MapPath("~") + @"\RpxReports\NwindLabels.rpx");
			rpt.LoadLayout(xtr);
			xtr.Close();
			try
			{
				rpt.Run(false);
			}
			catch (ReportException eRunReport)
			{
				// Show error message to the user when there is a failure in generating the report.
				Response.Clear();
				
				Response.Write("<h1>Error running report:</h1>");
				
				
				Response.Write(eRunReport.ToString());
				return;
			}
			// Used when the page output is already getting created.
			Response.Buffer = true;
			// Clear the output contents from the buffer stream.
			Response.ClearContent();
			// Clear any headers from the buffer stream (such as the content type for an HTML page).
			Response.ClearHeaders();
			// Notify the browser that cache should not be created.
			Response.Cache.SetCacheability(HttpCacheability.NoCache);
			// Specify the appropriate viewer for the browser.
			Response.ContentType = "text/html";
			// Create an instance of the HTMLExport class.
			HtmlExport html = new HtmlExport { IncludeHtmlHeader = true };
			// Export the report to HTML in this session's webcache.
			RpxHandler.HtmlOutputHandler output = new RpxHandler.HtmlOutputHandler(Cache, "Custom HTML");
			html.Export(rpt.Document, output, string.Empty);
			Response.BinaryWrite(output.MainPageData);
			// Send all buffered content to the client
			Response.End();
		}
		
		#region Web Form Designer generated code
		
		
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		}
		#endregion
	}
}
