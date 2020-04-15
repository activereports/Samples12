Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Public Class Invoice
	Inherits GrapeCity.ActiveReports.SectionReport
	Public Sub New()
		MyBase.New()
		InitializeComponent()
		Me.Document.Name = "Invoice ActiveReport"
	End Sub
	
	
	
	
	
	Public ds As GrapeCity.ActiveReports.Data.OleDBDataSource
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	Private Sub Invoice_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
	End Sub
End Class
