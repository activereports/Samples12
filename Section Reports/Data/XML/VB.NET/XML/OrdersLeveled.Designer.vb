 _
Partial Class OrdersLeveled
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdersLeveled))
		Dim XmlDataSource1 As GrapeCity.ActiveReports.Data.XMLDataSource = New GrapeCity.ActiveReports.Data.XMLDataSource()
		Me.txtISBN = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtTitle = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtPRICE = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblEMail = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtEMail = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblCustomerTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtCustomerTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtOrderNumber = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtOrderDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblISBN = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lneSep = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lblPrice = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblOrderTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtOrderTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		Me.ghCustomers = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.gfCustomers = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		Me.ghOrders = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.gfOrders = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		'
		'txtISBN
		'
		Me.txtISBN.DataField = "@isbn"
		resources.ApplyResources(Me.txtISBN, "txtISBN")
		Me.txtISBN.Name = "txtISBN"
		'
		'txtTitle
		'
		Me.txtTitle.DataField = "TITLE"
		resources.ApplyResources(Me.txtTitle, "txtTitle")
		Me.txtTitle.Name = "txtTitle"
		'
		'txtPRICE
		'
		Me.txtPRICE.DataField = "PRICE"
		resources.ApplyResources(Me.txtPRICE, "txtPRICE")
		Me.txtPRICE.Name = "txtPRICE"
		'
		'txtName
		'
		Me.txtName.DataField = "../../NAME"
		resources.ApplyResources(Me.txtName, "txtName")
		Me.txtName.Name = "txtName"
		'
		'txtID
		'
		Me.txtID.DataField = "../../@id"
		resources.ApplyResources(Me.txtID, "txtID")
		Me.txtID.Name = "txtID"
		'
		'lblID
		'
		resources.ApplyResources(Me.lblID, "lblID")
		Me.lblID.Name = "lblID"
		'
		'lblEMail
		'
		resources.ApplyResources(Me.lblEMail, "lblEMail")
		Me.lblEMail.Name = "lblEMail"
		'
		'txtEMail
		'
		Me.txtEMail.DataField = "../../@email"
		resources.ApplyResources(Me.txtEMail, "txtEMail")
		Me.txtEMail.Name = "txtEMail"
		'
		'lblName
		'
		resources.ApplyResources(Me.lblName, "lblName")
		Me.lblName.Name = "lblName"
		'
		'lblCustomerTotal
		'
		resources.ApplyResources(Me.lblCustomerTotal, "lblCustomerTotal")
		Me.lblCustomerTotal.Name = "lblCustomerTotal"
		'
		'txtCustomerTotal
		'
		Me.txtCustomerTotal.DataField = "PRICE"
		resources.ApplyResources(Me.txtCustomerTotal, "txtCustomerTotal")
		Me.txtCustomerTotal.Name = "txtCustomerTotal"
		Me.txtCustomerTotal.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'txtOrderNumber
		'
		Me.txtOrderNumber.DataField = "../NUMBER"
		resources.ApplyResources(Me.txtOrderNumber, "txtOrderNumber")
		Me.txtOrderNumber.Name = "txtOrderNumber"
		'
		'txtOrderDate
		'
		Me.txtOrderDate.DataField = "../DATE"
		resources.ApplyResources(Me.txtOrderDate, "txtOrderDate")
		Me.txtOrderDate.Name = "txtOrderDate"
		'
		'lblISBN
		'
		resources.ApplyResources(Me.lblISBN, "lblISBN")
		Me.lblISBN.Name = "lblISBN"
		'
		'lblTitle
		'
		resources.ApplyResources(Me.lblTitle, "lblTitle")
		Me.lblTitle.Name = "lblTitle"
		'
		'lneSep
		'
		resources.ApplyResources(Me.lneSep, "lneSep")
		Me.lneSep.LineWeight = 1.0!
		Me.lneSep.Name = "lneSep"
		Me.lneSep.X1 = 0.0!
		Me.lneSep.X2 = 6.0625!
		Me.lneSep.Y1 = 0.437!
		Me.lneSep.Y2 = 0.437!
		'
		'lblPrice
		'
		resources.ApplyResources(Me.lblPrice, "lblPrice")
		Me.lblPrice.Name = "lblPrice"
		'
		'lblOrderTotal
		'
		resources.ApplyResources(Me.lblOrderTotal, "lblOrderTotal")
		Me.lblOrderTotal.Name = "lblOrderTotal"
		'
		'txtOrderTotal
		'
		Me.txtOrderTotal.DataField = "PRICE"
		resources.ApplyResources(Me.txtOrderTotal, "txtOrderTotal")
		Me.txtOrderTotal.Name = "txtOrderTotal"
		Me.txtOrderTotal.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		'
		'Detail
		'
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtISBN, Me.txtTitle, Me.txtPRICE})
		Me.Detail.Height = 0.1875!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.Height = 0.25!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.Height = 0.25!
		Me.PageFooter.Name = "PageFooter"
		'
		'ghCustomers
		'
		Me.ghCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.ghCustomers.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtName, Me.txtID, Me.lblID, Me.lblEMail, Me.txtEMail, Me.lblName})
		Me.ghCustomers.DataField = "../../@id"
		Me.ghCustomers.Height = 0.3958333!
		Me.ghCustomers.KeepTogether = True
		Me.ghCustomers.Name = "ghCustomers"
		'
		'gfCustomers
		'
		Me.gfCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.gfCustomers.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblCustomerTotal, Me.txtCustomerTotal})
		Me.gfCustomers.Height = 0.25!
		Me.gfCustomers.KeepTogether = True
		Me.gfCustomers.Name = "gfCustomers"
		Me.gfCustomers.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
		'
		'ghOrders
		'
		Me.ghOrders.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.ghOrders.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtOrderNumber, Me.txtOrderDate, Me.lblISBN, Me.lblTitle, Me.lblPrice, Me.lneSep})
		Me.ghOrders.DataField = "../NUMBER"
		Me.ghOrders.Height = 0.4784722!
		Me.ghOrders.KeepTogether = True
		Me.ghOrders.Name = "ghOrders"
		'
		'gfOrders
		'
		Me.gfOrders.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.gfOrders.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblOrderTotal, Me.txtOrderTotal})
		Me.gfOrders.Height = 0.1875!
		Me.gfOrders.KeepTogether = True
		Me.gfOrders.Name = "gfOrders"
		'
		'OrdersLeveled
		'
		Me.MasterReport = False
		XmlDataSource1.FileURL = "C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\customer.xml"
		XmlDataSource1.RecordsetPattern = "//ITEM"
		Me.DataSource = XmlDataSource1
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.ghCustomers)
		Me.Sections.Add(Me.ghOrders)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.gfOrders)
		Me.Sections.Add(Me.gfCustomers)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents ghCustomers As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents ghOrders As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents gfOrders As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents gfCustomers As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private txtName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblEMail As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtEMail As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblName As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtOrderNumber As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtOrderDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblISBN As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblTitle As GrapeCity.ActiveReports.SectionReportModel.Label
Private lneSep As GrapeCity.ActiveReports.SectionReportModel.Line
Private lblPrice As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtISBN As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtTitle As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtPRICE As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblOrderTotal As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtOrderTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblCustomerTotal As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtCustomerTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
