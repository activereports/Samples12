<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Invoice
	Inherits GrapeCity.ActiveReports.SectionReport
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
		End If
		MyBase.Dispose(disposing)
	End Sub
	'NOTE: The following procedure is required by the ActiveReports Designer
	'It can be modified using the ActiveReports Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
		Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.qtyTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.productNameTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.unitPriceTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.totalTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.companyNameLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.invoiceLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.orderDateTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.orderIDTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.orderIDLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.shape3 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.pageNoFMReportInfo = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.shippingAddressLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.billingAddressLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.qtyLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.productDescLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.unitPriceLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.totalLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.crossSectionBox1 = New GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox()
		Me.crossSectionLine1 = New GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine()
		Me.crossSectionLine2 = New GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine()
		Me.crossSectionLine3 = New GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine()
		Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.billingAddressTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.shippingAddressTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Shape4 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.freightLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.freightTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.subTotalLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.subtotalTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.grandTotalTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.shape2 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		Me.customerGroupHeader = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.customerGroupFooter = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		Me.BillingAddress = New GrapeCity.ActiveReports.Data.Field()
		Me.ShippingAddress = New GrapeCity.ActiveReports.Data.Field()
		Me.Total = New GrapeCity.ActiveReports.Data.Field()
		CType(Me.qtyTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.productNameTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.unitPriceTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.totalTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.companyNameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.invoiceLabel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.orderDateTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.orderIDTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.orderIDLabel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.label2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pageNoFMReportInfo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.shippingAddressLabel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.billingAddressLabel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.qtyLabel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.productDescLabel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.unitPriceLabel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.totalLabel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.billingAddressTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.shippingAddressTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.freightLabel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.freightTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.subTotalLabel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.subtotalTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grandTotalTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'line1
		'
		Me.line1.AnchorBottom = True
		resources.ApplyResources(Me.line1, "line1")
		Me.line1.LineWeight = 1.0!
		Me.line1.Name = "line1"
		Me.line1.X1 = 0.002!
		Me.line1.X2 = 6.5!
		Me.line1.Y1 = 0.198!
		Me.line1.Y2 = 0.198!
		'
		'qtyTextBox
		'
		Me.qtyTextBox.DataField = "Quantity"
		resources.ApplyResources(Me.qtyTextBox, "qtyTextBox")
		Me.qtyTextBox.Name = "qtyTextBox"
		Me.qtyTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'productNameTextBox
		'
		Me.productNameTextBox.DataField = "ProductName"
		resources.ApplyResources(Me.productNameTextBox, "productNameTextBox")
		Me.productNameTextBox.Name = "productNameTextBox"
		Me.productNameTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'unitPriceTextBox
		'
		Me.unitPriceTextBox.DataField = "UnitPrice"
		resources.ApplyResources(Me.unitPriceTextBox, "unitPriceTextBox")
		Me.unitPriceTextBox.Name = "unitPriceTextBox"
		Me.unitPriceTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'totalTextBox
		'
		Me.totalTextBox.DataField = "Total"
		resources.ApplyResources(Me.totalTextBox, "totalTextBox")
		Me.totalTextBox.Name = "totalTextBox"
		Me.totalTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'companyNameLabel
		'
		resources.ApplyResources(Me.companyNameLabel, "companyNameLabel")
		Me.companyNameLabel.Name = "companyNameLabel"
		'
		'invoiceLabel
		'
		resources.ApplyResources(Me.invoiceLabel, "invoiceLabel")
		Me.invoiceLabel.Name = "invoiceLabel"
		'
		'orderDateTextBox
		'
		Me.orderDateTextBox.DataField = "OrderDate"
		resources.ApplyResources(Me.orderDateTextBox, "orderDateTextBox")
		Me.orderDateTextBox.Name = "orderDateTextBox"
		Me.orderDateTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'orderIDTextBox
		'
		Me.orderIDTextBox.DataField = "OrderID"
		resources.ApplyResources(Me.orderIDTextBox, "orderIDTextBox")
		Me.orderIDTextBox.Name = "orderIDTextBox"
		Me.orderIDTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'orderIDLabel
		'
		resources.ApplyResources(Me.orderIDLabel, "orderIDLabel")
		Me.orderIDLabel.Name = "orderIDLabel"
		Me.orderIDLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'label2
		'
		resources.ApplyResources(Me.label2, "label2")
		Me.label2.Name = "label2"
		Me.label2.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'shape3
		'
		resources.ApplyResources(Me.shape3, "shape3")
		Me.shape3.Name = "shape3"
		Me.shape3.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		'
		'pageNoFMReportInfo
		'
		Me.pageNoFMReportInfo.FormatString = "{PageNumber} / {PageCount} "
		resources.ApplyResources(Me.pageNoFMReportInfo, "pageNoFMReportInfo")
		Me.pageNoFMReportInfo.Name = "pageNoFMReportInfo"
		'
		'shape1
		'
		Me.shape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(126, Byte), Integer))
		resources.ApplyResources(Me.shape1, "shape1")
		Me.shape1.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(126, Byte), Integer))
		Me.shape1.Name = "shape1"
		Me.shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		'
		'shippingAddressLabel
		'
		Me.shippingAddressLabel.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressLabel.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressLabel.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressLabel.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		resources.ApplyResources(Me.shippingAddressLabel, "shippingAddressLabel")
		Me.shippingAddressLabel.Name = "shippingAddressLabel"
		'
		'billingAddressLabel
		'
		Me.billingAddressLabel.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.billingAddressLabel.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.billingAddressLabel.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.billingAddressLabel.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		resources.ApplyResources(Me.billingAddressLabel, "billingAddressLabel")
		Me.billingAddressLabel.Name = "billingAddressLabel"
		'
		'qtyLabel
		'
		resources.ApplyResources(Me.qtyLabel, "qtyLabel")
		Me.qtyLabel.Name = "qtyLabel"
		Me.qtyLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'productDescLabel
		'
		resources.ApplyResources(Me.productDescLabel, "productDescLabel")
		Me.productDescLabel.Name = "productDescLabel"
		Me.productDescLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'unitPriceLabel
		'
		resources.ApplyResources(Me.unitPriceLabel, "unitPriceLabel")
		Me.unitPriceLabel.Name = "unitPriceLabel"
		Me.unitPriceLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'totalLabel
		'
		resources.ApplyResources(Me.totalLabel, "totalLabel")
		Me.totalLabel.Name = "totalLabel"
		Me.totalLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'crossSectionBox1
		'
		Me.crossSectionBox1.Bottom = 0.0!
		resources.ApplyResources(Me.crossSectionBox1, "crossSectionBox1")
		Me.crossSectionBox1.LineWeight = 1.0!
		Me.crossSectionBox1.Name = "crossSectionBox1"
		Me.crossSectionBox1.Right = 6.5!
		'
		'crossSectionLine1
		'
		Me.crossSectionLine1.Bottom = 0.0000001192093!
		resources.ApplyResources(Me.crossSectionLine1, "crossSectionLine1")
		Me.crossSectionLine1.LineWeight = 1.0!
		Me.crossSectionLine1.Name = "crossSectionLine1"
		'
		'crossSectionLine2
		'
		Me.crossSectionLine2.Bottom = 0.0!
		resources.ApplyResources(Me.crossSectionLine2, "crossSectionLine2")
		Me.crossSectionLine2.LineWeight = 1.0!
		Me.crossSectionLine2.Name = "crossSectionLine2"
		'
		'crossSectionLine3
		'
		Me.crossSectionLine3.Bottom = 0.5935001!
		resources.ApplyResources(Me.crossSectionLine3, "crossSectionLine3")
		Me.crossSectionLine3.LineWeight = 1.0!
		Me.crossSectionLine3.Name = "crossSectionLine3"
		'
		'line2
		'
		Me.line2.AnchorBottom = True
		resources.ApplyResources(Me.line2, "line2")
		Me.line2.LineWeight = 1.0!
		Me.line2.Name = "line2"
		Me.line2.X1 = 0.0!
		Me.line2.X2 = 6.5!
		Me.line2.Y1 = 1.253!
		Me.line2.Y2 = 1.253!
		'
		'billingAddressTextBox
		'
		Me.billingAddressTextBox.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.billingAddressTextBox.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.billingAddressTextBox.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.billingAddressTextBox.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.billingAddressTextBox.DataField = "BillingAddress"
		resources.ApplyResources(Me.billingAddressTextBox, "billingAddressTextBox")
		Me.billingAddressTextBox.Name = "billingAddressTextBox"
		'
		'shippingAddressTextBox
		'
		Me.shippingAddressTextBox.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressTextBox.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressTextBox.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressTextBox.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressTextBox.DataField = "ShippingAddress"
		resources.ApplyResources(Me.shippingAddressTextBox, "shippingAddressTextBox")
		Me.shippingAddressTextBox.Name = "shippingAddressTextBox"
		'
		'Shape4
		'
		Me.Shape4.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(126, Byte), Integer))
		resources.ApplyResources(Me.Shape4, "Shape4")
		Me.Shape4.LineColor = System.Drawing.Color.Transparent
		Me.Shape4.Name = "Shape4"
		Me.Shape4.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		'
		'freightLabel
		'
		resources.ApplyResources(Me.freightLabel, "freightLabel")
		Me.freightLabel.Name = "freightLabel"
		Me.freightLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'freightTextBox
		'
		Me.freightTextBox.DataField = "Freight"
		resources.ApplyResources(Me.freightTextBox, "freightTextBox")
		Me.freightTextBox.Name = "freightTextBox"
		Me.freightTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'subTotalLabel
		'
		resources.ApplyResources(Me.subTotalLabel, "subTotalLabel")
		Me.subTotalLabel.Name = "subTotalLabel"
		Me.subTotalLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'subtotalTextBox
		'
		Me.subtotalTextBox.DataField = "Total"
		resources.ApplyResources(Me.subtotalTextBox, "subtotalTextBox")
		Me.subtotalTextBox.Name = "subtotalTextBox"
		Me.subtotalTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.subtotalTextBox.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
		Me.subtotalTextBox.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
		'
		'label1
		'
		resources.ApplyResources(Me.label1, "label1")
		Me.label1.Name = "label1"
		Me.label1.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'grandTotalTextBox
		'
		resources.ApplyResources(Me.grandTotalTextBox, "grandTotalTextBox")
		Me.grandTotalTextBox.Name = "grandTotalTextBox"
		Me.grandTotalTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		'
		'shape2
		'
		resources.ApplyResources(Me.shape2, "shape2")
		Me.shape2.Name = "shape2"
		Me.shape2.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		'
		'Line3
		'
		resources.ApplyResources(Me.Line3, "Line3")
		Me.Line3.LineWeight = 1.0!
		Me.Line3.Name = "Line3"
		Me.Line3.X1 = 4.56!
		Me.Line3.X2 = 6.572001!
		Me.Line3.Y1 = 0.2!
		Me.Line3.Y2 = 0.2!
		'
		'Line4
		'
		resources.ApplyResources(Me.Line4, "Line4")
		Me.Line4.LineWeight = 1.0!
		Me.Line4.Name = "Line4"
		Me.Line4.X1 = 4.501!
		Me.Line4.X2 = 6.51!
		Me.Line4.Y1 = 0.394!
		Me.Line4.Y2 = 0.402!
		'
		'Line5
		'
		resources.ApplyResources(Me.Line5, "Line5")
		Me.Line5.LineWeight = 1.0!
		Me.Line5.Name = "Line5"
		Me.Line5.X1 = 4.501!
		Me.Line5.X2 = 6.51!
		Me.Line5.Y1 = 0.594!
		Me.Line5.Y2 = 0.594!
		'
		'Line6
		'
		resources.ApplyResources(Me.Line6, "Line6")
		Me.Line6.LineWeight = 1.0!
		Me.Line6.Name = "Line6"
		Me.Line6.X1 = 5.498!
		Me.Line6.X2 = 6.498!
		Me.Line6.Y1 = 0.8010001!
		Me.Line6.Y2 = 0.8010001!
		'
		'Detail
		'
		Me.Detail.CanGrow = False
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.line1, Me.qtyTextBox, Me.productNameTextBox, Me.unitPriceTextBox, Me.totalTextBox})
		Me.Detail.Height = 0.2!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.CanGrow = False
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.companyNameLabel, Me.invoiceLabel, Me.orderDateTextBox, Me.orderIDTextBox, Me.orderIDLabel, Me.label2, Me.shape3, Me.Line6})
		Me.PageHeader.Height = 1.25!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.CanGrow = False
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.pageNoFMReportInfo})
		Me.PageFooter.Name = "PageFooter"
		'
		'customerGroupHeader
		'
		Me.customerGroupHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.shape1, Me.shippingAddressLabel, Me.billingAddressLabel, Me.qtyLabel, Me.productDescLabel, Me.unitPriceLabel, Me.totalLabel, Me.crossSectionBox1, Me.crossSectionLine1, Me.crossSectionLine2, Me.crossSectionLine3, Me.line2, Me.billingAddressTextBox, Me.shippingAddressTextBox})
		Me.customerGroupHeader.DataField = "OrderID"
		Me.customerGroupHeader.Height = 1.2!
		Me.customerGroupHeader.Name = "customerGroupHeader"
		'
		'customerGroupFooter
		'
		Me.customerGroupFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Shape4, Me.freightLabel, Me.freightTextBox, Me.subTotalLabel, Me.subtotalTextBox, Me.label1, Me.grandTotalTextBox, Me.shape2, Me.Line3, Me.Line4, Me.Line5})
		Me.customerGroupFooter.Height = 1.0!
		Me.customerGroupFooter.Name = "customerGroupFooter"
		Me.customerGroupFooter.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
		'
		'BillingAddress
		'
		Me.BillingAddress.DefaultValue = Nothing
		Me.BillingAddress.FieldType = GrapeCity.ActiveReports.Data.FieldTypeEnum.None
		Me.BillingAddress.Formula = "Customers.CompanyName + ""\n"" + Address + ""\n"" + City + "", "" + Region + ""  "" + Pos" & _
	"talCode"
		Me.BillingAddress.Name = "BillingAddress"
		Me.BillingAddress.Tag = Nothing
		'
		'ShippingAddress
		'
		Me.ShippingAddress.DefaultValue = Nothing
		Me.ShippingAddress.FieldType = GrapeCity.ActiveReports.Data.FieldTypeEnum.None
		Me.ShippingAddress.Formula = "ShipName + ""\n"" + ShipAddress + ""\n"" + ShipCity + "", "" + ShipRegion + ""  "" + Ship" & _
	"PostalCode"
		Me.ShippingAddress.Name = "ShippingAddress"
		Me.ShippingAddress.Tag = Nothing
		'
		'Total
		'
		Me.Total.DefaultValue = Nothing
		Me.Total.FieldType = GrapeCity.ActiveReports.Data.FieldTypeEnum.None
		Me.Total.Formula = "Quantity * UnitPrice"
		Me.Total.Name = "Total"
		Me.Total.Tag = Nothing
		'
		'Invoice
		'
		Me.MasterReport = False
		Me.CalculatedFields.Add(Me.BillingAddress)
		Me.CalculatedFields.Add(Me.ShippingAddress)
		Me.CalculatedFields.Add(Me.Total)
		OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.MDB;Persist Security Info=False"
		OleDBDataSource1.SQL = ""
		Me.DataSource = OleDBDataSource1
		Me.MaxPages = CType(100, Long)
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Script = resources.GetString("$this.Script")
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.customerGroupHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.customerGroupFooter)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
			"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.qtyTextBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.productNameTextBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.unitPriceTextBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.totalTextBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.companyNameLabel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.invoiceLabel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.orderDateTextBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.orderIDTextBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.orderIDLabel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.label2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pageNoFMReportInfo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.shippingAddressLabel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.billingAddressLabel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.qtyLabel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.productDescLabel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.unitPriceLabel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.totalLabel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.billingAddressTextBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.shippingAddressTextBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.freightLabel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.freightTextBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.subTotalLabel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.subtotalTextBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grandTotalTextBox, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
	Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
	Friend WithEvents line1 As GrapeCity.ActiveReports.SectionReportModel.Line
	Friend WithEvents qtyTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents productNameTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents unitPriceTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents totalTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
	Friend WithEvents companyNameLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents invoiceLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents orderDateTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents orderIDTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents orderIDLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents label2 As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents shape3 As GrapeCity.ActiveReports.SectionReportModel.Shape
	Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
	Friend WithEvents pageNoFMReportInfo As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
	Private WithEvents customerGroupHeader As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
	Friend WithEvents shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape
	Friend WithEvents shippingAddressLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents billingAddressLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents qtyLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents productDescLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents unitPriceLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents totalLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents crossSectionBox1 As GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox
	Friend WithEvents crossSectionLine1 As GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine
	Friend WithEvents crossSectionLine2 As GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine
	Friend WithEvents crossSectionLine3 As GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine
	Friend WithEvents line2 As GrapeCity.ActiveReports.SectionReportModel.Line
	Friend WithEvents billingAddressTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents shippingAddressTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents customerGroupFooter As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
	Friend WithEvents freightLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents freightTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents subTotalLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents subtotalTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents label1 As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents grandTotalTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents shape2 As GrapeCity.ActiveReports.SectionReportModel.Shape
	Friend WithEvents BillingAddress As GrapeCity.ActiveReports.Data.Field
	Friend WithEvents ShippingAddress As GrapeCity.ActiveReports.Data.Field
	Friend WithEvents Total As GrapeCity.ActiveReports.Data.Field
	Private WithEvents Shape4 As GrapeCity.ActiveReports.SectionReportModel.Shape
	Private WithEvents Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
	Private WithEvents Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
	Private WithEvents Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
	Private WithEvents Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
End Class
