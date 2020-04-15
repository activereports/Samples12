Public Class rpt3DBar
	Inherits GrapeCity.ActiveReports.SectionReport
	
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		'
		'
		'
		'
		'
		'
	End Sub
	Private Sub rptUnboundChart_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		'To create a series.
		'
		Dim s As New Chart.Series
		s.Type = Chart.ChartType.Bar3D
		'(If the path of the mdb is different, please change below.)
		'
		Dim cnnString As String = My.Resources.ConnectionString
		Dim cnn As New OleDb.OleDbConnection(cnnString)
		Dim oDBAdapter As OleDb.OleDbDataAdapter
		'Create a DataSet.
		'
		Dim oDS As DataSet
		oDBAdapter = New OleDb.OleDbDataAdapter("SELECT * from Orders WHERE OrderDate < #08/17/1994#", cnnString)
		oDS = New DataSet
		oDBAdapter.Fill(oDS, "Orders")
		'Setting each of the properties for DataSource,ValueMembersY and ValueMembersX
		'
		ChartControl1.DataSource = oDS
		ChartControl1.Series.Add(s)
		ChartControl1.Series(0).ValueMembersY = oDS.Tables("Orders").Columns(7).ColumnName
		ChartControl1.Series(0).ValueMemberX = oDS.Tables("Orders").Columns(8).ColumnName
		'Set the angle on the labelto avoid overlapping
		'
		ChartControl1.ChartAreas(0).Axes(0).LabelFont.Angle = -90
	End Sub
End Class
