 _
Partial Class rptSimpleSub
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSimpleSub))
		Me.lblProductName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtProductName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Barcode1 = New GrapeCity.ActiveReports.SectionReportModel.Barcode()
		Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		'
		'lblProductName
		'
		resources.ApplyResources(Me.lblProductName, "lblProductName")
		Me.lblProductName.Name = "lblProductName"
		'
		'txtProductName
		'
		resources.ApplyResources(Me.txtProductName, "txtProductName")
		Me.txtProductName.DataField = "ProductName"
		Me.txtProductName.Name = "txtProductName"
		'
		'Barcode1
		'
		Me.Barcode1.DataField = "ProductName"
		Me.Barcode1.Font = New System.Drawing.Font("Courier New", 8.0!)
		resources.ApplyResources(Me.Barcode1, "Barcode1")
		Me.Barcode1.Name = "Barcode1"
		Me.Barcode1.QuietZoneBottom = 0.0!
		Me.Barcode1.QuietZoneLeft = 0.0!
		Me.Barcode1.QuietZoneRight = 0.0!
		Me.Barcode1.QuietZoneTop = 0.0!
		'
		'line1
		'
		resources.ApplyResources(Me.line1, "line1")
		Me.line1.LineColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(250, Byte), Integer))
		Me.line1.LineWeight = 1.0!
		Me.line1.Name = "line1"
		Me.line1.X1 = 0.0!
		Me.line1.X2 = 4.6!
		Me.line1.Y1 = 0.447!
		Me.line1.Y2 = 0.447!
		'
		'Detail
		'
		Me.Detail.BackColor = System.Drawing.Color.AliceBlue
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProductName, Me.Barcode1, Me.line1})
		Me.Detail.Height = 0.489!
		Me.Detail.Name = "Detail"
		'
		'GroupHeader1
		'
		Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblProductName})
		Me.GroupHeader1.Height = 0.25!
		Me.GroupHeader1.Name = "GroupHeader1"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Height = 0.25!
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'rptSimpleSub
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 4.6!
		Me.Sections.Add(Me.GroupHeader1)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private lblProductName As GrapeCity.ActiveReports.SectionReportModel.Label
Private WithEvents Barcode1 As GrapeCity.ActiveReports.SectionReportModel.Barcode
Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents line1 As GrapeCity.ActiveReports.SectionReportModel.Line
Private txtProductName As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
