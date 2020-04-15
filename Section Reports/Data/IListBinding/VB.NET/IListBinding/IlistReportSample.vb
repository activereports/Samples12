Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Public Class IlistReportSample
	Inherits GrapeCity.ActiveReports.SectionReport
	Private _productCollection As IListBinding.DataLayer.ProductCollection
	Private _greenBarCounter As Long = 0
	Sub New(productCollection As IListBinding.DataLayer.ProductCollection)
		_productCollection = productCollection
		InitializeComponent()
	End Sub
	
	Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
		' Green bar effect colors the background of every other row.
		_greenBarCounter = _greenBarCounter + 1
		If _greenBarCounter Mod 2 = 0 Then
			Me.Detail.BackColor = System.Drawing.Color.Transparent
		Else
			Me.Detail.BackColor = System.Drawing.Color.LightGray
		End If
		' Reorder Row Coloring - Highlights the products that are to be
		'  re-ordered for a better understanding.
		'  Values for calculating the highlight.
		Dim _reorderLevel As Integer = Int32.Parse(Me.txtReorderLevel.Text)
		Dim _unitsInStock As Integer = Int32.Parse(Me.txtUnitsInStock.Text)
		If _unitsInStock < _reorderLevel Then
			' Highlight since the re-stocking level has been met.
			Me.Detail.BackColor = System.Drawing.Color.LightCoral
			
			Me.txtComments.Text = "Check " + Me.txtProductName.Text
			
			'
		Else
			' Reset the comments text
			Me.txtComments.Text = ""
		End If
	End Sub
	Private Sub IlistReportSample_ReportStart(sender As Object, e As EventArgs) Handles MyBase.ReportStart
		' Assign the productCollection DataLayer Object to the report's datasource
		Me.DataSource = _productCollection
	End Sub
End Class
