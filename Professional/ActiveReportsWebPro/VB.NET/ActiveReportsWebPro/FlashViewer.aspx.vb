Imports System.Globalization
Imports GrapeCity.ActiveReports.Web.Controls
Imports System.Threading
Public Class FlashViewer
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		' Ensure that the report has been selected on the introduction page.
		Dim reportName As String = Request.Form("ReportsDropDownList")
		If String.IsNullOrEmpty(reportName) Then
			Server.Transfer("~/FlashViewerIntro.aspx")
		End If
		' Load the report layout and generate the report.
		Dim report As New SectionReport()
		Dim xtr As New System.Xml.XmlTextReader(Server.MapPath(reportName))
		report.LoadLayout(xtr)
		xtr.Close()
		report.ShowParameterUI = False
		report.Document.Printer.PrinterName = String.Empty
		' Set the report in the WebViewer.
		WebViewer.Report = report
		' Reflect the properties set in FlashViewerIntro.aspx.
		WebViewer.FlashViewerOptions.ResourceLocale = Request.Form("LanguageDropDownList")
		WebViewer.FlashViewerOptions.ThemeUrl = Request.Form("ThemesDropDownList")
		WebViewer.FlashViewerOptions.ShowSplitter = GetBooleanValueFromForm(Request.Form("ShowSplitter"))
		WebViewer.FlashViewerOptions.TocPanelOptions.ShowThumbnails = GetBooleanValueFromForm(Request.Form("ShowThumbnails"))
		WebViewer.FlashViewerOptions.TocPanelOptions.ShowToc = GetBooleanValueFromForm(Request.Form("ShowTOC"))
		WebViewer.FlashViewerToolBar.Visible = GetBooleanValueFromForm(Request.Form("ShowToolbar"))
		' add a custom toolbar button if the user selected InsertButton on the intro page
		If GetBooleanValueFromForm(Request.Form("InsertButton")) Then
			Thread.CurrentThread.CurrentUICulture = New CultureInfo(Replace(Request.Form("LanguageDropDownList"), "_", "-"))
			Dim customButton As ToolButton = Tool.CreateButton("CustomButton")
			customButton.Caption = GetLocalResourceObject("customButtonCaption")
			customButton.ToolTip = GetLocalResourceObject("customButtonToolTip")
			customButton.ClickNavigateTo = GetLocalResourceObject("customButtonUrl")
			WebViewer.FlashViewerToolBar.Tools.Add(customButton)
		End If
	End Sub
	' Helper method that returns a boolean value based on the form value of a checkbox.
	Private Shared Function GetBooleanValueFromForm(ByVal value As String) As Boolean
		Return String.Compare(value, "on", StringComparison.InvariantCultureIgnoreCase) = 0
	End Function
End Class
