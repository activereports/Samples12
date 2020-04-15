<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CategoryReport
	Inherits GrapeCity.ActiveReports.SectionReport
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
		End If
		MyBase.Dispose(disposing)
	End Sub
	'NOTE: The following procedure is required by the ActiveReports Designer
	'It can be modified using the ActiveReports Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoryReport))
		Me.txtAvgUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCategory = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.textBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblTotalNumber = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtProductCount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lneReportFooter = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblProductName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lnePageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lnePageHeader2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
		Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		'
		'txtAvgUnitPrice
		'
		Me.txtAvgUnitPrice.CanShrink = True
		resources.ApplyResources(Me.txtAvgUnitPrice, "txtAvgUnitPrice")
		Me.txtAvgUnitPrice.DataField = "AvgUnitPrice"
		Me.txtAvgUnitPrice.Name = "txtAvgUnitPrice"
		Me.txtAvgUnitPrice.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 4, 0)
		'
		'txtCategory
		'
		Me.txtCategory.CanShrink = True
		resources.ApplyResources(Me.txtCategory, "txtCategory")
		Me.txtCategory.DataField = "CategoryName"
		Me.txtCategory.Name = "txtCategory"
		'
		'textBox1
		'
		Me.textBox1.CanShrink = True
		resources.ApplyResources(Me.textBox1, "textBox1")
		Me.textBox1.DataField = "ProductCount"
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 4, 0)
		'
		'lblTotalNumber
		'
		resources.ApplyResources(Me.lblTotalNumber, "lblTotalNumber")
		Me.lblTotalNumber.Name = "lblTotalNumber"
		'
		'txtProductCount
		'
		resources.ApplyResources(Me.txtProductCount, "txtProductCount")
		Me.txtProductCount.DataField = "CategoryID"
		Me.txtProductCount.Name = "txtProductCount"
		Me.txtProductCount.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Count
		Me.txtProductCount.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
		'
		'lneReportFooter
		'
		resources.ApplyResources(Me.lneReportFooter, "lneReportFooter")
		Me.lneReportFooter.LineWeight = 2.0!
		Me.lneReportFooter.Name = "lneReportFooter"
		Me.lneReportFooter.X1 = 0.0!
		Me.lneReportFooter.X2 = 6.635433!
		Me.lneReportFooter.Y1 = 0.0!
		Me.lneReportFooter.Y2 = 0.0!
		'
		'label1
		'
		resources.ApplyResources(Me.label1, "label1")
		Me.label1.Name = "label1"
		'
		'lblUnitPrice
		'
		resources.ApplyResources(Me.lblUnitPrice, "lblUnitPrice")
		Me.lblUnitPrice.Name = "lblUnitPrice"
		'
		'lblProductName
		'
		resources.ApplyResources(Me.lblProductName, "lblProductName")
		Me.lblProductName.Name = "lblProductName"
		'
		'lblTitle
		'
		resources.ApplyResources(Me.lblTitle, "lblTitle")
		Me.lblTitle.Name = "lblTitle"
		'
		'lnePageHeader1
		'
		resources.ApplyResources(Me.lnePageHeader1, "lnePageHeader1")
		Me.lnePageHeader1.LineWeight = 2.0!
		Me.lnePageHeader1.Name = "lnePageHeader1"
		Me.lnePageHeader1.X1 = 0.0!
		Me.lnePageHeader1.X2 = 6.583465!
		Me.lnePageHeader1.Y1 = 1.0!
		Me.lnePageHeader1.Y2 = 1.0!
		'
		'lnePageHeader2
		'
		resources.ApplyResources(Me.lnePageHeader2, "lnePageHeader2")
		Me.lnePageHeader2.LineWeight = 2.0!
		Me.lnePageHeader2.Name = "lnePageHeader2"
		Me.lnePageHeader2.X1 = 0.0!
		Me.lnePageHeader2.X2 = 6.583465!
		Me.lnePageHeader2.Y1 = 1.2!
		Me.lnePageHeader2.Y2 = 1.2!
		'
		'reportInfo1
		'
		Me.reportInfo1.FormatString = "{PageNumber} / {PageCount}"
		resources.ApplyResources(Me.reportInfo1, "reportInfo1")
		Me.reportInfo1.Name = "reportInfo1"
		'
		'Detail
		'
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtAvgUnitPrice, Me.txtCategory, Me.textBox1})
		Me.Detail.Height = 0.2!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'ReportHeader
		'
		Me.ReportHeader.Height = 0.0!
		Me.ReportHeader.Name = "ReportHeader"
		'
		'ReportFooter
		'
		Me.ReportFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblTotalNumber, Me.txtProductCount, Me.lneReportFooter})
		Me.ReportFooter.Height = 0.9256945!
		Me.ReportFooter.KeepTogether = True
		Me.ReportFooter.Name = "ReportFooter"
		'
		'PageHeader
		'
		Me.PageHeader.CanGrow = False
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.label1, Me.lblUnitPrice, Me.lblProductName, Me.lblTitle, Me.lnePageHeader1, Me.lnePageHeader2})
		Me.PageHeader.Height = 1.2!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.CanGrow = False
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.reportInfo1})
		Me.PageFooter.Height = 0.2!
		Me.PageFooter.Name = "PageFooter"
		'
		'CategoryReport
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		Me.PageSettings.DefaultPaperSize = False
		Me.PageSettings.Margins.Right = 0.5!
		Me.PageSettings.PaperHeight = 11.69!
		Me.PageSettings.PaperWidth = 8.27!
		Me.PrintWidth = 6.583465!
		Me.Sections.Add(Me.ReportHeader)
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.Sections.Add(Me.ReportFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 204", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
					"lic; ddo-char-set: 204", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-weight: bold; ddo-char-set: 204; font-size: 10pt", "Heading3", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; color: Black; ddo-char-set: 204; font-size: 8pt", "DetailRecord", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; color: Black; background-color: LightSteelBlue; ddo-char-set: 204; font-size:" & _
					" 22pt", "ReportTitle", "Normal"))
	End Sub
	Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
	Friend WithEvents txtAvgUnitPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents txtCategory As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents textBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents ReportHeader As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
	Private WithEvents ReportFooter As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
	Friend WithEvents lblTotalNumber As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents txtProductCount As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents lneReportFooter As GrapeCity.ActiveReports.SectionReportModel.Line
	Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
	Friend WithEvents label1 As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents lblUnitPrice As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents lblProductName As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents lblTitle As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents lnePageHeader1 As GrapeCity.ActiveReports.SectionReportModel.Line
	Friend WithEvents lnePageHeader2 As GrapeCity.ActiveReports.SectionReportModel.Line
	Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
	Friend WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
End Class
