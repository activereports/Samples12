Imports GrapeCity.ActiveReports.SectionReportModel
Public Class rptBookmarkSub
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	Private Sub Detail_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail.Format
		Detail.AddBookmark(CType(ParentReport.Sections("Detail").Controls("txtCategoryName"), TextBox).Text + "\" + txtProductName.Text)
	End Sub
End Class
