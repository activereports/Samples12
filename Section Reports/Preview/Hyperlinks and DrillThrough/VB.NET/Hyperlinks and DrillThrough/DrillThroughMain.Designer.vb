 _
Partial Class DrillThroughMain
	Inherits GrapeCity.ActiveReports.SectionReport
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DrillThroughMain))
		Me.txtCustomerID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCompanyName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtContactName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblCustomer = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblCompanyName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblContactName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.cscBorder = New GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		CType(Me.txtCustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtContactName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblCompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblContactName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'txtCustomerID
		'
		Me.txtCustomerID.DataField = "CustomerID"
		resources.ApplyResources(Me.txtCustomerID, "txtCustomerID")
		Me.txtCustomerID.Name = "txtCustomerID"
		Me.txtCustomerID.Padding = New GrapeCity.ActiveReports.PaddingEx(3, 0, 0, 0)
		'
		'txtCompanyName
		'
		Me.txtCompanyName.DataField = "CompanyName"
		resources.ApplyResources(Me.txtCompanyName, "txtCompanyName")
		Me.txtCompanyName.Name = "txtCompanyName"
		'
		'txtContactName
		'
		Me.txtContactName.DataField = "ContactName"
		resources.ApplyResources(Me.txtContactName, "txtContactName")
		Me.txtContactName.Name = "txtContactName"
		'
		'lblCustomer
		'
		resources.ApplyResources(Me.lblCustomer, "lblCustomer")
		Me.lblCustomer.Name = "lblCustomer"
		Me.lblCustomer.Padding = New GrapeCity.ActiveReports.PaddingEx(3, 0, 0, 0)
		'
		'lblCompanyName
		'
		resources.ApplyResources(Me.lblCompanyName, "lblCompanyName")
		Me.lblCompanyName.Name = "lblCompanyName"
		'
		'lblContactName
		'
		resources.ApplyResources(Me.lblContactName, "lblContactName")
		Me.lblContactName.Name = "lblContactName"
		'
		'cscBorder
		'
		Me.cscBorder.BackColor = System.Drawing.Color.Thistle
		Me.cscBorder.Bottom = 0.0!
		resources.ApplyResources(Me.cscBorder, "cscBorder")
		Me.cscBorder.LineColor = System.Drawing.Color.Purple
		Me.cscBorder.LineWeight = 3.0!
		Me.cscBorder.Name = "cscBorder"
		Me.cscBorder.Right = 6.5!
		'
		'Detail
		'
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCustomerID, Me.txtCompanyName, Me.txtContactName})
		Me.Detail.Height = 0.2388889!
		Me.Detail.Name = "Detail"
		Me.Detail.RepeatToFill = True
		'
		'PageHeader
		'
		Me.PageHeader.CanShrink = True
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblCustomer, Me.lblCompanyName, Me.lblContactName, Me.cscBorder})
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.Height = 0.0!
		Me.PageFooter.Name = "PageFooter"
		'
		'DrillThroughMain
		'
		Me.MasterReport = False
		Me.PageSettings.DefaultPaperSize = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
			"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.txtCustomerID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCompanyName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtContactName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblCustomer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblCompanyName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblContactName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private lblCustomer As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblCompanyName As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblContactName As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtCustomerID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCompanyName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents cscBorder As GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox
Private txtContactName As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
