﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GrapeCity.ActiveReports.Samples.Web.Professional._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/default.css"/>
    <title>ActiveReports Professional Edition Web Sample</title>
</head>
<body>
    
    <div id="pagetop">
        <div id="pagetitlebanner">
            <h1>
                <a href="Default.aspx">ActiveReports Professional Edition Web Sample</a></h1>
        </div>
    </div>
    <div id="pagebody">
     <h2>
            ActiveReports for ASP.NET Professional Edition Options</h2>
        <!-- WebControl -->
        <a href="WebControl.aspx">WebControl for ASP.NET</a>
        <br/>
        For easy to use, robust browser based viewing and easy drag-and-drop development
        ActiveReports includes the server side ASP.NET WebControl. The web control supports
        the following <b>viewer types</b> for viewing reports in the browser:
        
        <div id="pagebody0">
        <p>
           <b>Flash Viewer</b>
            <br/>
            Provides an interactive viewing experience, and a high quality printable output 
            by downloading an interactive, flexible, and tiny Flash viewer component to the 
            browser.&nbsp;&nbsp;             <br />
            The 
            <a href="FlashViewer.aspx">Flash Viewer Control</a> included with ActiveReports for .NET can be used to provide
            an interactive viewing experience, and a high quality printable output. Suitable
            for any browser with Adobe Flash Player 11 or above installed.</p>
    </div>
    <dl>
                <dt>
            Html Viewer
            </dt>
            <dd>
                &nbsp;Provides a scrollable view of a single page of the report at a time. Downloads
            only HTML and JavaScript to the client browser. Not preferable for printable output.
            </dd>
            <dt>
            PDF Reader
            </dt>
            <dd>
                Returns output as a PDF document viewable in Adobe Reader. Client Requirements:
            Adobe Reader.
            </dd>
            <dt>
            Raw Html
            </dt>
            <dd>
                Shows all pages in the report document as a single HTML continuous page. Provides
                a static view of the entire report document, and usually decent printable output,
                although under some circumstances, pagination is not preserved. 
            </dd>
        </dl>
        <!-- HttpHandlers -->
        <p>
            <a href="HttpHandlers.aspx">HttpHandlers</a>
            <br/>
            ActiveReports also includes three HttpHandler components (two for section(CompiledReportHandler, RpxHandler and one for page-RdlxHandler) that allow easy distribution
            of reports to your web server, and printable output (PDF) as well as HTML output.
        </p>
        <!-- Raw Exporting -->
        <p>
            <a href="CustomExportPdf.aspx">Custom Exporting PDF Example</a> &amp; <a href="CustomExportHtml.aspx">
                Custom Exporting HTML Example</a>
            <br/>
            The PDF and HTML exports allow developers to manually control exporting by writing
            a little code in your favorite ASP.NET language.
        </p>
        <p>
            <a href="ParameterReport.aspx">Parameterized Report Example</a>
            <br/>
            This sample demonstrates how to generate a report by passing a parameter 
            to the report.
        </p>

    </div>
    <form id="form1" runat="server">
    </form>
</body>
</html>
