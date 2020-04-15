<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptStackedArea
	Inherits GrapeCity.ActiveReports.SectionReport
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
		End If
		MyBase.Dispose(disposing)
	End Sub
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptStackedArea))
		Dim ChartArea1 As GrapeCity.ActiveReports.Chart.ChartArea = New GrapeCity.ActiveReports.Chart.ChartArea()
		Dim Axis1 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis2 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis3 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis4 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis5 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim WallRange1 As GrapeCity.ActiveReports.Chart.WallRange = New GrapeCity.ActiveReports.Chart.WallRange()
		Dim WallRange2 As GrapeCity.ActiveReports.Chart.WallRange = New GrapeCity.ActiveReports.Chart.WallRange()
		Dim Legend1 As GrapeCity.ActiveReports.Chart.Legend = New GrapeCity.ActiveReports.Chart.Legend()
		Dim Title1 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Title2 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Series1 As GrapeCity.ActiveReports.Chart.Series = New GrapeCity.ActiveReports.Chart.Series()
		Dim Series2 As GrapeCity.ActiveReports.Chart.Series = New GrapeCity.ActiveReports.Chart.Series()
		Dim Series3 As GrapeCity.ActiveReports.Chart.Series = New GrapeCity.ActiveReports.Chart.Series()
		Dim Series4 As GrapeCity.ActiveReports.Chart.Series = New GrapeCity.ActiveReports.Chart.Series()
		Dim Title3 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Me.ChartUnbound = New GrapeCity.ActiveReports.SectionReportModel.ChartControl()
		Me.lblUnbound = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		CType(Me.ChartUnbound, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblUnbound, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'ChartUnbound
		'
		Me.ChartUnbound.AutoRefresh = True
		Me.ChartUnbound.Backdrop = New GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.SteelBlue)
		Axis1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Text
		Axis1.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle
		Axis1.AxisType = GrapeCity.ActiveReports.Chart.AxisType.Categorical
		Axis1.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, New System.Drawing.Font("Verdana", 8.25!))
		Axis1.Labels.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
		Axis1.Line = New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White)
		Axis1.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), 1.0R, 0.0!, True)
		Axis1.Max = 9.0R
		Axis1.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), 0.0R, 5.0!, True)
		Axis2.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle
		Axis2.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(), 0.5R, 5.0!)
		Axis2.Visible = False
		Axis3.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Text
		Axis3.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle
		Axis3.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, New System.Drawing.Font("Verdana", 8.25!))
		Axis3.Line = New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White)
		Axis3.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0), 10.0R, 6.0!, True)
		Axis3.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), 5.0R, 3.0!, False)
		Axis4.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle
		Axis4.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(), 0.5R, 5.0!)
		Axis4.Visible = False
		Axis5.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle
		Axis5.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(), 0.5R, 5.0!)
		Axis5.Visible = False
		ChartArea1.Axes.AddRange(New GrapeCity.ActiveReports.Chart.AxisBase() {Axis1, Axis2, Axis3, Axis4, Axis5})
		ChartArea1.Backdrop = New GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.Black, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
		ChartArea1.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 10, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Transparent)
		ChartArea1.Light = New GrapeCity.ActiveReports.Chart.Light(New GrapeCity.ActiveReports.Chart.Graphics.Point3d(0.0!, 10.0!, 20.0!), GrapeCity.ActiveReports.Chart.LightType.Ambient, 0.6!)
		ChartArea1.Name = "chartArea1"
		ChartArea1.Projection = New GrapeCity.ActiveReports.Chart.Projection(GrapeCity.ActiveReports.Chart.Graphics.ProjectionType.Identical, 0.3!, 0.3!)
		WallRange1.AdjacentAxes.AddRange(New GrapeCity.ActiveReports.Chart.AxisBase() {Axis1, Axis3})
		WallRange1.Backdrop = New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.White, CType(70, Byte))
		WallRange1.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent))
		WallRange1.EndValue = 24.0R
		WallRange1.Name = ""
		WallRange1.PrimaryAxis = Axis3
		WallRange1.StartValue = 12.0R
		WallRange2.AdjacentAxes.AddRange(New GrapeCity.ActiveReports.Chart.AxisBase() {Axis1, Axis3})
		WallRange2.Backdrop = New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.White, CType(70, Byte))
		WallRange2.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent))
		WallRange2.EndValue = 48.0R
		WallRange2.Name = ""
		WallRange2.PrimaryAxis = Axis3
		WallRange2.StartValue = 36.0R
		ChartArea1.WallRanges.AddRange(New GrapeCity.ActiveReports.Chart.WallRange() {WallRange1, WallRange2})
		ChartArea1.WallXY = New GrapeCity.ActiveReports.Chart.PlaneItem(New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Silver, CType(100, Byte)))
		ChartArea1.WallXZ = New GrapeCity.ActiveReports.Chart.PlaneItem(New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Beige), 5.0!)
		ChartArea1.WallYZ = New GrapeCity.ActiveReports.Chart.PlaneItem(New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Beige), 5.0!)
		ChartArea1.ZDepthRatio = 0.3!
		Me.ChartUnbound.ChartAreas.AddRange(New GrapeCity.ActiveReports.Chart.ChartArea() {ChartArea1})
		Me.ChartUnbound.ChartBorder = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.DodgerBlue, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Gainsboro)
		Me.ChartUnbound.Height = 4.0!
		Me.ChartUnbound.Left = 0.0625!
		Legend1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Both
		Legend1.Backdrop = New GrapeCity.ActiveReports.Chart.BackdropItem(System.Drawing.Color.Silver, CType(87, Byte))
		Legend1.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.CadetBlue, 0), 0, System.Drawing.Color.White)
		Legend1.DockArea = ChartArea1
		Legend1.DockInsideArea = True
		Title1.Backdrop = New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.Black, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched)
		Title1.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None))
		Title1.DockArea = Nothing
		Title1.Name = ""
		Title1.Text = ""
		Title1.Visible = False
		Legend1.Footer = Title1
		Title2.DockArea = Nothing
		Title2.Name = ""
		Title2.Text = ""
		Title2.Visible = False
		Legend1.Header = Title2
		Legend1.LabelsFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, New System.Drawing.Font("Verdana", 8.25!))
		Legend1.MarginX = 77
		Legend1.Name = "defaultLegend"
		Me.ChartUnbound.Legends.AddRange(New GrapeCity.ActiveReports.Chart.Legend() {Legend1})
		Me.ChartUnbound.Name = "ChartUnbound"
		Series1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics
		Series1.AxisX = Axis1
		Series1.AxisY = Axis3
		Series1.ChartArea = ChartArea1
		Series1.Legend = Legend1
		Series1.Name = "Series A"
		Series1.Points.AddRange(New GrapeCity.ActiveReports.Chart.DataPoint() {New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("5"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("7"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("7"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("9"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("13"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("12"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("14"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("16"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("16"), False)})
		Series1.Properties = New GrapeCity.ActiveReports.Chart.CustomProperties(New GrapeCity.ActiveReports.Chart.KeyValuePair() {New GrapeCity.ActiveReports.Chart.KeyValuePair("Backdrop", New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Gold, CType(200, Byte))), New GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White)), New GrapeCity.ActiveReports.Chart.KeyValuePair("Marker", New GrapeCity.ActiveReports.Chart.Marker(10, GrapeCity.ActiveReports.Chart.MarkerStyle.None, New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(), New GrapeCity.ActiveReports.Chart.Graphics.Line(), New GrapeCity.ActiveReports.Chart.LabelInfo(New GrapeCity.ActiveReports.Chart.Graphics.Line(), New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(), New GrapeCity.ActiveReports.Chart.FontInfo(), "", GrapeCity.ActiveReports.Chart.Alignment.Bottom))), New GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", New GrapeCity.ActiveReports.Chart.LabelInfo())})
		Series1.Type = GrapeCity.ActiveReports.Chart.ChartType.StackedArea
		Series1.ValueMembersY = Nothing
		Series1.ValueMemberX = Nothing
		Series1.ZOrder = 0.0!
		Series2.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics
		Series2.AxisX = Axis1
		Series2.AxisY = Axis3
		Series2.ChartArea = ChartArea1
		Series2.Legend = Legend1
		Series2.Name = "Series B"
		Series2.Points.AddRange(New GrapeCity.ActiveReports.Chart.DataPoint() {New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("8"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("12"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("12"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("15"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("14"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("14"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("17"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("20"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("18"), False)})
		Series2.Properties = New GrapeCity.ActiveReports.Chart.CustomProperties(New GrapeCity.ActiveReports.Chart.KeyValuePair() {New GrapeCity.ActiveReports.Chart.KeyValuePair("Backdrop", New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.LimeGreen, CType(200, Byte))), New GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White)), New GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", New GrapeCity.ActiveReports.Chart.LabelInfo())})
		Series2.Type = GrapeCity.ActiveReports.Chart.ChartType.StackedArea
		Series2.ValueMembersY = Nothing
		Series2.ValueMemberX = Nothing
		Series2.ZOrder = 0.0!
		Series3.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics
		Series3.AxisX = Axis1
		Series3.AxisY = Axis3
		Series3.ChartArea = ChartArea1
		Series3.Legend = Legend1
		Series3.Name = "Series C"
		Series3.Points.AddRange(New GrapeCity.ActiveReports.Chart.DataPoint() {New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("3"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("3"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("4"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("4"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("5"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("3"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("6"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("8"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("8"), False)})
		Series3.Properties = New GrapeCity.ActiveReports.Chart.CustomProperties(New GrapeCity.ActiveReports.Chart.KeyValuePair() {New GrapeCity.ActiveReports.Chart.KeyValuePair("Backdrop", New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.DodgerBlue, CType(200, Byte))), New GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White)), New GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", New GrapeCity.ActiveReports.Chart.LabelInfo())})
		Series3.Type = GrapeCity.ActiveReports.Chart.ChartType.StackedArea
		Series3.ValueMembersY = Nothing
		Series3.ValueMemberX = Nothing
		Series3.ZOrder = 0.0!
		Series4.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics
		Series4.AxisX = Axis1
		Series4.AxisY = Axis3
		Series4.ChartArea = ChartArea1
		Series4.Legend = Legend1
		Series4.Name = "Series D"
		Series4.Points.AddRange(New GrapeCity.ActiveReports.Chart.DataPoint() {New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("6"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("6"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("7"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("10"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("11"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("14"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("12"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("15"), False), New GrapeCity.ActiveReports.Chart.DataPoint("", New GrapeCity.ActiveReports.Chart.DoubleArray("12"), False)})
		Series4.Properties = New GrapeCity.ActiveReports.Chart.CustomProperties(New GrapeCity.ActiveReports.Chart.KeyValuePair() {New GrapeCity.ActiveReports.Chart.KeyValuePair("Backdrop", New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.DarkOrange, CType(200, Byte))), New GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White)), New GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", New GrapeCity.ActiveReports.Chart.LabelInfo())})
		Series4.Type = GrapeCity.ActiveReports.Chart.ChartType.StackedArea
		Series4.ValueMembersY = Nothing
		Series4.ValueMemberX = Nothing
		Series4.ZOrder = 0.0!
		Me.ChartUnbound.Series.AddRange(New GrapeCity.ActiveReports.Chart.Series() {Series1, Series2, Series3, Series4})
		Title3.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center
		Title3.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Text
		Title3.Backdrop = New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.SteelBlue)
		Title3.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 10, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None))
		Title3.DockArea = Nothing
		Title3.Docking = GrapeCity.ActiveReports.Chart.DockType.Bottom
		Title3.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, New System.Drawing.Font("Verdana", 8.25!))
		Title3.Name = "footer"
		Title3.Text = "Unbound graph"
		Me.ChartUnbound.Titles.AddRange(New GrapeCity.ActiveReports.Chart.Title() {Title3})
		Me.ChartUnbound.Top = 0.75!
		Me.ChartUnbound.Width = 5.938001!
		'
		'lblUnbound
		'
		Me.lblUnbound.Height = 0.25!
		Me.lblUnbound.HyperLink = ""
		Me.lblUnbound.Left = 0.0!
		Me.lblUnbound.Name = "lblUnbound"
		
		Me.lblUnbound.Style = "font-family: Arial; font-size: 12pt; font-weight: bold; text-align: center; ddo-c" & _
			"har-set: 128"
		Me.lblUnbound.Text = "Unbound graph"
		
		'
		'
		Me.lblUnbound.Top = 0.0!
		Me.lblUnbound.Width = 6.0!
		'
		'Label2
		'
		Me.Label2.Height = 0.4375!
		Me.Label2.HyperLink = ""
		Me.Label2.Left = 0.5!
		Me.Label2.Name = "Label2"
		
		Me.Label2.Style = "font-family: Arial; font-size: 9pt; text-align: center; ddo-char-set: 128"
		Me.Label2.Text = "Data used in the chart control is set to the data points using the series in a ch" & _
			"art editor. There are no external data source connections in this chart."
		
		'
		'
		Me.Label2.Top = 0.25!
		Me.Label2.Width = 5.0!
		'
		'Detail
		'
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ChartUnbound, Me.lblUnbound, Me.Label2})
		Me.Detail.Height = 4.875!
		Me.Detail.Name = "Detail"
		'
		'rptStackedArea
		'
		Me.MasterReport = False
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.1!
		Me.Sections.Add(Me.Detail)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
					"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		CType(Me.ChartUnbound, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblUnbound, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
	Friend WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
	Friend WithEvents ChartUnbound As GrapeCity.ActiveReports.SectionReportModel.ChartControl
	Friend WithEvents lblUnbound As GrapeCity.ActiveReports.SectionReportModel.Label
	Friend WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
