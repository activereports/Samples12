 _
Partial Class rptHierarchicalSub
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptHierarchicalSub))
		Me.txtOrderDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtOrderID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtFreight = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblOrderDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblOrderID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblFreight = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.ghOrders = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		CType(Me.txtOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtFreight, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblOrderID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblFreight, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'txtOrderDate
		'
		Me.txtOrderDate.CanShrink = True
		Me.txtOrderDate.DataField = "OrderDate"
		resources.ApplyResources(Me.txtOrderDate, "txtOrderDate")
		Me.txtOrderDate.Name = "txtOrderDate"
		'
		'txtOrderID
		'
		Me.txtOrderID.CanShrink = True
		Me.txtOrderID.DataField = "OrderID"
		resources.ApplyResources(Me.txtOrderID, "txtOrderID")
		Me.txtOrderID.Name = "txtOrderID"
		'
		'txtFreight
		'
		Me.txtFreight.CanShrink = True
		Me.txtFreight.DataField = "Freight"
		resources.ApplyResources(Me.txtFreight, "txtFreight")
		Me.txtFreight.Name = "txtFreight"
		'
		'lblOrderDate
		'
		resources.ApplyResources(Me.lblOrderDate, "lblOrderDate")
		Me.lblOrderDate.Name = "lblOrderDate"
		'
		'lblOrderID
		'
		resources.ApplyResources(Me.lblOrderID, "lblOrderID")
		Me.lblOrderID.Name = "lblOrderID"
		'
		'lblFreight
		'
		resources.ApplyResources(Me.lblFreight, "lblFreight")
		Me.lblFreight.Name = "lblFreight"
		'
		'Detail
		'
		Me.Detail.CanShrink = True
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtOrderDate, Me.txtOrderID, Me.txtFreight})
		Me.Detail.Height = 0.3020833!
		Me.Detail.Name = "Detail"
		'
		'ghOrders
		'
		Me.ghOrders.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblOrderDate, Me.lblOrderID, Me.lblFreight})
		Me.ghOrders.DataField = "CustomerID"
		Me.ghOrders.Height = 0.3020833!
		Me.ghOrders.Name = "ghOrders"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'rptHierarchicalSub
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Script = resources.GetString("$this.Script")
		Me.Sections.Add(Me.ghOrders)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
					"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.txtOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtOrderID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtFreight, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblOrderID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblFreight, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents ghOrders As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private lblOrderDate As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblOrderID As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblFreight As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtOrderDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtOrderID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtFreight As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
