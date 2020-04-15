<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CodeReport
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
		Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodeReport))
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		Me.customerGroupHeader = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.customerGroupFooter = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		Me.shape3 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.companyNameLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.invoiceLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.orderDateTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.orderIDTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.orderIDLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.shippingAddressLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.billingAddressLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.qtyLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.productDescLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.unitPriceLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.totalLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.crossSectionLine1 = New GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine()
		Me.crossSectionLine2 = New GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine()
		Me.crossSectionLine3 = New GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine()
		Me.line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.billingAddressTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.shippingAddressTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.crossSectionBox1 = New GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox()
		Me.line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.qtyTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.productNameTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.unitPriceTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.totalTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.grandTotalTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.shape2 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.shape4 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.freightLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.freightTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.subTotalLabel = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.subtotalTextBox = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.pageNoFMReportInfo = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.BillingAddress = New GrapeCity.ActiveReports.Data.Field()
		Me.ShippingAddress = New GrapeCity.ActiveReports.Data.Field()
		Me.Total = New GrapeCity.ActiveReports.Data.Field()
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
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.shape3, Me.companyNameLabel, Me.invoiceLabel, Me.orderDateTextBox, Me.orderIDTextBox, Me.orderIDLabel, Me.label2, Me.line5})
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
		Me.customerGroupHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.shape1, Me.shippingAddressLabel, Me.billingAddressLabel, Me.qtyLabel, Me.productDescLabel, Me.unitPriceLabel, Me.totalLabel, Me.crossSectionLine1, Me.crossSectionLine2, Me.crossSectionLine3, Me.line2, Me.billingAddressTextBox, Me.shippingAddressTextBox, Me.crossSectionBox1})
		Me.customerGroupHeader.DataField = "OrderID"
		Me.customerGroupHeader.Height = 1.2!
		Me.customerGroupHeader.Name = "customerGroupHeader"
		'
		'customerGroupFooter
		'
		Me.customerGroupFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.grandTotalTextBox, Me.shape2, Me.shape4, Me.freightLabel, Me.freightTextBox, Me.subTotalLabel, Me.subtotalTextBox, Me.label1, Me.line3, Me.line4})
		Me.customerGroupFooter.Height = 1.0!
		Me.customerGroupFooter.Name = "customerGroupFooter"
		Me.customerGroupFooter.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
		'
		'shape3
		'
		Me.shape3.Height = 0.3978333!
		Me.shape3.Left = 4.5!
		Me.shape3.Name = "shape3"
		Me.shape3.RoundingRadius = 9.999999!
		Me.shape3.Top = 0.6041667!
		Me.shape3.Width = 2.0!
		'
		'companyNameLabel
		'
		Me.companyNameLabel.Height = 0.375!
		Me.companyNameLabel.HyperLink = Nothing
		Me.companyNameLabel.Left = 0.0!
		Me.companyNameLabel.Name = "companyNameLabel"
		Me.companyNameLabel.Style = "color: Black; font-size: 20.25pt; font-weight: bold"
		Me.companyNameLabel.Text = "Northwind Traders"
		Me.companyNameLabel.Top = 0.0!
		Me.companyNameLabel.Width = 3.0!
		'
		'invoiceLabel
		'
		Me.invoiceLabel.Height = 0.3750001!
		Me.invoiceLabel.HyperLink = Nothing
		Me.invoiceLabel.Left = 4.501!
		Me.invoiceLabel.Name = "invoiceLabel"
		Me.invoiceLabel.Style = "background-color: #49277E; color: White; font-size: 20.25pt; font-weight: bold; t" & _
	"ext-align: center"
		Me.invoiceLabel.Text = "Invoice"
		Me.invoiceLabel.Top = 0.0!
		Me.invoiceLabel.Width = 2.0!
		'
		'orderDateTextBox
		'
		Me.orderDateTextBox.DataField = "OrderDate"
		Me.orderDateTextBox.Height = 0.2!
		Me.orderDateTextBox.Left = 5.5!
		Me.orderDateTextBox.Name = "orderDateTextBox"
		Me.orderDateTextBox.OutputFormat = resources.GetString("orderDateTextBox.OutputFormat")
		Me.orderDateTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.orderDateTextBox.Style = "text-align: right"
		Me.orderDateTextBox.Text = "OrderDate"
		Me.orderDateTextBox.Top = 0.8!
		Me.orderDateTextBox.Width = 1.0!
		'
		'orderIDTextBox
		'
		Me.orderIDTextBox.DataField = "OrderID"
		Me.orderIDTextBox.Height = 0.2!
		Me.orderIDTextBox.Left = 5.5!
		Me.orderIDTextBox.Name = "orderIDTextBox"
		Me.orderIDTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.orderIDTextBox.Style = "text-align: right"
		Me.orderIDTextBox.Text = "OrderID"
		Me.orderIDTextBox.Top = 0.6039999!
		Me.orderIDTextBox.Width = 1.0!
		'
		'orderIDLabel
		'
		Me.orderIDLabel.Height = 0.1979167!
		Me.orderIDLabel.HyperLink = Nothing
		Me.orderIDLabel.Left = 4.498002!
		Me.orderIDLabel.Name = "orderIDLabel"
		Me.orderIDLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.orderIDLabel.Style = "background-color: #49277E; color: White; font-weight: bold; ddo-char-set: 1"
		Me.orderIDLabel.Text = "Order ID:"
		Me.orderIDLabel.Top = 0.603!
		Me.orderIDLabel.Width = 1.0!
		'
		'label2
		'
		Me.label2.Height = 0.1979167!
		Me.label2.HyperLink = Nothing
		Me.label2.Left = 4.498002!
		Me.label2.Name = "label2"
		Me.label2.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.label2.Style = "background-color: #49277E; color: White; font-weight: bold; ddo-char-set: 1"
		Me.label2.Text = "Order Date:"
		Me.label2.Top = 0.8!
		Me.label2.Width = 1.0!
		'
		'line5
		'
		Me.line5.Height = 0.004000008!
		Me.line5.Left = 4.498!
		Me.line5.LineWeight = 1.0!
		Me.line5.Name = "line5"
		Me.line5.Top = 0.8!
		Me.line5.Width = 2.0!
		Me.line5.X1 = 4.498!
		Me.line5.X2 = 6.498!
		Me.line5.Y1 = 0.8!
		Me.line5.Y2 = 0.804!
		'
		'shape1
		'
		Me.shape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(126, Byte), Integer))
		Me.shape1.Height = 0.1875833!
		Me.shape1.Left = 0.0!
		Me.shape1.LineColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(126, Byte), Integer))
		Me.shape1.Name = "shape1"
		Me.shape1.RoundingRadius = 9.999999!
		Me.shape1.Top = 1.0!
		Me.shape1.Width = 6.498!
		'
		'shippingAddressLabel
		'
		Me.shippingAddressLabel.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressLabel.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressLabel.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressLabel.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressLabel.Height = 0.1979167!
		Me.shippingAddressLabel.HyperLink = Nothing
		Me.shippingAddressLabel.Left = 3.5!
		Me.shippingAddressLabel.Name = "shippingAddressLabel"
		Me.shippingAddressLabel.Style = "background-color: #49277E; color: White; font-size: 9.75pt; font-weight: bold"
		Me.shippingAddressLabel.Text = "Shipping Address"
		Me.shippingAddressLabel.Top = 0.0!
		Me.shippingAddressLabel.Width = 3.0!
		'
		'billingAddressLabel
		'
		Me.billingAddressLabel.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.billingAddressLabel.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.billingAddressLabel.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.billingAddressLabel.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.billingAddressLabel.Height = 0.1979167!
		Me.billingAddressLabel.HyperLink = Nothing
		Me.billingAddressLabel.Left = 0.0!
		Me.billingAddressLabel.Name = "billingAddressLabel"
		Me.billingAddressLabel.Style = "background-color: #49277E; color: White; font-size: 9.75pt; font-weight: bold"
		Me.billingAddressLabel.Text = "Billing Address"
		Me.billingAddressLabel.Top = 0.0!
		Me.billingAddressLabel.Width = 3.0!
		'
		'qtyLabel
		'
		Me.qtyLabel.Height = 0.1979167!
		Me.qtyLabel.HyperLink = Nothing
		Me.qtyLabel.Left = 0.0!
		Me.qtyLabel.Name = "qtyLabel"
		Me.qtyLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.qtyLabel.Style = "color: White; font-size: 9.75pt; font-weight: bold; text-align: center"
		Me.qtyLabel.Text = "QTY"
		Me.qtyLabel.Top = 1.0!
		Me.qtyLabel.Width = 0.5!
		'
		'productDescLabel
		'
		Me.productDescLabel.Height = 0.1979167!
		Me.productDescLabel.HyperLink = Nothing
		Me.productDescLabel.Left = 0.5!
		Me.productDescLabel.Name = "productDescLabel"
		Me.productDescLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.productDescLabel.Style = "color: White; font-size: 9.75pt; font-weight: bold"
		Me.productDescLabel.Text = "Product Description"
		Me.productDescLabel.Top = 1.0!
		Me.productDescLabel.Width = 4.0!
		'
		'unitPriceLabel
		'
		Me.unitPriceLabel.Height = 0.1979167!
		Me.unitPriceLabel.HyperLink = Nothing
		Me.unitPriceLabel.Left = 4.5!
		Me.unitPriceLabel.Name = "unitPriceLabel"
		Me.unitPriceLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.unitPriceLabel.Style = "color: White; font-size: 9.75pt; font-weight: bold; text-align: right"
		Me.unitPriceLabel.Text = "Unit Price"
		Me.unitPriceLabel.Top = 1.0!
		Me.unitPriceLabel.Width = 1.0!
		'
		'totalLabel
		'
		Me.totalLabel.Height = 0.1979167!
		Me.totalLabel.HyperLink = Nothing
		Me.totalLabel.Left = 5.5!
		Me.totalLabel.Name = "totalLabel"
		Me.totalLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.totalLabel.Style = "color: White; font-size: 9.75pt; font-weight: bold; text-align: right"
		Me.totalLabel.Text = "Total"
		Me.totalLabel.Top = 1.0!
		Me.totalLabel.Width = 0.998!
		'
		'crossSectionLine1
		'
		Me.crossSectionLine1.Bottom = 0.0000001192093!
		Me.crossSectionLine1.Left = 0.5!
		Me.crossSectionLine1.LineWeight = 1.0!
		Me.crossSectionLine1.Name = "crossSectionLine1"
		Me.crossSectionLine1.Top = 1.0!
		'
		'crossSectionLine2
		'
		Me.crossSectionLine2.Bottom = 0.0!
		Me.crossSectionLine2.Left = 4.501!
		Me.crossSectionLine2.LineWeight = 1.0!
		Me.crossSectionLine2.Name = "crossSectionLine2"
		Me.crossSectionLine2.Top = 1.0!
		'
		'crossSectionLine3
		'
		Me.crossSectionLine3.Bottom = 0.5965834!
		Me.crossSectionLine3.Left = 5.498!
		Me.crossSectionLine3.LineWeight = 1.0!
		Me.crossSectionLine3.Name = "crossSectionLine3"
		Me.crossSectionLine3.Top = 1.0!
		'
		'line2
		'
		Me.line2.AnchorBottom = True
		Me.line2.Height = 0.0!
		Me.line2.Left = 0.0!
		Me.line2.LineWeight = 1.0!
		Me.line2.Name = "line2"
		Me.line2.Top = 1.253!
		Me.line2.Width = 6.5!
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
		Me.billingAddressTextBox.Height = 0.6000001!
		Me.billingAddressTextBox.Left = 0.0!
		Me.billingAddressTextBox.Name = "billingAddressTextBox"
		Me.billingAddressTextBox.Style = "font-size: 10pt; ddo-char-set: 1"
		Me.billingAddressTextBox.Text = "BillingAddress"
		Me.billingAddressTextBox.Top = 0.198!
		Me.billingAddressTextBox.Width = 3.0!
		'
		'shippingAddressTextBox
		'
		Me.shippingAddressTextBox.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressTextBox.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressTextBox.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressTextBox.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
		Me.shippingAddressTextBox.DataField = "ShippingAddress"
		Me.shippingAddressTextBox.Height = 0.6000001!
		Me.shippingAddressTextBox.Left = 3.5!
		Me.shippingAddressTextBox.Name = "shippingAddressTextBox"
		Me.shippingAddressTextBox.Style = "font-size: 10pt; ddo-char-set: 1"
		Me.shippingAddressTextBox.Text = "ShippingAddress"
		Me.shippingAddressTextBox.Top = 0.1979167!
		Me.shippingAddressTextBox.Width = 3.0!
		'
		'crossSectionBox1
		'
		Me.crossSectionBox1.Bottom = 0.0!
		Me.crossSectionBox1.Left = 0.0!
		Me.crossSectionBox1.LineWeight = 1.0!
		Me.crossSectionBox1.Name = "crossSectionBox1"
		Me.crossSectionBox1.Right = 6.500999!
		Me.crossSectionBox1.Top = 1.0!
		'
		'line1
		'
		Me.line1.AnchorBottom = True
		Me.line1.Height = 0.0!
		Me.line1.Left = 0.002!
		Me.line1.LineWeight = 1.0!
		Me.line1.Name = "line1"
		Me.line1.Top = 0.198!
		Me.line1.Width = 6.498!
		Me.line1.X1 = 0.002!
		Me.line1.X2 = 6.5!
		Me.line1.Y1 = 0.198!
		Me.line1.Y2 = 0.198!
		'
		'qtyTextBox
		'
		Me.qtyTextBox.DataField = "Quantity"
		Me.qtyTextBox.Height = 0.1979167!
		Me.qtyTextBox.Left = 0.0!
		Me.qtyTextBox.Name = "qtyTextBox"
		Me.qtyTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.qtyTextBox.Style = "text-align: center"
		Me.qtyTextBox.Text = "QTY"
		Me.qtyTextBox.Top = 0.0!
		Me.qtyTextBox.Width = 0.5!
		'
		'productNameTextBox
		'
		Me.productNameTextBox.DataField = "ProductName"
		Me.productNameTextBox.Height = 0.1979167!
		Me.productNameTextBox.Left = 0.5!
		Me.productNameTextBox.Name = "productNameTextBox"
		Me.productNameTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.productNameTextBox.Text = "ProductDescription"
		Me.productNameTextBox.Top = 0.0!
		Me.productNameTextBox.Width = 4.0!
		'
		'unitPriceTextBox
		'
		Me.unitPriceTextBox.DataField = "UnitPrice"
		Me.unitPriceTextBox.Height = 0.1979167!
		Me.unitPriceTextBox.Left = 4.5!
		Me.unitPriceTextBox.Name = "unitPriceTextBox"
		Me.unitPriceTextBox.OutputFormat = resources.GetString("unitPriceTextBox.OutputFormat")
		Me.unitPriceTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.unitPriceTextBox.Style = "text-align: right"
		Me.unitPriceTextBox.Text = "UnitPrice"
		Me.unitPriceTextBox.Top = 0.0!
		Me.unitPriceTextBox.Width = 1.0!
		'
		'totalTextBox
		'
		Me.totalTextBox.DataField = "Total"
		Me.totalTextBox.Height = 0.1979167!
		Me.totalTextBox.Left = 5.5!
		Me.totalTextBox.Name = "totalTextBox"
		Me.totalTextBox.OutputFormat = resources.GetString("totalTextBox.OutputFormat")
		Me.totalTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.totalTextBox.Style = "text-align: right"
		Me.totalTextBox.Text = "Total"
		Me.totalTextBox.Top = 0.0!
		Me.totalTextBox.Width = 1.001001!
		'
		'grandTotalTextBox
		'
		Me.grandTotalTextBox.Height = 0.2!
		Me.grandTotalTextBox.Left = 5.5!
		Me.grandTotalTextBox.Name = "grandTotalTextBox"
		Me.grandTotalTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.grandTotalTextBox.Style = "text-align: right"
		Me.grandTotalTextBox.Text = "Grand Total"
		Me.grandTotalTextBox.Top = 0.394!
		Me.grandTotalTextBox.Width = 1.0!
		'
		'shape2
		'
		Me.shape2.Height = 0.6000001!
		Me.shape2.Left = 4.5!
		Me.shape2.Name = "shape2"
		Me.shape2.RoundingRadius = 9.999999!
		Me.shape2.Top = 0.001999989!
		Me.shape2.Width = 2.0!
		'
		'shape4
		'
		Me.shape4.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(126, Byte), Integer))
		Me.shape4.Height = 0.5960001!
		Me.shape4.Left = 4.5!
		Me.shape4.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.shape4.Name = "shape4"
		Me.shape4.RoundingRadius = 9.999999!
		Me.shape4.Top = 0.0!
		Me.shape4.Width = 1.0!
		'
		'freightLabel
		'
		Me.freightLabel.Height = 0.2!
		Me.freightLabel.HyperLink = Nothing
		Me.freightLabel.Left = 4.5!
		Me.freightLabel.Name = "freightLabel"
		Me.freightLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.freightLabel.Style = "color: White; font-weight: bold; ddo-char-set: 1"
		Me.freightLabel.Text = "Shipping:"
		Me.freightLabel.Top = 0.202!
		Me.freightLabel.Width = 1.0!
		'
		'freightTextBox
		'
		Me.freightTextBox.DataField = "Freight"
		Me.freightTextBox.Height = 0.2!
		Me.freightTextBox.Left = 5.498!
		Me.freightTextBox.Name = "freightTextBox"
		Me.freightTextBox.OutputFormat = resources.GetString("freightTextBox.OutputFormat")
		Me.freightTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.freightTextBox.Style = "text-align: right"
		Me.freightTextBox.Text = "Freight"
		Me.freightTextBox.Top = 0.202!
		Me.freightTextBox.Width = 1.0!
		'
		'subTotalLabel
		'
		Me.subTotalLabel.Height = 0.2!
		Me.subTotalLabel.HyperLink = Nothing
		Me.subTotalLabel.Left = 4.5!
		Me.subTotalLabel.Name = "subTotalLabel"
		Me.subTotalLabel.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.subTotalLabel.Style = "color: White; font-weight: bold; ddo-char-set: 1"
		Me.subTotalLabel.Text = "Sub Total:"
		Me.subTotalLabel.Top = 0.0!
		Me.subTotalLabel.Width = 1.0!
		'
		'subtotalTextBox
		'
		Me.subtotalTextBox.DataField = "Total"
		Me.subtotalTextBox.Height = 0.2!
		Me.subtotalTextBox.Left = 5.498!
		Me.subtotalTextBox.Name = "subtotalTextBox"
		Me.subtotalTextBox.OutputFormat = resources.GetString("subtotalTextBox.OutputFormat")
		Me.subtotalTextBox.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.subtotalTextBox.Style = "text-align: right"
		Me.subtotalTextBox.SummaryGroup = "customerGroupHeader"
		Me.subtotalTextBox.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
		Me.subtotalTextBox.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
		Me.subtotalTextBox.Text = "Subtotal"
		Me.subtotalTextBox.Top = 0.0!
		Me.subtotalTextBox.Width = 1.0!
		'
		'label1
		'
		Me.label1.Height = 0.2!
		Me.label1.HyperLink = Nothing
		Me.label1.Left = 4.5!
		Me.label1.Name = "label1"
		Me.label1.Padding = New GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0)
		Me.label1.Style = "color: White; font-weight: bold; ddo-char-set: 1"
		Me.label1.Text = "Total:"
		Me.label1.Top = 0.4!
		Me.label1.Width = 1.0!
		'
		'line3
		'
		Me.line3.Height = 0.0!
		Me.line3.Left = 4.5!
		Me.line3.LineWeight = 1.0!
		Me.line3.Name = "line3"
		Me.line3.Top = 0.2!
		Me.line3.Width = 1.998!
		Me.line3.X1 = 4.5!
		Me.line3.X2 = 6.498!
		Me.line3.Y1 = 0.2!
		Me.line3.Y2 = 0.2!
		'
		'line4
		'
		Me.line4.Height = 0.0!
		Me.line4.Left = 4.5!
		Me.line4.LineWeight = 1.0!
		Me.line4.Name = "line4"
		Me.line4.Top = 0.394!
		Me.line4.Width = 1.998!
		Me.line4.X1 = 4.5!
		Me.line4.X2 = 6.498!
		Me.line4.Y1 = 0.394!
		Me.line4.Y2 = 0.394!
		'
		'pageNoFMReportInfo
		'
		Me.pageNoFMReportInfo.FormatString = "{PageNumber} / {PageCount} "
		Me.pageNoFMReportInfo.Height = 0.1979167!
		Me.pageNoFMReportInfo.Left = 1.75!
		Me.pageNoFMReportInfo.Name = "pageNoFMReportInfo"
		Me.pageNoFMReportInfo.Style = "text-align: center"
		Me.pageNoFMReportInfo.Top = 0.0!
		Me.pageNoFMReportInfo.Width = 3.0!
		'
		'BillingAddress
		'
		Me.BillingAddress.DefaultValue = Nothing
		Me.BillingAddress.FieldType = GrapeCity.ActiveReports.Data.FieldTypeEnum.None
		Me.BillingAddress.Formula = "Customers.CompanyName + """ & Global.Microsoft.VisualBasic.ChrW(10) & """ + Address + """ & Global.Microsoft.VisualBasic.ChrW(10) & """ + City + "", "" + Region + ""  "" + Posta" & _
	"lCode"
		Me.BillingAddress.Name = "BillingAddress"
		Me.BillingAddress.Tag = Nothing
		'
		'ShippingAddress
		'
		Me.ShippingAddress.DefaultValue = Nothing
		Me.ShippingAddress.FieldType = GrapeCity.ActiveReports.Data.FieldTypeEnum.None
		Me.ShippingAddress.Formula = "ShipName + """ & Global.Microsoft.VisualBasic.ChrW(10) & """ + ShipAddress + """ & Global.Microsoft.VisualBasic.ChrW(10) & """ + ShipCity + "", "" + ShipRegion + ""  "" + ShipPo" & _
	"stalCode"
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
		OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.mdb;Persist Security Info=False"
		OleDBDataSource1.SQL = ""
		Me.DataSource = OleDBDataSource1
		Me.MaxPages = CType(100, Long)
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.510417!
		Me.Script = resources.GetString("$this.Script")
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.customerGroupHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.customerGroupFooter)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
	Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
	Private WithEvents line1 As GrapeCity.ActiveReports.SectionReportModel.Line
	Private WithEvents qtyTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents productNameTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents unitPriceTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents totalTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
	Private WithEvents shape3 As GrapeCity.ActiveReports.SectionReportModel.Shape
	Private WithEvents companyNameLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents invoiceLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents orderDateTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents orderIDTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents orderIDLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents label2 As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents line5 As GrapeCity.ActiveReports.SectionReportModel.Line
	Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
	Private WithEvents pageNoFMReportInfo As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
	Private WithEvents customerGroupHeader As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
	Private WithEvents shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape
	Private WithEvents shippingAddressLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents billingAddressLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents qtyLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents productDescLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents unitPriceLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents totalLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents crossSectionLine1 As GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine
	Private WithEvents crossSectionLine2 As GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine
	Private WithEvents crossSectionLine3 As GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine
	Private WithEvents line2 As GrapeCity.ActiveReports.SectionReportModel.Line
	Private WithEvents billingAddressTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents shippingAddressTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents crossSectionBox1 As GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox
	Private WithEvents customerGroupFooter As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
	Private WithEvents grandTotalTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents shape2 As GrapeCity.ActiveReports.SectionReportModel.Shape
	Private WithEvents shape4 As GrapeCity.ActiveReports.SectionReportModel.Shape
	Private WithEvents freightLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents freightTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents subTotalLabel As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents subtotalTextBox As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private WithEvents label1 As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents line3 As GrapeCity.ActiveReports.SectionReportModel.Line
	Private WithEvents line4 As GrapeCity.ActiveReports.SectionReportModel.Line
	Friend WithEvents BillingAddress As GrapeCity.ActiveReports.Data.Field
	Friend WithEvents ShippingAddress As GrapeCity.ActiveReports.Data.Field
	Friend WithEvents Total As GrapeCity.ActiveReports.Data.Field
End Class
