Public Class rptCandle
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
		'
		'
		'
		'
		'
	End Sub
	Private Sub rptCandle_ReportStart(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		
		ChartControl.ChartAreas(0).Axes("AxisX").Labels.Add("Monday")
		ChartControl.ChartAreas(0).Axes("AxisX").Labels.Add("Tuesday")
		ChartControl.ChartAreas(0).Axes("AxisX").Labels.Add("Wednesday")
		ChartControl.ChartAreas(0).Axes("AxisX").Labels.Add("Thursday")
		ChartControl.ChartAreas(0).Axes("AxisX").Labels.Add("Friday")
		
	End Sub
End Class
