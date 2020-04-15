 _
Partial Class rptHierarchicalMain
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptHierarchicalMain))
		Me.txtCustomerID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCompanyName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Subreport1 = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.Shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
		Me.ReportInfo1 = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.textBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		CType(Me.txtCustomerID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.textBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'txtCustomerID
		'
		Me.txtCustomerID.DataField = "CustomerID"
		resources.ApplyResources(Me.txtCustomerID, "txtCustomerID")
		Me.txtCustomerID.Name = "txtCustomerID"
		'
		'txtCompanyName
		'
		Me.txtCompanyName.DataField = "CompanyName"
		resources.ApplyResources(Me.txtCompanyName, "txtCompanyName")
		Me.txtCompanyName.Name = "txtCompanyName"
		'
		'txtAddress
		'
		Me.txtAddress.DataField = "Address"
		resources.ApplyResources(Me.txtAddress, "txtAddress")
		Me.txtAddress.Name = "txtAddress"
		'
		'Subreport1
		'
		Me.Subreport1.CloseBorder = False
		Me.Subreport1.DataField = "CustomerOrders"
		resources.ApplyResources(Me.Subreport1, "Subreport1")
		Me.Subreport1.Name = "Subreport1"
		Me.Subreport1.Report = Nothing
		'
		'Shape1
		'
		resources.ApplyResources(Me.Shape1, "Shape1")
		Me.Shape1.Name = "Shape1"
		Me.Shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.99!, Nothing, Nothing, Nothing, Nothing)
		'
		'ReportInfo1
		'
		Me.ReportInfo1.FormatString = Nothing
		resources.ApplyResources(Me.ReportInfo1, "ReportInfo1")
		Me.ReportInfo1.Name = "ReportInfo1"
		'
		'textBox1
		'
		resources.ApplyResources(Me.textBox1, "textBox1")
		Me.textBox1.Name = "textBox1"
		'
		'Detail
		'
		Me.Detail.CanShrink = True
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCustomerID, Me.txtCompanyName, Me.txtAddress, Me.Subreport1, Me.Shape1})
		Me.Detail.Height = 1.167!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.textBox1})
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.CanShrink = True
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ReportInfo1})
		Me.PageFooter.Height = 0.2083333!
		Me.PageFooter.Name = "PageFooter"
		'
		'rptHierarchicalMain
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.043001!
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
		CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.textBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private txtCustomerID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCompanyName As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Private txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
 Private WithEvents Shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape
 Private WithEvents ReportInfo1 As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
Private WithEvents textBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private Subreport1 As GrapeCity.ActiveReports.SectionReportModel.SubReport
End Class
