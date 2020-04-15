using System;
using System.Globalization;
using System.Threading;
using GrapeCity.ActiveReports.Web.Controls;
namespace GrapeCity.ActiveReports.Samples.Web.Professional
{
	public partial class FlashViewer : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			//  Ensure that the report has been selected on the introduction page.
			string reportName = Request.Form["ReportsDropDownList"];
			if (string.IsNullOrEmpty(reportName))
				Server.Transfer("~/FlashViewerIntro.aspx");
			// Load the report layout and generate the report.
			SectionReport report = new SectionReport();
			System.Xml.XmlTextReader xtr = new System.Xml.XmlTextReader(Server.MapPath(reportName));
			report.LoadLayout(xtr);
			xtr.Close();
			report.ShowParameterUI = false;
			report.Document.Printer.PrinterName = string.Empty;
			// Set the report in the WebViewer.
			WebViewer.Report = report;
			// Reflect the properties set in FlashViewerIntro.aspx.
			WebViewer.FlashViewerOptions.ResourceLocale = Request.Form["LanguageDropDownList"];
			WebViewer.FlashViewerOptions.ThemeUrl = Request.Form["ThemesDropDownList"];
			WebViewer.FlashViewerOptions.ShowSplitter = GetBooleanValueFromForm(Request.Form["ShowSplitter"]);
			WebViewer.FlashViewerOptions.TocPanelOptions.ShowThumbnails = GetBooleanValueFromForm(Request.Form["ShowThumbnails"]);
			WebViewer.FlashViewerOptions.TocPanelOptions.ShowToc = GetBooleanValueFromForm(Request.Form["ShowTOC"]);
			WebViewer.FlashViewerToolBar.Visible = GetBooleanValueFromForm(Request.Form["ShowToolbar"]);
			// add a custom toolbar button if the user selected InsertButton on the intro page
			if (GetBooleanValueFromForm(Request.Form["InsertButton"]))
			{
				Thread.CurrentThread.CurrentUICulture = new CultureInfo(Request.Form["LanguageDropDownList"].Replace('_', '-'));
				ToolButton customButton = Tool.CreateButton("CustomButton");
				customButton.Caption = (string)GetLocalResourceObject("customButtonCaption");
				customButton.ToolTip = (string)GetLocalResourceObject("customButtonToolTip");
				customButton.ClickNavigateTo = (string)GetLocalResourceObject("customButtonUrl");
				WebViewer.FlashViewerToolBar.Tools.Add(customButton);
			}
		}
		// Helper method that returns a boolean value based on the form value of a checkbox.
		private static bool GetBooleanValueFromForm(string value)
		{
			return string.Compare(value, "on", StringComparison.InvariantCultureIgnoreCase) == 0;
		}
	}
}
