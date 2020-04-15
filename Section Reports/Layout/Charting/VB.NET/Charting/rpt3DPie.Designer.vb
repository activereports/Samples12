 _
Partial Class rpt3DPie
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim ChartArea1 As GrapeCity.ActiveReports.Chart.ChartArea = New GrapeCity.ActiveReports.Chart.ChartArea()
		Dim Axis1 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis2 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis3 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis4 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis5 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt3DPie))
		Dim Legend1 As GrapeCity.ActiveReports.Chart.Legend = New GrapeCity.ActiveReports.Chart.Legend()
		Dim Title1 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Title2 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Series1 As GrapeCity.ActiveReports.Chart.Series = New GrapeCity.ActiveReports.Chart.Series()
		Dim Title3 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Title4 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Me.ChartSalesCategories = New GrapeCity.ActiveReports.SectionReportModel.ChartControl()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		'
		'ChartSalesCategories
		'
		Me.ChartSalesCategories.AutoRefresh = True
		Me.ChartSalesCategories.Backdrop = New GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.GradientType.FromCenter, System.Drawing.Color.Honeydew, System.Drawing.Color.DarkGreen)
		Axis1.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle
		Axis1.AxisType = GrapeCity.ActiveReports.Chart.AxisType.Categorical
		Axis1.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis1.LabelsGap = 0
		Axis1.LabelsVisible = False
		Axis1.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis1.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis1.Position = 0.0R
		Axis1.TickOffset = 0.0R
		Axis1.Title = "Axis X"
		Axis1.TitleFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis1.Visible = False
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
		Axis3.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle
		Axis3.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis3.LabelsGap = 0
		Axis3.LabelsVisible = False
		Axis3.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis3.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis3.Position = 0.0R
		Axis3.TickOffset = 0.0R
		Axis3.Title = "Axis Y"
		Axis3.TitleFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), -90.0!)
		Axis3.Visible = False
		Axis4.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis4.LabelsGap = 0
		Axis4.LabelsVisible = False
		Axis4.Line = New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None)
		Axis4.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis4.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis4.Position = 0.0R
		Axis4.TickOffset = 0.0R
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
		ChartArea1.Light = New GrapeCity.ActiveReports.Chart.Light(New GrapeCity.ActiveReports.Chart.Graphics.Point3d(10.0!, 40.0!, 20.0!), GrapeCity.ActiveReports.Chart.LightType.InfiniteDirectional, 0.5!)
		ChartArea1.Name = "defaultArea"
		ChartArea1.Projection = New GrapeCity.ActiveReports.Chart.Projection(GrapeCity.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0.0!, 0.0!, 0.0!, 45.0!)
		ChartArea1.WallXY = New GrapeCity.ActiveReports.Chart.PlaneItem(New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched), False, 0.0!)
		ChartArea1.WallXZ = New GrapeCity.ActiveReports.Chart.PlaneItem(New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched), False, 0.0!)
		ChartArea1.WallYZ = New GrapeCity.ActiveReports.Chart.PlaneItem(New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched), False, 0.0!)
		ChartArea1.ZDepthRatio = 0.3!
		Me.ChartSalesCategories.ChartAreas.AddRange(New GrapeCity.ActiveReports.Chart.ChartArea() {ChartArea1})
		Me.ChartSalesCategories.ChartBorder = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		resources.ApplyResources(Me.ChartSalesCategories, "ChartSalesCategories")
		Legend1.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Bottom
		Legend1.Backdrop = New GrapeCity.ActiveReports.Chart.BackdropItem(System.Drawing.Color.White, CType(30, Byte))
		Legend1.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Black, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		Legend1.DockArea = ChartArea1
		Title1.Backdrop = New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
		Title1.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		Title1.DockArea = Nothing
		Title1.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Title1.Name = ""
		Title1.Text = ""
		Title1.Visible = False
		Legend1.Footer = Title1
		Legend1.GridLayout = New GrapeCity.ActiveReports.Chart.GridLayout(0, 1)
		Title2.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Top
		Title2.Backdrop = New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.White, CType(20, Byte))
		Title2.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.DarkGray, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.White)
		Title2.DockArea = Nothing
		Title2.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold))
		Title2.Name = ""
		Title2.Text = "Categories"
		Legend1.Header = Title2
		Legend1.LabelsFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Legend1.Name = "CategoryLegend"
		Legend1.Visible = False
		Me.ChartSalesCategories.Legends.AddRange(New GrapeCity.ActiveReports.Chart.Legend() {Legend1})
		Me.ChartSalesCategories.Name = "ChartSalesCategories"
		Series1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Both
		Series1.AxisX = Axis1
		Series1.AxisY = Axis3
		Series1.ChartArea = ChartArea1
		Series1.ColorPalette = GrapeCity.ActiveReports.Chart.ColorPalette.[Default]
		Series1.Legend = Legend1
		Series1.LegendText = "Category Sales"
		Series1.Name = "Sales"
		Series1.Properties = New GrapeCity.ActiveReports.Chart.CustomProperties(New GrapeCity.ActiveReports.Chart.KeyValuePair() {New GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.DimGray)), New GrapeCity.ActiveReports.Chart.KeyValuePair("ExplodeFactor", 0.15!), New GrapeCity.ActiveReports.Chart.KeyValuePair("HoleSize", 0.0!), New GrapeCity.ActiveReports.Chart.KeyValuePair("StartAngle", 1.0!), New GrapeCity.ActiveReports.Chart.KeyValuePair("Marker", New GrapeCity.ActiveReports.Chart.Marker(10, GrapeCity.ActiveReports.Chart.MarkerStyle.None, New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(), New GrapeCity.ActiveReports.Chart.Graphics.Line(), New GrapeCity.ActiveReports.Chart.LabelInfo(New GrapeCity.ActiveReports.Chart.Graphics.Line(), New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.MintCream, CType(175, Byte)), New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.DarkGreen, New System.Drawing.Font("Arial", 10.0!)), "{Name}", GrapeCity.ActiveReports.Chart.Alignment.Bottom))), New GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", New GrapeCity.ActiveReports.Chart.LabelInfo()), New GrapeCity.ActiveReports.Chart.KeyValuePair("Clockwise", False)})
		Series1.Type = GrapeCity.ActiveReports.Chart.ChartType.Doughnut3D
		Series1.ValueMembersY = "ProductSales"
		Series1.ValueMemberX = "CategoryName"
		Me.ChartSalesCategories.Series.AddRange(New GrapeCity.ActiveReports.Chart.Series() {Series1})
		Title3.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center
		Title3.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.None
		Title3.Backdrop = New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.White, CType(50, Byte))
		Title3.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		Title3.DockArea = ChartArea1
		Title3.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, New System.Drawing.Font("Arial", 20.0!))
		Title3.Name = "header"
		Title3.Text = "Total sales of Pacific CSR by category"
		Title4.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		Title4.DockArea = ChartArea1
		Title4.Docking = GrapeCity.ActiveReports.Chart.DockType.Bottom
		Title4.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Title4.Name = "Title1"
		Title4.Text = ""
		Me.ChartSalesCategories.Titles.AddRange(New GrapeCity.ActiveReports.Chart.Title() {Title3, Title4})
		Me.ChartSalesCategories.UIOptions = GrapeCity.ActiveReports.Chart.UIOptions.ForceHitTesting
		'
		'Detail
		'
		Me.Detail.ColumnSpacing = 0.0!
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ChartSalesCategories})
		Me.Detail.Height = 5.3!
		Me.Detail.Name = "Detail"
		'
		'rpt3DPie
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.0!
		Me.Sections.Add(Me.Detail)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
	End Sub
Friend WithEvents ChartSalesCategories As GrapeCity.ActiveReports.SectionReportModel.ChartControl
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
End Class
