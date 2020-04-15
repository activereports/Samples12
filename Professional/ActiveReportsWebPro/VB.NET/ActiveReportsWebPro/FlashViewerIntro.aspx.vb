Imports System.IO
Public Class FlashViewerIntro
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		' Populate the list of themes.
		Dim themeDirectory As New DirectoryInfo(Server.MapPath("~/Themes"))
		Dim themeFiles As FileInfo() = themeDirectory.GetFiles("*.swf")
		ThemesDropDownList.Items.Add(New ListItem("Default Theme", String.Empty))
		For Each themeFile As FileInfo In themeFiles
			ThemesDropDownList.Items.Add(New ListItem(Path.GetFileNameWithoutExtension(themeFile.Name), "Themes/" + themeFile.Name))
		Next
		' Populate the list of reports.
		Dim reportDirectory As New DirectoryInfo(Server.MapPath("~/RpxReports"))
		Dim reportFiles As FileInfo() = reportDirectory.GetFiles("*.rpx")
		For Each reportFile As FileInfo In reportFiles
			ReportsDropDownList.Items.Add(New ListItem(Path.GetFileNameWithoutExtension(reportFile.Name), "RpxReports/" + reportFile.Name))
		Next
	End Sub
	Protected Sub ViewReportButton_Click(ByVal sender As Object, ByVal e As EventArgs)
		' Transfer the request to the flash viewer page.
		Server.Transfer("~/FlashViewer.aspx", True)
	End Sub
End Class
