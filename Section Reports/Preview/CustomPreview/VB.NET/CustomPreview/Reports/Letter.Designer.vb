 _
Partial Class Letter
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Letter))
		Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Me.txtOrderID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtOrderDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtSubtotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.imgLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
		Me.lblNorthwind = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTraders = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lneTitle = New GrapeCity.ActiveReports.SectionReportModel.Line()
		Me.lblNWAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtTotalOrders = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblOrderID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblOrderDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblAmount = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.rtbMain = New GrapeCity.ActiveReports.SectionReportModel.RichTextBox()
		Me.txtCompanyName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtContactName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtRegion = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtPostalCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblYours = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblNTAP = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		Me.ghCustomerID = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.gfCustomerID = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		CType(Me.txtOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSubtotal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblNorthwind, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblTraders, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblNWAddress, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTotalOrders, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblAmount, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtContactName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRegion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPostalCode, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblYours, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblNTAP, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'txtOrderID
		'
		Me.txtOrderID.DataField = "OrderID"
		resources.ApplyResources(Me.txtOrderID, "txtOrderID")
		Me.txtOrderID.Name = "txtOrderID"
		'
		'txtOrderDate
		'
		Me.txtOrderDate.DataField = "OrderDate"
		resources.ApplyResources(Me.txtOrderDate, "txtOrderDate")
		Me.txtOrderDate.Name = "txtOrderDate"
		'
		'txtSubtotal
		'
		Me.txtSubtotal.DataField = "Subtotal"
		resources.ApplyResources(Me.txtSubtotal, "txtSubtotal")
		Me.txtSubtotal.Name = "txtSubtotal"
		'
		'imgLogo
		'
		Me.imgLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		resources.ApplyResources(Me.imgLogo, "imgLogo")
		Me.imgLogo.ImageData = CType(resources.GetObject("imgLogo.ImageData"), System.IO.Stream)
		Me.imgLogo.LineColor = System.Drawing.Color.Black
		Me.imgLogo.LineWeight = 1.0!
		Me.imgLogo.Name = "imgLogo"
		Me.imgLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
		'
		'lblNorthwind
		'
		resources.ApplyResources(Me.lblNorthwind, "lblNorthwind")
		Me.lblNorthwind.Name = "lblNorthwind"
		'
		'lblTraders
		'
		resources.ApplyResources(Me.lblTraders, "lblTraders")
		Me.lblTraders.Name = "lblTraders"
		'
		'lneTitle
		'
		resources.ApplyResources(Me.lneTitle, "lneTitle")
		Me.lneTitle.LineWeight = 10.0!
		Me.lneTitle.Name = "lneTitle"
		Me.lneTitle.X1 = 5.1!
		Me.lneTitle.X2 = 6.375!
		Me.lneTitle.Y1 = 0.4375!
		Me.lneTitle.Y2 = 0.4375!
		'
		'lblNWAddress
		'
		resources.ApplyResources(Me.lblNWAddress, "lblNWAddress")
		Me.lblNWAddress.Name = "lblNWAddress"
		'
		'txtTotalOrders
		'
		Me.txtTotalOrders.DataField = "Subtotal"
		resources.ApplyResources(Me.txtTotalOrders, "txtTotalOrders")
		Me.txtTotalOrders.Name = "txtTotalOrders"
		Me.txtTotalOrders.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
		Me.txtTotalOrders.Visible = False
		'
		'lblOrderID
		'
		resources.ApplyResources(Me.lblOrderID, "lblOrderID")
		Me.lblOrderID.Name = "lblOrderID"
		'
		'lblOrderDate
		'
		resources.ApplyResources(Me.lblOrderDate, "lblOrderDate")
		Me.lblOrderDate.Name = "lblOrderDate"
		'
		'lblAmount
		'
		resources.ApplyResources(Me.lblAmount, "lblAmount")
		Me.lblAmount.Name = "lblAmount"
		'
		'rtbMain
		'
		Me.rtbMain.AutoReplaceFields = True
		Me.rtbMain.Font = New System.Drawing.Font("Arial", 10.0!)
		resources.ApplyResources(Me.rtbMain, "rtbMain")
		Me.rtbMain.Name = "rtbMain"
		'
		'txtCompanyName
		'
		Me.txtCompanyName.CanGrow = False
		Me.txtCompanyName.DataField = "CompanyName"
		resources.ApplyResources(Me.txtCompanyName, "txtCompanyName")
		Me.txtCompanyName.Name = "txtCompanyName"
		Me.txtCompanyName.Visible = False
		'
		'txtContactName
		'
		Me.txtContactName.CanGrow = False
		Me.txtContactName.DataField = "ContactName"
		resources.ApplyResources(Me.txtContactName, "txtContactName")
		Me.txtContactName.Name = "txtContactName"
		Me.txtContactName.Visible = False
		'
		'txtAddress
		'
		Me.txtAddress.CanGrow = False
		Me.txtAddress.DataField = "Address"
		resources.ApplyResources(Me.txtAddress, "txtAddress")
		Me.txtAddress.Name = "txtAddress"
		Me.txtAddress.Visible = False
		'
		'txtCity
		'
		Me.txtCity.CanGrow = False
		Me.txtCity.DataField = "City"
		resources.ApplyResources(Me.txtCity, "txtCity")
		Me.txtCity.Name = "txtCity"
		Me.txtCity.Visible = False
		'
		'txtRegion
		'
		Me.txtRegion.CanGrow = False
		Me.txtRegion.DataField = "Region"
		resources.ApplyResources(Me.txtRegion, "txtRegion")
		Me.txtRegion.Name = "txtRegion"
		Me.txtRegion.Visible = False
		'
		'txtCountry
		'
		Me.txtCountry.CanGrow = False
		Me.txtCountry.DataField = "Country"
		resources.ApplyResources(Me.txtCountry, "txtCountry")
		Me.txtCountry.Name = "txtCountry"
		Me.txtCountry.Visible = False
		'
		'txtPostalCode
		'
		Me.txtPostalCode.CanGrow = False
		Me.txtPostalCode.DataField = "PostalCode"
		resources.ApplyResources(Me.txtPostalCode, "txtPostalCode")
		Me.txtPostalCode.Name = "txtPostalCode"
		Me.txtPostalCode.Visible = False
		'
		'lblYours
		'
		resources.ApplyResources(Me.lblYours, "lblYours")
		Me.lblYours.Name = "lblYours"
		'
		'lblNTAP
		'
		resources.ApplyResources(Me.lblNTAP, "lblNTAP")
		Me.lblNTAP.Name = "lblNTAP"
		'
		'Detail
		'
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtOrderID, Me.txtOrderDate, Me.txtSubtotal})
		Me.Detail.Height = 0.2!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.CanGrow = False
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.imgLogo, Me.lblNorthwind, Me.lblTraders, Me.lneTitle})
		Me.PageHeader.Height = 0.9375!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.CanGrow = False
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblNWAddress})
		Me.PageFooter.Name = "PageFooter"
		'
		'ghCustomerID
		'
		Me.ghCustomerID.CanShrink = True
		Me.ghCustomerID.ColumnLayout = False
		Me.ghCustomerID.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtTotalOrders, Me.lblOrderID, Me.lblOrderDate, Me.lblAmount, Me.rtbMain, Me.txtCompanyName, Me.txtContactName, Me.txtAddress, Me.txtCity, Me.txtRegion, Me.txtCountry, Me.txtPostalCode})
		Me.ghCustomerID.DataField = "CustomerID"
		Me.ghCustomerID.Height = 2.510417!
		Me.ghCustomerID.KeepTogether = True
		Me.ghCustomerID.Name = "ghCustomerID"
		'
		'gfCustomerID
		'
		Me.gfCustomerID.ColumnLayout = False
		Me.gfCustomerID.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblYours, Me.lblNTAP})
		Me.gfCustomerID.Height = 0.7381945!
		Me.gfCustomerID.KeepTogether = True
		Me.gfCustomerID.Name = "gfCustomerID"
		Me.gfCustomerID.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After
		'
		'Letter
		'
		Me.MasterReport = False
		OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.MDB;Persist Security Info=False"
		OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
		Me.DataSource = OleDBDataSource1
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.ghCustomerID)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.gfCustomerID)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
			"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.txtOrderID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSubtotal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblNorthwind, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblTraders, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblNWAddress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTotalOrders, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblOrderID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblAmount, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCompanyName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtContactName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRegion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPostalCode, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblYours, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblNTAP, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents ghCustomerID As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents gfCustomerID As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private imgLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
Private lblNorthwind As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblTraders As GrapeCity.ActiveReports.SectionReportModel.Label
Private lneTitle As GrapeCity.ActiveReports.SectionReportModel.Line
Private txtTotalOrders As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblOrderID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblOrderDate As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblAmount As GrapeCity.ActiveReports.SectionReportModel.Label
Private rtbMain As GrapeCity.ActiveReports.SectionReportModel.RichTextBox
Private txtCompanyName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtContactName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtRegion As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtPostalCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtOrderID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtOrderDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtSubtotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblYours As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblNTAP As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblNWAddress As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
