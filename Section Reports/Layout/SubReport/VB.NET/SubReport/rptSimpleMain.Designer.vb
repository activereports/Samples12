 _
Partial Class rptSimpleMain
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSimpleMain))
		Me.lblCategoryName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtCategoryName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.ctlSubreport = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.textBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.ReportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		CType(Me.lblCategoryName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCategoryName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.textBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'lblCategoryName
		'
		resources.ApplyResources(Me.lblCategoryName, "lblCategoryName")
		Me.lblCategoryName.Name = "lblCategoryName"
		'
		'txtCategoryName
		'
		Me.txtCategoryName.DataField = "CategoryName"
		resources.ApplyResources(Me.txtCategoryName, "txtCategoryName")
		Me.txtCategoryName.Name = "txtCategoryName"
		'
		'ctlSubreport
		'
		Me.ctlSubreport.CloseBorder = False
		resources.ApplyResources(Me.ctlSubreport, "ctlSubreport")
		Me.ctlSubreport.Name = "ctlSubreport"
		Me.ctlSubreport.Report = Nothing
		'
		'textBox1
		'
		resources.ApplyResources(Me.textBox1, "textBox1")
		Me.textBox1.Name = "textBox1"
		'
		'ReportInfo1
		'
		Me.ReportInfo1.FormatString = Nothing
		resources.ApplyResources(Me.ReportInfo1, "ReportInfo1")
		Me.ReportInfo1.Name = "ReportInfo1"
		'
		'Detail
		'
		Me.Detail.CanShrink = True
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblCategoryName, Me.txtCategoryName, Me.ctlSubreport})
		Me.Detail.Height = 0.75!
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.textBox1})
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ReportInfo1})
		Me.PageFooter.Name = "PageFooter"
		'
		'rptSimpleMain
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; color: Black; fon" & _
					"t-size: 10pt; vertical-align: top; font-family: ""Arial""; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
					"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.lblCategoryName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCategoryName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.textBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents textBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents ReportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private lblCategoryName As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtCategoryName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private ctlSubreport As GrapeCity.ActiveReports.SectionReportModel.SubReport
End Class
