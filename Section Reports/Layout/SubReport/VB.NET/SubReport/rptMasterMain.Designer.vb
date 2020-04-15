 _
Partial Class rptMasterMain
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptMasterMain))
		Me.txtOrderDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtShipName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtShippedDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtShipAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtShipCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtFreight = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.ctlSubreport = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.lblOrderDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblShipName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblShipDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblShipAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblShipCountry = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblFreight = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblWhiteLine = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.textBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.ReportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		CType(Me.txtOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShippedDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipAddress, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtShipCountry, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtFreight, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblShipName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblShipDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblShipAddress, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblShipCountry, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblFreight, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblWhiteLine, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.textBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'txtOrderDate
		'
		Me.txtOrderDate.CanShrink = True
		Me.txtOrderDate.DataField = "OrderDate"
		resources.ApplyResources(Me.txtOrderDate, "txtOrderDate")
		Me.txtOrderDate.Name = "txtOrderDate"
		'
		'txtShipName
		'
		Me.txtShipName.CanShrink = True
		Me.txtShipName.DataField = "ShipName"
		resources.ApplyResources(Me.txtShipName, "txtShipName")
		Me.txtShipName.Name = "txtShipName"
		'
		'txtShippedDate
		'
		Me.txtShippedDate.CanShrink = True
		Me.txtShippedDate.DataField = "ShippedDate"
		resources.ApplyResources(Me.txtShippedDate, "txtShippedDate")
		Me.txtShippedDate.Name = "txtShippedDate"
		'
		'txtShipAddress
		'
		Me.txtShipAddress.CanShrink = True
		Me.txtShipAddress.DataField = "ShipAddress"
		resources.ApplyResources(Me.txtShipAddress, "txtShipAddress")
		Me.txtShipAddress.Name = "txtShipAddress"
		'
		'txtShipCountry
		'
		Me.txtShipCountry.CanShrink = True
		Me.txtShipCountry.DataField = "ShipCountry"
		resources.ApplyResources(Me.txtShipCountry, "txtShipCountry")
		Me.txtShipCountry.Name = "txtShipCountry"
		'
		'txtFreight
		'
		Me.txtFreight.CanShrink = True
		Me.txtFreight.DataField = "Freight"
		resources.ApplyResources(Me.txtFreight, "txtFreight")
		Me.txtFreight.Name = "txtFreight"
		'
		'ctlSubreport
		'
		Me.ctlSubreport.CloseBorder = False
		resources.ApplyResources(Me.ctlSubreport, "ctlSubreport")
		Me.ctlSubreport.Name = "ctlSubreport"
		Me.ctlSubreport.Report = Nothing
		'
		'lblOrderDate
		'
		resources.ApplyResources(Me.lblOrderDate, "lblOrderDate")
		Me.lblOrderDate.Name = "lblOrderDate"
		'
		'lblShipName
		'
		resources.ApplyResources(Me.lblShipName, "lblShipName")
		Me.lblShipName.Name = "lblShipName"
		'
		'lblShipDate
		'
		resources.ApplyResources(Me.lblShipDate, "lblShipDate")
		Me.lblShipDate.Name = "lblShipDate"
		'
		'lblShipAddress
		'
		resources.ApplyResources(Me.lblShipAddress, "lblShipAddress")
		Me.lblShipAddress.Name = "lblShipAddress"
		'
		'lblShipCountry
		'
		resources.ApplyResources(Me.lblShipCountry, "lblShipCountry")
		Me.lblShipCountry.Name = "lblShipCountry"
		'
		'lblFreight
		'
		resources.ApplyResources(Me.lblFreight, "lblFreight")
		Me.lblFreight.Name = "lblFreight"
		'
		'lblWhiteLine
		'
		resources.ApplyResources(Me.lblWhiteLine, "lblWhiteLine")
		Me.lblWhiteLine.Name = "lblWhiteLine"
		'
		'textBox1
		'
		Me.textBox1.CanShrink = True
		resources.ApplyResources(Me.textBox1, "textBox1")
		Me.textBox1.Name = "textBox1"
		'
		'ReportInfo1
		'
		Me.ReportInfo1.FormatString = Nothing
		resources.ApplyResources(Me.ReportInfo1, "ReportInfo1")
		Me.ReportInfo1.Name = "ReportInfo1"
		'
		'Detail
		'
		Me.Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(143, Byte), Integer))
		Me.Detail.CanShrink = True
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtOrderDate, Me.txtShipName, Me.txtShippedDate, Me.txtShipAddress, Me.txtShipCountry, Me.txtFreight, Me.ctlSubreport, Me.lblOrderDate, Me.lblShipName, Me.lblShipDate, Me.lblShipAddress, Me.lblShipCountry, Me.lblFreight, Me.lblWhiteLine})
		Me.Detail.Height = 1.96!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.CanShrink = True
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.textBox1})
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.CanShrink = True
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ReportInfo1})
		Me.PageFooter.Name = "PageFooter"
		'
		'rptMasterMain
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
					"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.txtOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShippedDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipAddress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShipCountry, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtFreight, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShipName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShipDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShipAddress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShipCountry, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblFreight, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblWhiteLine, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.textBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private txtOrderDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtShipName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtShippedDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtShipAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtShipCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtFreight As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private ctlSubreport As GrapeCity.ActiveReports.SectionReportModel.SubReport
Private lblOrderDate As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblShipName As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblShipDate As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblShipAddress As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblShipCountry As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblFreight As GrapeCity.ActiveReports.SectionReportModel.Label
Private WithEvents textBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents ReportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
Private lblWhiteLine As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
