namespace GrapeCity.ActiveReports.Samples.Charting
{
	/// <summary>
	/// rptStackedArea 
	/// </summary>
	partial class rptStackedArea
	{
		
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
			}
			base.Dispose(disposing);
		}
		
		#region  ActiveReports Designer generated code  
		
		
		private void InitializeComponent()
		{
			GrapeCity.ActiveReports.Chart.ChartArea chartArea1 = new GrapeCity.ActiveReports.Chart.ChartArea();
			GrapeCity.ActiveReports.Chart.Axis axis1 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Axis axis2 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Axis axis3 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Axis axis4 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Axis axis5 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.WallRange wallRange1 = new GrapeCity.ActiveReports.Chart.WallRange();
			GrapeCity.ActiveReports.Chart.WallRange wallRange2 = new GrapeCity.ActiveReports.Chart.WallRange();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptStackedArea));
			GrapeCity.ActiveReports.Chart.Legend legend1 = new GrapeCity.ActiveReports.Chart.Legend();
			GrapeCity.ActiveReports.Chart.Title title1 = new GrapeCity.ActiveReports.Chart.Title();
			GrapeCity.ActiveReports.Chart.Title title2 = new GrapeCity.ActiveReports.Chart.Title();
			GrapeCity.ActiveReports.Chart.Series series1 = new GrapeCity.ActiveReports.Chart.Series();
			GrapeCity.ActiveReports.Chart.Series series2 = new GrapeCity.ActiveReports.Chart.Series();
			GrapeCity.ActiveReports.Chart.Series series3 = new GrapeCity.ActiveReports.Chart.Series();
			GrapeCity.ActiveReports.Chart.Series series4 = new GrapeCity.ActiveReports.Chart.Series();
			GrapeCity.ActiveReports.Chart.Title title3 = new GrapeCity.ActiveReports.Chart.Title();
			this.ChartUnbound = new GrapeCity.ActiveReports.SectionReportModel.ChartControl();
			this.lblUnbound = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
	   
			// 
			// ChartUnbound
			// 
			this.ChartUnbound.AutoRefresh = true;
			this.ChartUnbound.Backdrop = new GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.SteelBlue);
			axis1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Text;
			axis1.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle;
			axis1.AxisType = GrapeCity.ActiveReports.Chart.AxisType.Categorical;
			axis1.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, new System.Drawing.Font("Verdana", 8.25F));
			axis1.Labels.AddRange(new string[] {
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9"});
			axis1.Line = new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White);
			axis1.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), 1D, 0F, true);
			axis1.Max = 9D;
			axis1.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), 0D, 5F, true);
			axis2.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle;
			axis2.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(), 0.5D, 5F);
			axis2.Visible = false;
			axis3.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Text;
			axis3.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle;
			axis3.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, new System.Drawing.Font("Verdana", 8.25F));
			axis3.Line = new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White);
			axis3.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0), 10D, 6F, true);
			axis3.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent), 5D, 3F, false);
			axis4.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle;
			axis4.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(), 0.5D, 5F);
			axis4.Visible = false;
			axis5.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle;
			axis5.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(), 0.5D, 5F);
			axis5.Visible = false;
			chartArea1.Axes.AddRange(new GrapeCity.ActiveReports.Chart.AxisBase[] {
			axis1,
			axis2,
			axis3,
			axis4,
			axis5});
			chartArea1.Backdrop = new GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.Black, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched);
			chartArea1.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 10, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Transparent);
			chartArea1.Light = new GrapeCity.ActiveReports.Chart.Light(new GrapeCity.ActiveReports.Chart.Graphics.Point3d(0F, 10F, 20F), GrapeCity.ActiveReports.Chart.LightType.Ambient, 0.6F);
			chartArea1.Name = "chartArea1";
			chartArea1.Projection = new GrapeCity.ActiveReports.Chart.Projection(GrapeCity.ActiveReports.Chart.Graphics.ProjectionType.Identical, 0.3F, 0.3F);
			wallRange1.AdjacentAxes.AddRange(new GrapeCity.ActiveReports.Chart.AxisBase[] {
			axis1,
			axis3});
			wallRange1.Backdrop = new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.White, ((byte)(70)));
			wallRange1.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent));
			wallRange1.EndValue = 24D;
			wallRange1.Name = "";
			wallRange1.PrimaryAxis = axis3;
			wallRange1.StartValue = 12D;
			wallRange2.AdjacentAxes.AddRange(new GrapeCity.ActiveReports.Chart.AxisBase[] {
			axis1,
			axis3});
			wallRange2.Backdrop = new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.White, ((byte)(70)));
			wallRange2.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent));
			wallRange2.EndValue = 48D;
			wallRange2.Name = "";
			wallRange2.PrimaryAxis = axis3;
			wallRange2.StartValue = 36D;
			chartArea1.WallRanges.AddRange(new GrapeCity.ActiveReports.Chart.WallRange[] {
			wallRange1,
			wallRange2});
			chartArea1.WallXY = new GrapeCity.ActiveReports.Chart.PlaneItem(new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Silver, ((byte)(100))));
			chartArea1.WallXZ = new GrapeCity.ActiveReports.Chart.PlaneItem(new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Beige), 5F);
			chartArea1.WallYZ = new GrapeCity.ActiveReports.Chart.PlaneItem(new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Beige), 5F);
			chartArea1.ZDepthRatio = 0.3F;
			this.ChartUnbound.ChartAreas.AddRange(new GrapeCity.ActiveReports.Chart.ChartArea[] {
			chartArea1});
			this.ChartUnbound.ChartBorder = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.DodgerBlue, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Gainsboro);
			resources.ApplyResources(this.ChartUnbound, "ChartUnbound");
			legend1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Both;
			legend1.Backdrop = new GrapeCity.ActiveReports.Chart.BackdropItem(System.Drawing.Color.Silver, ((byte)(87)));
			legend1.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.CadetBlue, 0), 0, System.Drawing.Color.White);
			legend1.DockArea = chartArea1;
			legend1.DockInsideArea = true;
			title1.Backdrop = new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.Transparent, System.Drawing.Color.Black, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched);
			title1.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None));
			title1.DockArea = null;
			title1.Name = "";
			title1.Text = "";
			title1.Visible = false;
			legend1.Footer = title1;
			title2.DockArea = null;
			title2.Name = "";
			title2.Text = "";
			title2.Visible = false;
			legend1.Header = title2;
			legend1.LabelsFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, new System.Drawing.Font("Verdana", 8.25F));
			legend1.MarginX = 77;
			legend1.Name = "defaultLegend";
			this.ChartUnbound.Legends.AddRange(new GrapeCity.ActiveReports.Chart.Legend[] {
			legend1});
			this.ChartUnbound.Name = "ChartUnbound";
			series1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics;
			series1.AxisX = axis1;
			series1.AxisY = axis3;
			series1.ChartArea = chartArea1;
			series1.Legend = legend1;
			series1.LegendText = "";
			series1.Name = "Series A";
			series1.Points.AddRange(new GrapeCity.ActiveReports.Chart.DataPoint[] {
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("5"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("7"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("7"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("9"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("13"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("12"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("14"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("16"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("16"), false)});
			series1.Properties = new GrapeCity.ActiveReports.Chart.CustomProperties(new GrapeCity.ActiveReports.Chart.KeyValuePair[] {
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Backdrop", new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Gold, ((byte)(200)))),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White)),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Marker", new GrapeCity.ActiveReports.Chart.Marker(10, GrapeCity.ActiveReports.Chart.MarkerStyle.None, new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(), new GrapeCity.ActiveReports.Chart.Graphics.Line(), new GrapeCity.ActiveReports.Chart.LabelInfo(new GrapeCity.ActiveReports.Chart.Graphics.Line(), new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(), new GrapeCity.ActiveReports.Chart.FontInfo(), "", GrapeCity.ActiveReports.Chart.Alignment.Bottom))),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", new GrapeCity.ActiveReports.Chart.LabelInfo())});
			series1.Type = GrapeCity.ActiveReports.Chart.ChartType.StackedArea;
			series1.ValueMembersY = null;
			series1.ValueMemberX = null;
			series1.ZOrder = 0F;
			series2.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics;
			series2.AxisX = axis1;
			series2.AxisY = axis3;
			series2.ChartArea = chartArea1;
			series2.Legend = legend1;
			series2.LegendText = "";
			series2.Name = "Series B";
			series2.Points.AddRange(new GrapeCity.ActiveReports.Chart.DataPoint[] {
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("8"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("12"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("12"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("15"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("14"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("14"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("17"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("20"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("18"), false)});
			series2.Properties = new GrapeCity.ActiveReports.Chart.CustomProperties(new GrapeCity.ActiveReports.Chart.KeyValuePair[] {
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Backdrop", new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.LimeGreen, ((byte)(200)))),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White)),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", new GrapeCity.ActiveReports.Chart.LabelInfo())});
			series2.Type = GrapeCity.ActiveReports.Chart.ChartType.StackedArea;
			series2.ValueMembersY = null;
			series2.ValueMemberX = null;
			series2.ZOrder = 0F;
			series3.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics;
			series3.AxisX = axis1;
			series3.AxisY = axis3;
			series3.ChartArea = chartArea1;
			series3.Legend = legend1;
			series3.LegendText = "";
			series3.Name = "Series C";
			series3.Points.AddRange(new GrapeCity.ActiveReports.Chart.DataPoint[] {
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("3"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("3"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("4"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("4"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("5"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("3"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("6"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("8"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("8"), false)});
			series3.Properties = new GrapeCity.ActiveReports.Chart.CustomProperties(new GrapeCity.ActiveReports.Chart.KeyValuePair[] {
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Backdrop", new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.DodgerBlue, ((byte)(200)))),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White)),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", new GrapeCity.ActiveReports.Chart.LabelInfo())});
			series3.Type = GrapeCity.ActiveReports.Chart.ChartType.StackedArea;
			series3.ValueMembersY = null;
			series3.ValueMemberX = null;
			series3.ZOrder = 0F;
			series4.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics;
			series4.AxisX = axis1;
			series4.AxisY = axis3;
			series4.ChartArea = chartArea1;
			series4.Legend = legend1;
			series4.LegendText = "";
			series4.Name = "Series D";
			series4.Points.AddRange(new GrapeCity.ActiveReports.Chart.DataPoint[] {
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("6"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("6"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("7"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("10"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("11"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("14"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("12"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("15"), false),
			new GrapeCity.ActiveReports.Chart.DataPoint("", new GrapeCity.ActiveReports.Chart.DoubleArray("12"), false)});
			series4.Properties = new GrapeCity.ActiveReports.Chart.CustomProperties(new GrapeCity.ActiveReports.Chart.KeyValuePair[] {
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Backdrop", new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.DarkOrange, ((byte)(200)))),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White)),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", new GrapeCity.ActiveReports.Chart.LabelInfo())});
			series4.Type = GrapeCity.ActiveReports.Chart.ChartType.StackedArea;
			series4.ValueMembersY = null;
			series4.ValueMemberX = null;
			series4.ZOrder = 0F;
			this.ChartUnbound.Series.AddRange(new GrapeCity.ActiveReports.Chart.Series[] {
			series1,
			series2,
			series3,
			series4});
			title3.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center;
			title3.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Text;
			title3.Backdrop = new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.SteelBlue);
			title3.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 10, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None));
			title3.DockArea = null;
			title3.Docking = GrapeCity.ActiveReports.Chart.DockType.Bottom;
			title3.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, new System.Drawing.Font("Verdana", 8.25F));
			title3.Name = "footer";
			title3.Text = "Unbound Graph";
			this.ChartUnbound.Titles.AddRange(new GrapeCity.ActiveReports.Chart.Title[] {
			title3});
			// 
			// lblUnbound
			// 
			resources.ApplyResources(this.lblUnbound, "lblUnbound");
			this.lblUnbound.Name = "lblUnbound";
			// 
			// Label2
			// 
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.Name = "Label2";
			// 
			// Detail
			// 
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.ChartUnbound,
			this.lblUnbound,
			this.Label2});
			this.Detail.Height = 4.875F;
			this.Detail.Name = "Detail";
			// 
			// rptStackedArea
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.1F;
			this.Sections.Add(this.Detail);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
		 
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.ChartControl ChartUnbound;
		private GrapeCity.ActiveReports.SectionReportModel.Label lblUnbound;
		private GrapeCity.ActiveReports.SectionReportModel.Label Label2;
	}
}
