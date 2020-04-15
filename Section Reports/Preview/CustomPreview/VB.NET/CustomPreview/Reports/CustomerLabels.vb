Public Class CustomerLabels
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		
		Document.Name = "Labels Report"
		
		'
	End Sub
	Public ds As GrapeCity.ActiveReports.Data.OleDBDataSource
	
End Class
