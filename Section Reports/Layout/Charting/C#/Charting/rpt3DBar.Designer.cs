namespace GrapeCity.ActiveReports.Samples.Charting
{
	/// <summary>
	/// rpt3DBar
	/// </summary>
	partial class rpt3DBar
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(rpt3DBar));
			GrapeCity.ActiveReports.Chart.ChartArea chartArea1 = new GrapeCity.ActiveReports.Chart.ChartArea();
			GrapeCity.ActiveReports.Chart.Axis axis1 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Axis axis2 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Axis axis3 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Axis axis4 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Axis axis5 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Legend legend1 = new GrapeCity.ActiveReports.Chart.Legend();
			GrapeCity.ActiveReports.Chart.Title title1 = new GrapeCity.ActiveReports.Chart.Title();
			GrapeCity.ActiveReports.Chart.Title title2 = new GrapeCity.ActiveReports.Chart.Title();
			GrapeCity.ActiveReports.Chart.Series series1 = new GrapeCity.ActiveReports.Chart.Series();
			GrapeCity.ActiveReports.Chart.Title title3 = new GrapeCity.ActiveReports.Chart.Title();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.ChartControl1 = new GrapeCity.ActiveReports.SectionReportModel.ChartControl();
			
			// 
			// Detail
			// 
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.ChartControl1});
			this.Detail.Height = 4.3F;
			this.Detail.Name = "Detail";
			// 
			// ChartControl1
			// 
			this.ChartControl1.AutoRefresh = true;
			this.ChartControl1.Backdrop = new GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.White, System.Drawing.Color.SteelBlue);
			chartArea1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics;
			axis1.AxisType = GrapeCity.ActiveReports.Chart.AxisType.Categorical;
			axis1.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Arial", 8F));
			axis1.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 1D, 0F, false);
			axis1.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis1.Title = "Name";
			axis1.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Arial", 12F));
			axis2.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis2.LabelsGap = 0;
			axis2.LabelsVisible = false;
			axis2.Line = new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None);
			axis2.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis2.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis2.Position = 0D;
			axis2.TickOffset = 0D;
			axis2.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis2.Visible = false;
			axis3.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Arial", 8F));
			axis3.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 1D, 5F, true);
			axis3.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis3.Position = 0D;
			axis3.Title = "Sales Amount (Dollar)";
			axis3.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Arial", 12F), -90F);
			axis4.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis4.LabelsVisible = false;
			axis4.Line = new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None);
			axis4.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis4.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis4.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis4.Visible = false;
			axis5.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis5.LabelsGap = 0;
			axis5.LabelsVisible = false;
			axis5.Line = new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None);
			axis5.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis5.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis5.Position = 0D;
			axis5.TickOffset = 0D;
			axis5.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis5.Visible = false;
			chartArea1.Axes.AddRange(new GrapeCity.ActiveReports.Chart.AxisBase[] {
			axis1,
			axis2,
			axis3,
			axis4,
			axis5});
			chartArea1.Backdrop = new GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched);
			chartArea1.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			chartArea1.Light = new GrapeCity.ActiveReports.Chart.Light(new GrapeCity.ActiveReports.Chart.Graphics.Point3d(10F, 40F, 20F), GrapeCity.ActiveReports.Chart.LightType.InfiniteDirectional, 0.3F);
			chartArea1.Name = "defaultArea";
			chartArea1.Projection = new GrapeCity.ActiveReports.Chart.Projection(GrapeCity.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0.1F, 0.1F);
			this.ChartControl1.ChartAreas.AddRange(new GrapeCity.ActiveReports.Chart.ChartArea[] {
			chartArea1});
			this.ChartControl1.ChartBorder = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			this.ChartControl1.Height = 4F;
			this.ChartControl1.Left = 0F;
			legend1.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Right;
			legend1.Backdrop = new GrapeCity.ActiveReports.Chart.BackdropItem(System.Drawing.Color.White, ((byte)(128)));
			legend1.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(), 0, System.Drawing.Color.Black);
			legend1.DockArea = chartArea1;
			title1.Backdrop = new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched);
			title1.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			title1.DockArea = null;
			title1.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			title1.Name = "";
			title1.Text = "";
			legend1.Footer = title1;
			legend1.GridLayout = new GrapeCity.ActiveReports.Chart.GridLayout(0, 1);
			title2.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 2), 0, System.Drawing.Color.Black);
			title2.DockArea = null;
			title2.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			title2.Name = "";
			title2.Text = "Legend";
			legend1.Header = title2;
			legend1.LabelsFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			legend1.Name = "defaultLegend";
			legend1.Visible = false;
			this.ChartControl1.Legends.AddRange(new GrapeCity.ActiveReports.Chart.Legend[] {
			legend1});
			this.ChartControl1.Name = "ChartControl1";
			series1.AxisX = axis1;
			series1.AxisY = axis3;
			series1.ChartArea = chartArea1;
			series1.Legend = legend1;
			series1.LegendText = "";
			series1.Name = "Series 1";
			series1.Type = GrapeCity.ActiveReports.Chart.ChartType.Bar3D;
			this.ChartControl1.Series.AddRange(new GrapeCity.ActiveReports.Chart.Series[] {
			series1});
			title3.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center;
			title3.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			title3.DockArea = null;
			title3.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Arial", 14F));
			title3.Name = "header";
			title3.Text = "3D Bar Chart";
			this.ChartControl1.Titles.AddRange(new GrapeCity.ActiveReports.Chart.Title[] {
			title3});
			this.ChartControl1.Top = 0F;
			this.ChartControl1.UIOptions = GrapeCity.ActiveReports.Chart.UIOptions.ForceHitTesting;
			this.ChartControl1.Width = 5.9F;
			// 
			// rpt3DBar
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6F;
			this.Sections.Add(this.Detail);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.ReportStart += new System.EventHandler(this.rpt3DBar_ReportStart);
		 
		}
		#endregion
		private SectionReportModel.Detail Detail;
		private SectionReportModel.ChartControl ChartControl1;
	}
}
