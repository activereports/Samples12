 _
Partial Class rptNestedChildMain
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptNestedChildMain))
		Me.lblProductID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblQuantity = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtProductID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtQuantity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.subCustomers = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		Me.GroupHeader2 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter2 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		'
		'lblProductID
		'
		resources.ApplyResources(Me.lblProductID, "lblProductID")
		Me.lblProductID.Name = "lblProductID"
		'
		'lblQuantity
		'
		resources.ApplyResources(Me.lblQuantity, "lblQuantity")
		Me.lblQuantity.Name = "lblQuantity"
		'
		'txtProductID
		'
		resources.ApplyResources(Me.txtProductID, "txtProductID")
		Me.txtProductID.DataField = "ProductID"
		Me.txtProductID.Name = "txtProductID"
		'
		'txtQuantity
		'
		resources.ApplyResources(Me.txtQuantity, "txtQuantity")
		Me.txtQuantity.DataField = "Quantity"
		Me.txtQuantity.Name = "txtQuantity"
		'
		'subCustomers
		'
		Me.subCustomers.CloseBorder = False
		resources.ApplyResources(Me.subCustomers, "subCustomers")
		Me.subCustomers.Name = "subCustomers"
		Me.subCustomers.Report = Nothing
		'
		'Label1
		'
		resources.ApplyResources(Me.Label1, "Label1")
		Me.Label1.Name = "Label1"
		'
		'TextBox1
		'
		resources.ApplyResources(Me.TextBox1, "TextBox1")
		Me.TextBox1.DataField = "orders.OrderID"
		Me.TextBox1.Name = "TextBox1"
		'
		'Label2
		'
		resources.ApplyResources(Me.Label2, "Label2")
		Me.Label2.Name = "Label2"
		'
		'TextBox2
		'
		resources.ApplyResources(Me.TextBox2, "TextBox2")
		Me.TextBox2.DataField = "OrderDate"
		Me.TextBox2.Name = "TextBox2"
		'
		'Detail
		'
		Me.Detail.BackColor = System.Drawing.Color.LightCyan
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProductID, Me.txtQuantity})
		Me.Detail.Height = 0.2395834!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'GroupHeader1
		'
		Me.GroupHeader1.BackColor = System.Drawing.Color.LightGray
		Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.TextBox1, Me.Label2, Me.TextBox2})
		Me.GroupHeader1.DataField = "orders.OrderID"
		Me.GroupHeader1.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
		Me.GroupHeader1.Height = 0.25!
		Me.GroupHeader1.Name = "GroupHeader1"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Height = 0.25!
		Me.GroupFooter1.Name = "GroupFooter1"
		Me.GroupFooter1.Visible = False
		'
		'GroupHeader2
		'
		Me.GroupHeader2.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.subCustomers, Me.lblProductID, Me.lblQuantity})
		Me.GroupHeader2.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
		Me.GroupHeader2.Height = 0.896!
		Me.GroupHeader2.Name = "GroupHeader2"
		'
		'GroupFooter2
		'
		Me.GroupFooter2.Height = 0.25!
		Me.GroupFooter2.Name = "GroupFooter2"
		Me.GroupFooter2.Visible = False
		'
		'rptNestedChildMain
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Script = resources.GetString("$this.Script")
		Me.Sections.Add(Me.GroupHeader1)
		Me.Sections.Add(Me.GroupHeader2)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter2)
		Me.Sections.Add(Me.GroupFooter1)
		Me.ShowParameterUI = False
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private lblProductID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblQuantity As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtProductID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtQuantity As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
Private WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
Private WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents GroupHeader2 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents GroupFooter2 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private subCustomers As GrapeCity.ActiveReports.SectionReportModel.SubReport
End Class
