namespace GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Reports
{
	/// <summary>
	/// Summary description for OrderReport.
	/// </summary>
	partial class OrderReport
	{
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
			}
			base.Dispose(disposing);
		}
		#region ActiveReport Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(OrderReport));
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
			this.detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.reportHeader1 = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
			this.reportFooter1 = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
			this.groupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.groupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			this.lblOrId = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblOrdDt = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblRqDt = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblshpdate = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblShpVia = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblfreight = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.txtOrderID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtRequiredDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtOrderDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtShippedDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtShipVia = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtFreight = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.chartControl1 = new GrapeCity.ActiveReports.SectionReportModel.ChartControl();
			// 
			// detail
			// 
			this.detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
			this.detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtOrderID,
			this.txtRequiredDate,
			this.txtOrderDate,
			this.txtShippedDate,
			this.txtShipVia,
			this.txtFreight});
			this.detail.Height = 0.375F;
			this.detail.Name = "detail";
			// 
			// reportHeader1
			// 
			this.reportHeader1.Height = 0F;
			this.reportHeader1.Name = "reportHeader1";
			// 
			// reportFooter1
			// 
			this.reportFooter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
			this.reportFooter1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.chartControl1});
			this.reportFooter1.Height = 3.114083F;
			this.reportFooter1.Name = "reportFooter1";
			this.reportFooter1.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.Before;
			// 
			// groupHeader1
			// 
			this.groupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblOrId,
			this.lblOrdDt,
			this.lblRqDt,
			this.lblshpdate,
			this.lblShpVia,
			this.lblfreight,
			this.line1});
			this.groupHeader1.DataField = "0";
			this.groupHeader1.Height = 0.2395834F;
			this.groupHeader1.Name = "groupHeader1";
			this.groupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage;
			// 
			// groupFooter1
			// 
			this.groupFooter1.Height = 0F;
			this.groupFooter1.Name = "groupFooter1";
			// 
			// lblOrId
			// 
			this.lblOrId.Height = 0.2F;
			this.lblOrId.HyperLink = null;
			this.lblOrId.Left = 0.048F;
			this.lblOrId.Name = "lblOrId";
			this.lblOrId.Style = "font-weight: bold; text-align: right";
			this.lblOrId.Text = "Order ID";
			this.lblOrId.Top = 0.025F;
			this.lblOrId.Width = 1F;
			// 
			// lblOrdDt
			// 
			this.lblOrdDt.Height = 0.2F;
			this.lblOrdDt.HyperLink = null;
			this.lblOrdDt.Left = 1.088F;
			this.lblOrdDt.Name = "lblOrdDt";
			this.lblOrdDt.Style = "font-weight: bold; text-align: right";
			this.lblOrdDt.Text = "Order Date";
			this.lblOrdDt.Top = 0.025F;
			this.lblOrdDt.Width = 1F;
			// 
			// lblRqDt
			// 
			this.lblRqDt.Height = 0.2F;
			this.lblRqDt.HyperLink = null;
			this.lblRqDt.Left = 2.117F;
			this.lblRqDt.Name = "lblRqDt";
			this.lblRqDt.Style = "font-weight: bold; text-align: right";
			this.lblRqDt.Text = "Rqd Date";
			this.lblRqDt.Top = 0.025F;
			this.lblRqDt.Width = 1F;
			// 
			// lblshpdate
			// 
			this.lblshpdate.Height = 0.2F;
			this.lblshpdate.HyperLink = null;
			this.lblshpdate.Left = 3.151F;
			this.lblshpdate.Name = "lblshpdate";
			this.lblshpdate.Style = "font-weight: bold; text-align: right";
			this.lblshpdate.Text = "Shipped Date";
			this.lblshpdate.Top = 0.025F;
			this.lblshpdate.Width = 1F;
			// 
			// lblShpVia
			// 
			this.lblShpVia.Height = 0.2F;
			this.lblShpVia.HyperLink = null;
			this.lblShpVia.Left = 4.178F;
			this.lblShpVia.Name = "lblShpVia";
			this.lblShpVia.Style = "font-weight: bold; text-align: right";
			this.lblShpVia.Text = "Ship Via";
			this.lblShpVia.Top = 0.025F;
			this.lblShpVia.Width = 1F;
			// 
			// lblfreight
			// 
			this.lblfreight.Height = 0.2F;
			this.lblfreight.HyperLink = null;
			this.lblfreight.Left = 5.211F;
			this.lblfreight.Name = "lblfreight";
			this.lblfreight.Style = "font-weight: bold; text-align: right";
			this.lblfreight.Text = "Freight";
			this.lblfreight.Top = 0.025F;
			this.lblfreight.Width = 1F;
			// 
			// line1
			// 
			this.line1.Height = 0F;
			this.line1.Left = 0F;
			this.line1.LineWeight = 3F;
			this.line1.Name = "line1";
			this.line1.Top = 0.225F;
			this.line1.Width = 6.75F;
			this.line1.X1 = 0F;
			this.line1.X2 = 6.75F;
			this.line1.Y1 = 0.225F;
			this.line1.Y2 = 0.225F;
			// 
			// txtOrderID
			// 
			this.txtOrderID.DataField = "OrderID";
			this.txtOrderID.Height = 0.2F;
			this.txtOrderID.Left = 0.048F;
			this.txtOrderID.Name = "txtOrderID";
			this.txtOrderID.Style = "text-align: right";
			this.txtOrderID.Text = "OrderID";
			this.txtOrderID.Top = 0.095F;
			this.txtOrderID.Width = 1F;
			// 
			// txtRequiredDate
			// 
			this.txtRequiredDate.DataField = "RequiredDate";
			this.txtRequiredDate.Height = 0.2F;
			this.txtRequiredDate.Left = 2.111F;
			this.txtRequiredDate.Name = "txtRequiredDate";
			this.txtRequiredDate.Style = "text-align: right";
			this.txtRequiredDate.Text = "RequiredDate";
			this.txtRequiredDate.Top = 0.095F;
			this.txtRequiredDate.Width = 1F;
			// 
			// txtOrderDate
			// 
			this.txtOrderDate.DataField = "OrderDate";
			this.txtOrderDate.Height = 0.2F;
			this.txtOrderDate.Left = 1.088F;
			this.txtOrderDate.Name = "txtOrderDate";
			this.txtOrderDate.Style = "text-align: right";
			this.txtOrderDate.Text = "OrderDate";
			this.txtOrderDate.Top = 0.095F;
			this.txtOrderDate.Width = 1F;
			// 
			// txtShippedDate
			// 
			this.txtShippedDate.DataField = "ShippedDate";
			this.txtShippedDate.Height = 0.2F;
			this.txtShippedDate.Left = 3.145F;
			this.txtShippedDate.Name = "txtShippedDate";
			this.txtShippedDate.Style = "text-align: right";
			this.txtShippedDate.Text = "ShippedDate";
			this.txtShippedDate.Top = 0.095F;
			this.txtShippedDate.Width = 1F;
			// 
			// txtShipVia
			// 
			this.txtShipVia.DataField = "ShipVia";
			this.txtShipVia.Height = 0.2F;
			this.txtShipVia.Left = 4.182F;
			this.txtShipVia.Name = "txtShipVia";
			this.txtShipVia.Style = "text-align: right";
			this.txtShipVia.Text = "ShipVia";
			this.txtShipVia.Top = 0.095F;
			this.txtShipVia.Width = 1F;
			// 
			// txtFreight
			// 
			this.txtFreight.DataField = "Freight";
			this.txtFreight.Height = 0.2F;
			this.txtFreight.Left = 5.207F;
			this.txtFreight.Name = "txtFreight";
			this.txtFreight.OutputFormat = resources.GetString("txtFreight.OutputFormat");
			this.txtFreight.Style = "text-align: right";
			this.txtFreight.Text = "Freight";
			this.txtFreight.Top = 0.095F;
			this.txtFreight.Width = 1F;
			// 
			// chartControl1
			// 
			this.chartControl1.AutoRefresh = true;
			this.chartControl1.Backdrop = new GrapeCity.ActiveReports.Chart.BackdropItem(GrapeCity.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.White, System.Drawing.Color.SteelBlue);
			chartArea1.AntiAliasMode = GrapeCity.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics;
			axis1.AxisType = GrapeCity.ActiveReports.Chart.AxisType.Categorical;
			axis1.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F), -45F);
			axis1.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 1D, 0F, false);
			axis1.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis1.SmartLabels = false;
			axis1.Title = "Ship Date";
			axis1.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))), new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold));
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
			axis3.LabelFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			axis3.MajorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis3.MinorTick = new GrapeCity.ActiveReports.Chart.Tick(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
			axis3.Position = 0D;
			axis3.Title = "Freight ($)";
			axis3.TitleFont = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))), new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold), -90F);
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
			chartArea1.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			chartArea1.Light = new GrapeCity.ActiveReports.Chart.Light(new GrapeCity.ActiveReports.Chart.Graphics.Point3d(10F, 40F, 20F), GrapeCity.ActiveReports.Chart.LightType.InfiniteDirectional, 0.3F);
			chartArea1.Name = "defaultArea";
			chartArea1.Projection = new GrapeCity.ActiveReports.Chart.Projection(GrapeCity.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0.1F, 0.1F);
			this.chartControl1.ChartAreas.AddRange(new GrapeCity.ActiveReports.Chart.ChartArea[] {
			chartArea1});
			this.chartControl1.ChartBorder = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			this.chartControl1.ColorPalette = GrapeCity.ActiveReports.Chart.ColorPalette.Springtime;
			this.chartControl1.Height = 2.625F;
			this.chartControl1.Left = 0.187F;
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
			this.chartControl1.Legends.AddRange(new GrapeCity.ActiveReports.Chart.Legend[] {
			legend1});
			this.chartControl1.Name = "chartControl1";
			series1.AxisX = axis1;
			series1.AxisY = axis3;
			series1.ChartArea = chartArea1;
			series1.Legend = null;
			series1.LegendText = "";
			series1.Name = "Series1";
			series1.Type = GrapeCity.ActiveReports.Chart.ChartType.Bar2D;
			this.chartControl1.Series.AddRange(new GrapeCity.ActiveReports.Chart.Series[] {
			series1});
			title3.Alignment = GrapeCity.ActiveReports.Chart.Alignment.Center;
			title3.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			title3.DockArea = null;
			title3.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold));
			title3.Name = "header";
			title3.Text = "Frieght By Date";
			title4.Border = new GrapeCity.ActiveReports.Chart.Border(new GrapeCity.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, GrapeCity.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
			title4.DockArea = null;
			title4.Docking = GrapeCity.ActiveReports.Chart.DockType.Bottom;
			title4.Font = new GrapeCity.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
			title4.Name = "footer";
			title4.Text = "";
			this.chartControl1.Titles.AddRange(new GrapeCity.ActiveReports.Chart.Title[] {
			title3,
			title4});
			this.chartControl1.Top = 0.489F;
			this.chartControl1.Width = 6.313001F;
			// 
			// OrderReport
			// 
			this.MasterReport = false;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.75F;
			this.Sections.Add(this.reportHeader1);
			this.Sections.Add(this.groupHeader1);
			this.Sections.Add(this.detail);
			this.Sections.Add(this.groupFooter1);
			this.Sections.Add(this.reportFooter1);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
						"lic", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
			this.ReportStart += new System.EventHandler(this.OrderReport_ReportStart);			
		}
		#endregion
		private SectionReportModel.Detail detail;
		private SectionReportModel.TextBox txtOrderID;
		private SectionReportModel.TextBox txtRequiredDate;
		private SectionReportModel.TextBox txtOrderDate;
		private SectionReportModel.TextBox txtShippedDate;
		private SectionReportModel.TextBox txtShipVia;
		private SectionReportModel.TextBox txtFreight;
		private SectionReportModel.ReportHeader reportHeader1;
		private SectionReportModel.ReportFooter reportFooter1;
		private SectionReportModel.ChartControl chartControl1;
		private SectionReportModel.GroupHeader groupHeader1;
		private SectionReportModel.Label lblOrId;
		private SectionReportModel.Label lblOrdDt;
		private SectionReportModel.Label lblRqDt;
		private SectionReportModel.Label lblshpdate;
		private SectionReportModel.Label lblShpVia;
		private SectionReportModel.Label lblfreight;
		private SectionReportModel.Line line1;
		private SectionReportModel.GroupFooter groupFooter1;
	}
}
