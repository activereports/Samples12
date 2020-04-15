 _
Partial Class DataFieldExpressionsReport
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataFieldExpressionsReport))
		Me.txtProductName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtQuantity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtExtendedPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblProductName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblQuantity = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblExtendedPrice = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblNote = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		CType(Me.txtProductName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtExtendedPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblProductName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblExtendedPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblNote, System.ComponentModel.ISupportInitialize).BeginInit()
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
		'txtQuantity
		'
		Me.txtQuantity.DataField = "Quantity"
		resources.ApplyResources(Me.txtQuantity, "txtQuantity")
		Me.txtQuantity.Name = "txtQuantity"
		'
		'txtExtendedPrice
		'
		Me.txtExtendedPrice.DataField = "=UnitPrice*Quantity"
		resources.ApplyResources(Me.txtExtendedPrice, "txtExtendedPrice")
		Me.txtExtendedPrice.Name = "txtExtendedPrice"
		'
		'lblProductName
		'
		resources.ApplyResources(Me.lblProductName, "lblProductName")
		Me.lblProductName.Name = "lblProductName"
		Me.lblProductName.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0)
		'
		'lblUnitPrice
		'
		resources.ApplyResources(Me.lblUnitPrice, "lblUnitPrice")
		Me.lblUnitPrice.Name = "lblUnitPrice"
		Me.lblUnitPrice.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0)
		'
		'lblQuantity
		'
		resources.ApplyResources(Me.lblQuantity, "lblQuantity")
		Me.lblQuantity.Name = "lblQuantity"
		Me.lblQuantity.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0)
		'
		'lblExtendedPrice
		'
		resources.ApplyResources(Me.lblExtendedPrice, "lblExtendedPrice")
		Me.lblExtendedPrice.Name = "lblExtendedPrice"
		Me.lblExtendedPrice.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0)
		'
		'lblNote
		'
		resources.ApplyResources(Me.lblNote, "lblNote")
		Me.lblNote.Name = "lblNote"
		'
		'Detail
		'
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProductName, Me.txtUnitPrice, Me.txtQuantity, Me.txtExtendedPrice})
		Me.Detail.Height = 0.3222222!
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblProductName, Me.lblUnitPrice, Me.lblQuantity, Me.lblExtendedPrice, Me.lblNote})
		Me.PageHeader.Height = 1.134722!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.Height = 0.15625!
		Me.PageFooter.Name = "PageFooter"
		'
		'DataFieldExpressionsReport
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
			"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.txtProductName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtExtendedPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblProductName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblExtendedPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblNote, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private lblProductName As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblUnitPrice As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblQuantity As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblExtendedPrice As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblNote As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtProductName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtUnitPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtQuantity As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtExtendedPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
