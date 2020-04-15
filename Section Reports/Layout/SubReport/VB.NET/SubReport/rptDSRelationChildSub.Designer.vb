 _
Partial Class rptDSRelationChildSub
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptDSRelationChildSub))
		Me.txtUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtQuantity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtDiscount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtOrderID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		'
		'txtUnitPrice
		'
		Me.txtUnitPrice.DataField = "UnitPrice"
		resources.ApplyResources(Me.txtUnitPrice, "txtUnitPrice")
		Me.txtUnitPrice.Name = "txtUnitPrice"
		'
		'txtQuantity
		'
		Me.txtQuantity.DataField = "Quantity"
		resources.ApplyResources(Me.txtQuantity, "txtQuantity")
		Me.txtQuantity.Name = "txtQuantity"
		'
		'txtDiscount
		'
		Me.txtDiscount.DataField = "Discount"
		resources.ApplyResources(Me.txtDiscount, "txtDiscount")
		Me.txtDiscount.Name = "txtDiscount"
		'
		'txtOrderID
		'
		Me.txtOrderID.DataField = "OrderID"
		resources.ApplyResources(Me.txtOrderID, "txtOrderID")
		Me.txtOrderID.Name = "txtOrderID"
		'
		'Detail
		'
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtUnitPrice, Me.txtQuantity, Me.txtDiscount, Me.txtOrderID})
		Me.Detail.Height = 0.2520833!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'rptDSRelationChildSub
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 3.0!
		Me.Sections.Add(Me.Detail)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private txtUnitPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtQuantity As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents txtOrderID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtDiscount As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
