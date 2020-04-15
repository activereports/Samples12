Public Class rptBookmarkMain
	Inherits GrapeCity.ActiveReports.SectionReport
	Dim rpt As rptBookmarkSub
	Dim _categoryID As String
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	Private Sub rptMainBM_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles MyBase.FetchData
		_categoryID = (Fields("CategoryID").Value).ToString()
	End Sub
	Private Sub Detail_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail.Format
		Dim subDS As New Data.OleDBDataSource()
		subDS.ConnectionString = CType(DataSource, Data.OleDBDataSource).ConnectionString
		subDS.SQL = "Select * from products where categoryID = " + _categoryID
		rpt.DataSource = subDS
		ctlSubreport.Report = rpt
		Detail.AddBookmark(txtCategoryName.Text)
	End Sub
	
	Private Sub rptBookmarkMain_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		rpt = New rptBookmarkSub()
		Dim dS As New Data.OleDBDataSource()
		dS.ConnectionString = My.Resources.ConnectionString
		dS.SQL = "Select * from categories"
		DataSource = dS
		
		ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
		
		'
	End Sub
End Class
