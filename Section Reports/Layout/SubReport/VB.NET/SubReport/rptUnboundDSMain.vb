Public Class rptUnboundDSMain
	Inherits GrapeCity.ActiveReports.SectionReport
	Dim _rpt As rptUnboundDSSub
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	Private Sub Detail_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail.Format
		'Create a DataView from the Orders table in the DataSet.
		'
		Dim ds As New DataSet()
		ds = CType(DataSource, DataSet)
		Dim dv As New DataView(ds.Tables("Orders"))
		dv.RowFilter = "CustomerID='" + TextBox1.Text + "'"
		'Orders data to bind to the report.
		'
		_rpt.DataSource = dv
		'Show the Orders report in the SubReport1 control.
		'
		SubReport1.Report = _rpt
	End Sub
	Private Sub rptUnboundDSMain_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		_rpt = New rptUnboundDSSub()
		
		ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
		
		'
	End Sub
End Class
