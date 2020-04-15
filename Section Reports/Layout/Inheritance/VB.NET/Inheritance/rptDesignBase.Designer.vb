<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDesignBase
	Inherits GrapeCity.ActiveReports.SectionReport
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
		End If
		MyBase.Dispose(disposing)
	End Sub
	
#Region "ActiveReports Designer generated code"
	
	'
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptDesignBase))
		Me.imgLogo = New GrapeCity.ActiveReports.SectionReportModel.Picture()
		Me.lblNorthWind = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTraders = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.riPageOf = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
		Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
		CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblNorthWind, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblTraders, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.riPageOf, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'imgLogo
		'
		Me.imgLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		resources.ApplyResources(Me.imgLogo, "imgLogo")
		Me.imgLogo.ImageData = CType(resources.GetObject("imgLogo.ImageData"), System.IO.Stream)
		Me.imgLogo.LineColor = System.Drawing.Color.Black
		Me.imgLogo.LineWeight = 1.0!
		Me.imgLogo.Name = "imgLogo"
		Me.imgLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
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
		'Label1
		'
		resources.ApplyResources(Me.Label1, "Label1")
		Me.Label1.Name = "Label1"
		'
		'riPageOf
		'
		Me.riPageOf.FormatString = "{PageNumber} ／ {PageCount}"
		resources.ApplyResources(Me.riPageOf, "riPageOf")
		Me.riPageOf.Name = "riPageOf"
		'
		'PageHeader
		'
		Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.imgLogo, Me.lblNorthWind, Me.lblTraders, Me.Label1})
		Me.PageHeader.Height = 0.78125!
		Me.PageHeader.Name = "PageHeader"
		'
		'Detail
		'
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Height = 0.2291667!
		Me.Detail.Name = "Detail"
		'
		'PageFooter
		'
		Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.riPageOf})
		Me.PageFooter.Height = 0.3333333!
		Me.PageFooter.Name = "PageFooter"
		'
		'rptDesignBase
		'
		resources.ApplyResources(Me, "$this")
		Me.MasterReport = True
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Sections.Add(Me.PageHeader)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.PageFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblNorthWind, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblTraders, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.riPageOf, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
#End Region
	Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
	Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
	Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
	Friend WithEvents imgLogo As GrapeCity.ActiveReports.SectionReportModel.Picture
	Friend WithEvents lblNorthWind As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents lblTraders As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
	Private WithEvents riPageOf As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
End Class
