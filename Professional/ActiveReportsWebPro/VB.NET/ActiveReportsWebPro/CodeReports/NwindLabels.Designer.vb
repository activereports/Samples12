Namespace CodeReports
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
	Partial Public Class NwindLabels
		Inherits GrapeCity.ActiveReports.SectionReport
		'Form overrides dispose to clean up the component list.
		Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
			End If
			MyBase.Dispose(disposing)
		End Sub
		'NOTE: The following procedure is required by the ActiveReports Designer
		'It can be modified using the ActiveReports Designer.
		'Do not modify it using the code editor.
		<System.Diagnostics.DebuggerStepThrough()> _
		Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NwindLabels))
			Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
			Me.lblNorthWind = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblTraders = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblAddr1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.lblAddr2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
			Me.linSep1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
			Me.txtName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtRegion = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtPostalCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
			Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
			Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
			Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
			'
			'lblNorthWind
			'
			resources.ApplyResources(Me.lblNorthWind, "lblNorthWind")
			Me.lblNorthWind.Name = "lblNorthWind"
			'
			'lblTraders
			'
			Me.lblTraders.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
			Me.lblTraders.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.ThickSolid
			resources.ApplyResources(Me.lblTraders, "lblTraders")
			Me.lblTraders.Name = "lblTraders"
			'
			'lblAddr1
			'
			resources.ApplyResources(Me.lblAddr1, "lblAddr1")
			Me.lblAddr1.Name = "lblAddr1"
			'
			'lblAddr2
			'
			resources.ApplyResources(Me.lblAddr2, "lblAddr2")
			Me.lblAddr2.Name = "lblAddr2"
			'
			'linSep1
			'
			resources.ApplyResources(Me.linSep1, "linSep1")
			Me.linSep1.LineWeight = 2.0!
			Me.linSep1.Name = "linSep1"
			Me.linSep1.X1 = 0.0625!
			Me.linSep1.X2 = 3.1875!
			Me.linSep1.Y1 = 0.625!
			Me.linSep1.Y2 = 0.625!
			'
			'txtName
			'
			Me.txtName.CanGrow = False
			Me.txtName.DataField = "CompanyName"
			resources.ApplyResources(Me.txtName, "txtName")
			Me.txtName.Name = "txtName"
			'
			'txtAddress
			'
			Me.txtAddress.DataField = "Address"
			resources.ApplyResources(Me.txtAddress, "txtAddress")
			Me.txtAddress.Name = "txtAddress"
			'
			'txtCity
			'
			Me.txtCity.CanGrow = False
			Me.txtCity.DataField = "City"
			resources.ApplyResources(Me.txtCity, "txtCity")
			Me.txtCity.Name = "txtCity"
			'
			'txtRegion
			'
			Me.txtRegion.CanGrow = False
			Me.txtRegion.DataField = "Region"
			resources.ApplyResources(Me.txtRegion, "txtRegion")
			Me.txtRegion.Name = "txtRegion"
			'
			'txtPostalCode
			'
			Me.txtPostalCode.CanGrow = False
			Me.txtPostalCode.DataField = "PostalCode"
			resources.ApplyResources(Me.txtPostalCode, "txtPostalCode")
			Me.txtPostalCode.Name = "txtPostalCode"
			'
			'txtCountry
			'
			Me.txtCountry.CanGrow = False
			Me.txtCountry.DataField = "Country"
			resources.ApplyResources(Me.txtCountry, "txtCountry")
			Me.txtCountry.Name = "txtCountry"
			'
			'Detail
			'
			Me.Detail.CanGrow = False
			Me.Detail.ColumnCount = 2
			Me.Detail.ColumnDirection = GrapeCity.ActiveReports.SectionReportModel.ColumnDirection.AcrossDown
			Me.Detail.ColumnSpacing = 0.0!
			Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblNorthWind, Me.lblTraders, Me.lblAddr1, Me.lblAddr2, Me.linSep1, Me.txtName, Me.txtAddress, Me.txtCity, Me.txtRegion, Me.txtPostalCode, Me.txtCountry})
			Me.Detail.Height = 1.487!
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			'
			'PageHeader
			'
			Me.PageHeader.CanGrow = False
			Me.PageHeader.Height = 0.0!
			Me.PageHeader.Name = "PageHeader"
			'
			'PageFooter
			'
			Me.PageFooter.CanGrow = False
			Me.PageFooter.Height = 0.25!
			Me.PageFooter.Name = "PageFooter"
			'
			'NwindLabels
			'
			Me.MasterReport = False
			OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\Nwind.mdb;Persist Security Info=False"
			OleDBDataSource1.SQL = "Select * from customers"
			Me.DataSource = OleDBDataSource1
			Me.PageSettings.PaperHeight = 11.0!
			Me.PageSettings.PaperWidth = 8.5!
			Me.PrintWidth = 6.5!
			Me.Sections.Add(Me.PageHeader)
			Me.Sections.Add(Me.Detail)
			Me.Sections.Add(Me.PageFooter)
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 186", "Heading1", "Normal"))
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
						"lic; ddo-char-set: 186", "Heading2", "Normal"))
			Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 186", "Heading3", "Normal"))
		End Sub
		Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
		Private WithEvents lblNorthWind As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblTraders As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblAddr1 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents lblAddr2 As GrapeCity.ActiveReports.SectionReportModel.Label
		Private WithEvents linSep1 As GrapeCity.ActiveReports.SectionReportModel.Line
		Private WithEvents txtName As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtRegion As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtPostalCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
		Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
		Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
	End Class
End Namespace
