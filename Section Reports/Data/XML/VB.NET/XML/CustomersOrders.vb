Public Class CustomersOrders
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub
	' Format Event
	' ActiveReports raises this event after the data is loaded and bound to the controls contained in a section, 
	' but before the section is rendered to a page.The Format event is the only event in which you can change
	' the section's height. Use this section to set or change the properties of any controls or the section itself.
	' Also use the Format event to pass information, such as an SQL String, to a Subreport.
	Private Sub Detail_Format_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles Detail.Format
		'Set subreport object per line.
		srptOrders.Report = New Orders()
	End Sub
End Class
