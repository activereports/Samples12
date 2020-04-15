Public Class rptSimpleMain
	Inherits GrapeCity.ActiveReports.SectionReport
	Dim _rpt As rptSimpleSub
	Dim _categoryID As String
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	Private Sub rptMain_FetchData(ByVal sender As Object, ByVal eArgs As FetchEventArgs) Handles MyBase.FetchData
		' Gets the criteria for data to be output to the sub report.
		'
		_categoryID = (Me.Fields("CategoryID").Value).ToString()
	End Sub
	Private Sub Detail_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail.Format
		Dim subDS As New Data.OleDBDataSource
		'SQL statement to set the connection string for the data source of the subreport.
		' 
		subDS.ConnectionString = CType(DataSource, Data.OleDBDataSource).ConnectionString
		subDS.SQL = "SELECT * FROM products WHERE categoryID = " + _categoryID
		_rpt.DataSource = subDS
		'Sets the sub-report object to the subreport control.
		' 
		ctlSubreport.Report = _rpt
	End Sub
	Private Sub rptSimpleMain_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		_rpt = New rptSimpleSub()
		Dim dS As New Data.OleDBDataSource()
		dS.ConnectionString = My.Resources.ConnectionString
		dS.SQL = "Select * from categories"
		DataSource = dS
		
		ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
		
		'
	End Sub
End Class
