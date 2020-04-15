 _
Partial Class rptUnboundDSSub
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptUnboundDSSub))
		Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		'
		'TextBox1
		'
		resources.ApplyResources(Me.TextBox1, "TextBox1")
		Me.TextBox1.DataField = "OrderID"
		Me.TextBox1.Name = "TextBox1"
		'
		'TextBox2
		'
		resources.ApplyResources(Me.TextBox2, "TextBox2")
		Me.TextBox2.DataField = "OrderDate"
		Me.TextBox2.Name = "TextBox2"
		'
		'TextBox3
		'
		resources.ApplyResources(Me.TextBox3, "TextBox3")
		Me.TextBox3.DataField = "ShippedDate"
		Me.TextBox3.Name = "TextBox3"
		'
		'TextBox4
		'
		resources.ApplyResources(Me.TextBox4, "TextBox4")
		Me.TextBox4.DataField = "ShipVia"
		Me.TextBox4.Name = "TextBox4"
		'
		'TextBox5
		'
		resources.ApplyResources(Me.TextBox5, "TextBox5")
		Me.TextBox5.DataField = "Freight"
		Me.TextBox5.Name = "TextBox5"
		'
		'Label1
		'
		resources.ApplyResources(Me.Label1, "Label1")
		Me.Label1.Name = "Label1"
		'
		'Label2
		'
		resources.ApplyResources(Me.Label2, "Label2")
		Me.Label2.Name = "Label2"
		'
		'Label3
		'
		resources.ApplyResources(Me.Label3, "Label3")
		Me.Label3.Name = "Label3"
		'
		'Label4
		'
		resources.ApplyResources(Me.Label4, "Label4")
		Me.Label4.Name = "Label4"
		'
		'Label5
		'
		resources.ApplyResources(Me.Label5, "Label5")
		Me.Label5.Name = "Label5"
		'
		'Detail
		'
		Me.Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5})
		Me.Detail.Height = 0.3326389!
		Me.Detail.Name = "Detail"
		'
		'GroupHeader1
		'
		Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label5})
		Me.GroupHeader1.Height = 0.25!
		Me.GroupHeader1.Name = "GroupHeader1"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Height = 0.25!
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'rptUnboundDSSub
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 5.875!
		Me.Sections.Add(Me.GroupHeader1)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Friend WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Friend WithEvents TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
End Class
