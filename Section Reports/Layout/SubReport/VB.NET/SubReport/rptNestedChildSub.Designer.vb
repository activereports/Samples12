 _
Partial Class rptNestedChildSub
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptNestedChildSub))
		Me.lblCompanyName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblContactName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblPhone = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtCompanyName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtContactName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtPhone = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
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
		'lblPhone
		'
		resources.ApplyResources(Me.lblPhone, "lblPhone")
		Me.lblPhone.Name = "lblPhone"
		'
		'txtCompanyName
		'
		resources.ApplyResources(Me.txtCompanyName, "txtCompanyName")
		Me.txtCompanyName.DataField = "CompanyName"
		Me.txtCompanyName.Name = "txtCompanyName"
		'
		'txtContactName
		'
		resources.ApplyResources(Me.txtContactName, "txtContactName")
		Me.txtContactName.DataField = "ContactName"
		Me.txtContactName.Name = "txtContactName"
		'
		'txtPhone
		'
		resources.ApplyResources(Me.txtPhone, "txtPhone")
		Me.txtPhone.DataField = "Phone"
		Me.txtPhone.Name = "txtPhone"
		'
		'Detail
		'
		Me.Detail.BackColor = System.Drawing.Color.LightSteelBlue
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblCompanyName, Me.lblContactName, Me.lblPhone, Me.txtCompanyName, Me.txtContactName, Me.txtPhone})
		Me.Detail.Height = 0.5!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'rptNestedChildSub
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Sections.Add(Me.Detail)
		Me.ShowParameterUI = False
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private lblCompanyName As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblContactName As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblPhone As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtCompanyName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtContactName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtPhone As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
