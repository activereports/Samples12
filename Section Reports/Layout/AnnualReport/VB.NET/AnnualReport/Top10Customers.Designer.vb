 _
Partial Class Top10Customers
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Top10Customers))
		Dim ChartArea1 As GrapeCity.ActiveReports.Chart.ChartArea = New GrapeCity.ActiveReports.Chart.ChartArea()
		Dim Axis1 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis2 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis3 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis4 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis5 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Legend1 As GrapeCity.ActiveReports.Chart.Legend = New GrapeCity.ActiveReports.Chart.Legend()
		Dim Title1 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Title2 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Series1 As GrapeCity.ActiveReports.Chart.Series = New GrapeCity.ActiveReports.Chart.Series()
		Dim Title3 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Title4 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Me.txtCompanyname = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblRank = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.ChartControl1 = New GrapeCity.ActiveReports.SectionReportModel.ChartControl()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
	
		'txtCompanyname
		'
		resources.ApplyResources(Me.txtCompanyname, "txtCompanyname")
		Me.txtCompanyname.DataField = "CompanyName"
		Me.txtCompanyname.Name = "txtCompanyname"
		'
		'txtSales
		'
		resources.ApplyResources(Me.txtSales, "txtSales")
		Me.txtSales.DataField = "Sales"
		Me.txtSales.Name = "txtSales"
		'
		'lblRank
		'
		resources.ApplyResources(Me.lblRank, "lblRank")
		Me.lblRank.Name = "lblRank"
		'
		'ChartControl1
		'
		Me.ChartControl1.AutoRefresh = True
		Me.ChartControl1.Backdrop = New GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.White, System.Drawing.Color.LightYellow)
		Axis1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Both
		Axis1.AxisType = GrapeCity.ActiveReports.Chart.AxisType.Categorical
		Axis1.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), -50.0!)
		Axis1.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.IndianRed, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 1.0R, 10.0!, False)
		Axis1.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.DarkRed, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis1.SmartLabels = False
		Axis1.TitleFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis2.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis2.LabelsGap = 0
		Axis2.LabelsVisible = False
		Axis2.Line = New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None)
		Axis2.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis2.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis2.Position = 0.0R
		Axis2.TickOffset = 0.0R
		Axis2.TitleFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis2.Visible = False
		Axis3.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Both
		Axis3.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Arial", 7.0!))
		Axis3.LabelsGap = 0
		Axis3.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Firebrick, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Firebrick, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 50000.0R, 3.0!, True)
		Axis3.Min = 0.0R
		Axis3.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.MistyRose, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.Dot), 10000.0R, 0.0!, False)
		Axis3.Position = 0.0R
		Axis3.SmartLabels = False
		Axis3.TitleFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), -90.0!)
		Axis4.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis4.LabelsVisible = False
		Axis4.Line = New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None)
		Axis4.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis4.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis4.TitleFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis4.Visible = False
		Axis5.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis5.LabelsGap = 0
		Axis5.LabelsVisible = False
		Axis5.Line = New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None)
		Axis5.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(), 2.0R, 10.0!)
		Axis5.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis5.Position = 0.0R
		Axis5.TickOffset = 0.0R
		Axis5.TitleFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis5.Visible = False
		ChartArea1.Axes.AddRange(New GrapeCity.ActiveReports.Chart.AxisBase() {Axis1, Axis2, Axis3, Axis4, Axis5})
		ChartArea1.Backdrop = New GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
		ChartArea1.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		ChartArea1.Light = New GrapeCity.ActiveReports.Chart.Light(New GrapeCity.ActiveReports.Chart.Graphics.Point3d(10.0!, 40.0!, 20.0!), GrapeCity.ActiveReports.Chart.LightType.Ambient, 0.3!)
		ChartArea1.Name = "defaultArea"
		ChartArea1.Projection = New GrapeCity.ActiveReports.Chart.Projection(GrapeCity.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0.1!, 0.1!)
		ChartArea1.WallXY = New GrapeCity.ActiveReports.Chart.PlaneItem(New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Transparent, CType(197, Byte)))
		ChartArea1.WallXZ = New GrapeCity.ActiveReports.Chart.PlaneItem(New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Gradient, System.Drawing.Color.Gray, System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched, CType(197, Byte)))
		ChartArea1.WallYZ = New GrapeCity.ActiveReports.Chart.PlaneItem(New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Gradient, System.Drawing.Color.DimGray, System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched, CType(200, Byte)))
		Me.ChartControl1.ChartAreas.AddRange(New GrapeCity.ActiveReports.Chart.ChartArea() {ChartArea1})
		Me.ChartControl1.ChartBorder = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		Me.ChartControl1.ColorPalette = GrapeCity.ActiveReports.Chart.ColorPalette.Cascade
		resources.ApplyResources(Me.ChartControl1, "ChartControl1")
		Legend1.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Bottom
		Legend1.Backdrop = New GrapeCity.ActiveReports.Chart.BackdropItem(System.Drawing.Color.White, CType(128, Byte))
		Legend1.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(), 0, System.Drawing.Color.Black)
		Legend1.DockArea = ChartArea1
		Title1.Backdrop = New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
		Title1.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		Title1.DockArea = Nothing
		Title1.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Title1.Name = ""
		Title1.Text = ""
		Legend1.Footer = Title1
		Legend1.GridLayout = New GrapeCity.ActiveReports.Chart.GridLayout(2, 5)
		Title2.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 2), 0, System.Drawing.Color.Black)
		Title2.DockArea = Nothing
		Title2.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Title2.Name = ""
		Title2.Text = "Top 10 Products"
		Legend1.Header = Title2
		Legend1.LabelsFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Legend1.Name = "defaultLegend"
		Legend1.Visible = False
		Me.ChartControl1.Legends.AddRange(New GrapeCity.ActiveReports.Chart.Legend() {Legend1})
		Me.ChartControl1.Name = "ChartControl1"
		Series1.AxisX = Axis1
		Series1.AxisY = Axis3
		Series1.ChartArea = ChartArea1
		Series1.Legend = Legend1
		Series1.LegendText = ""
		Series1.Name = "Series1"
		Series1.Properties = New GrapeCity.ActiveReports.Chart.CustomProperties(New GrapeCity.ActiveReports.Chart.KeyValuePair() {New GrapeCity.ActiveReports.Chart.KeyValuePair("Backdrop", New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.GradientType.DiagonalDown, System.Drawing.Color.White, System.Drawing.Color.IndianRed)), New GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.DimGray)), New GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", New GrapeCity.ActiveReports.Chart.LabelInfo())})
		Series1.Type = GrapeCity.ActiveReports.Chart.ChartType.Bar2D
		Series1.ValueMembersY = "Sales"
		Series1.ValueMemberX = "CompanyName"
		Me.ChartControl1.Series.AddRange(New GrapeCity.ActiveReports.Chart.Series() {Series1})
		Title3.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center
		Title3.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		Title3.DockArea = ChartArea1
		Title3.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Title3.Name = "header"
		Title3.Text = ""
		Title4.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center
		Title4.Backdrop = New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
		Title4.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		Title4.DockArea = ChartArea1
		Title4.Docking = GrapeCity.ActiveReports.Chart.DockType.Bottom
		Title4.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Title4.Name = "footer"
		Title4.Text = ""
		Me.ChartControl1.Titles.AddRange(New GrapeCity.ActiveReports.Chart.Title() {Title3, Title4})
		Me.ChartControl1.UIOptions = GrapeCity.ActiveReports.Chart.UIOptions.ForceHitTesting
		'
		'Detail
		'
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCompanyname, Me.txtSales, Me.lblRank})
		Me.Detail.Height = 0.1875!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'GroupHeader1
		'
		Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ChartControl1})
		Me.GroupHeader1.Height = 4.0!
		Me.GroupHeader1.Name = "GroupHeader1"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Height = 0.0!
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'Top10Customers
		'
		Me.MasterReport = False
		resources.ApplyResources(Me, "$this")
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 3.135417!
		Me.Sections.Add(Me.GroupHeader1)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private ChartControl1 As GrapeCity.ActiveReports.SectionReportModel.ChartControl
Private txtCompanyname As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private lblRank As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
