 _
Partial Class OrderItems
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderItems))
		Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Me.txtISBN = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtTitle = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblISBN = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblPrice = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lneSep = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.txtOrderTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.ghOrderItems = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.gfOrderItems = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		'
		'txtISBN
		'
		resources.ApplyResources(Me.txtISBN, "txtISBN")
		Me.txtISBN.DataField = "@isbn"
		Me.txtISBN.Name = "txtISBN"
		'
		'txtTitle
		'
		resources.ApplyResources(Me.txtTitle, "txtTitle")
		Me.txtTitle.DataField = "TITLE"
		Me.txtTitle.Name = "txtTitle"
		'
		'txtPrice
		'
		resources.ApplyResources(Me.txtPrice, "txtPrice")
		Me.txtPrice.DataField = "PRICE"
		Me.txtPrice.Name = "txtPrice"
		'
		'lblISBN
		'
		resources.ApplyResources(Me.lblISBN, "lblISBN")
		Me.lblISBN.Name = "lblISBN"
		'
		'lblTitle
		'
		resources.ApplyResources(Me.lblTitle, "lblTitle")
		Me.lblTitle.Name = "lblTitle"
		'
		'lblPrice
		'
		resources.ApplyResources(Me.lblPrice, "lblPrice")
		Me.lblPrice.Name = "lblPrice"
		'
		'lneSep
		'
		resources.ApplyResources(Me.lneSep, "lneSep")
		Me.lneSep.LineWeight = 1.0!
		Me.lneSep.Name = "lneSep"
		Me.lneSep.X1 = 0.0!
		Me.lneSep.X2 = 6.063!
		Me.lneSep.Y1 = 0.188!
		Me.lneSep.Y2 = 0.188!
		'
		'txtOrderTotal
		'
		resources.ApplyResources(Me.txtOrderTotal, "txtOrderTotal")
		Me.txtOrderTotal.DataField = "PRICE"
		Me.txtOrderTotal.Name = "txtOrderTotal"
		Me.txtOrderTotal.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'Detail
		'
		Me.Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtISBN, Me.txtTitle, Me.txtPrice})
		Me.Detail.Height = 0.188!
		Me.Detail.Name = "Detail"
		'
		'ghOrderItems
		'
		Me.ghOrderItems.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblISBN, Me.lblTitle, Me.lblPrice, Me.lneSep})
		Me.ghOrderItems.Height = 0.208!
		Me.ghOrderItems.Name = "ghOrderItems"
		'
		'gfOrderItems
		'
		Me.gfOrderItems.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtOrderTotal})
		Me.gfOrderItems.Height = 0.188!
		Me.gfOrderItems.Name = "gfOrderItems"
		'
		'OrderItems
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		OleDBDataSource1.ConnectionString = ""
		OleDBDataSource1.SQL = "Select * from"
		Me.DataSource = OleDBDataSource1
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.063001!
		Me.Sections.Add(Me.ghOrderItems)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.gfOrderItems)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents ghOrderItems As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents lblISBN As GrapeCity.ActiveReports.SectionReportModel.Label
Private WithEvents gfOrderItems As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents lblTitle As GrapeCity.ActiveReports.SectionReportModel.Label
Private WithEvents lblPrice As GrapeCity.ActiveReports.SectionReportModel.Label
Private WithEvents lneSep As GrapeCity.ActiveReports.SectionReportModel.Line
Private WithEvents txtISBN As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents txtTitle As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents txtPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents txtOrderTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
