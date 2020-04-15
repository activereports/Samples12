 _
Partial Class Orders
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
		Dim XmlDataSource1 As GrapeCity.ActiveReports.Data.XMLDataSource = New GrapeCity.ActiveReports.Data.XMLDataSource()
		Me.txtOrderNumber = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtOrderDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.srptItems = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
		Me.lblItems = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		'
		'txtOrderNumber
		'
		Me.txtOrderNumber.DataField = "NUMBER"
		resources.ApplyResources(Me.txtOrderNumber, "txtOrderNumber")
		Me.txtOrderNumber.Name = "txtOrderNumber"
		'
		'txtOrderDate
		'
		Me.txtOrderDate.DataField = "DATE"
		resources.ApplyResources(Me.txtOrderDate, "txtOrderDate")
		Me.txtOrderDate.Name = "txtOrderDate"
		'
		'srptItems
		'
		Me.srptItems.CloseBorder = False
		Me.srptItems.DataField = "ITEM"
		resources.ApplyResources(Me.srptItems, "srptItems")
		Me.srptItems.Name = "srptItems"
		Me.srptItems.Report = Nothing
		'
		'lblItems
		'
		resources.ApplyResources(Me.lblItems, "lblItems")
		Me.lblItems.Name = "lblItems"
		'
		'Detail
		'
		Me.Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtOrderNumber, Me.txtOrderDate, Me.srptItems, Me.lblItems})
		Me.Detail.Height = 0.4159722!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'Orders
		'
		Me.MasterReport = False
		XmlDataSource1.FileURL = "C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\customer.xml"
		XmlDataSource1.RecordsetPattern = "//ORDER"
		Me.DataSource = XmlDataSource1
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Sections.Add(Me.Detail)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private txtOrderNumber As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtOrderDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private srptItems As GrapeCity.ActiveReports.SectionReportModel.SubReport
Private lblItems As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
