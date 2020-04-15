 _
Partial Class ProductSalesByCategory
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductSalesByCategory))
		Me.txtCategory = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Category = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblSales = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
	  
		'
		'txtCategory
		'
		Me.txtCategory.CanGrow = False
		resources.ApplyResources(Me.txtCategory, "txtCategory")
		Me.txtCategory.DataField = "CategoryName"
		Me.txtCategory.Name = "txtCategory"
		'
		'txtSales
		'
		Me.txtSales.CanGrow = False
		resources.ApplyResources(Me.txtSales, "txtSales")
		Me.txtSales.DataField = "ProductSales"
		Me.txtSales.Name = "txtSales"
		'
		'Category
		'
		resources.ApplyResources(Me.Category, "Category")
		Me.Category.Name = "Category"
		'
		'lblSales
		'
		resources.ApplyResources(Me.lblSales, "lblSales")
		Me.lblSales.Name = "lblSales"
		'
		'Detail
		'
		Me.Detail.CanGrow = False
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCategory, Me.txtSales})
		Me.Detail.Height = 0.1875!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'GroupHeader1
		'
		Me.GroupHeader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(92, Byte), Integer))
		Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Category, Me.lblSales})
		Me.GroupHeader1.Height = 0.1875!
		Me.GroupHeader1.Name = "GroupHeader1"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Height = 0.0!
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'ProductSalesByCategory
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 2.677083!
		Me.Sections.Add(Me.GroupHeader1)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private Category As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblSales As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtCategory As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
