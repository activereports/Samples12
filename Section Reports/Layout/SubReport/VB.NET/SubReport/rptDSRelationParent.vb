Public Class rptDSRelationParent
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	
	Dim cnt As Integer
	Private Sub Detail_Format(ByVal sender As Object, ByVal e As EventArgs) Handles Detail.Format
		'The tables in DataSet ("Categories") to get the DataRow included.
		'
		'The number of minutes that included DataRow Detail section, this is kept in the output.
		'
		Dim drCategories As DataRow = Nothing
		If CType(DataSource, DataSet).Tables("Categories").Rows.Count > cnt Then
			drCategories = CType(DataSource, DataSet).Tables("Categories").Rows(cnt)
			cnt = cnt + 1
		End If
		'Gets an array of child DataRow objects that are associated with the name of that relationship "CategoriesProducts" and sets the DataSource of the sub-report.
		'
		Dim rpt As New rptDSRelationChildMain
		rpt.DataSource = drCategories.GetChildRows(CType(DataSource, DataSet).Relations("CategoriesProducts"))
		SubReport1.Report = rpt
	End Sub
	Private Sub rptDSRelationParent_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		cnt = 0
		
		ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
		
		'
	End Sub
End Class
