Public Class DrillThrough1
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		'Connect to Sample Database
		'
		DataSource = New Data.OleDBDataSource()
		CType(DataSource, Data.OleDBDataSource).ConnectionString = My.Resources.ConnectionString
		
		CType(DataSource, Data.OleDBDataSource).SQL = "Select * from orders where customerID = '<%param:customerID%>' order by orderdate"
		Dim paramCustomerID As New SectionReportModel.Parameter()
		paramCustomerID.Key = "customerID"
	End Sub
	Private ds As Data.OleDBDataSource
	Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As EventArgs) Handles Detail.BeforePrint
		txtOrderID.HyperLink = "DrillThrough2:" & txtOrderID.Text
	End Sub
End Class
