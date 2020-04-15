 _
Partial Class CategoryProducts
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoryProducts))
		Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Me.txtProductName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblTotalNumber = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtProductCount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lneReportFooter = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lblUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblProductName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtCategory = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lnePageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lnePageHeader2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.ReportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
		Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		CType(Me.txtProductName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblTotalNumber, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtProductCount, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblProductName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCategory, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'txtProductName
		'
		Me.txtProductName.DataField = "ProductName"
		resources.ApplyResources(Me.txtProductName, "txtProductName")
		Me.txtProductName.Name = "txtProductName"
		'
		'txtUnitPrice
		'
		Me.txtUnitPrice.DataField = "UnitPrice"
		resources.ApplyResources(Me.txtUnitPrice, "txtUnitPrice")
		Me.txtUnitPrice.Name = "txtUnitPrice"
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
		Me.lneReportFooter.X1 = 0.0!
		Me.lneReportFooter.X2 = 6.4375!
		Me.lneReportFooter.Y1 = 0.0!
		Me.lneReportFooter.Y2 = 0.0!
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
		'txtCategory
		'
		Me.txtCategory.DataField = "CategoryName"
		resources.ApplyResources(Me.txtCategory, "txtCategory")
		Me.txtCategory.Name = "txtCategory"
		'
		'lnePageHeader1
		'
		resources.ApplyResources(Me.lnePageHeader1, "lnePageHeader1")
		Me.lnePageHeader1.LineWeight = 2.0!
		Me.lnePageHeader1.Name = "lnePageHeader1"
		Me.lnePageHeader1.X1 = 0.062!
		Me.lnePageHeader1.X2 = 6.437!
		Me.lnePageHeader1.Y1 = 0.7500001!
		Me.lnePageHeader1.Y2 = 0.7500001!
		'
		'lnePageHeader2
		'
		resources.ApplyResources(Me.lnePageHeader2, "lnePageHeader2")
		Me.lnePageHeader2.LineWeight = 2.0!
		Me.lnePageHeader2.Name = "lnePageHeader2"
		Me.lnePageHeader2.X1 = 0.063!
		Me.lnePageHeader2.X2 = 6.438!
		Me.lnePageHeader2.Y1 = 0.95!
		Me.lnePageHeader2.Y2 = 0.95!
		'
		'ReportInfo1
		'
		Me.ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}"
		resources.ApplyResources(Me.ReportInfo1, "ReportInfo1")
		Me.ReportInfo1.Name = "ReportInfo1"
		'
		'Detail
		'
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProductName, Me.txtUnitPrice})
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
		Me.ReportFooter.Height = 0.5506945!
		Me.ReportFooter.KeepTogether = True
		Me.ReportFooter.Name = "ReportFooter"
		'
		'PageHeader
		'
		Me.PageHeader.CanGrow = False
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblUnitPrice, Me.lblProductName, Me.lblTitle, Me.txtCategory, Me.lnePageHeader1, Me.lnePageHeader2})
		Me.PageHeader.Height = 0.95!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.CanGrow = False
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ReportInfo1})
		Me.PageFooter.Height = 0.2!
		Me.PageFooter.Name = "PageFooter"
		'
		'CategoryProducts
		'
		Me.MasterReport = False
		OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.MDB"
		OleDBDataSource1.SQL = ""
		Me.DataSource = OleDBDataSource1
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.Sections.Add(Me.ReportHeader)
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.Sections.Add(Me.ReportFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
			"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.txtProductName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblTotalNumber, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtProductCount, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblProductName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCategory, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents ReportHeader As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private WithEvents ReportFooter As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
Private lblUnitPrice As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblProductName As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblTitle As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtCategory As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lnePageHeader1 As GrapeCity.ActiveReports.SectionReportModel.Line
Private lnePageHeader2 As GrapeCity.ActiveReports.SectionReportModel.Line
Private txtProductName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtUnitPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblTotalNumber As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtProductCount As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents ReportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
Private lneReportFooter As GrapeCity.ActiveReports.SectionReportModel.Line
End Class
