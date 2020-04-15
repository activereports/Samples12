 _
Partial Class CustomersOrders
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomersOrders))
		Dim XmlDataSource1 As GrapeCity.ActiveReports.Data.XMLDataSource = New GrapeCity.ActiveReports.Data.XMLDataSource()
		Me.txtName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblEMail = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtEMail = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.srptOrders = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.lblOrders = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		'
		'txtName
		'
		Me.txtName.DataField = "NAME"
		resources.ApplyResources(Me.txtName, "txtName")
		Me.txtName.Name = "txtName"
		'
		'txtID
		'
		Me.txtID.DataField = "@id"
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
		Me.txtEMail.DataField = "@email"
		resources.ApplyResources(Me.txtEMail, "txtEMail")
		Me.txtEMail.Name = "txtEMail"
		'
		'lblName
		'
		resources.ApplyResources(Me.lblName, "lblName")
		Me.lblName.Name = "lblName"
		'
		'srptOrders
		'
		Me.srptOrders.CloseBorder = False
		Me.srptOrders.DataField = "ORDER"
		resources.ApplyResources(Me.srptOrders, "srptOrders")
		Me.srptOrders.Name = "srptOrders"
		Me.srptOrders.Report = Nothing
		'
		'lblOrders
		'
		resources.ApplyResources(Me.lblOrders, "lblOrders")
		Me.lblOrders.Name = "lblOrders"
		'
		'Detail
		'
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtName, Me.txtID, Me.lblID, Me.lblEMail, Me.txtEMail, Me.lblName, Me.srptOrders, Me.lblOrders})
		Me.Detail.Height = 0.8125!
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
		'CustomersOrders
		'
		Me.MasterReport = False
		XmlDataSource1.FileURL = "C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\customer.xml"
		XmlDataSource1.RecordsetPattern = "//CUSTOMER"
		Me.DataSource = XmlDataSource1
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private txtName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblEMail As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtEMail As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblName As GrapeCity.ActiveReports.SectionReportModel.Label
Private srptOrders As GrapeCity.ActiveReports.SectionReportModel.SubReport
Private lblOrders As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
