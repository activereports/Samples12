using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.AnnualReport
{
	public partial class Top10Customers
	{
  protected override void Dispose(bool disposing)
	{
	if (disposing)
	  {
	  }
	base.Dispose(disposing);
	}
	  
		#region ActiveReports Designer generated code
	   
	   
		
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Top10Customers));
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
			GrapeCity.ActiveReports.Chart.Title title4 = new GrapeCity.ActiveReports.Chart.Title();
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			this.txtCompanyname = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblRank = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.ChartControl1 = new GrapeCity.ActiveReports.SectionReportModel.ChartControl();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.GroupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
		   
			// txtCompanyname
			// 
			resources.ApplyResources(this.txtCompanyname, "txtCompanyname");
			this.txtCompanyname.DataField = "CompanyName";
			this.txtCompanyname.Name = "txtCompanyname";
			// 
			// txtSales
			// 
			resources.ApplyResources(this.txtSales, "txtSales");
			this.txtSales.DataField = "Sales";
			this.txtSales.Name = "txtSales";
			// 
			// lblRank
			// 
			resources.ApplyResources(this.lblRank, "lblRank");
			this.lblRank.Name = "lblRank";
			// 
			// ChartControl1
			// 
			this.ChartControl1.AutoRefresh = true;
			this.ChartControl1.Backdrop = new GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.White, System.Drawing.Color.LightYellow);
			axis1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Both;
			axis1.AxisType = GrapeCity.ActiveReports.Chart.AxisType.Categorical;
			axis1.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("MS PGothic", 8F), -50F);
			axis1.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.IndianRed, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 1D, 0F, false);
			axis1.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.DarkRed, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis1.SmartLabels = false;
			axis1.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
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
			axis3.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Both;
			axis3.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Arial", 7F));
			axis3.LabelsGap = 0;
			axis3.Line = new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Black, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None);
			axis3.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Firebrick), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Firebrick, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 50000D, 3F, true);
			axis3.Min = 0D;
			axis3.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.MistyRose, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.Dot), 10000D, 0F, false);
			axis3.Position = 0D;
			axis3.SmartLabels = false;
			axis3.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F), -90F);
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
			axis5.Line = new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None);
			axis5.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(), 2D, 10F);
			axis5.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
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
			chartArea1.Light = new GrapeCity.ActiveReports.Chart.Light(new GrapeCity.ActiveReports.Chart.Graphics.Point3d(10F, 40F, 20F), GrapeCity.ActiveReports.Chart.LightType.Ambient, 0.3F);
			chartArea1.Name = "defaultArea";
			chartArea1.Projection = new GrapeCity.ActiveReports.Chart.Projection(GrapeCity.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0.1F, 0.1F);
			chartArea1.WallXY = new GrapeCity.ActiveReports.Chart.PlaneItem(new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Transparent, ((byte)(197))));
			chartArea1.WallXZ = new GrapeCity.ActiveReports.Chart.PlaneItem(new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Gradient, System.Drawing.Color.Gray, System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched, ((byte)(197))));
			chartArea1.WallYZ = new GrapeCity.ActiveReports.Chart.PlaneItem(new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Gradient, System.Drawing.Color.DimGray, System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched, ((byte)(200))));
			this.ChartControl1.ChartAreas.AddRange(new GrapeCity.ActiveReports.Chart.ChartArea[] {
			chartArea1});
			this.ChartControl1.ChartBorder = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			this.ChartControl1.ColorPalette = GrapeCity.ActiveReports.Chart.ColorPalette.Cascade;
			resources.ApplyResources(this.ChartControl1, "ChartControl1");
			legend1.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Bottom;
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
			legend1.GridLayout = new GrapeCity.ActiveReports.Chart.GridLayout(2, 5);
			title2.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 2), 0, System.Drawing.Color.Black);
			title2.DockArea = null;
			title2.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			title2.Name = "";
			title2.Text = "Top 10 Products";
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
			series1.Name = "Series1";
			series1.Properties = new GrapeCity.ActiveReports.Chart.CustomProperties(new GrapeCity.ActiveReports.Chart.KeyValuePair[] {
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Backdrop", new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.GradientType.DiagonalDown, System.Drawing.Color.White, System.Drawing.Color.IndianRed)),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.DimGray)),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", new GrapeCity.ActiveReports.Chart.LabelInfo())});
			series1.Type = GrapeCity.ActiveReports.Chart.ChartType.Bar2D;
			series1.ValueMembersY = "Sales";
			series1.ValueMemberX = "CompanyName";
			this.ChartControl1.Series.AddRange(new GrapeCity.ActiveReports.Chart.Series[] {
			series1});
			title3.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center;
			title3.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			title3.DockArea = chartArea1;
			title3.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			title3.Name = "header";
			title3.Text = "";
			title4.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center;
			title4.Backdrop = new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched);
			title4.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			title4.DockArea = chartArea1;
			title4.Docking = GrapeCity.ActiveReports.Chart.DockType.Bottom;
			title4.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Arial Unicode MS", 8F));
			title4.Name = "footer";
			title4.Text = "";
			this.ChartControl1.Titles.AddRange(new GrapeCity.ActiveReports.Chart.Title[] {
			title3,
			title4});
			this.ChartControl1.UIOptions = GrapeCity.ActiveReports.Chart.UIOptions.ForceHitTesting;
			// 
			// Detail
			// 
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtCompanyname,
			this.txtSales,
			this.lblRank});
			this.Detail.Height = 0.1875F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.ChartControl1});
			this.GroupHeader1.Height = 4F;
			this.GroupHeader1.Name = "GroupHeader1";
			this.GroupHeader1.Format += new System.EventHandler(this.GroupHeader1_Format);
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Height = 0F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// Top10Customers
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			oleDBDataSource1.ConnectionString = "";
			oleDBDataSource1.SQL = "Select * from";
			this.DataSource = oleDBDataSource1;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 3.135417F;
			this.Sections.Add(this.GroupHeader1);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.ReportStart += new System.EventHandler(this.Top10Customers_ReportStart);
	   
		}
		private GroupHeader GroupHeader1;
		private ChartControl ChartControl1;
		private Detail Detail;
		private TextBox txtCompanyname;
		private TextBox txtSales;
		private Label lblRank;
		private GroupFooter GroupFooter1;
		#endregion
		
	}
}
