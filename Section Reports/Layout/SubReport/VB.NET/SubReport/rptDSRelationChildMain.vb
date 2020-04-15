Public Class rptDSRelationChildMain
	Inherits GrapeCity.ActiveReports.SectionReport
	Dim _drc() As DataRow
	Dim _cnt As Integer
	Dim _rpt As rptDSRelationChildSub
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	Private Sub Detail_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail.Format
		_drc = CType(DataSource, DataRow())
		''Gets an array of child DataRow objects that are associated with the name of the relationship "ProductsOrderDetails" and set the DataSource of the sub-report.
		''
		If (_cnt < _drc.Length) Then
			_rpt.DataSource = _drc(_cnt).GetChildRows("ProductsOrderDetails")
		End If
		_cnt = _cnt + 1
	End Sub
	Private Sub rptDSRelationChildMain_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		_rpt = New rptDSRelationChildSub
		SubReport1.Report = _rpt
	End Sub
End Class
