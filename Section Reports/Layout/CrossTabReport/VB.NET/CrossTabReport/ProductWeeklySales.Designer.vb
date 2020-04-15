 _
Partial Class ProductWeeklySales
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductWeeklySales))
		Me.txtDetProduct = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtDetUnits = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtDetSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtDetOrderDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.lblTitle1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTitle2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTitleLine = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lblReportDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.imgLogoSm = New GrapeCity.ActiveReports.SectionReportModel.Picture()
		Me.lblNorthWind = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTraders = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Shape2 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.lblCategory = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblProduct = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblCurrentWeek = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblMTD = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblQTD = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblYTD = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblPrevQTD = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblWkUnits = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblWkSales = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblMTDUnits = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblMTDSales = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblQTDUnits = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblQTDSales = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblYTDUnits = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblYTDSales = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblPQTDSales = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblPQTDChange = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtCategoryName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.txtCatWkUnits = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCAtWkSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCatMTDUnits = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCatMTDSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCatQTDUnits = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCatQTDSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCatYTDUnits = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCatYTDSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCatPQTDSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCatPQTDChange = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.txtProduct = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtWkUnits = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtWkSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtMTDUnits = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtMTDSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtQTDUnits = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtQTDSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtYTDUnits = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtYTDSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtPQTDSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtPQTDChange = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
		Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		Me.ghCategory = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.gfCategory = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		Me.ghProduct = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.gfProduct = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
	  
		'
		'txtDetProduct
		'
		Me.txtDetProduct.CanGrow = False
		resources.ApplyResources(Me.txtDetProduct, "txtDetProduct")
		Me.txtDetProduct.DataField = "ProductName"
		Me.txtDetProduct.Name = "txtDetProduct"
		'
		'txtDetUnits
		'
		Me.txtDetUnits.CanGrow = False
		resources.ApplyResources(Me.txtDetUnits, "txtDetUnits")
		Me.txtDetUnits.DataField = "ProductUnits"
		Me.txtDetUnits.Name = "txtDetUnits"
		'
		'txtDetSales
		'
		Me.txtDetSales.CanGrow = False
		resources.ApplyResources(Me.txtDetSales, "txtDetSales")
		Me.txtDetSales.DataField = "ProductSales"
		Me.txtDetSales.Name = "txtDetSales"
		'
		'txtDetOrderDate
		'
		Me.txtDetOrderDate.CanGrow = False
		resources.ApplyResources(Me.txtDetOrderDate, "txtDetOrderDate")
		Me.txtDetOrderDate.DataField = "OrderDate"
		Me.txtDetOrderDate.Name = "txtDetOrderDate"
		'
		'Shape1
		'
		Me.Shape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		resources.ApplyResources(Me.Shape1, "Shape1")
		Me.Shape1.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Transparent
		Me.Shape1.Name = "Shape1"
		Me.Shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		'
		'lblTitle1
		'
		resources.ApplyResources(Me.lblTitle1, "lblTitle1")
		Me.lblTitle1.Name = "lblTitle1"
		'
		'lblTitle2
		'
		resources.ApplyResources(Me.lblTitle2, "lblTitle2")
		Me.lblTitle2.Name = "lblTitle2"
		'
		'lblTitleLine
		'
		resources.ApplyResources(Me.lblTitleLine, "lblTitleLine")
		Me.lblTitleLine.LineWeight = 2.0!
		Me.lblTitleLine.Name = "lblTitleLine"
		Me.lblTitleLine.X1 = 0.0625!
		Me.lblTitleLine.X2 = 5.9375!
		Me.lblTitleLine.Y1 = 0.6875!
		Me.lblTitleLine.Y2 = 0.6875!
		'
		'lblReportDate
		'
		resources.ApplyResources(Me.lblReportDate, "lblReportDate")
		Me.lblReportDate.Name = "lblReportDate"
		'
		'imgLogoSm
		'
		Me.imgLogoSm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		resources.ApplyResources(Me.imgLogoSm, "imgLogoSm")
		Me.imgLogoSm.ImageData = CType(resources.GetObject("imgLogoSm.ImageData"), System.IO.Stream)
		Me.imgLogoSm.LineColor = System.Drawing.Color.Black
		Me.imgLogoSm.LineWeight = 1.0!
		Me.imgLogoSm.Name = "imgLogoSm"
		'
		'lblNorthWind
		'
		resources.ApplyResources(Me.lblNorthWind, "lblNorthWind")
		Me.lblNorthWind.Name = "lblNorthWind"
		'
		'lblTraders
		'
		resources.ApplyResources(Me.lblTraders, "lblTraders")
		Me.lblTraders.Name = "lblTraders"
		'
		'Shape2
		'
		Me.Shape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		resources.ApplyResources(Me.Shape2, "Shape2")
		Me.Shape2.Name = "Shape2"
		Me.Shape2.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, Nothing, Nothing, Nothing, Nothing)
		'
		'lblCategory
		'
		resources.ApplyResources(Me.lblCategory, "lblCategory")
		Me.lblCategory.Name = "lblCategory"
		'
		'lblProduct
		'
		resources.ApplyResources(Me.lblProduct, "lblProduct")
		Me.lblProduct.Name = "lblProduct"
		'
		'lblCurrentWeek
		'
		resources.ApplyResources(Me.lblCurrentWeek, "lblCurrentWeek")
		Me.lblCurrentWeek.Name = "lblCurrentWeek"
		'
		'lblMTD
		'
		resources.ApplyResources(Me.lblMTD, "lblMTD")
		Me.lblMTD.Name = "lblMTD"
		'
		'lblQTD
		'
		resources.ApplyResources(Me.lblQTD, "lblQTD")
		Me.lblQTD.Name = "lblQTD"
		'
		'lblYTD
		'
		resources.ApplyResources(Me.lblYTD, "lblYTD")
		Me.lblYTD.Name = "lblYTD"
		'
		'lblPrevQTD
		'
		resources.ApplyResources(Me.lblPrevQTD, "lblPrevQTD")
		Me.lblPrevQTD.Name = "lblPrevQTD"
		'
		'lblWkUnits
		'
		resources.ApplyResources(Me.lblWkUnits, "lblWkUnits")
		Me.lblWkUnits.Name = "lblWkUnits"
		'
		'lblWkSales
		'
		resources.ApplyResources(Me.lblWkSales, "lblWkSales")
		Me.lblWkSales.Name = "lblWkSales"
		'
		'lblMTDUnits
		'
		resources.ApplyResources(Me.lblMTDUnits, "lblMTDUnits")
		Me.lblMTDUnits.Name = "lblMTDUnits"
		'
		'lblMTDSales
		'
		resources.ApplyResources(Me.lblMTDSales, "lblMTDSales")
		Me.lblMTDSales.Name = "lblMTDSales"
		'
		'lblQTDUnits
		'
		resources.ApplyResources(Me.lblQTDUnits, "lblQTDUnits")
		Me.lblQTDUnits.Name = "lblQTDUnits"
		'
		'lblQTDSales
		'
		resources.ApplyResources(Me.lblQTDSales, "lblQTDSales")
		Me.lblQTDSales.Name = "lblQTDSales"
		'
		'lblYTDUnits
		'
		resources.ApplyResources(Me.lblYTDUnits, "lblYTDUnits")
		Me.lblYTDUnits.Name = "lblYTDUnits"
		'
		'lblYTDSales
		'
		resources.ApplyResources(Me.lblYTDSales, "lblYTDSales")
		Me.lblYTDSales.Name = "lblYTDSales"
		'
		'lblPQTDSales
		'
		resources.ApplyResources(Me.lblPQTDSales, "lblPQTDSales")
		Me.lblPQTDSales.Name = "lblPQTDSales"
		'
		'lblPQTDChange
		'
		resources.ApplyResources(Me.lblPQTDChange, "lblPQTDChange")
		Me.lblPQTDChange.Name = "lblPQTDChange"
		'
		'txtCategoryName
		'
		Me.txtCategoryName.CanGrow = False
		resources.ApplyResources(Me.txtCategoryName, "txtCategoryName")
		Me.txtCategoryName.DataField = "CategoryName"
		Me.txtCategoryName.Name = "txtCategoryName"
		'
		'Line1
		'
		resources.ApplyResources(Me.Line1, "Line1")
		Me.Line1.LineWeight = 3.0!
		Me.Line1.Name = "Line1"
		Me.Line1.X1 = 1.625!
		Me.Line1.X2 = 9.9375!
		Me.Line1.Y1 = 0.0!
		Me.Line1.Y2 = 0.0!
		'
		'txtCatWkUnits
		'
		Me.txtCatWkUnits.CanGrow = False
		resources.ApplyResources(Me.txtCatWkUnits, "txtCatWkUnits")
		Me.txtCatWkUnits.DataField = "WkUnits"
		Me.txtCatWkUnits.Name = "txtCatWkUnits"
		Me.txtCatWkUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtCAtWkSales
		'
		Me.txtCAtWkSales.CanGrow = False
		resources.ApplyResources(Me.txtCAtWkSales, "txtCAtWkSales")
		Me.txtCAtWkSales.DataField = "WkSales"
		Me.txtCAtWkSales.Name = "txtCAtWkSales"
		Me.txtCAtWkSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtCatMTDUnits
		'
		Me.txtCatMTDUnits.CanGrow = False
		resources.ApplyResources(Me.txtCatMTDUnits, "txtCatMTDUnits")
		Me.txtCatMTDUnits.DataField = "MTDUnits"
		Me.txtCatMTDUnits.Name = "txtCatMTDUnits"
		Me.txtCatMTDUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtCatMTDSales
		'
		Me.txtCatMTDSales.CanGrow = False
		resources.ApplyResources(Me.txtCatMTDSales, "txtCatMTDSales")
		Me.txtCatMTDSales.DataField = "MTDSales"
		Me.txtCatMTDSales.Name = "txtCatMTDSales"
		Me.txtCatMTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtCatQTDUnits
		'
		Me.txtCatQTDUnits.CanGrow = False
		resources.ApplyResources(Me.txtCatQTDUnits, "txtCatQTDUnits")
		Me.txtCatQTDUnits.DataField = "QTDUnits"
		Me.txtCatQTDUnits.Name = "txtCatQTDUnits"
		Me.txtCatQTDUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtCatQTDSales
		'
		Me.txtCatQTDSales.CanGrow = False
		resources.ApplyResources(Me.txtCatQTDSales, "txtCatQTDSales")
		Me.txtCatQTDSales.DataField = "QTDSales"
		Me.txtCatQTDSales.Name = "txtCatQTDSales"
		Me.txtCatQTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtCatYTDUnits
		'
		Me.txtCatYTDUnits.CanGrow = False
		resources.ApplyResources(Me.txtCatYTDUnits, "txtCatYTDUnits")
		Me.txtCatYTDUnits.DataField = "YTDUnits"
		Me.txtCatYTDUnits.Name = "txtCatYTDUnits"
		Me.txtCatYTDUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtCatYTDSales
		'
		Me.txtCatYTDSales.CanGrow = False
		resources.ApplyResources(Me.txtCatYTDSales, "txtCatYTDSales")
		Me.txtCatYTDSales.DataField = "YTDSales"
		Me.txtCatYTDSales.Name = "txtCatYTDSales"
		Me.txtCatYTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtCatPQTDSales
		'
		Me.txtCatPQTDSales.CanGrow = False
		resources.ApplyResources(Me.txtCatPQTDSales, "txtCatPQTDSales")
		Me.txtCatPQTDSales.DataField = "PQTDSales"
		Me.txtCatPQTDSales.Name = "txtCatPQTDSales"
		Me.txtCatPQTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtCatPQTDChange
		'
		Me.txtCatPQTDChange.CanGrow = False
		resources.ApplyResources(Me.txtCatPQTDChange, "txtCatPQTDChange")
		Me.txtCatPQTDChange.Name = "txtCatPQTDChange"
		'
		'Line2
		'
		resources.ApplyResources(Me.Line2, "Line2")
		Me.Line2.LineWeight = 3.0!
		Me.Line2.Name = "Line2"
		Me.Line2.X1 = 0.0!
		Me.Line2.X2 = 9.9375!
		Me.Line2.Y1 = 0.25!
		Me.Line2.Y2 = 0.25!
		'
		'txtProduct
		'
		resources.ApplyResources(Me.txtProduct, "txtProduct")
		Me.txtProduct.Name = "txtProduct"
		'
		'txtWkUnits
		'
		Me.txtWkUnits.CanGrow = False
		resources.ApplyResources(Me.txtWkUnits, "txtWkUnits")
		Me.txtWkUnits.DataField = "WkUnits"
		Me.txtWkUnits.Name = "txtWkUnits"
		Me.txtWkUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtWkSales
		'
		Me.txtWkSales.CanGrow = False
		resources.ApplyResources(Me.txtWkSales, "txtWkSales")
		Me.txtWkSales.DataField = "WkSales"
		Me.txtWkSales.Name = "txtWkSales"
		Me.txtWkSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtMTDUnits
		'
		Me.txtMTDUnits.CanGrow = False
		resources.ApplyResources(Me.txtMTDUnits, "txtMTDUnits")
		Me.txtMTDUnits.DataField = "MTDUnits"
		Me.txtMTDUnits.Name = "txtMTDUnits"
		Me.txtMTDUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtMTDSales
		'
		Me.txtMTDSales.CanGrow = False
		resources.ApplyResources(Me.txtMTDSales, "txtMTDSales")
		Me.txtMTDSales.DataField = "MTDSales"
		Me.txtMTDSales.Name = "txtMTDSales"
		Me.txtMTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtQTDUnits
		'
		Me.txtQTDUnits.CanGrow = False
		resources.ApplyResources(Me.txtQTDUnits, "txtQTDUnits")
		Me.txtQTDUnits.DataField = "QTDUnits"
		Me.txtQTDUnits.Name = "txtQTDUnits"
		Me.txtQTDUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtQTDSales
		'
		Me.txtQTDSales.CanGrow = False
		resources.ApplyResources(Me.txtQTDSales, "txtQTDSales")
		Me.txtQTDSales.DataField = "QTDSales"
		Me.txtQTDSales.Name = "txtQTDSales"
		Me.txtQTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtYTDUnits
		'
		Me.txtYTDUnits.CanGrow = False
		resources.ApplyResources(Me.txtYTDUnits, "txtYTDUnits")
		Me.txtYTDUnits.DataField = "YTDUnits"
		Me.txtYTDUnits.Name = "txtYTDUnits"
		Me.txtYTDUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtYTDSales
		'
		Me.txtYTDSales.CanGrow = False
		resources.ApplyResources(Me.txtYTDSales, "txtYTDSales")
		Me.txtYTDSales.DataField = "YTDSales"
		Me.txtYTDSales.Name = "txtYTDSales"
		Me.txtYTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtPQTDSales
		'
		Me.txtPQTDSales.CanGrow = False
		resources.ApplyResources(Me.txtPQTDSales, "txtPQTDSales")
		Me.txtPQTDSales.DataField = "PQTDSales"
		Me.txtPQTDSales.Name = "txtPQTDSales"
		Me.txtPQTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtPQTDChange
		'
		Me.txtPQTDChange.CanGrow = False
		resources.ApplyResources(Me.txtPQTDChange, "txtPQTDChange")
		Me.txtPQTDChange.Name = "txtPQTDChange"
		'
		'Line3
		'
		resources.ApplyResources(Me.Line3, "Line3")
		Me.Line3.LineWeight = 1.0!
		Me.Line3.Name = "Line3"
		Me.Line3.X1 = 1.625!
		Me.Line3.X2 = 9.9375!
		Me.Line3.Y1 = 0.201!
		Me.Line3.Y2 = 0.201!
		'
		'Detail
		'
		Me.Detail.CanGrow = False
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtDetProduct, Me.txtDetUnits, Me.txtDetSales, Me.txtDetOrderDate})
		Me.Detail.Height = 0.0!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		Me.Detail.Visible = False
		'
		'ReportHeader
		'
		Me.ReportHeader.CanGrow = False
		Me.ReportHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Shape1, Me.lblTitle1, Me.lblTitle2, Me.lblTitleLine, Me.lblReportDate, Me.imgLogoSm, Me.lblNorthWind, Me.lblTraders})
		Me.ReportHeader.Height = 1.0!
		Me.ReportHeader.Name = "ReportHeader"
		'
		'ReportFooter
		'
		Me.ReportFooter.CanGrow = False
		Me.ReportFooter.Height = 0.0!
		Me.ReportFooter.KeepTogether = True
		Me.ReportFooter.Name = "ReportFooter"
		'
		'PageHeader
		'
		Me.PageHeader.CanGrow = False
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Shape2, Me.lblCategory, Me.lblProduct, Me.lblCurrentWeek, Me.lblMTD, Me.lblQTD, Me.lblYTD, Me.lblPrevQTD, Me.lblWkUnits, Me.lblWkSales, Me.lblMTDUnits, Me.lblMTDSales, Me.lblQTDUnits, Me.lblQTDSales, Me.lblYTDUnits, Me.lblYTDSales, Me.lblPQTDSales, Me.lblPQTDChange})
		Me.PageHeader.Height = 0.375!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.CanGrow = False
		Me.PageFooter.Height = 0.0!
		Me.PageFooter.Name = "PageFooter"
		'
		'ghCategory
		'
		Me.ghCategory.CanGrow = False
		Me.ghCategory.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCategoryName})
		Me.ghCategory.DataField = "CategoryName"
		Me.ghCategory.Height = 0.25!
		Me.ghCategory.KeepTogether = True
		Me.ghCategory.Name = "ghCategory"
		Me.ghCategory.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
		Me.ghCategory.UnderlayNext = True
		'
		'gfCategory
		'
		Me.gfCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.gfCategory.CanGrow = False
		Me.gfCategory.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line1, Me.txtCatWkUnits, Me.txtCAtWkSales, Me.txtCatMTDUnits, Me.txtCatMTDSales, Me.txtCatQTDUnits, Me.txtCatQTDSales, Me.txtCatYTDUnits, Me.txtCatYTDSales, Me.txtCatPQTDSales, Me.txtCatPQTDChange, Me.Line2})
		Me.gfCategory.Height = 0.2597222!
		Me.gfCategory.KeepTogether = True
		Me.gfCategory.Name = "gfCategory"
		'
		'ghProduct
		'
		Me.ghProduct.CanGrow = False
		Me.ghProduct.DataField = "ProductName"
		Me.ghProduct.Height = 0.0!
		Me.ghProduct.KeepTogether = True
		Me.ghProduct.Name = "ghProduct"
		Me.ghProduct.Visible = False
		'
		'gfProduct
		'
		Me.gfProduct.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProduct, Me.txtWkUnits, Me.txtWkSales, Me.txtMTDUnits, Me.txtMTDSales, Me.txtQTDUnits, Me.txtQTDSales, Me.txtYTDUnits, Me.txtYTDSales, Me.txtPQTDSales, Me.txtPQTDChange, Me.Line3})
		Me.gfProduct.Height = 0.2076389!
		Me.gfProduct.KeepTogether = True
		Me.gfProduct.Name = "gfProduct"
		'
		'ProductWeeklySales
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		Me.PageSettings.Margins.Bottom = 0.5!
		Me.PageSettings.Margins.Left = 0.5!
		Me.PageSettings.Margins.Right = 0.5!
		Me.PageSettings.Margins.Top = 0.5!
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 9.947917!
		Me.Sections.Add(Me.ReportHeader)
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.ghCategory)
		Me.Sections.Add(Me.ghProduct)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.gfProduct)
		Me.Sections.Add(Me.gfCategory)
		Me.Sections.Add(Me.PageFooter)
		Me.Sections.Add(Me.ReportFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	   
	End Sub
Private WithEvents ReportHeader As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents ghCategory As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents ghProduct As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents gfProduct As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents gfCategory As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private WithEvents ReportFooter As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
Private Shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape
Private lblTitle1 As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblTitle2 As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblTitleLine As GrapeCity.ActiveReports.SectionReportModel.Line
Private lblReportDate As GrapeCity.ActiveReports.SectionReportModel.Label
Private imgLogoSm As GrapeCity.ActiveReports.SectionReportModel.Picture
Private lblNorthWind As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblTraders As GrapeCity.ActiveReports.SectionReportModel.Label
Private Shape2 As GrapeCity.ActiveReports.SectionReportModel.Shape
Private lblCategory As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblProduct As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblCurrentWeek As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblMTD As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblQTD As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblYTD As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblPrevQTD As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblWkUnits As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblWkSales As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblMTDUnits As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblMTDSales As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblQTDUnits As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblQTDSales As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblYTDUnits As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblYTDSales As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblPQTDSales As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblPQTDChange As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtCategoryName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtDetProduct As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtDetUnits As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtDetSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtDetOrderDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtProduct As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtWkUnits As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtWkSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtMTDUnits As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtMTDSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtQTDUnits As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtQTDSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtYTDUnits As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtYTDSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtPQTDSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtPQTDChange As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
Private Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
Private txtCatWkUnits As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCAtWkSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCatMTDUnits As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCatMTDSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCatQTDUnits As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCatQTDSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCatYTDUnits As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCatYTDSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCatPQTDSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCatPQTDChange As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
End Class
