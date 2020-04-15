 _
Partial Class Top10
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Top10))
		Me.srptTop10Customers = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.srptTop10Products = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		'
		'srptTop10Customers
		'
		Me.srptTop10Customers.CloseBorder = False
		resources.ApplyResources(Me.srptTop10Customers, "srptTop10Customers")
		Me.srptTop10Customers.Name = "srptTop10Customers"
		Me.srptTop10Customers.Report = Nothing
		'
		'srptTop10Products
		'
		Me.srptTop10Products.CloseBorder = False
		resources.ApplyResources(Me.srptTop10Products, "srptTop10Products")
		Me.srptTop10Products.Name = "srptTop10Products"
		Me.srptTop10Products.Report = Nothing
		'
		'Detail
		'
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.srptTop10Customers, Me.srptTop10Products})
		Me.Detail.Height = 2.3125!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'Top10
		'
		Me.MasterReport = False
		Me.PageSettings.Margins.Left = 0.5!
		Me.PageSettings.Margins.Right = 0.5!
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.489583!
		Me.Sections.Add(Me.Detail)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
				   "l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private srptTop10Customers As GrapeCity.ActiveReports.SectionReportModel.SubReport
Private srptTop10Products As GrapeCity.ActiveReports.SectionReportModel.SubReport
End Class
