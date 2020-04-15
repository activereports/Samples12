Public Class AnnualReport
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	' ReportStart Event
	' Use this event to initialize any objects or variables needed while running a report.
	' Also use this event to set any Subreport control objects to a new instance 
	' of the report assigned to the Subreport control.
	Private Sub AnnualReport_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		'Set subreport control's Report property to a new report instance.
		srptTop10.Report = New Top10()
		srptProductSales.Report = New ProductSalesByCategory()
	End Sub
End Class
