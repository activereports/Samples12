 _
Partial Class CustomerLabels
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerLabels))
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
		CType(Me.lblNorthWind, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblTraders, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblAddr1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblAddr2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRegion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPostalCode, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'lblNorthWind
		'
		resources.ApplyResources(Me.lblNorthWind, "lblNorthWind")
		Me.lblNorthWind.Name = "lblNorthWind"
		'
		'lblTraders
		'
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
		Me.Detail.ColumnCount = 2
		Me.Detail.ColumnDirection = GrapeCity.ActiveReports.SectionReportModel.ColumnDirection.AcrossDown
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblNorthWind, Me.lblTraders, Me.lblAddr1, Me.lblAddr2, Me.linSep1, Me.txtName, Me.txtAddress, Me.txtCity, Me.txtRegion, Me.txtPostalCode, Me.txtCountry})
		Me.Detail.Height = 1.475!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'CustomerLabels
		'
		Me.MasterReport = False
		OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.MDB;Persist Security Info=False"
		OleDBDataSource1.SQL = "Select * from Customers"
		Me.DataSource = OleDBDataSource1
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Sections.Add(Me.Detail)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
			"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.lblNorthWind, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblTraders, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblAddr1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblAddr2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRegion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPostalCode, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
	Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
	Private lblNorthWind As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblTraders As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblAddr1 As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblAddr2 As GrapeCity.ActiveReports.SectionReportModel.Label
Private linSep1 As GrapeCity.ActiveReports.SectionReportModel.Line
Private txtName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtRegion As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtPostalCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
