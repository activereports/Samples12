Public Class Catalog
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		
		Document.Name = "Catalog Report"
		
		'
	End Sub
	Private Sub PageFooter_BeforePrint(ByVal sender As Object, ByVal e As EventArgs) Handles PageFooter.BeforePrint
		Dim pg As Integer = CType(PageNumber, Integer)
		
		lblPage.Text = "Page " + pg.ToString(Globalization.CultureInfo.CurrentCulture)
		
		'
	End Sub
	Public ds As Data.OleDBDataSource
End Class
