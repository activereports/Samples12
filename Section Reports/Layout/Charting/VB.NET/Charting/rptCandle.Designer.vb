 _
Partial Class rptCandle
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim ChartArea1 As GrapeCity.ActiveReports.Chart.ChartArea = New GrapeCity.ActiveReports.Chart.ChartArea()
		Dim Axis1 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis2 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis3 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis4 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis5 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCandle))
		Dim Legend1 As GrapeCity.ActiveReports.Chart.Legend = New GrapeCity.ActiveReports.Chart.Legend()
		Dim Title1 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Title2 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Series1 As GrapeCity.ActiveReports.Chart.Series = New GrapeCity.ActiveReports.Chart.Series()
		Dim Title3 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Me.ChartControl = New GrapeCity.ActiveReports.SectionReportModel.ChartControl()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
	  
		'
		'ChartControl
		'
		Me.ChartControl.AutoRefresh = True
		Me.ChartControl.Backdrop = New GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.White, System.Drawing.Color.SteelBlue)
		ChartArea1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics
		Axis1.AxisType = GrapeCity.ActiveReports.Chart.AxisType.Categorical
		Axis1.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis1.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 1.0R, 0.0!, False)
		Axis1.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis1.SmartLabels = False
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
		Axis3.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis3.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 10.0R, 0.0!, False)
		Axis3.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis3.Position = 0.0R
		Axis3.Title = "Thousand Dollars"
		Axis3.TitleFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Arial", 8.0!), -90.0!)
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
		Axis5.Line = New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None)
		Axis5.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis5.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis5.Position = 0.0R
		Axis5.TickOffset = 0.0R
		Axis5.TitleFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis5.Visible = False
		ChartArea1.Axes.AddRange(New GrapeCity.ActiveReports.Chart.AxisBase() {Axis1, Axis2, Axis3, Axis4, Axis5})
		ChartArea1.Backdrop = New GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
		ChartArea1.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		ChartArea1.Light = New GrapeCity.ActiveReports.Chart.Light(New GrapeCity.ActiveReports.Chart.Graphics.Point3d(10.0!, 40.0!, 20.0!), GrapeCity.ActiveReports.Chart.LightType.InfiniteDirectional, 0.3!)
		ChartArea1.Name = "defaultArea"
		ChartArea1.Projection = New GrapeCity.ActiveReports.Chart.Projection(GrapeCity.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0.1!, 0.1!)
		Me.ChartControl.ChartAreas.AddRange(New GrapeCity.ActiveReports.Chart.ChartArea() {ChartArea1})
		Me.ChartControl.ChartBorder = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		resources.ApplyResources(Me.ChartControl, "ChartControl")
		Legend1.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Right
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
		Title2.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 2), 0, System.Drawing.Color.Black)
		Title2.DockArea = Nothing
		Title2.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Title2.Name = ""
		Title2.Text = "Legend"
		Legend1.Header = Title2
		Legend1.LabelsFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Legend1.Name = "defaultLegend"
		Legend1.Visible = False
		Me.ChartControl.Legends.AddRange(New GrapeCity.ActiveReports.Chart.Legend() {Legend1})
		Me.ChartControl.Name = "ChartControl"
		Series1.AxisX = Axis1
		Series1.AxisY = Axis3
		Series1.ChartArea = ChartArea1
		Series1.Legend = Legend1
		Series1.LegendText = ""
		Series1.Name = "Series1"
		Series1.Points.AddRange(New GrapeCity.ActiveReports.Chart.DataPoint() {New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("99; 37; 53; 88"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("115; 22; 101; 35"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("87; 1; 7; 80"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("63; 14; 57; 25"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("130; 25; 25; 120"), False)})
		Series1.Properties = New GrapeCity.ActiveReports.Chart.CustomProperties(New GrapeCity.ActiveReports.Chart.KeyValuePair() {New GrapeCity.ActiveReports.Chart.KeyValuePair("BodyDownswingBackdrop", New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Fuchsia)), New GrapeCity.ActiveReports.Chart.KeyValuePair("BodyUpswingBackdrop", New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.DarkViolet)), New GrapeCity.ActiveReports.Chart.KeyValuePair("WickLine", New GrapeCity.ActiveReports.Chart.Graphics.Line()), New GrapeCity.ActiveReports.Chart.KeyValuePair("BodyWidth", 10.0!)})
		Series1.Type = GrapeCity.ActiveReports.Chart.ChartType.Candle
		Series1.ValueMembersY = Nothing
		Series1.ValueMemberX = Nothing
		Me.ChartControl.Series.AddRange(New GrapeCity.ActiveReports.Chart.Series() {Series1})
		Title3.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center
		Title3.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		Title3.DockArea = Nothing
		Title3.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Arial", 14.0!))
		Title3.Name = "header"
		Title3.Text = "Candle Chart"
		Me.ChartControl.Titles.AddRange(New GrapeCity.ActiveReports.Chart.Title() {Title3})
		'
		'Detail
		'
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ChartControl})
		Me.Detail.Height = 3.8!
		Me.Detail.Name = "Detail"
		'
		'rptCandle
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Sections.Add(Me.Detail)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		
	End Sub
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private ChartControl As GrapeCity.ActiveReports.SectionReportModel.ChartControl
End Class
