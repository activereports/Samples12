 _
Partial Class EmployeeProfiles
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeProfiles))
		Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Me.txtEmployeeID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtTitle = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtHireDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtAddress = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtRegion = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtPostalCode = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtCountry = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtHomePhone = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtExtension = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtNotes = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblTitle2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblAddress = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblCityRegion = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblPostalCode = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblCountry = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblExtension = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblHomePhone = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblHireDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblNotes = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblID = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblBirthDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtBirthDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtDescription = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.Picture1 = New GrapeCity.ActiveReports.SectionReportModel.Picture()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		CType(Me.txtEmployeeID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTitle, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtHireDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRegion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPostalCode, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtHomePhone, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtExtension, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtNotes, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblTitle2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblCityRegion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblPostalCode, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblCountry, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblExtension, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblHomePhone, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblHireDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblNotes, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblBirthDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtBirthDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'txtEmployeeID
		'
		Me.txtEmployeeID.DataField = "EmployeeID"
		resources.ApplyResources(Me.txtEmployeeID, "txtEmployeeID")
		Me.txtEmployeeID.Name = "txtEmployeeID"
		'
		'txtTitle
		'
		Me.txtTitle.DataField = "Title"
		resources.ApplyResources(Me.txtTitle, "txtTitle")
		Me.txtTitle.Name = "txtTitle"
		'
		'txtHireDate
		'
		Me.txtHireDate.DataField = "HireDate"
		resources.ApplyResources(Me.txtHireDate, "txtHireDate")
		Me.txtHireDate.Name = "txtHireDate"
		'
		'txtAddress
		'
		Me.txtAddress.DataField = "Address"
		resources.ApplyResources(Me.txtAddress, "txtAddress")
		Me.txtAddress.Name = "txtAddress"
		'
		'txtCity
		'
		Me.txtCity.DataField = "City"
		resources.ApplyResources(Me.txtCity, "txtCity")
		Me.txtCity.Name = "txtCity"
		'
		'txtRegion
		'
		Me.txtRegion.DataField = "Region"
		resources.ApplyResources(Me.txtRegion, "txtRegion")
		Me.txtRegion.Name = "txtRegion"
		'
		'txtPostalCode
		'
		Me.txtPostalCode.DataField = "PostalCode"
		resources.ApplyResources(Me.txtPostalCode, "txtPostalCode")
		Me.txtPostalCode.Name = "txtPostalCode"
		'
		'txtCountry
		'
		Me.txtCountry.DataField = "Country"
		resources.ApplyResources(Me.txtCountry, "txtCountry")
		Me.txtCountry.Name = "txtCountry"
		'
		'txtHomePhone
		'
		Me.txtHomePhone.DataField = "HomePhone"
		resources.ApplyResources(Me.txtHomePhone, "txtHomePhone")
		Me.txtHomePhone.Name = "txtHomePhone"
		'
		'txtExtension
		'
		Me.txtExtension.DataField = "Extension"
		resources.ApplyResources(Me.txtExtension, "txtExtension")
		Me.txtExtension.Name = "txtExtension"
		'
		'txtNotes
		'
		Me.txtNotes.DataField = "Notes"
		resources.ApplyResources(Me.txtNotes, "txtNotes")
		Me.txtNotes.Name = "txtNotes"
		'
		'lblTitle2
		'
		resources.ApplyResources(Me.lblTitle2, "lblTitle2")
		Me.lblTitle2.Name = "lblTitle2"
		Me.lblTitle2.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0)
		'
		'lblAddress
		'
		resources.ApplyResources(Me.lblAddress, "lblAddress")
		Me.lblAddress.Name = "lblAddress"
		Me.lblAddress.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0)
		'
		'lblCityRegion
		'
		resources.ApplyResources(Me.lblCityRegion, "lblCityRegion")
		Me.lblCityRegion.Name = "lblCityRegion"
		Me.lblCityRegion.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0)
		'
		'lblPostalCode
		'
		resources.ApplyResources(Me.lblPostalCode, "lblPostalCode")
		Me.lblPostalCode.Name = "lblPostalCode"
		Me.lblPostalCode.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0)
		'
		'lblCountry
		'
		resources.ApplyResources(Me.lblCountry, "lblCountry")
		Me.lblCountry.Name = "lblCountry"
		Me.lblCountry.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0)
		'
		'lblExtension
		'
		resources.ApplyResources(Me.lblExtension, "lblExtension")
		Me.lblExtension.Name = "lblExtension"
		Me.lblExtension.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0)
		'
		'lblHomePhone
		'
		resources.ApplyResources(Me.lblHomePhone, "lblHomePhone")
		Me.lblHomePhone.Name = "lblHomePhone"
		Me.lblHomePhone.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0)
		'
		'lblHireDate
		'
		resources.ApplyResources(Me.lblHireDate, "lblHireDate")
		Me.lblHireDate.Name = "lblHireDate"
		Me.lblHireDate.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0)
		'
		'lblNotes
		'
		resources.ApplyResources(Me.lblNotes, "lblNotes")
		Me.lblNotes.Name = "lblNotes"
		Me.lblNotes.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0)
		'
		'lblID
		'
		resources.ApplyResources(Me.lblID, "lblID")
		Me.lblID.Name = "lblID"
		Me.lblID.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0)
		'
		'lblBirthDate
		'
		resources.ApplyResources(Me.lblBirthDate, "lblBirthDate")
		Me.lblBirthDate.Name = "lblBirthDate"
		Me.lblBirthDate.Padding = New GrapeCity.ActiveReports.PaddingEx(0, 0, 2, 0)
		'
		'txtBirthDate
		'
		Me.txtBirthDate.DataField = "BirthDate"
		resources.ApplyResources(Me.txtBirthDate, "txtBirthDate")
		Me.txtBirthDate.Name = "txtBirthDate"
		'
		'txtName
		'
		Me.txtName.DataField = "Name"
		resources.ApplyResources(Me.txtName, "txtName")
		Me.txtName.Name = "txtName"
		'
		'lblTitle
		'
		resources.ApplyResources(Me.lblTitle, "lblTitle")
		Me.lblTitle.Name = "lblTitle"
		'
		'txtDescription
		'
		resources.ApplyResources(Me.txtDescription, "txtDescription")
		Me.txtDescription.Name = "txtDescription"
		'
		'Picture1
		'
		Me.Picture1.DataField = "Photo"
		resources.ApplyResources(Me.Picture1, "Picture1")
		Me.Picture1.ImageData = Nothing
		Me.Picture1.Name = "Picture1"
		'
		'Detail
		'
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblNotes, Me.txtEmployeeID, Me.txtTitle, Me.txtHireDate, Me.txtAddress, Me.txtCity, Me.txtRegion, Me.txtPostalCode, Me.txtCountry, Me.txtHomePhone, Me.txtExtension, Me.txtNotes, Me.lblTitle2, Me.lblAddress, Me.lblCityRegion, Me.lblPostalCode, Me.lblCountry, Me.lblExtension, Me.lblHomePhone, Me.lblHireDate, Me.lblID, Me.lblBirthDate, Me.txtBirthDate, Me.txtName, Me.Picture1})
		Me.Detail.Height = 2.55!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'PageHeader
		'
		Me.PageHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblTitle, Me.txtDescription})
		Me.PageHeader.Height = 0.5625!
		Me.PageHeader.Name = "PageHeader"
		'
		'PageFooter
		'
		Me.PageFooter.CanGrow = False
		Me.PageFooter.Height = 0.0!
		Me.PageFooter.Name = "PageFooter"
		'
		'EmployeeProfiles
		'
		Me.MasterReport = False
		OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.MDB"
		OleDBDataSource1.SQL = "SELECT * FROM employees ORDER BY LastName, FirstName"
		Me.DataSource = OleDBDataSource1
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.072917!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
			"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.txtEmployeeID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTitle, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtHireDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtAddress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtRegion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPostalCode, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtCountry, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtHomePhone, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtExtension, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtNotes, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblTitle2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblAddress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblCityRegion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblPostalCode, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblCountry, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblExtension, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblHomePhone, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblHireDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblNotes, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblBirthDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtBirthDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Friend WithEvents txtEmployeeID As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtTitle As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtHireDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtAddress As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtCity As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtRegion As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtPostalCode As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtCountry As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtHomePhone As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtExtension As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtNotes As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents lblTitle2 As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblAddress As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblCityRegion As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblPostalCode As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblCountry As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblExtension As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblHomePhone As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblHireDate As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblNotes As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblID As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents lblBirthDate As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents txtBirthDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
Friend WithEvents txtName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
Friend WithEvents lblTitle As GrapeCity.ActiveReports.SectionReportModel.Label
Friend WithEvents txtDescription As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
Private WithEvents Picture1 As GrapeCity.ActiveReports.SectionReportModel.Picture
End Class
