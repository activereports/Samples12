 _
Partial Class Catalog
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catalog))
		Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Me.txtProductName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtProductID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtQtyPerUnit = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lblTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDesc1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDesc2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDesc3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDesc4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDesc5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDesc6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDesc7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDesc8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.imgNWLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
		Me.PageBreak1 = New GrapeCity.ActiveReports.SectionReportModel.PageBreak()
		Me.boxShip = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.boxTotals = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.boxProducts = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.lblOrderForm = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblInstructionsText = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblBillTo = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblShipTo = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDateOfOrder = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDateRequired = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblCustomerID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblProductID2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblProductName2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblUnitPrice2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblQuantity2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblExtendedPrice2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblSubTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblFreight = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lneBillTo1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneBillTo2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneBillTo3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneBillTo4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneShipTo1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneShipTo2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneShipTo3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneShipTo4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneDateOfOrder = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneDateRequired = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneCustomerID = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneTotal1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneTotal2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lblSpeedyExpress = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblUnitedPackage = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblFederalShipping = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblShipVia = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.boxSpeedyExpress = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.boxUnitedPackage = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.boxFederalShipping = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.SmallPictureLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
		Me.NameLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
		Me.lneSeparator = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lneProducts11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lblPageFooter = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtDescription = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblProductName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblProductID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblQtyPerUnit = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtCategoryName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.oleCategory = New GrapeCity.ActiveReports.SectionReportModel.OleObject()
		Me.lneSep = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
		Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		Me.ghCategoryName = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.gfCategoryName = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		CType(Me.txtProductName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtProductID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtQtyPerUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDesc1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDesc2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDesc3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDesc4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDesc5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDesc6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDesc7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDesc8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgNWLogo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblOrderForm, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblInstructionsText, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblBillTo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblShipTo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDateOfOrder, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDateRequired, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblCustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblProductID2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblProductName2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblUnitPrice2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblQuantity2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblExtendedPrice2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblFreight, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblTotal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblSpeedyExpress, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblUnitedPackage, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblFederalShipping, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblShipVia, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SmallPictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NameLogo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblPageFooter, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblProductName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblProductID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblQtyPerUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCategoryName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'txtProductName
		'
		Me.txtProductName.CanGrow = False
		Me.txtProductName.DataField = "ProductName"
		resources.ApplyResources(Me.txtProductName, "txtProductName")
		Me.txtProductName.Name = "txtProductName"
		'
		'txtProductID
		'
		Me.txtProductID.CanGrow = False
		Me.txtProductID.DataField = "ProductID"
		resources.ApplyResources(Me.txtProductID, "txtProductID")
		Me.txtProductID.Name = "txtProductID"
		'
		'txtQtyPerUnit
		'
		Me.txtQtyPerUnit.CanGrow = False
		Me.txtQtyPerUnit.DataField = "QuantityPerUnit"
		resources.ApplyResources(Me.txtQtyPerUnit, "txtQtyPerUnit")
		Me.txtQtyPerUnit.Name = "txtQtyPerUnit"
		'
		'txtUnitPrice
		'
		Me.txtUnitPrice.CanGrow = False
		Me.txtUnitPrice.DataField = "UnitPrice"
		resources.ApplyResources(Me.txtUnitPrice, "txtUnitPrice")
		Me.txtUnitPrice.Name = "txtUnitPrice"
		'
		'Line1
		'
		resources.ApplyResources(Me.Line1, "Line1")
		Me.Line1.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.Line1.LineWeight = 4.0!
		Me.Line1.Name = "Line1"
		Me.Line1.X1 = 0.0!
		Me.Line1.X2 = 6.5!
		Me.Line1.Y1 = 2.5625!
		Me.Line1.Y2 = 2.5625!
		'
		'lblTitle
		'
		resources.ApplyResources(Me.lblTitle, "lblTitle")
		Me.lblTitle.Name = "lblTitle"
		'
		'lblDesc1
		'
		resources.ApplyResources(Me.lblDesc1, "lblDesc1")
		Me.lblDesc1.Name = "lblDesc1"
		'
		'lblDesc2
		'
		resources.ApplyResources(Me.lblDesc2, "lblDesc2")
		Me.lblDesc2.Name = "lblDesc2"
		'
		'lblDesc3
		'
		resources.ApplyResources(Me.lblDesc3, "lblDesc3")
		Me.lblDesc3.Name = "lblDesc3"
		'
		'lblDesc4
		'
		resources.ApplyResources(Me.lblDesc4, "lblDesc4")
		Me.lblDesc4.Name = "lblDesc4"
		'
		'lblDesc5
		'
		resources.ApplyResources(Me.lblDesc5, "lblDesc5")
		Me.lblDesc5.Name = "lblDesc5"
		'
		'lblDesc6
		'
		resources.ApplyResources(Me.lblDesc6, "lblDesc6")
		Me.lblDesc6.Name = "lblDesc6"
		'
		'lblDesc7
		'
		resources.ApplyResources(Me.lblDesc7, "lblDesc7")
		Me.lblDesc7.Name = "lblDesc7"
		'
		'lblDesc8
		'
		resources.ApplyResources(Me.lblDesc8, "lblDesc8")
		Me.lblDesc8.Name = "lblDesc8"
		'
		'imgNWLogo
		'
		Me.imgNWLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		resources.ApplyResources(Me.imgNWLogo, "imgNWLogo")
		Me.imgNWLogo.ImageData = CType(resources.GetObject("imgNWLogo.ImageData"), System.IO.Stream)
		Me.imgNWLogo.LineColor = System.Drawing.Color.Black
		Me.imgNWLogo.LineWeight = 1.0!
		Me.imgNWLogo.Name = "imgNWLogo"
		'
		'PageBreak1
		'
		resources.ApplyResources(Me.PageBreak1, "PageBreak1")
		Me.PageBreak1.Name = "PageBreak1"
		Me.PageBreak1.Size = New System.Drawing.SizeF(6.5!, 0.05555556!)
		'
		'boxShip
		'
		resources.ApplyResources(Me.boxShip, "boxShip")
		Me.boxShip.Name = "boxShip"
		Me.boxShip.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		Me.boxShip.Tag = ""
		'
		'boxTotals
		'
		resources.ApplyResources(Me.boxTotals, "boxTotals")
		Me.boxTotals.Name = "boxTotals"
		Me.boxTotals.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		Me.boxTotals.Tag = ""
		'
		'boxProducts
		'
		resources.ApplyResources(Me.boxProducts, "boxProducts")
		Me.boxProducts.Name = "boxProducts"
		Me.boxProducts.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		Me.boxProducts.Tag = ""
		'
		'lblOrderForm
		'
		resources.ApplyResources(Me.lblOrderForm, "lblOrderForm")
		Me.lblOrderForm.Name = "lblOrderForm"
		Me.lblOrderForm.Tag = ""
		'
		'lblAddress
		'
		resources.ApplyResources(Me.lblAddress, "lblAddress")
		Me.lblAddress.Name = "lblAddress"
		Me.lblAddress.Tag = ""
		'
		'lblInstructionsText
		'
		resources.ApplyResources(Me.lblInstructionsText, "lblInstructionsText")
		Me.lblInstructionsText.Name = "lblInstructionsText"
		Me.lblInstructionsText.Tag = ""
		'
		'lblBillTo
		'
		resources.ApplyResources(Me.lblBillTo, "lblBillTo")
		Me.lblBillTo.Name = "lblBillTo"
		Me.lblBillTo.Tag = ""
		'
		'lblShipTo
		'
		resources.ApplyResources(Me.lblShipTo, "lblShipTo")
		Me.lblShipTo.Name = "lblShipTo"
		Me.lblShipTo.Tag = ""
		'
		'lblDateOfOrder
		'
		resources.ApplyResources(Me.lblDateOfOrder, "lblDateOfOrder")
		Me.lblDateOfOrder.Name = "lblDateOfOrder"
		Me.lblDateOfOrder.Tag = ""
		'
		'lblDateRequired
		'
		resources.ApplyResources(Me.lblDateRequired, "lblDateRequired")
		Me.lblDateRequired.Name = "lblDateRequired"
		Me.lblDateRequired.Tag = ""
		'
		'lblCustomerID
		'
		resources.ApplyResources(Me.lblCustomerID, "lblCustomerID")
		Me.lblCustomerID.Name = "lblCustomerID"
		Me.lblCustomerID.Tag = ""
		'
		'lblProductID2
		'
		resources.ApplyResources(Me.lblProductID2, "lblProductID2")
		Me.lblProductID2.Name = "lblProductID2"
		Me.lblProductID2.Tag = ""
		'
		'lblProductName2
		'
		resources.ApplyResources(Me.lblProductName2, "lblProductName2")
		Me.lblProductName2.Name = "lblProductName2"
		Me.lblProductName2.Tag = ""
		'
		'lblUnitPrice2
		'
		resources.ApplyResources(Me.lblUnitPrice2, "lblUnitPrice2")
		Me.lblUnitPrice2.Name = "lblUnitPrice2"
		Me.lblUnitPrice2.Tag = ""
		'
		'lblQuantity2
		'
		resources.ApplyResources(Me.lblQuantity2, "lblQuantity2")
		Me.lblQuantity2.Name = "lblQuantity2"
		Me.lblQuantity2.Tag = ""
		'
		'lblExtendedPrice2
		'
		resources.ApplyResources(Me.lblExtendedPrice2, "lblExtendedPrice2")
		Me.lblExtendedPrice2.Name = "lblExtendedPrice2"
		Me.lblExtendedPrice2.Tag = ""
		'
		'lblSubTotal
		'
		resources.ApplyResources(Me.lblSubTotal, "lblSubTotal")
		Me.lblSubTotal.Name = "lblSubTotal"
		Me.lblSubTotal.Tag = ""
		'
		'lblFreight
		'
		resources.ApplyResources(Me.lblFreight, "lblFreight")
		Me.lblFreight.Name = "lblFreight"
		Me.lblFreight.Tag = ""
		'
		'lblTotal
		'
		resources.ApplyResources(Me.lblTotal, "lblTotal")
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Tag = ""
		'
		'lneBillTo1
		'
		resources.ApplyResources(Me.lneBillTo1, "lneBillTo1")
		Me.lneBillTo1.LineWeight = 1.0!
		Me.lneBillTo1.Name = "lneBillTo1"
		Me.lneBillTo1.Tag = ""
		Me.lneBillTo1.X1 = 0.7875!
		Me.lneBillTo1.X2 = 2.985417!
		Me.lneBillTo1.Y1 = 2.958333!
		Me.lneBillTo1.Y2 = 2.958333!
		'
		'lneBillTo2
		'
		resources.ApplyResources(Me.lneBillTo2, "lneBillTo2")
		Me.lneBillTo2.LineWeight = 1.0!
		Me.lneBillTo2.Name = "lneBillTo2"
		Me.lneBillTo2.Tag = ""
		Me.lneBillTo2.X1 = 0.28125!
		Me.lneBillTo2.X2 = 2.985417!
		Me.lneBillTo2.Y1 = 3.135417!
		Me.lneBillTo2.Y2 = 3.135417!
		'
		'lneBillTo3
		'
		resources.ApplyResources(Me.lneBillTo3, "lneBillTo3")
		Me.lneBillTo3.LineWeight = 1.0!
		Me.lneBillTo3.Name = "lneBillTo3"
		Me.lneBillTo3.Tag = ""
		Me.lneBillTo3.X1 = 0.28125!
		Me.lneBillTo3.X2 = 2.985417!
		Me.lneBillTo3.Y1 = 3.302083!
		Me.lneBillTo3.Y2 = 3.302083!
		'
		'lneBillTo4
		'
		resources.ApplyResources(Me.lneBillTo4, "lneBillTo4")
		Me.lneBillTo4.LineWeight = 1.0!
		Me.lneBillTo4.Name = "lneBillTo4"
		Me.lneBillTo4.Tag = ""
		Me.lneBillTo4.X1 = 0.28125!
		Me.lneBillTo4.X2 = 2.985417!
		Me.lneBillTo4.Y1 = 3.46875!
		Me.lneBillTo4.Y2 = 3.46875!
		'
		'lneShipTo1
		'
		resources.ApplyResources(Me.lneShipTo1, "lneShipTo1")
		Me.lneShipTo1.LineWeight = 1.0!
		Me.lneShipTo1.Name = "lneShipTo1"
		Me.lneShipTo1.Tag = ""
		Me.lneShipTo1.X1 = 3.902083!
		Me.lneShipTo1.X2 = 6.089582!
		Me.lneShipTo1.Y1 = 2.958333!
		Me.lneShipTo1.Y2 = 2.958333!
		'
		'lneShipTo2
		'
		resources.ApplyResources(Me.lneShipTo2, "lneShipTo2")
		Me.lneShipTo2.LineWeight = 1.0!
		Me.lneShipTo2.Name = "lneShipTo2"
		Me.lneShipTo2.Tag = ""
		Me.lneShipTo2.X1 = 3.395833!
		Me.lneShipTo2.X2 = 6.089582!
		Me.lneShipTo2.Y1 = 3.135417!
		Me.lneShipTo2.Y2 = 3.135417!
		'
		'lneShipTo3
		'
		resources.ApplyResources(Me.lneShipTo3, "lneShipTo3")
		Me.lneShipTo3.LineWeight = 1.0!
		Me.lneShipTo3.Name = "lneShipTo3"
		Me.lneShipTo3.Tag = ""
		Me.lneShipTo3.X1 = 3.395833!
		Me.lneShipTo3.X2 = 6.089582!
		Me.lneShipTo3.Y1 = 3.302083!
		Me.lneShipTo3.Y2 = 3.302083!
		'
		'lneShipTo4
		'
		resources.ApplyResources(Me.lneShipTo4, "lneShipTo4")
		Me.lneShipTo4.LineWeight = 1.0!
		Me.lneShipTo4.Name = "lneShipTo4"
		Me.lneShipTo4.Tag = ""
		Me.lneShipTo4.X1 = 3.395833!
		Me.lneShipTo4.X2 = 6.089582!
		Me.lneShipTo4.Y1 = 3.46875!
		Me.lneShipTo4.Y2 = 3.46875!
		'
		'lneDateOfOrder
		'
		resources.ApplyResources(Me.lneDateOfOrder, "lneDateOfOrder")
		Me.lneDateOfOrder.LineWeight = 1.0!
		Me.lneDateOfOrder.Name = "lneDateOfOrder"
		Me.lneDateOfOrder.Tag = ""
		Me.lneDateOfOrder.X1 = 1.166667!
		Me.lneDateOfOrder.X2 = 2.666667!
		Me.lneDateOfOrder.Y1 = 3.916667!
		Me.lneDateOfOrder.Y2 = 3.916667!
		'
		'lneDateRequired
		'
		resources.ApplyResources(Me.lneDateRequired, "lneDateRequired")
		Me.lneDateRequired.LineWeight = 1.0!
		Me.lneDateRequired.Name = "lneDateRequired"
		Me.lneDateRequired.Tag = ""
		Me.lneDateRequired.X1 = 1.166667!
		Me.lneDateRequired.X2 = 2.666667!
		Me.lneDateRequired.Y1 = 4.15625!
		Me.lneDateRequired.Y2 = 4.15625!
		'
		'lneCustomerID
		'
		resources.ApplyResources(Me.lneCustomerID, "lneCustomerID")
		Me.lneCustomerID.LineWeight = 1.0!
		Me.lneCustomerID.Name = "lneCustomerID"
		Me.lneCustomerID.Tag = ""
		Me.lneCustomerID.X1 = 4.18125!
		Me.lneCustomerID.X2 = 6.0875!
		Me.lneCustomerID.Y1 = 4.15625!
		Me.lneCustomerID.Y2 = 4.15625!
		'
		'lneProducts2
		'
		resources.ApplyResources(Me.lneProducts2, "lneProducts2")
		Me.lneProducts2.LineWeight = 1.0!
		Me.lneProducts2.Name = "lneProducts2"
		Me.lneProducts2.Tag = ""
		Me.lneProducts2.X1 = 0.3!
		Me.lneProducts2.X2 = 6.1!
		Me.lneProducts2.Y1 = 4.645833!
		Me.lneProducts2.Y2 = 4.645833!
		'
		'lneProducts3
		'
		resources.ApplyResources(Me.lneProducts3, "lneProducts3")
		Me.lneProducts3.LineWeight = 1.0!
		Me.lneProducts3.Name = "lneProducts3"
		Me.lneProducts3.Tag = ""
		Me.lneProducts3.X1 = 0.3!
		Me.lneProducts3.X2 = 6.1!
		Me.lneProducts3.Y1 = 4.8125!
		Me.lneProducts3.Y2 = 4.8125!
		'
		'lneProducts4
		'
		resources.ApplyResources(Me.lneProducts4, "lneProducts4")
		Me.lneProducts4.LineWeight = 1.0!
		Me.lneProducts4.Name = "lneProducts4"
		Me.lneProducts4.Tag = ""
		Me.lneProducts4.X1 = 0.3!
		Me.lneProducts4.X2 = 6.1!
		Me.lneProducts4.Y1 = 4.979167!
		Me.lneProducts4.Y2 = 4.979167!
		'
		'lneProducts5
		'
		resources.ApplyResources(Me.lneProducts5, "lneProducts5")
		Me.lneProducts5.LineWeight = 1.0!
		Me.lneProducts5.Name = "lneProducts5"
		Me.lneProducts5.Tag = ""
		Me.lneProducts5.X1 = 0.3!
		Me.lneProducts5.X2 = 6.1!
		Me.lneProducts5.Y1 = 5.145833!
		Me.lneProducts5.Y2 = 5.145833!
		'
		'lneProducts6
		'
		resources.ApplyResources(Me.lneProducts6, "lneProducts6")
		Me.lneProducts6.LineWeight = 1.0!
		Me.lneProducts6.Name = "lneProducts6"
		Me.lneProducts6.Tag = ""
		Me.lneProducts6.X1 = 0.3!
		Me.lneProducts6.X2 = 6.1!
		Me.lneProducts6.Y1 = 5.3125!
		Me.lneProducts6.Y2 = 5.3125!
		'
		'lneProducts7
		'
		resources.ApplyResources(Me.lneProducts7, "lneProducts7")
		Me.lneProducts7.LineWeight = 1.0!
		Me.lneProducts7.Name = "lneProducts7"
		Me.lneProducts7.Tag = ""
		Me.lneProducts7.X1 = 0.3!
		Me.lneProducts7.X2 = 6.1!
		Me.lneProducts7.Y1 = 5.479167!
		Me.lneProducts7.Y2 = 5.479167!
		'
		'lneProducts8
		'
		resources.ApplyResources(Me.lneProducts8, "lneProducts8")
		Me.lneProducts8.LineWeight = 1.0!
		Me.lneProducts8.Name = "lneProducts8"
		Me.lneProducts8.Tag = ""
		Me.lneProducts8.X1 = 0.3!
		Me.lneProducts8.X2 = 6.1!
		Me.lneProducts8.Y1 = 5.645833!
		Me.lneProducts8.Y2 = 5.645833!
		'
		'lneProducts9
		'
		resources.ApplyResources(Me.lneProducts9, "lneProducts9")
		Me.lneProducts9.LineWeight = 1.0!
		Me.lneProducts9.Name = "lneProducts9"
		Me.lneProducts9.Tag = ""
		Me.lneProducts9.X1 = 0.3!
		Me.lneProducts9.X2 = 6.1!
		Me.lneProducts9.Y1 = 5.8125!
		Me.lneProducts9.Y2 = 5.8125!
		'
		'lneProducts10
		'
		resources.ApplyResources(Me.lneProducts10, "lneProducts10")
		Me.lneProducts10.LineWeight = 1.0!
		Me.lneProducts10.Name = "lneProducts10"
		Me.lneProducts10.Tag = ""
		Me.lneProducts10.X1 = 0.3!
		Me.lneProducts10.X2 = 6.1!
		Me.lneProducts10.Y1 = 5.979167!
		Me.lneProducts10.Y2 = 5.979167!
		'
		'lneProducts1
		'
		resources.ApplyResources(Me.lneProducts1, "lneProducts1")
		Me.lneProducts1.LineWeight = 1.0!
		Me.lneProducts1.Name = "lneProducts1"
		Me.lneProducts1.Tag = ""
		Me.lneProducts1.X1 = 0.3!
		Me.lneProducts1.X2 = 6.1!
		Me.lneProducts1.Y1 = 4.489583!
		Me.lneProducts1.Y2 = 4.489583!
		'
		'lneProducts12
		'
		resources.ApplyResources(Me.lneProducts12, "lneProducts12")
		Me.lneProducts12.LineWeight = 1.0!
		Me.lneProducts12.Name = "lneProducts12"
		Me.lneProducts12.Tag = ""
		Me.lneProducts12.X1 = 3.404167!
		Me.lneProducts12.X2 = 3.404167!
		Me.lneProducts12.Y1 = 4.259722!
		Me.lneProducts12.Y2 = 6.144444!
		'
		'lneProducts14
		'
		resources.ApplyResources(Me.lneProducts14, "lneProducts14")
		Me.lneProducts14.LineWeight = 1.0!
		Me.lneProducts14.Name = "lneProducts14"
		Me.lneProducts14.Tag = ""
		Me.lneProducts14.X1 = 5.177083!
		Me.lneProducts14.X2 = 5.177083!
		Me.lneProducts14.Y1 = 4.259722!
		Me.lneProducts14.Y2 = 6.822222!
		'
		'lneProducts13
		'
		resources.ApplyResources(Me.lneProducts13, "lneProducts13")
		Me.lneProducts13.LineWeight = 1.0!
		Me.lneProducts13.Name = "lneProducts13"
		Me.lneProducts13.Tag = ""
		Me.lneProducts13.X1 = 4.302083!
		Me.lneProducts13.X2 = 4.302083!
		Me.lneProducts13.Y1 = 4.259722!
		Me.lneProducts13.Y2 = 6.144444!
		'
		'lneTotal1
		'
		resources.ApplyResources(Me.lneTotal1, "lneTotal1")
		Me.lneTotal1.LineWeight = 1.0!
		Me.lneTotal1.Name = "lneTotal1"
		Me.lneTotal1.Tag = ""
		Me.lneTotal1.X1 = 3.404167!
		Me.lneTotal1.X2 = 6.095833!
		Me.lneTotal1.Y1 = 6.365278!
		Me.lneTotal1.Y2 = 6.365278!
		'
		'lneTotal2
		'
		resources.ApplyResources(Me.lneTotal2, "lneTotal2")
		Me.lneTotal2.LineWeight = 1.0!
		Me.lneTotal2.Name = "lneTotal2"
		Me.lneTotal2.Tag = ""
		Me.lneTotal2.X1 = 3.404167!
		Me.lneTotal2.X2 = 6.095833!
		Me.lneTotal2.Y1 = 6.594444!
		Me.lneTotal2.Y2 = 6.594444!
		'
		'lblSpeedyExpress
		'
		resources.ApplyResources(Me.lblSpeedyExpress, "lblSpeedyExpress")
		Me.lblSpeedyExpress.Name = "lblSpeedyExpress"
		Me.lblSpeedyExpress.Tag = ""
		'
		'lblUnitedPackage
		'
		resources.ApplyResources(Me.lblUnitedPackage, "lblUnitedPackage")
		Me.lblUnitedPackage.Name = "lblUnitedPackage"
		Me.lblUnitedPackage.Tag = ""
		'
		'lblFederalShipping
		'
		resources.ApplyResources(Me.lblFederalShipping, "lblFederalShipping")
		Me.lblFederalShipping.Name = "lblFederalShipping"
		Me.lblFederalShipping.Tag = ""
		'
		'lblShipVia
		'
		resources.ApplyResources(Me.lblShipVia, "lblShipVia")
		Me.lblShipVia.Name = "lblShipVia"
		Me.lblShipVia.Tag = ""
		'
		'boxSpeedyExpress
		'
		resources.ApplyResources(Me.boxSpeedyExpress, "boxSpeedyExpress")
		Me.boxSpeedyExpress.Name = "boxSpeedyExpress"
		Me.boxSpeedyExpress.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		Me.boxSpeedyExpress.Tag = ""
		'
		'boxUnitedPackage
		'
		resources.ApplyResources(Me.boxUnitedPackage, "boxUnitedPackage")
		Me.boxUnitedPackage.Name = "boxUnitedPackage"
		Me.boxUnitedPackage.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		Me.boxUnitedPackage.Tag = ""
		'
		'boxFederalShipping
		'
		resources.ApplyResources(Me.boxFederalShipping, "boxFederalShipping")
		Me.boxFederalShipping.Name = "boxFederalShipping"
		Me.boxFederalShipping.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		Me.boxFederalShipping.Tag = ""
		'
		'SmallPictureLogo
		'
		Me.SmallPictureLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		resources.ApplyResources(Me.SmallPictureLogo, "SmallPictureLogo")
		Me.SmallPictureLogo.ImageData = CType(resources.GetObject("SmallPictureLogo.ImageData"), System.IO.Stream)
		Me.SmallPictureLogo.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.SmallPictureLogo.Name = "SmallPictureLogo"
		Me.SmallPictureLogo.Tag = ""
		'
		'NameLogo
		'
		Me.NameLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		resources.ApplyResources(Me.NameLogo, "NameLogo")
		Me.NameLogo.ImageData = CType(resources.GetObject("NameLogo.ImageData"), System.IO.Stream)
		Me.NameLogo.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.NameLogo.Name = "NameLogo"
		Me.NameLogo.Tag = ""
		'
		'lneSeparator
		'
		resources.ApplyResources(Me.lneSeparator, "lneSeparator")
		Me.lneSeparator.LineWeight = 1.0!
		Me.lneSeparator.Name = "lneSeparator"
		Me.lneSeparator.Tag = ""
		Me.lneSeparator.X1 = 0.0!
		Me.lneSeparator.X2 = 6.5!
		Me.lneSeparator.Y1 = 0.9270833!
		Me.lneSeparator.Y2 = 0.9270833!
		'
		'lneProducts11
		'
		resources.ApplyResources(Me.lneProducts11, "lneProducts11")
		Me.lneProducts11.LineWeight = 1.0!
		Me.lneProducts11.Name = "lneProducts11"
		Me.lneProducts11.Tag = ""
		Me.lneProducts11.X1 = 0.96875!
		Me.lneProducts11.X2 = 0.96875!
		Me.lneProducts11.Y1 = 4.259722!
		Me.lneProducts11.Y2 = 6.144444!
		'
		'lblPageFooter
		'
		resources.ApplyResources(Me.lblPageFooter, "lblPageFooter")
		Me.lblPageFooter.Name = "lblPageFooter"
		'
		'lblPage
		'
		resources.ApplyResources(Me.lblPage, "lblPage")
		Me.lblPage.Name = "lblPage"
		'
		'txtDescription
		'
		Me.txtDescription.CanGrow = False
		Me.txtDescription.DataField = "Description"
		resources.ApplyResources(Me.txtDescription, "txtDescription")
		Me.txtDescription.Name = "txtDescription"
		'
		'lblProductName
		'
		resources.ApplyResources(Me.lblProductName, "lblProductName")
		Me.lblProductName.Name = "lblProductName"
		'
		'lblProductID
		'
		resources.ApplyResources(Me.lblProductID, "lblProductID")
		Me.lblProductID.Name = "lblProductID"
		'
		'lblQtyPerUnit
		'
		resources.ApplyResources(Me.lblQtyPerUnit, "lblQtyPerUnit")
		Me.lblQtyPerUnit.Name = "lblQtyPerUnit"
		'
		'lblUnitPrice
		'
		resources.ApplyResources(Me.lblUnitPrice, "lblUnitPrice")
		Me.lblUnitPrice.Name = "lblUnitPrice"
		'
		'txtCategoryName
		'
		Me.txtCategoryName.DataField = "CategoryName"
		resources.ApplyResources(Me.txtCategoryName, "txtCategoryName")
		Me.txtCategoryName.Name = "txtCategoryName"
		'
		'oleCategory
		'
		Me.oleCategory.Class = Nothing
		Me.oleCategory.DataField = "Picture"
		Me.oleCategory.DataValue = Nothing
		resources.ApplyResources(Me.oleCategory, "oleCategory")
		Me.oleCategory.Name = "oleCategory"
		Me.oleCategory.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Stretch
		'
		'lneSep
		'
		resources.ApplyResources(Me.lneSep, "lneSep")
		Me.lneSep.LineWeight = 2.0!
		Me.lneSep.Name = "lneSep"
		Me.lneSep.X1 = 0.125!
		Me.lneSep.X2 = 6.4375!
		Me.lneSep.Y1 = 0.0!
		Me.lneSep.Y2 = 0.0!
		'
		'Detail
		'
		Me.Detail.CanGrow = False
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProductName, Me.txtProductID, Me.txtQtyPerUnit, Me.txtUnitPrice})
		Me.Detail.Height = 0.2625!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'ReportHeader
		'
		Me.ReportHeader.CanGrow = False
		Me.ReportHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line1, Me.lblTitle, Me.lblDesc1, Me.lblDesc2, Me.lblDesc3, Me.lblDesc4, Me.lblDesc5, Me.lblDesc6, Me.lblDesc7, Me.lblDesc8, Me.imgNWLogo, Me.PageBreak1})
		Me.ReportHeader.Height = 13.0625!
		Me.ReportHeader.Name = "ReportHeader"
		Me.ReportHeader.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
		'
		'ReportFooter
		'
		Me.ReportFooter.CanGrow = False
		Me.ReportFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.boxShip, Me.boxTotals, Me.boxProducts, Me.lblOrderForm, Me.lblAddress, Me.lblInstructionsText, Me.lblBillTo, Me.lblShipTo, Me.lblDateOfOrder, Me.lblDateRequired, Me.lblCustomerID, Me.lblProductID2, Me.lblProductName2, Me.lblUnitPrice2, Me.lblQuantity2, Me.lblExtendedPrice2, Me.lblSubTotal, Me.lblFreight, Me.lblTotal, Me.lneBillTo1, Me.lneBillTo2, Me.lneBillTo3, Me.lneBillTo4, Me.lneShipTo1, Me.lneShipTo2, Me.lneShipTo3, Me.lneShipTo4, Me.lneDateOfOrder, Me.lneDateRequired, Me.lneCustomerID, Me.lneProducts2, Me.lneProducts3, Me.lneProducts4, Me.lneProducts5, Me.lneProducts6, Me.lneProducts7, Me.lneProducts8, Me.lneProducts9, Me.lneProducts10, Me.lneProducts1, Me.lneProducts12, Me.lneProducts14, Me.lneProducts13, Me.lneTotal1, Me.lneTotal2, Me.lblSpeedyExpress, Me.lblUnitedPackage, Me.lblFederalShipping, Me.lblShipVia, Me.boxSpeedyExpress, Me.boxUnitedPackage, Me.boxFederalShipping, Me.SmallPictureLogo, Me.NameLogo, Me.lneSeparator, Me.lneProducts11})
		Me.ReportFooter.Height = 7.53125!
		Me.ReportFooter.KeepTogether = True
		Me.ReportFooter.Name = "ReportFooter"
		Me.ReportFooter.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.Before
		'
		'PageHeader
		'
		Me.PageHeader.CanGrow = False
		Me.PageHeader.Height = 0.0!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.CanGrow = False
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblPageFooter, Me.lblPage})
		Me.PageFooter.Height = 0.46875!
		Me.PageFooter.Name = "PageFooter"
		'
		'ghCategoryName
		'
		Me.ghCategoryName.CanGrow = False
		Me.ghCategoryName.ColumnLayout = False
		Me.ghCategoryName.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtDescription, Me.lblProductName, Me.lblProductID, Me.lblQtyPerUnit, Me.lblUnitPrice, Me.txtCategoryName, Me.oleCategory})
		Me.ghCategoryName.DataField = "CategoryName"
		Me.ghCategoryName.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
		Me.ghCategoryName.Height = 1.606!
		Me.ghCategoryName.KeepTogether = True
		Me.ghCategoryName.Name = "ghCategoryName"
		'
		'gfCategoryName
		'
		Me.gfCategoryName.CanGrow = False
		Me.gfCategoryName.ColumnLayout = False
		Me.gfCategoryName.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lneSep})
		Me.gfCategoryName.Height = 0.07222223!
		Me.gfCategoryName.KeepTogether = True
		Me.gfCategoryName.Name = "gfCategoryName"
		'
		'Catalog
		'
		Me.MasterReport = False
		OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.MDB"
		OleDBDataSource1.SQL = "SELECT Categories.*, Products.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM Categories INNER JOIN Products ON Categorie" & _
	"s.CategoryID = Products.CategoryID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY Categories.CategoryName;"
		Me.DataSource = OleDBDataSource1
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Sections.Add(Me.ReportHeader)
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.ghCategoryName)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.gfCategoryName)
		Me.Sections.Add(Me.PageFooter)
		Me.Sections.Add(Me.ReportFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
			"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.txtProductName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtProductID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtQtyPerUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDesc1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDesc2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDesc3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDesc4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDesc5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDesc6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDesc7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDesc8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgNWLogo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblOrderForm, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblInstructionsText, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblBillTo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShipTo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDateOfOrder, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDateRequired, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblCustomerID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblProductID2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblProductName2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblUnitPrice2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblQuantity2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblExtendedPrice2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblFreight, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblTotal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblSpeedyExpress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblUnitedPackage, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblFederalShipping, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShipVia, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SmallPictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NameLogo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblPageFooter, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblProductName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblProductID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblQtyPerUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCategoryName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Friend WithEvents txtProductName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtProductID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtQtyPerUnit As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtUnitPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents ReportHeader As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
Friend WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lblTitle As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblDesc1 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblDesc2 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblDesc3 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblDesc4 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblDesc5 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblDesc6 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblDesc7 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblDesc8 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents imgNWLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
Friend WithEvents PageBreak1 As GrapeCity.ActiveReports.SectionReportModel.PageBreak
Private WithEvents ReportFooter As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
Friend WithEvents boxShip As GrapeCity.ActiveReports.SectionReportModel.Shape
Friend WithEvents boxTotals As GrapeCity.ActiveReports.SectionReportModel.Shape
Friend WithEvents boxProducts As GrapeCity.ActiveReports.SectionReportModel.Shape
Friend WithEvents lblOrderForm As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblInstructionsText As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblBillTo As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblShipTo As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblDateOfOrder As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblDateRequired As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblCustomerID As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblProductID2 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblProductName2 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblUnitPrice2 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblQuantity2 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblExtendedPrice2 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblSubTotal As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblFreight As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblTotal As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lneBillTo1 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneBillTo2 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneBillTo3 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneBillTo4 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneShipTo1 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneShipTo2 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneShipTo3 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneShipTo4 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneDateOfOrder As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneDateRequired As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneCustomerID As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts2 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts3 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts4 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts5 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts6 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts7 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts8 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts9 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts10 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts1 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts12 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts14 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts13 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneTotal1 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneTotal2 As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lblSpeedyExpress As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblUnitedPackage As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblFederalShipping As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblShipVia As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents boxSpeedyExpress As GrapeCity.ActiveReports.SectionReportModel.Shape
Friend WithEvents boxUnitedPackage As GrapeCity.ActiveReports.SectionReportModel.Shape
Friend WithEvents boxFederalShipping As GrapeCity.ActiveReports.SectionReportModel.Shape
Friend WithEvents SmallPictureLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
Friend WithEvents NameLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
Friend WithEvents lneSeparator As GrapeCity.ActiveReports.SectionReportModel.Line
Friend WithEvents lneProducts11 As GrapeCity.ActiveReports.SectionReportModel.Line
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Friend WithEvents lblPageFooter As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
Private WithEvents ghCategoryName As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Friend WithEvents txtDescription As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents lblProductName As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblProductID As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblQtyPerUnit As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblUnitPrice As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents txtCategoryName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents oleCategory As GrapeCity.ActiveReports.SectionReportModel.OleObject
Private WithEvents gfCategoryName As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Friend WithEvents lneSep As GrapeCity.ActiveReports.SectionReportModel.Line
End Class
