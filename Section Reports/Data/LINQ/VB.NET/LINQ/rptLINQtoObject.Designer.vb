<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptLINQtoObject
	Inherits GrapeCity.ActiveReports.SectionReport
	'ActiveReport overrides dispose to clean up for the list of components.
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
		End If
		MyBase.Dispose(disposing)
	End Sub
	'Note: The following procedure is required by the ActiveReport designer.
	'Should only be modfied using the designer.
	'Please do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptLINQtoObject))
		Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'TextBox5
		'
		resources.ApplyResources(Me.TextBox5, "TextBox5")
		Me.TextBox5.Name = "TextBox5"
		'
		'TextBox6
		'
		resources.ApplyResources(Me.TextBox6, "TextBox6")
		Me.TextBox6.Name = "TextBox6"
		'
		'TextBox7
		'
		resources.ApplyResources(Me.TextBox7, "TextBox7")
		Me.TextBox7.Name = "TextBox7"
		'
		'TextBox8
		'
		resources.ApplyResources(Me.TextBox8, "TextBox8")
		Me.TextBox8.Name = "TextBox8"
		'
		'TextBox1
		'
		Me.TextBox1.DataField = "ID"
		resources.ApplyResources(Me.TextBox1, "TextBox1")
		Me.TextBox1.Name = "TextBox1"
		'
		'TextBox2
		'
		Me.TextBox2.DataField = "Name"
		resources.ApplyResources(Me.TextBox2, "TextBox2")
		Me.TextBox2.Name = "TextBox2"
		'
		'TextBox3
		'
		Me.TextBox3.DataField = "Age"
		resources.ApplyResources(Me.TextBox3, "TextBox3")
		Me.TextBox3.Name = "TextBox3"
		'
		'TextBox4
		'
		Me.TextBox4.DataField = "city"
		resources.ApplyResources(Me.TextBox4, "TextBox4")
		Me.TextBox4.Name = "TextBox4"
		'
		'PageHeader
		'
		Me.PageHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8})
		Me.PageHeader.Height = 0.28125!
		Me.PageHeader.Name = "PageHeader"
		'
		'Detail
		'
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4})
		Me.Detail.Height = 0.40625!
		Me.Detail.Name = "Detail"
		'
		'PageFooter
		'
		Me.PageFooter.Name = "PageFooter"
		'
		'rptLINQtoObject
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
					"color: Black; font-family: MS UI Gothic; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 186", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold; ddo-char-set: 186", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 186", "Heading3", "Normal"))
		CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
	Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
	Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
	Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
	Friend WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents TextBox7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
	Friend WithEvents TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
