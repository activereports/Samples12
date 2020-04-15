Public Class DrillThroughMain
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		'Connect to Sample Database
		'
		DataSource = New Data.OleDBDataSource()
		CType(DataSource, Data.OleDBDataSource).ConnectionString = My.Resources.ConnectionString
		CType(DataSource, Data.OleDBDataSource).SQL = "Select * from customers order by customerID"
	End Sub
	Public ds As Data.OleDBDataSource
	' BeforePrint Event
	'BeforePrint Event
	'ActiveReports raises this event before the section is rendered to a page.
	'Use this event to modify the control's values before printing.
	'The changes made here do not effect the height of the section.
	Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As EventArgs) Handles Detail.BeforePrint
		'Assign the hyperlink value to the Text value
		'
		txtCustomerID.HyperLink = "DrillThrough1:" & txtCustomerID.Text
	End Sub
End Class
