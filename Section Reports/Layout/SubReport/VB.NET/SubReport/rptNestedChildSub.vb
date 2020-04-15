Public Class rptNestedChildSub
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		Dim dS As New Data.OleDBDataSource()
		dS.ConnectionString = My.Resources.ConnectionString
		dS.SQL = "Select * from customers where customerID = '<%CustomerID%>'"
		DataSource = dS
	End Sub
End Class
