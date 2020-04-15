Public Class Top10
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	' ReportStart Event
	' Use this event to initialize any objects or variables needed while running a report.
	' Also use this event to set any Subreport control objects to a new instance 
	' of the report assigned to the Subreport control.任意の子レポートを割り当てることができます。
	Private Sub Top10_ReportStart(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.ReportStart
		srptTop10Products.Report = New Top10Products()
		srptTop10Customers.Report = New Top10Customers()
	End Sub
End Class
