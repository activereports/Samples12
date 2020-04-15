<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ProductsReport
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductsReport))
		Me.lblTotalNumber = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtProductCount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lneReportFooter = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lblTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.reportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.textBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.textBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.txtProductName1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtUnitPrice1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
		Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		Me.groupHeaderCategory = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.groupFooterCategory = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		'
		'lblTotalNumber
		'
		resources.ApplyResources(Me.lblTotalNumber, "lblTotalNumber")
		Me.lblTotalNumber.Name = "lblTotalNumber"
		'
		'txtProductCount
		'
		Me.txtProductCount.DataField = "ProductName"
		resources.ApplyResources(Me.txtProductCount, "txtProductCount")
		Me.txtProductCount.Name = "txtProductCount"
		Me.txtProductCount.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Count
		Me.txtProductCount.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
		'
		'lneReportFooter
		'
		resources.ApplyResources(Me.lneReportFooter, "lneReportFooter")
		Me.lneReportFooter.LineWeight = 2.0!
		Me.lneReportFooter.Name = "lneReportFooter"
		Me.lneReportFooter.X1 = 0.01023622!
		Me.lneReportFooter.X2 = 6.4375!
		Me.lneReportFooter.Y1 = 0.0!
		Me.lneReportFooter.Y2 = 0.0!
		'
		'lblTitle
		'
		resources.ApplyResources(Me.lblTitle, "lblTitle")
		Me.lblTitle.Name = "lblTitle"
		'
		'reportInfo1
		'
		Me.reportInfo1.FormatString = "{PageNumber} / {PageCount}"
		resources.ApplyResources(Me.reportInfo1, "reportInfo1")
		Me.reportInfo1.Name = "reportInfo1"
		'
		'label2
		'
		resources.ApplyResources(Me.label2, "label2")
		Me.label2.Name = "label2"
		'
		'label1
		'
		resources.ApplyResources(Me.label1, "label1")
		Me.label1.Name = "label1"
		'
		'textBox1
		'
		Me.textBox1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		resources.ApplyResources(Me.textBox1, "textBox1")
		Me.textBox1.DataField = "CategoryName"
		Me.textBox1.Name = "textBox1"
		'
		'textBox2
		'
		resources.ApplyResources(Me.textBox2, "textBox2")
		Me.textBox2.DataField = "ProductName"
		Me.textBox2.Name = "textBox2"
		Me.textBox2.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Count
		Me.textBox2.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'label3
		'
		resources.ApplyResources(Me.label3, "label3")
		Me.label3.Name = "label3"
		'
		'line2
		'
		resources.ApplyResources(Me.line2, "line2")
		Me.line2.LineWeight = 2.0!
		Me.line2.Name = "line2"
		Me.line2.X1 = 0.0!
		Me.line2.X2 = 6.5!
		Me.line2.Y1 = 0.0!
		Me.line2.Y2 = 0.0!
		'
		'Line1
		'
		resources.ApplyResources(Me.Line1, "Line1")
		Me.Line1.LineWeight = 1.0!
		Me.Line1.Name = "Line1"
		Me.Line1.X1 = 0.031!
		Me.Line1.X2 = 6.489334!
		Me.Line1.Y1 = 0.471!
		Me.Line1.Y2 = 0.471!
		'
		'txtProductName1
		'
		Me.txtProductName1.CanShrink = True
		resources.ApplyResources(Me.txtProductName1, "txtProductName1")
		Me.txtProductName1.DataField = "ProductName"
		Me.txtProductName1.Name = "txtProductName1"
		'
		'txtUnitPrice1
		'
		Me.txtUnitPrice1.CanShrink = True
		resources.ApplyResources(Me.txtUnitPrice1, "txtUnitPrice1")
		Me.txtUnitPrice1.DataField = "UnitPrice"
		Me.txtUnitPrice1.Name = "txtUnitPrice1"
		'
		'Detail
		'
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProductName1, Me.txtUnitPrice1})
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
		Me.ReportFooter.Height = 0.4986112!
		Me.ReportFooter.KeepTogether = True
		Me.ReportFooter.Name = "ReportFooter"
		'
		'PageHeader
		'
		Me.PageHeader.CanGrow = False
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblTitle})
		Me.PageHeader.Height = 0.6666667!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.CanGrow = False
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.reportInfo1})
		Me.PageFooter.Height = 0.2!
		Me.PageFooter.Name = "PageFooter"
		'
		'groupHeaderCategory
		'
		Me.groupHeaderCategory.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.label2, Me.label1, Me.textBox1, Me.Line1})
		Me.groupHeaderCategory.DataField = "CategoryID"
		Me.groupHeaderCategory.Height = 0.4779445!
		Me.groupHeaderCategory.Name = "groupHeaderCategory"
		'
		'groupFooterCategory
		'
		Me.groupFooterCategory.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.textBox2, Me.label3, Me.line2})
		Me.groupFooterCategory.Height = 0.3229167!
		Me.groupFooterCategory.Name = "groupFooterCategory"
		'
		'ProductsReport
		'
		Me.MasterReport = False
		Me.PageSettings.DefaultPaperSize = False
		Me.PageSettings.Margins.Right = 0.5!
		Me.PageSettings.PaperHeight = 11.69!
		Me.PageSettings.PaperWidth = 8.27!
		Me.PrintWidth = 6.5!
		Me.Sections.Add(Me.ReportHeader)
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.groupHeaderCategory)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.groupFooterCategory)
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
	Private WithEvents ReportHeader As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
	Private WithEvents ReportFooter As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
	Friend WithEvents lblTotalNumber As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents txtProductCount As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents lneReportFooter As GrapeCity.ActiveReports.SectionReportModel.Line
	Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
	Friend WithEvents lblTitle As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
	Friend WithEvents reportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
	Private WithEvents groupHeaderCategory As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
	Friend WithEvents label2 As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents label1 As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents textBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents groupFooterCategory As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
	Friend WithEvents textBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents label3 As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents line2 As GrapeCity.ActiveReports.SectionReportModel.Line
	Private WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
	Private WithEvents txtProductName1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents txtUnitPrice1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
