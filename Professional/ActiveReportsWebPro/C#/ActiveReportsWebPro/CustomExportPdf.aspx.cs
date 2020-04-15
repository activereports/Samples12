using System;
using GrapeCity.ActiveReports.Export.Pdf.Section;
namespace GrapeCity.ActiveReports.Samples.Web.Professional
{
	public partial class CustomExportPdf : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			SectionReport rpt = new SectionReport();
			System.Xml.XmlTextReader xtr = new System.Xml.XmlTextReader(Server.MapPath("~") + @"\RpxReports\Invoice.rpx");
			rpt.LoadLayout(xtr);
			xtr.Close();
			try
			{
				rpt.Run(false);
			}
			catch (ReportException eRunReport)
			{
				// Failure running report, just report the error to the user:
				Response.Clear();
				
				Response.Write("<h1>Error running report:</h1>");
				
				
				Response.Write(eRunReport.ToString());
				return;
			}
			// Specify the appropriate viewer.
			// If the report has been exported in a different format, the content-type will 
			// need to be changed as noted in the following table:
			//	ExportType  ContentType
			//	PDF	   "application/pdf"  (needs to be in lowercase)
			//	RTF	   "application/rtf"
			//	TIFF	  "image/tiff"	   (will open in separate viewer instead of browser)
			//	HTML	  "message/rfc822"   (only applies to compressed HTML pages that includes images)
			//	Excel	 "application/vnd.ms-excel"
			//	Excel	 "application/excel" (either of these types should work) 
			//	Text	  "text/plain"  
			Response.ContentType = "application/pdf";
			Response.Clear();   
			Response.AddHeader("content-disposition", "inline;filename=MyPDF.PDF");
			// Create the PDF export object.
			PdfExport pdf = new PdfExport();
			// Create a new memory stream that will hold the pdf output
			System.IO.MemoryStream memStream = new System.IO.MemoryStream();
			// Export the report to PDF.
			pdf.Export(rpt.Document, memStream);
			// Write the PDF stream to the output stream.
			Response.BinaryWrite(memStream.ToArray());
			// Send all buffered content to the client
			Response.End();
		}
	}
}
