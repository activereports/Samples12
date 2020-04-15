Public Class rptNestedParent
	Inherits GrapeCity.ActiveReports.SectionReport
	Dim _rpt As rptNestedChildMain
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	Private Sub Detail_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail.Format
		subOrders.Report = _rpt
	End Sub
	Private Sub rptNestedParent_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		_rpt = New rptNestedChildMain()
		Dim dS As New Data.OleDBDataSource()
		dS.ConnectionString = My.Resources.ConnectionString
		dS.SQL = "Select * from employees"
		DataSource = dS
		
		ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
		
		'
	End Sub
End Class
