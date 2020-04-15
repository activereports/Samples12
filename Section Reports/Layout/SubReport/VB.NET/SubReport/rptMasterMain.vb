Public Class rptMasterMain
	Inherits GrapeCity.ActiveReports.SectionReport
	Dim _rpt As rptMasterSub
	Dim _ds As GrapeCity.ActiveReports.Data.OleDBDataSource
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	Private Sub Detail_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail.Format
		ctlSubreport.Report = _rpt
	End Sub
	Private Sub rptMasterMain_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		_rpt = New rptMasterSub()
		Dim dS As New Data.OleDBDataSource()
		dS.ConnectionString = My.Resources.ConnectionString
		dS.SQL = "Select top 50 * from orders"
		DataSource = dS
		
		ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
		
		'
	End Sub
End Class
