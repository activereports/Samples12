 _
Partial Class rptBookmarkSub
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBookmarkSub))
		Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Me.txtProductName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		'
		'txtProductName
		'
		Me.txtProductName.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		resources.ApplyResources(Me.txtProductName, "txtProductName")
		Me.txtProductName.DataField = "ProductName"
		Me.txtProductName.Name = "txtProductName"
		'
		'txtUnitPrice
		'
		Me.txtUnitPrice.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		resources.ApplyResources(Me.txtUnitPrice, "txtUnitPrice")
		Me.txtUnitPrice.DataField = "UnitPrice"
		Me.txtUnitPrice.Name = "txtUnitPrice"
		'
		'Detail
		'
		Me.Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProductName, Me.txtUnitPrice})
		Me.Detail.Height = 0.3534722!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.Height = 0.25!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.Height = 0.25!
		Me.PageFooter.Name = "PageFooter"
		'
		'rptBookmarkSub
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		OleDBDataSource1.ConnectionString = ""
		OleDBDataSource1.SQL = "Select * from"
		Me.DataSource = OleDBDataSource1
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 5.0!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private WithEvents txtUnitPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtProductName As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
