 _
Partial Class rptNestedParent
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptNestedParent))
		Me.subOrders = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.lblEmployeeID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblExtension = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblLastName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblFirstName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtEmployeeID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtExtension = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtLastName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtFirstName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.textBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.ReportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		Me.ghEmployees = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		'
		'subOrders
		'
		Me.subOrders.CloseBorder = False
		resources.ApplyResources(Me.subOrders, "subOrders")
		Me.subOrders.Name = "subOrders"
		Me.subOrders.Report = Nothing
		'
		'lblEmployeeID
		'
		resources.ApplyResources(Me.lblEmployeeID, "lblEmployeeID")
		Me.lblEmployeeID.Name = "lblEmployeeID"
		'
		'lblExtension
		'
		resources.ApplyResources(Me.lblExtension, "lblExtension")
		Me.lblExtension.Name = "lblExtension"
		'
		'lblLastName
		'
		resources.ApplyResources(Me.lblLastName, "lblLastName")
		Me.lblLastName.Name = "lblLastName"
		'
		'lblFirstName
		'
		resources.ApplyResources(Me.lblFirstName, "lblFirstName")
		Me.lblFirstName.Name = "lblFirstName"
		'
		'txtEmployeeID
		'
		resources.ApplyResources(Me.txtEmployeeID, "txtEmployeeID")
		Me.txtEmployeeID.DataField = "EmployeeID"
		Me.txtEmployeeID.Name = "txtEmployeeID"
		'
		'txtExtension
		'
		resources.ApplyResources(Me.txtExtension, "txtExtension")
		Me.txtExtension.DataField = "Extension"
		Me.txtExtension.Name = "txtExtension"
		'
		'txtLastName
		'
		resources.ApplyResources(Me.txtLastName, "txtLastName")
		Me.txtLastName.DataField = "LastName"
		Me.txtLastName.Name = "txtLastName"
		'
		'txtFirstName
		'
		resources.ApplyResources(Me.txtFirstName, "txtFirstName")
		Me.txtFirstName.DataField = "FirstName"
		Me.txtFirstName.Name = "txtFirstName"
		'
		'textBox1
		'
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
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.subOrders})
		Me.Detail.Height = 0.75!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.textBox1})
		Me.PageHeader.Height = 0.25!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ReportInfo1})
		Me.PageFooter.Height = 0.25!
		Me.PageFooter.Name = "PageFooter"
		'
		'ghEmployees
		'
		Me.ghEmployees.BackColor = System.Drawing.Color.AntiqueWhite
		Me.ghEmployees.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblEmployeeID, Me.lblExtension, Me.lblLastName, Me.lblFirstName, Me.txtEmployeeID, Me.txtExtension, Me.txtLastName, Me.txtFirstName})
		Me.ghEmployees.DataField = "EmployeeID"
		Me.ghEmployees.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
		Me.ghEmployees.Height = 0.5104167!
		Me.ghEmployees.KeepTogether = True
		Me.ghEmployees.Name = "ghEmployees"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.BackColor = System.Drawing.Color.Navy
		Me.GroupFooter1.Height = 0.25!
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'rptNestedParent
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.ghEmployees)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents ghEmployees As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private lblEmployeeID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblExtension As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblLastName As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblFirstName As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtEmployeeID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtExtension As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtLastName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtFirstName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents textBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents ReportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
Private subOrders As GrapeCity.ActiveReports.SectionReportModel.SubReport
End Class
