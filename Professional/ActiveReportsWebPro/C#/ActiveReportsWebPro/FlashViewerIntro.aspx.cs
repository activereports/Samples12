using System;
using System.Web.UI.WebControls;
using System.IO;
namespace GrapeCity.ActiveReports.Samples.Web.Professional
{
	public partial class FlashViewerIntro : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// Populate the list of themes.
			DirectoryInfo themeDirectory = new DirectoryInfo(Server.MapPath("~/Themes"));
			FileInfo[] themeFiles = themeDirectory.GetFiles("*.swf");
			ThemesDropDownList.Items.Add(new ListItem("Default Theme", string.Empty));
			foreach (FileInfo themeFile in themeFiles)
				ThemesDropDownList.Items.Add(new ListItem(Path.GetFileNameWithoutExtension(themeFile.Name), "Themes/" + themeFile.Name));
			// Populate the list of reports.
			DirectoryInfo reportDirectory = new DirectoryInfo(Server.MapPath("~/RpxReports"));
			FileInfo[] reportFiles = reportDirectory.GetFiles("*.rpx");
			foreach (FileInfo reportFile in reportFiles)
				ReportsDropDownList.Items.Add(new ListItem(Path.GetFileNameWithoutExtension(reportFile.Name), "RpxReports/" + reportFile.Name));
		}
		protected void ViewReportButton_Click(object sender, EventArgs e)
		{
			// Transfer the request to the flash viewer page.
			Server.Transfer("~/FlashViewer.aspx", true);
		}
	}
}
