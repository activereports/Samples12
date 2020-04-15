 _
Partial Class rptParamMain
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptParamMain))
		Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.SubReport1 = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.ReportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		Me.ghSuppliers = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'TextBox2
		'
		Me.TextBox2.DataField = "CompanyName"
		resources.ApplyResources(Me.TextBox2, "TextBox2")
		Me.TextBox2.Name = "TextBox2"
		'
		'TextBox3
		'
		Me.TextBox3.DataField = "ContactName"
		resources.ApplyResources(Me.TextBox3, "TextBox3")
		Me.TextBox3.Name = "TextBox3"
		'
		'TextBox4
		'
		Me.TextBox4.DataField = "Phone"
		resources.ApplyResources(Me.TextBox4, "TextBox4")
		Me.TextBox4.Name = "TextBox4"
		'
		'SubReport1
		'
		Me.SubReport1.CloseBorder = False
		resources.ApplyResources(Me.SubReport1, "SubReport1")
		Me.SubReport1.Name = "SubReport1"
		Me.SubReport1.Report = Nothing
		'
		'TextBox1
		'
		Me.TextBox1.DataField = "Country"
		resources.ApplyResources(Me.TextBox1, "TextBox1")
		Me.TextBox1.Name = "TextBox1"
		'
		'ReportInfo1
		'
		Me.ReportInfo1.FormatString = Nothing
		resources.ApplyResources(Me.ReportInfo1, "ReportInfo1")
		Me.ReportInfo1.Name = "ReportInfo1"
		'
		'TextBox5
		'
		resources.ApplyResources(Me.TextBox5, "TextBox5")
		Me.TextBox5.Name = "TextBox5"
		'
		'Detail
		'
		Me.Detail.CanShrink = True
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.SubReport1})
		Me.Detail.Height = 1.290972!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox5})
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ReportInfo1})
		Me.PageFooter.Name = "PageFooter"
		'
		'ghSuppliers
		'
		Me.ghSuppliers.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox1})
		Me.ghSuppliers.DataField = "Country"
		Me.ghSuppliers.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.FirstDetail
		Me.ghSuppliers.Height = 0.2291667!
		Me.ghSuppliers.Name = "ghSuppliers"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'rptParamMain
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.ghSuppliers)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents ghSuppliers As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents ReportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
Private WithEvents TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private SubReport1 As GrapeCity.ActiveReports.SectionReportModel.SubReport
End Class
