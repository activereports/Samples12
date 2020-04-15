Public Class Invoice
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		
		Document.Name = "Invoice Report"
		
		'
	End Sub
	Public ds As Data.OleDBDataSource
	
End Class
