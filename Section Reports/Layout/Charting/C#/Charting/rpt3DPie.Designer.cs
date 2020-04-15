namespace GrapeCity.ActiveReports.Samples.Charting
{
	/// <summary>
	/// rpt3DPie 
	/// </summary>
	partial class rpt3DPie
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt3DPie));
			GrapeCity.ActiveReports.Chart.Legend legend1 = new GrapeCity.ActiveReports.Chart.Legend();
			GrapeCity.ActiveReports.Chart.Title title1 = new GrapeCity.ActiveReports.Chart.Title();
			GrapeCity.ActiveReports.Chart.Title title2 = new GrapeCity.ActiveReports.Chart.Title();
			GrapeCity.ActiveReports.Chart.Series series1 = new GrapeCity.ActiveReports.Chart.Series();
			GrapeCity.ActiveReports.Chart.Title title3 = new GrapeCity.ActiveReports.Chart.Title();
			GrapeCity.ActiveReports.Chart.Title title4 = new GrapeCity.ActiveReports.Chart.Title();
			this.ChartSalesCategories = new GrapeCity.ActiveReports.SectionReportModel.ChartControl();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
		  
			// 
			// ChartSalesCategories
			// 
			this.ChartSalesCategories.AutoRefresh = true;
			this.ChartSalesCategories.Backdrop = new GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.GradientType.FromCenter, System.Drawing.Color.Honeydew, System.Drawing.Color.DarkGreen);
			axis1.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle;
			axis1.AxisType = GrapeCity.ActiveReports.Chart.AxisType.Categorical;
			axis1.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis1.LabelsGap = 0;
			axis1.LabelsVisible = false;
			axis1.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis1.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis1.Position = 0D;
			axis1.TickOffset = 0D;
			axis1.Title = "Axis X";
			axis1.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis1.Visible = false;
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
			axis3.Arrow = GrapeCity.ActiveReports.Chart.ArrowType.Triangle;
			axis3.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis3.LabelsGap = 0;
			axis3.LabelsVisible = false;
			axis3.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis3.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis3.Position = 0D;
			axis3.TickOffset = 0D;
			axis3.Title = "Axis Y";
			axis3.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F), -90F);
			axis3.Visible = false;
			axis4.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis4.LabelsGap = 0;
			axis4.LabelsVisible = false;
			axis4.Line = new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None);
			axis4.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis4.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis4.Position = 0D;
			axis4.TickOffset = 0D;
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
			chartArea1.Light = new GrapeCity.ActiveReports.Chart.Light(new GrapeCity.ActiveReports.Chart.Graphics.Point3d(10F, 40F, 20F), GrapeCity.ActiveReports.Chart.LightType.InfiniteDirectional, 0.5F);
			chartArea1.Name = "defaultArea";
			chartArea1.Projection = new GrapeCity.ActiveReports.Chart.Projection(GrapeCity.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0F, 0F, 0F, 45F);
			chartArea1.WallXY = new GrapeCity.ActiveReports.Chart.PlaneItem(new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched), false, 0F);
			chartArea1.WallXZ = new GrapeCity.ActiveReports.Chart.PlaneItem(new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched), false, 0F);
			chartArea1.WallYZ = new GrapeCity.ActiveReports.Chart.PlaneItem(new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched), false, 0F);
			chartArea1.ZDepthRatio = 0.3F;
			this.ChartSalesCategories.ChartAreas.AddRange(new GrapeCity.ActiveReports.Chart.ChartArea[] {
			chartArea1});
			this.ChartSalesCategories.ChartBorder = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			resources.ApplyResources(this.ChartSalesCategories, "ChartSalesCategories");
			legend1.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Bottom;
			legend1.Backdrop = new GrapeCity.ActiveReports.Chart.BackdropItem(System.Drawing.Color.White, ((byte)(30)));
			legend1.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Black, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			legend1.DockArea = chartArea1;
			title1.Backdrop = new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched);
			title1.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			title1.DockArea = null;
			title1.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			title1.Name = "";
			title1.Text = "";
			title1.Visible = false;
			legend1.Footer = title1;
			legend1.GridLayout = new GrapeCity.ActiveReports.Chart.GridLayout(0, 1);
			title2.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Top;
			title2.Backdrop = new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.White, ((byte)(20)));
			title2.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.DarkGray, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.White);
			title2.DockArea = null;
			title2.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold));
			title2.Name = "";
			title2.Text = "Categories";
			legend1.Header = title2;
			legend1.LabelsFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			legend1.Name = "CategoryLegend";
			legend1.Visible = false;
			this.ChartSalesCategories.Legends.AddRange(new GrapeCity.ActiveReports.Chart.Legend[] {
			legend1});
			this.ChartSalesCategories.Name = "ChartSalesCategories";
			series1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Both;
			series1.AxisX = axis1;
			series1.AxisY = axis3;
			series1.ChartArea = chartArea1;
			series1.ColorPalette = GrapeCity.ActiveReports.Chart.ColorPalette.Default;
			series1.Legend = legend1;
			series1.LegendText = "Category Sales";
			series1.Name = "Sales";
			series1.Properties = new GrapeCity.ActiveReports.Chart.CustomProperties(new GrapeCity.ActiveReports.Chart.KeyValuePair[] {
			new GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.DimGray)),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("ExplodeFactor", 0.15F),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("HoleSize", 0F),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("StartAngle", 1F),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Marker", new GrapeCity.ActiveReports.Chart.Marker(10, GrapeCity.ActiveReports.Chart.MarkerStyle.None, new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(), new GrapeCity.ActiveReports.Chart.Graphics.Line(), new GrapeCity.ActiveReports.Chart.LabelInfo(new GrapeCity.ActiveReports.Chart.Graphics.Line(), new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.MintCream, ((byte)(175))), new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.DarkGreen, new System.Drawing.Font("Arial", 10F)), "{Name}", GrapeCity.ActiveReports.Chart.Alignment.Bottom))),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", new GrapeCity.ActiveReports.Chart.LabelInfo())});
			series1.Type = GrapeCity.ActiveReports.Chart.ChartType.Doughnut3D;
			series1.ValueMembersY = "ProductSales";
			series1.ValueMemberX = "CategoryName";
			this.ChartSalesCategories.Series.AddRange(new GrapeCity.ActiveReports.Chart.Series[] {
			series1});
			title3.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center;
			title3.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.None;
			title3.Backdrop = new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.White, ((byte)(50)));
			title3.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			title3.DockArea = chartArea1;
			title3.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, new System.Drawing.Font("Arial", 20F));
			title3.Name = "header";
			title3.Text = "Total sales of Pacific CSR by category";
			title4.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			title4.DockArea = chartArea1;
			title4.Docking = GrapeCity.ActiveReports.Chart.DockType.Bottom;
			title4.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			title4.Name = "Title1";
			title4.Text = "";
			this.ChartSalesCategories.Titles.AddRange(new GrapeCity.ActiveReports.Chart.Title[] {
			title3,
			title4});
			this.ChartSalesCategories.UIOptions = GrapeCity.ActiveReports.Chart.UIOptions.ForceHitTesting;
			// 
			// Detail
			// 
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.ChartSalesCategories});
			this.Detail.Height = 5.3F;
			this.Detail.Name = "Detail";
			// 
			// rpt3DPie
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6F;
			this.Sections.Add(this.Detail);
			
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
					  "l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.ReportStart += new System.EventHandler(this.rpt3DPie_ReportStart);
		}
		#endregion
		private GrapeCity.ActiveReports.SectionReportModel.Detail Detail;
		private GrapeCity.ActiveReports.SectionReportModel.ChartControl ChartSalesCategories;
	}
}
