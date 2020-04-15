 _
Partial Class EmployeeSales
	Inherits GrapeCity.ActiveReports.SectionReport
Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeSales))
		Dim ChartArea1 As GrapeCity.ActiveReports.Chart.ChartArea = New GrapeCity.ActiveReports.Chart.ChartArea()
		Dim Axis1 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis2 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis3 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis4 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim Axis5 As GrapeCity.ActiveReports.Chart.Axis = New GrapeCity.ActiveReports.Chart.Axis()
		Dim OleDBDataSource1 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Dim Legend1 As GrapeCity.ActiveReports.Chart.Legend = New GrapeCity.ActiveReports.Chart.Legend()
		Dim Title1 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Title2 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Series1 As GrapeCity.ActiveReports.Chart.Series = New GrapeCity.ActiveReports.Chart.Series()
		Dim Title3 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim Title4 As GrapeCity.ActiveReports.Chart.Title = New GrapeCity.ActiveReports.Chart.Title()
		Dim OleDBDataSource2 As GrapeCity.ActiveReports.Data.OleDBDataSource = New GrapeCity.ActiveReports.Data.OleDBDataSource()
		Me.txtEmployeeName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.txtSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.lblTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblTotalSales = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.txtTotalSales = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
		Me.chtSales = New GrapeCity.ActiveReports.SectionReportModel.ChartControl()
		Me.lblEmployeeName = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.lblSales = New GrapeCity.ActiveReports.SectionReportModel.Label()
		Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
		Me.ReportHeader = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
		Me.ReportFooter = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
		Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
		Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
		CType(Me.txtEmployeeName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtSales, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblTotalSales, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtTotalSales, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chtSales, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblEmployeeName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblSales, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'txtEmployeeName
		'
		Me.txtEmployeeName.CanGrow = False
		Me.txtEmployeeName.DataField = "EmployeeName"
		resources.ApplyResources(Me.txtEmployeeName, "txtEmployeeName")
		Me.txtEmployeeName.Name = "txtEmployeeName"
		'
		'txtSales
		'
		Me.txtSales.CanGrow = False
		Me.txtSales.DataField = "Sales"
		resources.ApplyResources(Me.txtSales, "txtSales")
		Me.txtSales.Name = "txtSales"
		'
		'lblTitle
		'
		resources.ApplyResources(Me.lblTitle, "lblTitle")
		Me.lblTitle.Name = "lblTitle"
		'
		'lblTotalSales
		'
		resources.ApplyResources(Me.lblTotalSales, "lblTotalSales")
		Me.lblTotalSales.Name = "lblTotalSales"
		'
		'lblDate
		'
		resources.ApplyResources(Me.lblDate, "lblDate")
		Me.lblDate.Name = "lblDate"
		'
		'txtTotalSales
		'
		Me.txtTotalSales.CanGrow = False
		Me.txtTotalSales.DataField = "Sales"
		resources.ApplyResources(Me.txtTotalSales, "txtTotalSales")
		Me.txtTotalSales.Name = "txtTotalSales"
		Me.txtTotalSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
		'
		'chtSales
		'
		Me.chtSales.AutoRefresh = True
		Me.chtSales.Backdrop = New GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.White, System.Drawing.Color.Black)
		Axis1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Both
		Axis1.AxisType = GrapeCity.ActiveReports.Chart.AxisType.Categorical
		Axis1.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, New System.Drawing.Font("Arial", 9.0!), -50.0!)
		Axis1.LabelsGap = 0
		Axis1.Line = New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None)
		Axis1.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 3), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 3, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 1.0R, 0.0!, False)
		Axis1.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis1.TitleFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, New System.Drawing.Font("Arial", 10.0!))
		Axis2.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis2.LabelsGap = 0
		Axis2.LabelsVisible = False
		Axis2.Line = New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None)
		Axis2.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis2.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis2.Position = 0.0R
		Axis2.TickOffset = 0.0R
		Axis2.TitleFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis2.Visible = False
		Axis3.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis3.LabelsGap = 0
		Axis3.LabelsVisible = False
		Axis3.Line = New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Black, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None)
		Axis3.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, True)
		Axis3.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis3.Position = 0.0R
		Axis3.SmartLabels = False
		Axis3.TickOffset = 0.0R
		Axis3.TitleFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), 90.0!)
		Axis4.LabelFont = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Axis4.LabelsGap = 0
		Axis4.LabelsVisible = False
		Axis4.Line = New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None)
		Axis4.MajorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
		Axis4.MinorTick = New GrapeCity.ActiveReports.Chart.Tick(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0.0R, 0.0!, False)
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
		ChartArea1.Light = New GrapeCity.ActiveReports.Chart.Light(New GrapeCity.ActiveReports.Chart.Graphics.Point3d(10.0!, 40.0!, 20.0!), GrapeCity.ActiveReports.Chart.LightType.InfiniteDirectional, 0.37!)
		ChartArea1.Name = "defaultArea"
		ChartArea1.Projection = New GrapeCity.ActiveReports.Chart.Projection(GrapeCity.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0.3!, 0.3!)
		ChartArea1.WallXY = New GrapeCity.ActiveReports.Chart.PlaneItem(New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched))
		ChartArea1.WallXZ = New GrapeCity.ActiveReports.Chart.PlaneItem(New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Gray))
		ChartArea1.WallYZ = New GrapeCity.ActiveReports.Chart.PlaneItem(New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, Nothing, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched))
		ChartArea1.ZDepthRatio = 0.4!
		Me.chtSales.ChartAreas.AddRange(New GrapeCity.ActiveReports.Chart.ChartArea() {ChartArea1})
		Me.chtSales.ChartBorder = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		Me.chtSales.ColorPalette = GrapeCity.ActiveReports.Chart.ColorPalette.Confetti
		OleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.mdb;Persist Security Info=False"
		OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
		Me.chtSales.DataSource = OleDBDataSource1
		resources.ApplyResources(Me.chtSales, "chtSales")
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
		Me.chtSales.Legends.AddRange(New GrapeCity.ActiveReports.Chart.Legend() {Legend1})
		Me.chtSales.Name = "chtSales"
		Series1.AxisX = Axis1
		Series1.AxisY = Axis3
		Series1.ChartArea = ChartArea1
		Series1.Legend = Legend1
		Series1.Name = "Series1"
		Series1.Properties = New GrapeCity.ActiveReports.Chart.CustomProperties(New GrapeCity.ActiveReports.Chart.KeyValuePair() {New GrapeCity.ActiveReports.Chart.KeyValuePair("Backdrop", New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.Red, System.Drawing.Color.Gray)), New GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", New GrapeCity.ActiveReports.Chart.Graphics.Line()), New GrapeCity.ActiveReports.Chart.KeyValuePair("Marker", New GrapeCity.ActiveReports.Chart.Marker(10, GrapeCity.ActiveReports.Chart.MarkerStyle.None, New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(), New GrapeCity.ActiveReports.Chart.Graphics.Line(), New GrapeCity.ActiveReports.Chart.LabelInfo(New GrapeCity.ActiveReports.Chart.Graphics.Line(), New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.White, CType(200, Byte)), New GrapeCity.ActiveReports.Chart.FontInfo(), "{Value:C}", GrapeCity.ActiveReports.Chart.Alignment.Top), GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Both)), New GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", New GrapeCity.ActiveReports.Chart.LabelInfo())})
		Series1.Type = GrapeCity.ActiveReports.Chart.ChartType.Bar3D
		Series1.ValueMembersY = "Sales"
		Series1.ValueMemberX = "EmployeeName"
		Me.chtSales.Series.AddRange(New GrapeCity.ActiveReports.Chart.Series() {Series1})
		Title3.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center
		Title3.Backdrop = New GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.White, CType(81, Byte))
		Title3.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		Title3.DockArea = ChartArea1
		Title3.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold))
		Title3.Name = "header"
		Title3.Text = "Sales by Employee for 1997"
		Title4.Border = New GrapeCity.ActiveReports.Chart.Border(New GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black)
		Title4.DockArea = ChartArea1
		Title4.Docking = GrapeCity.ActiveReports.Chart.DockType.Bottom
		Title4.Font = New GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, New System.Drawing.Font("Microsoft Sans Serif", 8.0!))
		Title4.Name = "Title1"
		Title4.Text = ""
		Me.chtSales.Titles.AddRange(New GrapeCity.ActiveReports.Chart.Title() {Title3, Title4})
		Me.chtSales.UIOptions = GrapeCity.ActiveReports.Chart.UIOptions.ForceHitTesting
		'
		'lblEmployeeName
		'
		resources.ApplyResources(Me.lblEmployeeName, "lblEmployeeName")
		Me.lblEmployeeName.Name = "lblEmployeeName"
		'
		'lblSales
		'
		resources.ApplyResources(Me.lblSales, "lblSales")
		Me.lblSales.Name = "lblSales"
		'
		'Detail
		'
		Me.Detail.CanGrow = False
		Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtEmployeeName, Me.txtSales})
		Me.Detail.Height = 0.2!
		Me.Detail.KeepTogether = True
		Me.Detail.Name = "Detail"
		'
		'ReportHeader
		'
		Me.ReportHeader.CanGrow = False
		Me.ReportHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblTitle, Me.lblTotalSales, Me.lblDate, Me.txtTotalSales, Me.chtSales})
		Me.ReportHeader.Height = 3.9375!
		Me.ReportHeader.Name = "ReportHeader"
		'
		'ReportFooter
		'
		Me.ReportFooter.CanGrow = False
		Me.ReportFooter.Height = 0.0!
		Me.ReportFooter.KeepTogether = True
		Me.ReportFooter.Name = "ReportFooter"
		'
		'GroupHeader1
		'
		Me.GroupHeader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblEmployeeName, Me.lblSales})
		Me.GroupHeader1.Name = "GroupHeader1"
		'
		'GroupFooter1
		'
		Me.GroupFooter1.Height = 0.0!
		Me.GroupFooter1.Name = "GroupFooter1"
		'
		'EmployeeSales
		'
		Me.MasterReport = False
		OleDBDataSource2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\evan.warren\Documents\GrapeCity Samples\ActiveReports 12\Data\NWIND.MDB;Persist Security Info=False"
		OleDBDataSource2.SQL = resources.GetString("OleDBDataSource2.SQL")
		Me.DataSource = OleDBDataSource2
		Me.PageSettings.PaperHeight = 11.0!
		Me.PageSettings.PaperWidth = 8.5!
		Me.PrintWidth = 6.5!
		Me.Script = resources.GetString("$this.Script")
		Me.Sections.Add(Me.ReportHeader)
		Me.Sections.Add(Me.GroupHeader1)
		Me.Sections.Add(Me.Detail)
		Me.Sections.Add(Me.GroupFooter1)
		Me.Sections.Add(Me.ReportFooter)
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" & _
			"old", "Heading2", "Normal"))
		Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"))
		CType(Me.txtEmployeeName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtSales, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblTotalSales, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtTotalSales, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chtSales, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblEmployeeName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblSales, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
Private WithEvents ReportHeader As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
Private WithEvents ReportFooter As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
Private lblTitle As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblTotalSales As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtTotalSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private chtSales As GrapeCity.ActiveReports.SectionReportModel.ChartControl
Private lblEmployeeName As GrapeCity.ActiveReports.SectionReportModel.Label
Private lblSales As GrapeCity.ActiveReports.SectionReportModel.Label
Private txtEmployeeName As GrapeCity.ActiveReports.SectionReportModel.TextBox
Private txtSales As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
