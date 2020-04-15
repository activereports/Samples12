 _
Partial Class AnnualReport
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnnualReport))
		Me.srptTop10 = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.lblTop10Products = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTop10Customers = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblNorthWind = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTraders = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblAnnualReport = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.PageBreak1 = New GrapeCity.ActiveReports.SectionReportModel.PageBreak()
		Me.shpYellowBackground = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.lblMessage1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblMessageHdr1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblMessage2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblMessage3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblAnnualReportTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblARYears = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblMessageHdr2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblMessageHdr3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblMessage4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.imgCompanyLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
		Me.srptProductSales = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
		Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		'
		'srptTop10
		'
		Me.srptTop10.CloseBorder = False
		resources.ApplyResources(Me.srptTop10, "srptTop10")
		Me.srptTop10.Name = "srptTop10"
		Me.srptTop10.Report = Nothing
		'
		'lblTop10Products
		'
		resources.ApplyResources(Me.lblTop10Products, "lblTop10Products")
		Me.lblTop10Products.Name = "lblTop10Products"
		'
		'lblTop10Customers
		'
		resources.ApplyResources(Me.lblTop10Customers, "lblTop10Customers")
		Me.lblTop10Customers.Name = "lblTop10Customers"
		'
		'lblNorthWind
		'
		resources.ApplyResources(Me.lblNorthWind, "lblNorthWind")
		Me.lblNorthWind.Name = "lblNorthWind"
		'
		'lblTraders
		'
		resources.ApplyResources(Me.lblTraders, "lblTraders")
		Me.lblTraders.Name = "lblTraders"
		'
		'lblAnnualReport
		'
		resources.ApplyResources(Me.lblAnnualReport, "lblAnnualReport")
		Me.lblAnnualReport.Name = "lblAnnualReport"
		'
		'PageBreak1
		'
		resources.ApplyResources(Me.PageBreak1, "PageBreak1")
		Me.PageBreak1.Name = "PageBreak1"
		Me.PageBreak1.Size = New System.Drawing.SizeF(6.5!, 0.05555556!)
		'
		'shpYellowBackground
		'
		Me.shpYellowBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		resources.ApplyResources(Me.shpYellowBackground, "shpYellowBackground")
		Me.shpYellowBackground.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Transparent
		Me.shpYellowBackground.Name = "shpYellowBackground"
		Me.shpYellowBackground.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		'
		'lblMessage1
		'
		resources.ApplyResources(Me.lblMessage1, "lblMessage1")
		Me.lblMessage1.Name = "lblMessage1"
		'
		'lblMessageHdr1
		'
		resources.ApplyResources(Me.lblMessageHdr1, "lblMessageHdr1")
		Me.lblMessageHdr1.Name = "lblMessageHdr1"
		'
		'lblMessage2
		'
		resources.ApplyResources(Me.lblMessage2, "lblMessage2")
		Me.lblMessage2.Name = "lblMessage2"
		'
		'lblMessage3
		'
		resources.ApplyResources(Me.lblMessage3, "lblMessage3")
		Me.lblMessage3.Name = "lblMessage3"
		'
		'lblAnnualReportTitle
		'
		resources.ApplyResources(Me.lblAnnualReportTitle, "lblAnnualReportTitle")
		Me.lblAnnualReportTitle.Name = "lblAnnualReportTitle"
		'
		'lblARYears
		'
		resources.ApplyResources(Me.lblARYears, "lblARYears")
		Me.lblARYears.Name = "lblARYears"
		'
		'lblMessageHdr2
		'
		resources.ApplyResources(Me.lblMessageHdr2, "lblMessageHdr2")
		Me.lblMessageHdr2.Name = "lblMessageHdr2"
		'
		'lblMessageHdr3
		'
		resources.ApplyResources(Me.lblMessageHdr3, "lblMessageHdr3")
		Me.lblMessageHdr3.Name = "lblMessageHdr3"
		'
		'lblMessage4
		'
		resources.ApplyResources(Me.lblMessage4, "lblMessage4")
		Me.lblMessage4.Name = "lblMessage4"
		'
		'imgCompanyLogo
		'
		Me.imgCompanyLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		resources.ApplyResources(Me.imgCompanyLogo, "imgCompanyLogo")
		Me.imgCompanyLogo.ImageData = CType(resources.GetObject("imgCompanyLogo.ImageData"), System.IO.Stream)
		Me.imgCompanyLogo.LineColor = System.Drawing.Color.Black
		Me.imgCompanyLogo.Name = "imgCompanyLogo"
		'
		'srptProductSales
		'
		Me.srptProductSales.CloseBorder = False
		resources.ApplyResources(Me.srptProductSales, "srptProductSales")
		Me.srptProductSales.Name = "srptProductSales"
		Me.srptProductSales.Report = Nothing
		'
		'Detail
		'
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.srptTop10, Me.lblTop10Products, Me.lblTop10Customers})
		Me.Detail.Height = 2.375!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'ReportHeader
		'
		Me.ReportHeader.CanGrow = False
		Me.ReportHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblNorthWind, Me.lblAnnualReport, Me.PageBreak1, Me.shpYellowBackground, Me.lblMessage1, Me.lblMessageHdr1, Me.lblMessage2, Me.lblMessage3, Me.lblAnnualReportTitle, Me.lblARYears, Me.lblMessageHdr2, Me.lblMessageHdr3, Me.lblMessage4, Me.imgCompanyLogo, Me.srptProductSales, Me.lblTraders})
		Me.ReportHeader.Height = 15.25!
		Me.ReportHeader.Name = "ReportHeader"
		Me.ReportHeader.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
		'
		'ReportFooter
		'
		Me.ReportFooter.CanGrow = False
		Me.ReportFooter.Height = 0.0!
		Me.ReportFooter.KeepTogether = True
		Me.ReportFooter.Name = "ReportFooter"
		'
		'PageHeader
		'
		Me.PageHeader.CanGrow = False
		Me.PageHeader.Height = 0.0!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.CanGrow = False
		Me.PageFooter.Height = 0.0!
		Me.PageFooter.Name = "PageFooter"
		'
		'AnnualReport
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Sections.Add(Me.ReportHeader)
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.Sections.Add(Me.ReportFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents ReportHeader As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private WithEvents ReportFooter As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
Private lblNorthWind As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblTraders As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblAnnualReport As GrapeCity.ActiveReports.SectionReportModel.Label
Private PageBreak1 As GrapeCity.ActiveReports.SectionReportModel.PageBreak
Private shpYellowBackground As GrapeCity.ActiveReports.SectionReportModel.Shape
Private lblMessage1 As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblMessageHdr1 As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblMessage2 As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblMessage3 As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblAnnualReportTitle As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblARYears As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblMessageHdr2 As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblMessageHdr3 As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblMessage4 As GrapeCity.ActiveReports.SectionReportModel.Label
Private imgCompanyLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
Private srptProductSales As GrapeCity.ActiveReports.SectionReportModel.SubReport
Private srptTop10 As GrapeCity.ActiveReports.SectionReportModel.SubReport
Private lblTop10Products As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblTop10Customers As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
