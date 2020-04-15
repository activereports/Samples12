 _
Partial Class DrillThrough2
	Inherits GrapeCity.ActiveReports.SectionReport
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DrillThrough2))
		Me.txtOrderID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtProductID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtQuantity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtDiscount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblOrderID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblProductID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblQuantity = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDiscount = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.CrossSectionBox1 = New GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		'
		'txtOrderID
		'
		Me.txtOrderID.DataField = "OrderID"
		resources.ApplyResources(Me.txtOrderID, "txtOrderID")
		Me.txtOrderID.Name = "txtOrderID"
		Me.txtOrderID.Padding = New GrapeCity.ActiveReports.PaddingEx(3, 0, 0, 0)
		'
		'txtProductID
		'
		Me.txtProductID.DataField = "ProductID"
		resources.ApplyResources(Me.txtProductID, "txtProductID")
		Me.txtProductID.Name = "txtProductID"
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
		'lblOrderID
		'
		resources.ApplyResources(Me.lblOrderID, "lblOrderID")
		Me.lblOrderID.Name = "lblOrderID"
		Me.lblOrderID.Padding = New GrapeCity.ActiveReports.PaddingEx(3, 0, 0, 0)
		'
		'lblProductID
		'
		resources.ApplyResources(Me.lblProductID, "lblProductID")
		Me.lblProductID.Name = "lblProductID"
		'
		'lblUnitPrice
		'
		resources.ApplyResources(Me.lblUnitPrice, "lblUnitPrice")
		Me.lblUnitPrice.Name = "lblUnitPrice"
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
		'CrossSectionBox1
		'
		Me.CrossSectionBox1.Bottom = 0.0!
		resources.ApplyResources(Me.CrossSectionBox1, "CrossSectionBox1")
		Me.CrossSectionBox1.LineColor = System.Drawing.Color.Purple
		Me.CrossSectionBox1.LineWeight = 3.0!
		Me.CrossSectionBox1.Name = "CrossSectionBox1"
		Me.CrossSectionBox1.Right = 6.5!
		'
		'Detail
		'
		Me.Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtOrderID, Me.txtProductID, Me.txtUnitPrice, Me.txtQuantity, Me.txtDiscount})
		Me.Detail.Height = 0.2!
		Me.Detail.Name = "Detail"
		'
		'GroupHeader1
		'
		Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblOrderID, Me.lblProductID, Me.lblUnitPrice, Me.lblQuantity, Me.lblDiscount, Me.CrossSectionBox1})
		Me.GroupHeader1.Height = 0.25!
		Me.GroupHeader1.Name = "GroupHeader1"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Height = 0.01!
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'DrillThrough2
		'
		Me.MasterReport = False
		Me.PageSettings.DefaultPaperSize = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Sections.Add(Me.GroupHeader1)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.ShowParameterUI = False
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		CType(Me.txtOrderID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtProductID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblOrderID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblProductID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDiscount, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private lblOrderID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblProductID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblUnitPrice As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblQuantity As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblDiscount As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtOrderID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtProductID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtUnitPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtQuantity As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents CrossSectionBox1 As GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox
Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private txtDiscount As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
