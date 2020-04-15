 _
Partial Class rptDSRelationParent
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptDSRelationParent))
		Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Me.SubReport1 = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.lblCategoryName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblProduct = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblOrderDetails = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtCategoryName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.textBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.ReportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		Me.ghCategories = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter2 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		'
		'SubReport1
		'
		Me.SubReport1.CloseBorder = False
		resources.ApplyResources(Me.SubReport1, "SubReport1")
		Me.SubReport1.Name = "SubReport1"
		Me.SubReport1.Report = Nothing
		'
		'lblCategoryName
		'
		resources.ApplyResources(Me.lblCategoryName, "lblCategoryName")
		Me.lblCategoryName.Name = "lblCategoryName"
		'
		'lblProduct
		'
		Me.lblProduct.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.lblProduct.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		resources.ApplyResources(Me.lblProduct, "lblProduct")
		Me.lblProduct.Name = "lblProduct"
		'
		'lblOrderDetails
		'
		Me.lblOrderDetails.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.lblOrderDetails.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		resources.ApplyResources(Me.lblOrderDetails, "lblOrderDetails")
		Me.lblOrderDetails.Name = "lblOrderDetails"
		'
		'txtCategoryName
		'
		resources.ApplyResources(Me.txtCategoryName, "txtCategoryName")
		Me.txtCategoryName.DataField = "CategoryName"
		Me.txtCategoryName.Name = "txtCategoryName"
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
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.SubReport1})
		Me.Detail.Height = 0.53125!
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
		'ghCategories
		'
		Me.ghCategories.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCategoryName})
		Me.ghCategories.DataField = "CategoryName"
		Me.ghCategories.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
		Me.ghCategories.Height = 0.25!
		Me.ghCategories.Name = "ghCategories"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Height = 0.25!
		Me.GroupFooter1.Name = "GroupFooter1"
		Me.GroupFooter1.Visible = False
		'
		'GroupHeader1
		'
		Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblCategoryName, Me.lblProduct, Me.lblOrderDetails})
		Me.GroupHeader1.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
		Me.GroupHeader1.Height = 0.25!
		Me.GroupHeader1.Name = "GroupHeader1"
		Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
		'
		'GroupFooter2
		'
		Me.GroupFooter2.Height = 0.25!
		Me.GroupFooter2.Name = "GroupFooter2"
		'
		'rptDSRelationParent
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		OleDBDataSource1.ConnectionString = ""
		OleDBDataSource1.SQL = "Select * from"
		Me.DataSource = OleDBDataSource1
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.GroupHeader1)
		Me.Sections.Add(Me.ghCategories)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.Sections.Add(Me.GroupFooter2)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents textBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents ReportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents GroupFooter2 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents ghCategories As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private lblCategoryName As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblProduct As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblOrderDetails As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtCategoryName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private SubReport1 As GrapeCity.ActiveReports.SectionReportModel.SubReport
End Class
