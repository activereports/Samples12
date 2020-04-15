 _
Partial Class rptMasterSub
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptMasterSub))
		Me.txtOrderID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtProductName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtProductID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtQuantity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtDiscount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblOrderID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblProductID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblProductName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblQuantity = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDiscount = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		CType(Me.txtOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtProductName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtProductID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblProductID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblProductName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'txtOrderID
		'
		Me.txtOrderID.CanShrink = True
		Me.txtOrderID.DataField = "OrderID"
		resources.ApplyResources(Me.txtOrderID, "txtOrderID")
		Me.txtOrderID.Name = "txtOrderID"
		'
		'txtProductName
		'
		Me.txtProductName.CanShrink = True
		Me.txtProductName.DataField = "ProductName"
		resources.ApplyResources(Me.txtProductName, "txtProductName")
		Me.txtProductName.Name = "txtProductName"
		'
		'txtProductID
		'
		Me.txtProductID.CanShrink = True
		Me.txtProductID.DataField = "products.ProductID"
		resources.ApplyResources(Me.txtProductID, "txtProductID")
		Me.txtProductID.Name = "txtProductID"
		'
		'txtQuantity
		'
		Me.txtQuantity.CanShrink = True
		Me.txtQuantity.DataField = "Quantity"
		resources.ApplyResources(Me.txtQuantity, "txtQuantity")
		Me.txtQuantity.Name = "txtQuantity"
		'
		'txtDiscount
		'
		Me.txtDiscount.CanShrink = True
		Me.txtDiscount.DataField = "Discount"
		resources.ApplyResources(Me.txtDiscount, "txtDiscount")
		Me.txtDiscount.Name = "txtDiscount"
		'
		'lblOrderID
		'
		resources.ApplyResources(Me.lblOrderID, "lblOrderID")
		Me.lblOrderID.Name = "lblOrderID"
		'
		'lblProductID
		'
		resources.ApplyResources(Me.lblProductID, "lblProductID")
		Me.lblProductID.Name = "lblProductID"
		'
		'lblProductName
		'
		resources.ApplyResources(Me.lblProductName, "lblProductName")
		Me.lblProductName.Name = "lblProductName"
		'
		'lblQuantity
		'
		resources.ApplyResources(Me.lblQuantity, "lblQuantity")
		Me.lblQuantity.Name = "lblQuantity"
		'
		'lblDiscount
		'
		resources.ApplyResources(Me.lblDiscount, "lblDiscount")
		Me.lblDiscount.Name = "lblDiscount"
		'
		'Detail
		'
		Me.Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
		Me.Detail.CanShrink = True
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtOrderID, Me.txtProductName, Me.txtProductID, Me.txtQuantity, Me.txtDiscount, Me.lblOrderID, Me.lblProductID, Me.lblProductName, Me.lblQuantity, Me.lblDiscount})
		Me.Detail.Height = 0.5104167!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.Height = 0.0!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.Height = 0.0!
		Me.PageFooter.Name = "PageFooter"
		'
		'rptMasterSub
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.ShowParameterUI = False
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
					"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.txtOrderID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtProductName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtProductID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblOrderID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblProductID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblProductName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDiscount, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private txtOrderID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtProductName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtProductID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtQuantity As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtDiscount As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblOrderID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblProductID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblProductName As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblQuantity As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblDiscount As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
