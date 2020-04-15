 _
Partial Class DrillThrough1
	Inherits GrapeCity.ActiveReports.SectionReport
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DrillThrough1))
		Me.txtCustomerID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtOrderID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtEmployeeID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtOrderDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtShippedDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblCustomerID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblOrderID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblEmployeeID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblOrderDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblShippedDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.CrossSectionBox1 = New GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		'
		'txtCustomerID
		'
		Me.txtCustomerID.DataField = "CustomerID"
		resources.ApplyResources(Me.txtCustomerID, "txtCustomerID")
		Me.txtCustomerID.Name = "txtCustomerID"
		'
		'txtOrderID
		'
		Me.txtOrderID.DataField = "OrderID"
		resources.ApplyResources(Me.txtOrderID, "txtOrderID")
		Me.txtOrderID.Name = "txtOrderID"
		'
		'txtEmployeeID
		'
		Me.txtEmployeeID.DataField = "EmployeeID"
		resources.ApplyResources(Me.txtEmployeeID, "txtEmployeeID")
		Me.txtEmployeeID.Name = "txtEmployeeID"
		'
		'txtOrderDate
		'
		Me.txtOrderDate.DataField = "OrderDate"
		resources.ApplyResources(Me.txtOrderDate, "txtOrderDate")
		Me.txtOrderDate.Name = "txtOrderDate"
		'
		'txtShippedDate
		'
		Me.txtShippedDate.DataField = "ShippedDate"
		resources.ApplyResources(Me.txtShippedDate, "txtShippedDate")
		Me.txtShippedDate.Name = "txtShippedDate"
		'
		'lblCustomerID
		'
		resources.ApplyResources(Me.lblCustomerID, "lblCustomerID")
		Me.lblCustomerID.Name = "lblCustomerID"
		'
		'lblOrderID
		'
		resources.ApplyResources(Me.lblOrderID, "lblOrderID")
		Me.lblOrderID.Name = "lblOrderID"
		'
		'lblEmployeeID
		'
		resources.ApplyResources(Me.lblEmployeeID, "lblEmployeeID")
		Me.lblEmployeeID.Name = "lblEmployeeID"
		'
		'lblOrderDate
		'
		resources.ApplyResources(Me.lblOrderDate, "lblOrderDate")
		Me.lblOrderDate.Name = "lblOrderDate"
		'
		'lblShippedDate
		'
		resources.ApplyResources(Me.lblShippedDate, "lblShippedDate")
		Me.lblShippedDate.Name = "lblShippedDate"
		'
		'CrossSectionBox1
		'
		Me.CrossSectionBox1.Bottom = 0.0!
		resources.ApplyResources(Me.CrossSectionBox1, "CrossSectionBox1")
		Me.CrossSectionBox1.LineColor = System.Drawing.Color.Purple
		Me.CrossSectionBox1.LineWeight = 3.0!
		Me.CrossSectionBox1.Name = "CrossSectionBox1"
		Me.CrossSectionBox1.Right = 6.5!
		'
		'Detail
		'
		Me.Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(143, Byte), Integer))
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCustomerID, Me.txtOrderID, Me.txtEmployeeID, Me.txtOrderDate, Me.txtShippedDate})
		Me.Detail.Height = 0.2!
		Me.Detail.Name = "Detail"
		'
		'GroupHeader1
		'
		Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblCustomerID, Me.lblOrderID, Me.lblEmployeeID, Me.lblOrderDate, Me.lblShippedDate, Me.CrossSectionBox1})
		Me.GroupHeader1.Height = 0.25!
		Me.GroupHeader1.Name = "GroupHeader1"
		Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Height = 0.01!
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'DrillThrough1
		'
		Me.MasterReport = False
		Me.PageSettings.DefaultPaperSize = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Sections.Add(Me.GroupHeader1)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.ShowParameterUI = False
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		CType(Me.txtCustomerID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtOrderID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtEmployeeID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtShippedDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblCustomerID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblOrderID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblEmployeeID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblShippedDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private lblCustomerID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblOrderID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblEmployeeID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblOrderDate As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblShippedDate As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtCustomerID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtOrderID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtEmployeeID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtOrderDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents CrossSectionBox1 As GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox
Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private txtShippedDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
