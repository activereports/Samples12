 _
Partial Class rptDSRelationChildMain
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptDSRelationChildMain))
		Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Me.SubReport1 = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.lblOrderID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblQuantity = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDiscount = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtProductName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.ghProducts = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		'
		'SubReport1
		'
		Me.SubReport1.CloseBorder = False
		resources.ApplyResources(Me.SubReport1, "SubReport1")
		Me.SubReport1.Name = "SubReport1"
		Me.SubReport1.Report = Nothing
		'
		'lblOrderID
		'
		resources.ApplyResources(Me.lblOrderID, "lblOrderID")
		Me.lblOrderID.Name = "lblOrderID"
		'
		'lblUnitPrice
		'
		Me.lblUnitPrice.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.lblUnitPrice.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		resources.ApplyResources(Me.lblUnitPrice, "lblUnitPrice")
		Me.lblUnitPrice.Name = "lblUnitPrice"
		'
		'lblQuantity
		'
		Me.lblQuantity.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.lblQuantity.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		resources.ApplyResources(Me.lblQuantity, "lblQuantity")
		Me.lblQuantity.Name = "lblQuantity"
		'
		'lblDiscount
		'
		Me.lblDiscount.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.lblDiscount.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		resources.ApplyResources(Me.lblDiscount, "lblDiscount")
		Me.lblDiscount.Name = "lblDiscount"
		'
		'txtProductName
		'
		Me.txtProductName.DataField = "ProductName"
		resources.ApplyResources(Me.txtProductName, "txtProductName")
		Me.txtProductName.Name = "txtProductName"
		'
		'Detail
		'
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.SubReport1, Me.lblOrderID, Me.lblUnitPrice, Me.lblQuantity, Me.lblDiscount})
		Me.Detail.Height = 0.1969167!
		Me.Detail.Name = "Detail"
		'
		'ghProducts
		'
		Me.ghProducts.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProductName})
		Me.ghProducts.DataField = "ProductName"
		Me.ghProducts.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.FirstDetail
		Me.ghProducts.Height = 0.374!
		Me.ghProducts.Name = "ghProducts"
		Me.ghProducts.UnderlayNext = True
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Height = 0.1666667!
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'rptDSRelationChildMain
		'
		Me.MasterReport = False
		OleDBDataSource1.ConnectionString = ""
		OleDBDataSource1.SQL = "Select * from"
		Me.DataSource = OleDBDataSource1
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 4.6!
		Me.Sections.Add(Me.ghProducts)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	
	End Sub
Private WithEvents ghProducts As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private txtProductName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblUnitPrice As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblQuantity As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblDiscount As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblOrderID As GrapeCity.ActiveReports.SectionReportModel.Label
Private SubReport1 As GrapeCity.ActiveReports.SectionReportModel.SubReport
End Class
