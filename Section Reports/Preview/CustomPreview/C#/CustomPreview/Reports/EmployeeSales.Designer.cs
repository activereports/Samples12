using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	public partial class EmployeeSales
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSales));
			GrapeCity.ActiveReports.Chart.ChartArea chartArea1 = new GrapeCity.ActiveReports.Chart.ChartArea();
			GrapeCity.ActiveReports.Chart.Axis axis1 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Axis axis2 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Axis axis3 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Axis axis4 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Chart.Axis axis5 = new GrapeCity.ActiveReports.Chart.Axis();
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			GrapeCity.ActiveReports.Chart.Legend legend1 = new GrapeCity.ActiveReports.Chart.Legend();
			GrapeCity.ActiveReports.Chart.Title title1 = new GrapeCity.ActiveReports.Chart.Title();
			GrapeCity.ActiveReports.Chart.Title title2 = new GrapeCity.ActiveReports.Chart.Title();
			GrapeCity.ActiveReports.Chart.Series series1 = new GrapeCity.ActiveReports.Chart.Series();
			GrapeCity.ActiveReports.Chart.Title title3 = new GrapeCity.ActiveReports.Chart.Title();
			GrapeCity.ActiveReports.Chart.Title title4 = new GrapeCity.ActiveReports.Chart.Title();
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource2 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			this.txtEmployeeName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTotalSales = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtTotalSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.chtSales = new GrapeCity.ActiveReports.SectionReportModel.ChartControl();
			this.lblEmployeeName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblSales = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.ReportHeader = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
			this.ReportFooter = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
			this.GroupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chtSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblEmployeeName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.CanGrow = false;
			this.txtEmployeeName.DataField = "EmployeeName";
			resources.ApplyResources(this.txtEmployeeName, "txtEmployeeName");
			this.txtEmployeeName.Name = "txtEmployeeName";
			// 
			// txtSales
			// 
			this.txtSales.CanGrow = false;
			this.txtSales.DataField = "Sales";
			resources.ApplyResources(this.txtSales, "txtSales");
			this.txtSales.Name = "txtSales";
			// 
			// lblTitle
			// 
			resources.ApplyResources(this.lblTitle, "lblTitle");
			this.lblTitle.Name = "lblTitle";
			// 
			// lblTotalSales
			// 
			resources.ApplyResources(this.lblTotalSales, "lblTotalSales");
			this.lblTotalSales.Name = "lblTotalSales";
			// 
			// lblDate
			// 
			resources.ApplyResources(this.lblDate, "lblDate");
			this.lblDate.Name = "lblDate";
			// 
			// txtTotalSales
			// 
			this.txtTotalSales.CanGrow = false;
			this.txtTotalSales.DataField = "Sales";
			resources.ApplyResources(this.txtTotalSales, "txtTotalSales");
			this.txtTotalSales.Name = "txtTotalSales";
			this.txtTotalSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal;
			// 
			// chtSales
			// 
			this.chtSales.AutoRefresh = true;
			this.chtSales.Backdrop = new GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.White, System.Drawing.Color.Black);
			axis1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Both;
			axis1.AxisType = GrapeCity.ActiveReports.Chart.AxisType.Categorical;
			axis1.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, new System.Drawing.Font("Arial", 9F), -50F);
			axis1.LabelsGap = 0;
			axis1.Line = new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None);
			axis1.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 3), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 3, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 1D, 0F, false);
			axis1.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis1.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.White, new System.Drawing.Font("Arial", 10F));
			axis2.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis2.LabelsGap = 0;
			axis2.LabelsVisible = false;
			axis2.Line = new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None);
			axis2.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis2.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis2.Position = 0D;
			axis2.TickOffset = 0D;
			axis2.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis2.Visible = false;
			axis3.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis3.LabelsGap = 0;
			axis3.LabelsVisible = false;
			axis3.Line = new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Black, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None);
			axis3.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, true);
			axis3.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis3.Position = 0D;
			axis3.SmartLabels = false;
			axis3.TickOffset = 0D;
			axis3.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F), 90F);
			axis4.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis4.LabelsGap = 0;
			axis4.LabelsVisible = false;
			axis4.Line = new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None);
			axis4.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis4.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
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
			chartArea1.Light = new GrapeCity.ActiveReports.Chart.Light(new GrapeCity.ActiveReports.Chart.Graphics.Point3d(10F, 40F, 20F), GrapeCity.ActiveReports.Chart.LightType.InfiniteDirectional, 0.37F);
			chartArea1.Name = "defaultArea";
			chartArea1.Projection = new GrapeCity.ActiveReports.Chart.Projection(GrapeCity.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0.3F, 0.3F);
			chartArea1.WallXY = new GrapeCity.ActiveReports.Chart.PlaneItem(new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched));
			chartArea1.WallXZ = new GrapeCity.ActiveReports.Chart.PlaneItem(new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.Gray));
			chartArea1.WallYZ = new GrapeCity.ActiveReports.Chart.PlaneItem(new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, GrapeCity.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched));
			chartArea1.ZDepthRatio = 0.4F;
			this.chtSales.ChartAreas.AddRange(new GrapeCity.ActiveReports.Chart.ChartArea[] {
			chartArea1});
			this.chtSales.ChartBorder = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			this.chtSales.ColorPalette = GrapeCity.ActiveReports.Chart.ColorPalette.Confetti;
			oleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\NWIND.MDB;Persist Security Info=False";
			oleDBDataSource1.SQL = resources.GetString("oleDBDataSource1.SQL");
			this.chtSales.DataSource = oleDBDataSource1;
			resources.ApplyResources(this.chtSales, "chtSales");
			this.chtSales.ImageType = GrapeCity.ActiveReports.SectionReportModel.ImageTypes.PNG;
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
			title2.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 2), 0, System.Drawing.Color.Black);
			title2.DockArea = null;
			title2.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			title2.Name = "";
			title2.Text = "Legend";
			legend1.Header = title2;
			legend1.LabelsFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			legend1.Name = "defaultLegend";
			legend1.Visible = false;
			this.chtSales.Legends.AddRange(new GrapeCity.ActiveReports.Chart.Legend[] {
			legend1});
			this.chtSales.Name = "chtSales";
			series1.AxisX = axis1;
			series1.AxisY = axis3;
			series1.ChartArea = chartArea1;
			series1.Legend = legend1;
			series1.Name = "Series1";
			series1.Properties = new GrapeCity.ActiveReports.Chart.CustomProperties(new GrapeCity.ActiveReports.Chart.KeyValuePair[] {
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Backdrop", new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.Red, System.Drawing.Color.Gray)),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("BorderLine", new GrapeCity.ActiveReports.Chart.Graphics.Line()),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Marker", new GrapeCity.ActiveReports.Chart.Marker(10, GrapeCity.ActiveReports.Chart.MarkerStyle.None, new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(), new GrapeCity.ActiveReports.Chart.Graphics.Line(), new GrapeCity.ActiveReports.Chart.LabelInfo(new GrapeCity.ActiveReports.Chart.Graphics.Line(), new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.White, ((byte)(200))), new GrapeCity.ActiveReports.Chart.FontInfo(), "{Value:C}", GrapeCity.ActiveReports.Chart.Alignment.Top), GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Both)),
			new GrapeCity.ActiveReports.Chart.KeyValuePair("Tooltip", new GrapeCity.ActiveReports.Chart.LabelInfo())});
			series1.Type = GrapeCity.ActiveReports.Chart.ChartType.Bar3D;
			series1.ValueMembersY = "Sales";
			series1.ValueMemberX = "EmployeeName";
			this.chtSales.Series.AddRange(new GrapeCity.ActiveReports.Chart.Series[] {
			series1});
			title3.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center;
			title3.Backdrop = new GrapeCity.ActiveReports.Chart.Graphics.Backdrop(System.Drawing.Color.White, ((byte)(81)));
			title3.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			title3.DockArea = chartArea1;
			title3.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold));
			title3.Name = "header";
			title3.Text = "Sales by Employee for 1997";
			title4.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			title4.DockArea = chartArea1;
			title4.Docking = GrapeCity.ActiveReports.Chart.DockType.Bottom;
			title4.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			title4.Name = "Title1";
			title4.Text = "";
			this.chtSales.Titles.AddRange(new GrapeCity.ActiveReports.Chart.Title[] {
			title3,
			title4});
			this.chtSales.UIOptions = GrapeCity.ActiveReports.Chart.UIOptions.ForceHitTesting;
			// 
			// lblEmployeeName
			// 
			resources.ApplyResources(this.lblEmployeeName, "lblEmployeeName");
			this.lblEmployeeName.Name = "lblEmployeeName";
			// 
			// lblSales
			// 
			resources.ApplyResources(this.lblSales, "lblSales");
			this.lblSales.Name = "lblSales";
			// 
			// Detail
			// 
			this.Detail.CanGrow = false;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtEmployeeName,
			this.txtSales});
			this.Detail.Height = 0.2076389F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// ReportHeader
			// 
			this.ReportHeader.CanGrow = false;
			this.ReportHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblTitle,
			this.lblTotalSales,
			this.lblDate,
			this.txtTotalSales,
			this.chtSales});
			this.ReportHeader.Height = 3.9375F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// ReportFooter
			// 
			this.ReportFooter.CanGrow = false;
			this.ReportFooter.Height = 0F;
			this.ReportFooter.KeepTogether = true;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.GroupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblEmployeeName,
			this.lblSales});
			this.GroupHeader1.Name = "GroupHeader1";
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Height = 0F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// EmployeeSales
			// 
			this.MasterReport = false;
			oleDBDataSource2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\NWIND.MDB;Persist Security Info=False";
			oleDBDataSource2.SQL = resources.GetString("oleDBDataSource2.SQL");
			this.DataSource = oleDBDataSource2;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.5F;
			this.Script = resources.GetString("$this.Script");
			this.Sections.Add(this.ReportHeader);
			this.Sections.Add(this.GroupHeader1);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.Sections.Add(this.ReportFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
			"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.EmployeeSales_ReportStart);
			((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotalSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chtSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblEmployeeName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		public GrapeCity.ActiveReports.Data.OleDBDataSource ds;
		private ReportHeader ReportHeader;
		private Label lblTitle;
		private Label lblTotalSales;
		private Label lblDate;
		private TextBox txtTotalSales;
		private ChartControl chtSales;
		private GroupHeader GroupHeader1;
		private Label lblEmployeeName;
		private Label lblSales;
		private Detail Detail;
		private TextBox txtEmployeeName;
		private TextBox txtSales;
		private GroupFooter GroupFooter1;
		private ReportFooter ReportFooter;
	}
}
