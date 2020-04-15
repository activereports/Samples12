 _
Partial Class OrdersReport
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdersReport))
		Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Me.txtProductID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtQuantity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtDiscount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtExtendedPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblMaxPagesSet = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblProductID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblQuantity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblDiscount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblExtendedPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblTotalExtendedPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtTotalExtendedPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		Me.ghOrderID = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.gfOrderID = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		CType(Me.txtProductID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtExtendedPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblMaxPagesSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblProductID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblExtendedPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblTotalExtendedPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTotalExtendedPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
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
		'txtExtendedPrice
		'
		Me.txtExtendedPrice.DataField = "ExtendedPrice"
		resources.ApplyResources(Me.txtExtendedPrice, "txtExtendedPrice")
		Me.txtExtendedPrice.Name = "txtExtendedPrice"
		'
		'lblMaxPagesSet
		'
		resources.ApplyResources(Me.lblMaxPagesSet, "lblMaxPagesSet")
		Me.lblMaxPagesSet.Name = "lblMaxPagesSet"
		'
		'TextBox1
		'
		Me.TextBox1.DataField = "OrderID"
		resources.ApplyResources(Me.TextBox1, "TextBox1")
		Me.TextBox1.Name = "TextBox1"
		'
		'TextBox6
		'
		resources.ApplyResources(Me.TextBox6, "TextBox6")
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0)
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
		'lblExtendedPrice
		'
		resources.ApplyResources(Me.lblExtendedPrice, "lblExtendedPrice")
		Me.lblExtendedPrice.Name = "lblExtendedPrice"
		'
		'lblTotalExtendedPrice
		'
		resources.ApplyResources(Me.lblTotalExtendedPrice, "lblTotalExtendedPrice")
		Me.lblTotalExtendedPrice.Name = "lblTotalExtendedPrice"
		Me.lblTotalExtendedPrice.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0)
		'
		'txtTotalExtendedPrice
		'
		Me.txtTotalExtendedPrice.DataField = "ExtendedPrice"
		resources.ApplyResources(Me.txtTotalExtendedPrice, "txtTotalExtendedPrice")
		Me.txtTotalExtendedPrice.Name = "txtTotalExtendedPrice"
		Me.txtTotalExtendedPrice.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
		Me.txtTotalExtendedPrice.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'Detail
		'
		Me.Detail.CanShrink = True
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProductID, Me.txtUnitPrice, Me.txtQuantity, Me.txtDiscount, Me.txtExtendedPrice})
		Me.Detail.Height = 0.34375!
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
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblMaxPagesSet})
		Me.PageFooter.Height = 0.5729167!
		Me.PageFooter.Name = "PageFooter"
		'
		'ghOrderID
		'
		Me.ghOrderID.CanShrink = True
		Me.ghOrderID.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox1, Me.TextBox6, Me.lblProductID, Me.lblUnitPrice, Me.lblQuantity, Me.lblDiscount, Me.lblExtendedPrice})
		Me.ghOrderID.DataField = "OrderID"
		Me.ghOrderID.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.FirstDetail
		Me.ghOrderID.Height = 0.6354167!
		Me.ghOrderID.Name = "ghOrderID"
		'
		'gfOrderID
		'
		Me.gfOrderID.CanShrink = True
		Me.gfOrderID.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblTotalExtendedPrice, Me.txtTotalExtendedPrice})
		Me.gfOrderID.Height = 0.3222222!
		Me.gfOrderID.Name = "gfOrderID"
		'
		'OrdersReport
		'
		Me.MasterReport = False
		OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.MDB;Persist Security Info=False"
		OleDBDataSource1.SQL = "SELECT * FROM [Order Details] ORDER BY OrderID"
		Me.DataSource = OleDBDataSource1
		Me.MaxPages = CType(10, Long)
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.ghOrderID)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.gfOrderID)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
			"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.txtProductID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtExtendedPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblMaxPagesSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblProductID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDiscount, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblExtendedPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblTotalExtendedPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTotalExtendedPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents ghOrderID As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents gfOrderID As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblProductID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblUnitPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblQuantity As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblDiscount As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblExtendedPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtProductID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtUnitPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtQuantity As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtDiscount As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtExtendedPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblTotalExtendedPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtTotalExtendedPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblMaxPagesSet As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
