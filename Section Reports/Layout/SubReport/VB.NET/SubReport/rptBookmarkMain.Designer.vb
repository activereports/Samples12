 _
Partial Class rptBookmarkMain
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBookmarkMain))
		Me.lblProducts = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lbllblCategoryName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.ctlSubreport = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.txtCategoryName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.ReportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.textBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		'
		'lblProducts
		'
		resources.ApplyResources(Me.lblProducts, "lblProducts")
		Me.lblProducts.Name = "lblProducts"
		'
		'lbllblCategoryName
		'
		Me.lbllblCategoryName.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		resources.ApplyResources(Me.lbllblCategoryName, "lbllblCategoryName")
		Me.lbllblCategoryName.Name = "lbllblCategoryName"
		'
		'ctlSubreport
		'
		Me.ctlSubreport.CloseBorder = False
		resources.ApplyResources(Me.ctlSubreport, "ctlSubreport")
		Me.ctlSubreport.Name = "ctlSubreport"
		Me.ctlSubreport.Report = Nothing
		'
		'txtCategoryName
		'
		Me.txtCategoryName.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.txtCategoryName.DataField = "CategoryName"
		resources.ApplyResources(Me.txtCategoryName, "txtCategoryName")
		Me.txtCategoryName.Name = "txtCategoryName"
		'
		'ReportInfo1
		'
		Me.ReportInfo1.FormatString = Nothing
		resources.ApplyResources(Me.ReportInfo1, "ReportInfo1")
		Me.ReportInfo1.Name = "ReportInfo1"
		'
		'textBox1
		'
		resources.ApplyResources(Me.textBox1, "textBox1")
		Me.textBox1.Name = "textBox1"
		'
		'Detail
		'
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblProducts, Me.lbllblCategoryName, Me.ctlSubreport, Me.txtCategoryName})
		Me.Detail.Height = 1.791!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.textBox1})
		Me.PageHeader.Height = 0.25!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ReportInfo1})
		Me.PageFooter.Height = 0.25!
		Me.PageFooter.Name = "PageFooter"
		'
		'rptBookmarkMain
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	 
	End Sub
Private WithEvents ReportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
Private WithEvents textBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private lblProducts As GrapeCity.ActiveReports.SectionReportModel.Label
Private lbllblCategoryName As GrapeCity.ActiveReports.SectionReportModel.Label
Private ctlSubreport As GrapeCity.ActiveReports.SectionReportModel.SubReport
Private txtCategoryName As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
