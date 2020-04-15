<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FlashViewer.aspx.vb" Inherits="GrapeCity.ActiveReports.Samples.Web.Professional.FlashViewer" %>
<%@ Register TagPrefix="ActiveReportsWeb" Namespace="GrapeCity.ActiveReports.Web"
    Assembly="GrapeCity.ActiveReports.Web.v12" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ActiveReports 12 Flash WebViewer</title>
        <style type="text/css">
    html, body, #WebViewer, #WebViewer_controlDiv
    {
        width: 100%;
        height: 100%;
        margin: 0;
    }
    </style>
</head>
<body>

        <ActiveReportsWeb:WebViewer ID="WebViewer" runat="server" ViewerType="FlashViewer" Width="100%" Height="100%" />
</body>
</html>
