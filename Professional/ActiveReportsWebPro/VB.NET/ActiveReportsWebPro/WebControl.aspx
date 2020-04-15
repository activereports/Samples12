<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebControl.aspx.vb" Inherits="GrapeCity.ActiveReports.Samples.Web.Professional.WebControl" culture="auto"%>
<%@ Register TagPrefix="activereportsweb" Namespace="GrapeCity.ActiveReports.Web"
    Assembly="GrapeCity.ActiveReports.Web.v12" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>GrapeCity ActiveReports WebViewer Control</title>
    <link rel="stylesheet" type="text/css" href="CSS/default.css"/>
</head>
<body>
    <div id="pagetop" style="z-index: 101">
        <div id="pagetitlebanner">
            <h1>
                <a href="Default.aspx">ActiveReports Professional Edition Web Sample</a></h1>
            <h2>
                WebViewerControl Sample</h2>
        </div>
    </div>
     <div class="content" style="overflow: auto">
        The ActiveReports WebControl allows you to easily publish simple reports to the
        web for viewing in the browser. The client machine will not require ActiveReports,
        nor ASP.NET to be installed. Below is a simple example of the ActiveReports web
        control. The WebControl also takes advantage of a report queuing technology to ensure
        the reports are executed and outputted efficiently. To use the webcontrol you simply
        select an ActiveReport using the Report property of the webcontrol in the property
        list. Alternatively, you can set the ReportName property programmatically to a new instance
        of an ActiveReport class.
    </div>
    <form id="form1" runat="server">
                 
        <activereportsweb:WebViewer ID="arvWebMain" Style="z-index: 102; left: 14px; position: absolute;
            top: 210px" runat="server" Width="814px" Height="476px"
            ReportName="file: RpxReports\Invoice.rpx" MaxReportRunTime="00:00:10" SlidingExpirationInterval="00:20:00">
            <HtmlExportOptions OutputType="DynamicHtml"
                RemoveVerticalSpace="False" BookmarkStyle="Html" CharacterSet="UnicodeUtf8"
                IncludePageMargins="False">
            </HtmlExportOptions>
            <PdfExportOptions ExportBookmarks="True" HideMenubar="False" ConvertMetaToPng="False"
                DisplayTitle="False" ImageResolution="0" Title="" Author="" Encrypt="False" OwnerPassword=""
                NeverEmbedFonts="Arial;Courier New;Times New Roman" Keywords="" HideWindowUI="False"
                CenterWindow="False" FitWindow="False" HideToolbar="False" DisplayMode="None"
                Application="GrapeCity ActiveReports (tm) 6" Version="Pdf13" Use128Bit="True"
                UserPassword="" ImageQuality="Medium" Permissions="AllowPrint, AllowModifyContents, AllowCopy, AllowModifyAnnotations, AllowFillIn, AllowAccessibleReaders, AllowAssembly"
                Subject="">
            </PdfExportOptions>
            <FlashViewerOptions ShowSplitter="false"> 
                <TocPanelOptions ShowThumbnails="False" ShowToc="False" /> 
            </FlashViewerOptions>    
        </activereportsweb:WebViewer>
       <asp:Label ID="lblViewerType" Style="z-index: 105; left: 24px; position: absolute;
            top: 175px" runat="server" Font-Bold="True">Select Viewer Type:</asp:Label>
        <asp:DropDownList ID="cboViewerType" Style="z-index: 103; left: 179px; position: absolute;
            top: 175px" runat="server" Width="149px"
            >
        </asp:DropDownList>
          <asp:Label ID="lblReportType" Style="z-index: 106; left: 350px; position: absolute;
            top: 175px" runat="server" Font-Bold="True">Select Report Type:</asp:Label>
        <asp:DropDownList ID="cboReportType" Style="z-index: 107; left: 505px; position: absolute;
            top: 175px" runat="server" Width="149px"
            >
            <asp:ListItem meta:resourcekey="liResourceSection"></asp:ListItem>
            <asp:ListItem meta:resourcekey="liResourcePage"></asp:ListItem>
            <asp:ListItem meta:resourcekey="liResourceRDL"></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="commit" runat="server" Style="z-index: 108; left: 656px; position: absolute;
            top: 174px" OnClick="commit_Click" Width="65px" meta:resourcekey="commitResource"/>

    </form>
</body>
</html>

