Public Class rptParamMain
	Inherits GrapeCity.ActiveReports.SectionReport
	Dim rpt As rptParamSub
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	Private Sub Detail_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail.Format
		SubReport1.Report = rpt
	End Sub
	
	Private Sub rptParamMain_ReportStart(sender As System.Object, e As System.EventArgs) Handles MyBase.ReportStart
		rpt = Nothing
		rpt = New rptParamSub()
		Dim dS As New Data.OleDBDataSource()
		dS.ConnectionString = My.Resources.ConnectionString
		dS.SQL = "Select * from suppliers order by country"
		DataSource = dS
		
		ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
		
		'
	End Sub
End Class
