 _
Partial Class IlistReportSample
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IlistReportSample))
		Me.txtProductName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtUnitPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtUnitsInStock = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtUnitsOnOrder = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.cbDiscontinued = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
		Me.txtReorderLevel = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtProductId = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtQuantityPerUnit = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtComments = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.customDataLbl0 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.customDataLbl = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
		Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
		Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		CType(Me.txtProductName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUnitsInStock, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtUnitsOnOrder, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cbDiscontinued, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtReorderLevel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtProductId, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtQuantityPerUnit, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtComments, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.customDataLbl0, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.customDataLbl, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'txtProductName
		'
		Me.txtProductName.DataField = "ProductName"
		resources.ApplyResources(Me.txtProductName, "txtProductName")
		Me.txtProductName.Name = "txtProductName"
		'
		'txtUnitPrice
		'
		Me.txtUnitPrice.DataField = "UnitPrice"
		resources.ApplyResources(Me.txtUnitPrice, "txtUnitPrice")
		Me.txtUnitPrice.Name = "txtUnitPrice"
		'
		'txtUnitsInStock
		'
		Me.txtUnitsInStock.DataField = "UnitsInStock"
		resources.ApplyResources(Me.txtUnitsInStock, "txtUnitsInStock")
		Me.txtUnitsInStock.Name = "txtUnitsInStock"
		'
		'txtUnitsOnOrder
		'
		Me.txtUnitsOnOrder.DataField = "UnitsOnOrder"
		resources.ApplyResources(Me.txtUnitsOnOrder, "txtUnitsOnOrder")
		Me.txtUnitsOnOrder.Name = "txtUnitsOnOrder"
		'
		'cbDiscontinued
		'
		Me.cbDiscontinued.DataField = "Discontinued"
		resources.ApplyResources(Me.cbDiscontinued, "cbDiscontinued")
		Me.cbDiscontinued.Name = "cbDiscontinued"
		'
		'txtReorderLevel
		'
		Me.txtReorderLevel.DataField = "ReorderLevel"
		resources.ApplyResources(Me.txtReorderLevel, "txtReorderLevel")
		Me.txtReorderLevel.Name = "txtReorderLevel"
		'
		'txtProductId
		'
		Me.txtProductId.DataField = "ProductId"
		resources.ApplyResources(Me.txtProductId, "txtProductId")
		Me.txtProductId.Name = "txtProductId"
		'
		'txtQuantityPerUnit
		'
		Me.txtQuantityPerUnit.DataField = "QuantityPerUnit"
		resources.ApplyResources(Me.txtQuantityPerUnit, "txtQuantityPerUnit")
		Me.txtQuantityPerUnit.Name = "txtQuantityPerUnit"
		'
		'txtComments
		'
		resources.ApplyResources(Me.txtComments, "txtComments")
		Me.txtComments.Name = "txtComments"
		'
		'customDataLbl0
		'
		resources.ApplyResources(Me.customDataLbl0, "customDataLbl0")
		Me.customDataLbl0.Name = "customDataLbl0"
		'
		'customDataLbl
		'
		resources.ApplyResources(Me.customDataLbl, "customDataLbl")
		Me.customDataLbl.Name = "customDataLbl"
		'
		'Label2
		'
		Me.Label2.Angle = 900
		resources.ApplyResources(Me.Label2, "Label2")
		Me.Label2.Name = "Label2"
		'
		'Label3
		'
		Me.Label3.Angle = 900
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
		Me.Label5.Angle = 900
		resources.ApplyResources(Me.Label5, "Label5")
		Me.Label5.Name = "Label5"
		'
		'Label6
		'
		Me.Label6.Angle = 900
		resources.ApplyResources(Me.Label6, "Label6")
		Me.Label6.Name = "Label6"
		'
		'Label7
		'
		Me.Label7.Angle = 900
		resources.ApplyResources(Me.Label7, "Label7")
		Me.Label7.Name = "Label7"
		'
		'Label8
		'
		resources.ApplyResources(Me.Label8, "Label8")
		Me.Label8.Name = "Label8"
		'
		'Label9
		'
		resources.ApplyResources(Me.Label9, "Label9")
		Me.Label9.Name = "Label9"
		'
		'Detail
		'
		Me.Detail.CanShrink = True
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtProductName, Me.txtUnitPrice, Me.txtUnitsInStock, Me.txtUnitsOnOrder, Me.cbDiscontinued, Me.txtReorderLevel, Me.txtProductId, Me.txtQuantityPerUnit, Me.txtComments})
		Me.Detail.Height = 0.1875!
		Me.Detail.Name = "Detail"
		'
		'ReportHeader
		'
		Me.ReportHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.customDataLbl0})
		Me.ReportHeader.Height = 0.4375!
		Me.ReportHeader.Name = "ReportHeader"
		'
		'ReportFooter
		'
		Me.ReportFooter.Height = 0.0!
		Me.ReportFooter.Name = "ReportFooter"
		'
		'GroupHeader1
		'
		Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.customDataLbl, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Label9})
		Me.GroupHeader1.Height = 1.0625!
		Me.GroupHeader1.Name = "GroupHeader1"
		Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Height = 0.0!
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'IlistReportSample
		'
		Me.MasterReport = False
		Me.PageSettings.DefaultPaperSize = False
		Me.PageSettings.Margins.Bottom = 0.45!
		Me.PageSettings.Margins.Left = 0.2!
		Me.PageSettings.Margins.Right = 0.2!
		Me.PageSettings.Margins.Top = 0.5!
		Me.PageSettings.PaperHeight = 11.69291!
		Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
		Me.PageSettings.PaperWidth = 8.267716!
		Me.PrintWidth = 7.87!
		Me.Sections.Add(Me.ReportHeader)
		Me.Sections.Add(Me.GroupHeader1)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.Sections.Add(Me.ReportFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
			"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.txtProductName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUnitsInStock, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtUnitsOnOrder, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cbDiscontinued, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtReorderLevel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtProductId, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtQuantityPerUnit, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtComments, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.customDataLbl0, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.customDataLbl, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents ReportHeader As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents ReportFooter As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
Private customDataLbl0 As GrapeCity.ActiveReports.SectionReportModel.Label
Private customDataLbl As GrapeCity.ActiveReports.SectionReportModel.Label
Private Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
Private Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
Private Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
Private Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
Private Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
Private Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
Private Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
Private Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtProductName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtUnitPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtUnitsInStock As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtUnitsOnOrder As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private cbDiscontinued As GrapeCity.ActiveReports.SectionReportModel.CheckBox
Private txtReorderLevel As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtProductId As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtQuantityPerUnit As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtComments As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
