 _
Partial Class rptUnboundDSMain
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptUnboundDSMain))
		Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.SubReport1 = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.textBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.ReportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.textBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'Label1
		'
		resources.ApplyResources(Me.Label1, "Label1")
		Me.Label1.Name = "Label1"
		'
		'TextBox1
		'
		Me.TextBox1.DataField = "CustomerID"
		resources.ApplyResources(Me.TextBox1, "TextBox1")
		Me.TextBox1.Name = "TextBox1"
		'
		'SubReport1
		'
		Me.SubReport1.CloseBorder = False
		resources.ApplyResources(Me.SubReport1, "SubReport1")
		Me.SubReport1.Name = "SubReport1"
		Me.SubReport1.Report = Nothing
		'
		'Label2
		'
		resources.ApplyResources(Me.Label2, "Label2")
		Me.Label2.Name = "Label2"
		'
		'TextBox2
		'
		Me.TextBox2.DataField = "CompanyName"
		resources.ApplyResources(Me.TextBox2, "TextBox2")
		Me.TextBox2.Name = "TextBox2"
		'
		'Label3
		'
		resources.ApplyResources(Me.Label3, "Label3")
		Me.Label3.Name = "Label3"
		'
		'textBox3
		'
		resources.ApplyResources(Me.textBox3, "textBox3")
		Me.textBox3.Name = "textBox3"
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
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.TextBox1, Me.SubReport1, Me.Label2, Me.TextBox2, Me.Label3})
		Me.Detail.Height = 1.21875!
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.textBox3})
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ReportInfo1})
		Me.PageFooter.Name = "PageFooter"
		'
		'rptUnboundDSMain
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
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
			"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.textBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Friend WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents SubReport1 As GrapeCity.ActiveReports.SectionReportModel.SubReport
Friend WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
Private WithEvents textBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents ReportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
End Class
