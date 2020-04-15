using System;
using System.Drawing;
using System.ComponentModel;
using System.Collections;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.CrossTabReport
{
	public partial class ProductWeeklySales
	{
	  
		#region Windows Form Designer generated code
	   
	   
		
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductWeeklySales));
			this.txtDetProduct = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtDetUnits = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtDetSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtDetOrderDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Shape1 = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.lblTitle1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTitle2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTitleLine = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lblReportDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.imgLogoSm = new GrapeCity.ActiveReports.SectionReportModel.Picture();
			this.lblNorthWind = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTraders = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Shape2 = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.lblCategory = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProduct = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblCurrentWeek = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblMTD = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblQTD = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblYTD = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblPrevQTD = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblWkUnits = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblWkSales = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblMTDUnits = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblMTDSales = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblQTDUnits = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblQTDSales = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblYTDUnits = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblYTDSales = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblPQTDSales = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblPQTDChange = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtCategoryName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.txtCatWkUnits = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCAtWkSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCatMTDUnits = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCatMTDSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCatQTDUnits = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCatQTDSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCatYTDUnits = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCatYTDSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCatPQTDSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtCatPQTDChange = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.txtProduct = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtWkUnits = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtWkSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtMTDUnits = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtMTDSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtQTDUnits = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtQTDSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtYTDUnits = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtYTDSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtPQTDSales = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtPQTDChange = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.ReportHeader = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
			this.ReportFooter = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.ghCategory = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.gfCategory = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			this.ghProduct = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.gfProduct = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
		   
			// 
			// txtDetProduct
			// 
			this.txtDetProduct.CanGrow = false;
			resources.ApplyResources(this.txtDetProduct, "txtDetProduct");
			this.txtDetProduct.DataField = "ProductName";
			this.txtDetProduct.Name = "txtDetProduct";
			// 
			// txtDetUnits
			// 
			this.txtDetUnits.CanGrow = false;
			resources.ApplyResources(this.txtDetUnits, "txtDetUnits");
			this.txtDetUnits.DataField = "ProductUnits";
			this.txtDetUnits.Name = "txtDetUnits";
			// 
			// txtDetSales
			// 
			this.txtDetSales.CanGrow = false;
			resources.ApplyResources(this.txtDetSales, "txtDetSales");
			this.txtDetSales.DataField = "ProductSales";
			this.txtDetSales.Name = "txtDetSales";
			// 
			// txtDetOrderDate
			// 
			this.txtDetOrderDate.CanGrow = false;
			resources.ApplyResources(this.txtDetOrderDate, "txtDetOrderDate");
			this.txtDetOrderDate.DataField = "OrderDate";
			this.txtDetOrderDate.Name = "txtDetOrderDate";
			// 
			// Shape1
			// 
			this.Shape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.Shape1, "Shape1");
			this.Shape1.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Transparent;
			this.Shape1.Name = "Shape1";
			this.Shape1.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, null, null, null, null);
			// 
			// lblTitle1
			// 
			resources.ApplyResources(this.lblTitle1, "lblTitle1");
			this.lblTitle1.Name = "lblTitle1";
			// 
			// lblTitle2
			// 
			resources.ApplyResources(this.lblTitle2, "lblTitle2");
			this.lblTitle2.Name = "lblTitle2";
			// 
			// lblTitleLine
			// 
			resources.ApplyResources(this.lblTitleLine, "lblTitleLine");
			this.lblTitleLine.LineWeight = 2F;
			this.lblTitleLine.Name = "lblTitleLine";
			this.lblTitleLine.X1 = 0.0625F;
			this.lblTitleLine.X2 = 5.9375F;
			this.lblTitleLine.Y1 = 0.6875F;
			this.lblTitleLine.Y2 = 0.6875F;
			// 
			// lblReportDate
			// 
			resources.ApplyResources(this.lblReportDate, "lblReportDate");
			this.lblReportDate.Name = "lblReportDate";
			// 
			// imgLogoSm
			// 
			this.imgLogoSm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.imgLogoSm, "imgLogoSm");
			this.imgLogoSm.ImageData = ((System.IO.Stream)(resources.GetObject("imgLogoSm.ImageData")));
			this.imgLogoSm.LineColor = System.Drawing.Color.Black;
			this.imgLogoSm.LineWeight = 1F;
			this.imgLogoSm.Name = "imgLogoSm";
			// 
			// lblNorthWind
			// 
			resources.ApplyResources(this.lblNorthWind, "lblNorthWind");
			this.lblNorthWind.Name = "lblNorthWind";
			// 
			// lblTraders
			// 
			resources.ApplyResources(this.lblTraders, "lblTraders");
			this.lblTraders.Name = "lblTraders";
			// 
			// Shape2
			// 
			this.Shape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			resources.ApplyResources(this.Shape2, "Shape2");
			this.Shape2.Name = "Shape2";
			this.Shape2.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, null, null, null, null);
			// 
			// lblCategory
			// 
			resources.ApplyResources(this.lblCategory, "lblCategory");
			this.lblCategory.Name = "lblCategory";
			// 
			// lblProduct
			// 
			resources.ApplyResources(this.lblProduct, "lblProduct");
			this.lblProduct.Name = "lblProduct";
			// 
			// lblCurrentWeek
			// 
			resources.ApplyResources(this.lblCurrentWeek, "lblCurrentWeek");
			this.lblCurrentWeek.Name = "lblCurrentWeek";
			// 
			// lblMTD
			// 
			resources.ApplyResources(this.lblMTD, "lblMTD");
			this.lblMTD.Name = "lblMTD";
			// 
			// lblQTD
			// 
			resources.ApplyResources(this.lblQTD, "lblQTD");
			this.lblQTD.Name = "lblQTD";
			// 
			// lblYTD
			// 
			resources.ApplyResources(this.lblYTD, "lblYTD");
			this.lblYTD.Name = "lblYTD";
			// 
			// lblPrevQTD
			// 
			resources.ApplyResources(this.lblPrevQTD, "lblPrevQTD");
			this.lblPrevQTD.Name = "lblPrevQTD";
			// 
			// lblWkUnits
			// 
			resources.ApplyResources(this.lblWkUnits, "lblWkUnits");
			this.lblWkUnits.Name = "lblWkUnits";
			// 
			// lblWkSales
			// 
			resources.ApplyResources(this.lblWkSales, "lblWkSales");
			this.lblWkSales.Name = "lblWkSales";
			// 
			// lblMTDUnits
			// 
			resources.ApplyResources(this.lblMTDUnits, "lblMTDUnits");
			this.lblMTDUnits.Name = "lblMTDUnits";
			// 
			// lblMTDSales
			// 
			resources.ApplyResources(this.lblMTDSales, "lblMTDSales");
			this.lblMTDSales.Name = "lblMTDSales";
			// 
			// lblQTDUnits
			// 
			resources.ApplyResources(this.lblQTDUnits, "lblQTDUnits");
			this.lblQTDUnits.Name = "lblQTDUnits";
			// 
			// lblQTDSales
			// 
			resources.ApplyResources(this.lblQTDSales, "lblQTDSales");
			this.lblQTDSales.Name = "lblQTDSales";
			// 
			// lblYTDUnits
			// 
			resources.ApplyResources(this.lblYTDUnits, "lblYTDUnits");
			this.lblYTDUnits.Name = "lblYTDUnits";
			// 
			// lblYTDSales
			// 
			resources.ApplyResources(this.lblYTDSales, "lblYTDSales");
			this.lblYTDSales.Name = "lblYTDSales";
			// 
			// lblPQTDSales
			// 
			resources.ApplyResources(this.lblPQTDSales, "lblPQTDSales");
			this.lblPQTDSales.Name = "lblPQTDSales";
			// 
			// lblPQTDChange
			// 
			resources.ApplyResources(this.lblPQTDChange, "lblPQTDChange");
			this.lblPQTDChange.Name = "lblPQTDChange";
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.CanGrow = false;
			resources.ApplyResources(this.txtCategoryName, "txtCategoryName");
			this.txtCategoryName.DataField = "CategoryName";
			this.txtCategoryName.Name = "txtCategoryName";
			// 
			// Line1
			// 
			resources.ApplyResources(this.Line1, "Line1");
			this.Line1.LineWeight = 3F;
			this.Line1.Name = "Line1";
			this.Line1.X1 = 1.625F;
			this.Line1.X2 = 9.9375F;
			this.Line1.Y1 = 0F;
			this.Line1.Y2 = 0F;
			// 
			// txtCatWkUnits
			// 
			this.txtCatWkUnits.CanGrow = false;
			resources.ApplyResources(this.txtCatWkUnits, "txtCatWkUnits");
			this.txtCatWkUnits.DataField = "WkUnits";
			this.txtCatWkUnits.Name = "txtCatWkUnits";
			this.txtCatWkUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtCAtWkSales
			// 
			this.txtCAtWkSales.CanGrow = false;
			resources.ApplyResources(this.txtCAtWkSales, "txtCAtWkSales");
			this.txtCAtWkSales.DataField = "WkSales";
			this.txtCAtWkSales.Name = "txtCAtWkSales";
			this.txtCAtWkSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtCatMTDUnits
			// 
			this.txtCatMTDUnits.CanGrow = false;
			resources.ApplyResources(this.txtCatMTDUnits, "txtCatMTDUnits");
			this.txtCatMTDUnits.DataField = "MTDUnits";
			this.txtCatMTDUnits.Name = "txtCatMTDUnits";
			this.txtCatMTDUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtCatMTDSales
			// 
			this.txtCatMTDSales.CanGrow = false;
			resources.ApplyResources(this.txtCatMTDSales, "txtCatMTDSales");
			this.txtCatMTDSales.DataField = "MTDSales";
			this.txtCatMTDSales.Name = "txtCatMTDSales";
			this.txtCatMTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtCatQTDUnits
			// 
			this.txtCatQTDUnits.CanGrow = false;
			resources.ApplyResources(this.txtCatQTDUnits, "txtCatQTDUnits");
			this.txtCatQTDUnits.DataField = "QTDUnits";
			this.txtCatQTDUnits.Name = "txtCatQTDUnits";
			this.txtCatQTDUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtCatQTDSales
			// 
			this.txtCatQTDSales.CanGrow = false;
			resources.ApplyResources(this.txtCatQTDSales, "txtCatQTDSales");
			this.txtCatQTDSales.DataField = "QTDSales";
			this.txtCatQTDSales.Name = "txtCatQTDSales";
			this.txtCatQTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtCatYTDUnits
			// 
			this.txtCatYTDUnits.CanGrow = false;
			resources.ApplyResources(this.txtCatYTDUnits, "txtCatYTDUnits");
			this.txtCatYTDUnits.DataField = "YTDUnits";
			this.txtCatYTDUnits.Name = "txtCatYTDUnits";
			this.txtCatYTDUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtCatYTDSales
			// 
			this.txtCatYTDSales.CanGrow = false;
			resources.ApplyResources(this.txtCatYTDSales, "txtCatYTDSales");
			this.txtCatYTDSales.DataField = "YTDSales";
			this.txtCatYTDSales.Name = "txtCatYTDSales";
			this.txtCatYTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtCatPQTDSales
			// 
			this.txtCatPQTDSales.CanGrow = false;
			resources.ApplyResources(this.txtCatPQTDSales, "txtCatPQTDSales");
			this.txtCatPQTDSales.DataField = "PQTDSales";
			this.txtCatPQTDSales.Name = "txtCatPQTDSales";
			this.txtCatPQTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtCatPQTDChange
			// 
			this.txtCatPQTDChange.CanGrow = false;
			resources.ApplyResources(this.txtCatPQTDChange, "txtCatPQTDChange");
			this.txtCatPQTDChange.Name = "txtCatPQTDChange";
			// 
			// Line2
			// 
			resources.ApplyResources(this.Line2, "Line2");
			this.Line2.LineWeight = 3F;
			this.Line2.Name = "Line2";
			this.Line2.X1 = 0F;
			this.Line2.X2 = 9.9375F;
			this.Line2.Y1 = 0.25F;
			this.Line2.Y2 = 0.25F;
			// 
			// txtProduct
			// 
			resources.ApplyResources(this.txtProduct, "txtProduct");
			this.txtProduct.Name = "txtProduct";
			// 
			// txtWkUnits
			// 
			this.txtWkUnits.CanGrow = false;
			resources.ApplyResources(this.txtWkUnits, "txtWkUnits");
			this.txtWkUnits.DataField = "WkUnits";
			this.txtWkUnits.Name = "txtWkUnits";
			this.txtWkUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtWkSales
			// 
			this.txtWkSales.CanGrow = false;
			resources.ApplyResources(this.txtWkSales, "txtWkSales");
			this.txtWkSales.DataField = "WkSales";
			this.txtWkSales.Name = "txtWkSales";
			this.txtWkSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtMTDUnits
			// 
			this.txtMTDUnits.CanGrow = false;
			resources.ApplyResources(this.txtMTDUnits, "txtMTDUnits");
			this.txtMTDUnits.DataField = "MTDUnits";
			this.txtMTDUnits.Name = "txtMTDUnits";
			this.txtMTDUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtMTDSales
			// 
			this.txtMTDSales.CanGrow = false;
			resources.ApplyResources(this.txtMTDSales, "txtMTDSales");
			this.txtMTDSales.DataField = "MTDSales";
			this.txtMTDSales.Name = "txtMTDSales";
			this.txtMTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtQTDUnits
			// 
			this.txtQTDUnits.CanGrow = false;
			resources.ApplyResources(this.txtQTDUnits, "txtQTDUnits");
			this.txtQTDUnits.DataField = "QTDUnits";
			this.txtQTDUnits.Name = "txtQTDUnits";
			this.txtQTDUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtQTDSales
			// 
			this.txtQTDSales.CanGrow = false;
			resources.ApplyResources(this.txtQTDSales, "txtQTDSales");
			this.txtQTDSales.DataField = "QTDSales";
			this.txtQTDSales.Name = "txtQTDSales";
			this.txtQTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtYTDUnits
			// 
			this.txtYTDUnits.CanGrow = false;
			resources.ApplyResources(this.txtYTDUnits, "txtYTDUnits");
			this.txtYTDUnits.DataField = "YTDUnits";
			this.txtYTDUnits.Name = "txtYTDUnits";
			this.txtYTDUnits.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtYTDSales
			// 
			this.txtYTDSales.CanGrow = false;
			resources.ApplyResources(this.txtYTDSales, "txtYTDSales");
			this.txtYTDSales.DataField = "YTDSales";
			this.txtYTDSales.Name = "txtYTDSales";
			this.txtYTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtPQTDSales
			// 
			this.txtPQTDSales.CanGrow = false;
			resources.ApplyResources(this.txtPQTDSales, "txtPQTDSales");
			this.txtPQTDSales.DataField = "PQTDSales";
			this.txtPQTDSales.Name = "txtPQTDSales";
			this.txtPQTDSales.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtPQTDChange
			// 
			this.txtPQTDChange.CanGrow = false;
			resources.ApplyResources(this.txtPQTDChange, "txtPQTDChange");
			this.txtPQTDChange.Name = "txtPQTDChange";
			// 
			// Line3
			// 
			resources.ApplyResources(this.Line3, "Line3");
			this.Line3.LineWeight = 1F;
			this.Line3.Name = "Line3";
			this.Line3.X1 = 1.625F;
			this.Line3.X2 = 9.9375F;
			this.Line3.Y1 = 0.201F;
			this.Line3.Y2 = 0.201F;
			// 
			// Detail
			// 
			this.Detail.CanGrow = false;
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtDetProduct,
			this.txtDetUnits,
			this.txtDetSales,
			this.txtDetOrderDate});
			this.Detail.Height = 0F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Visible = false;
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// ReportHeader
			// 
			this.ReportHeader.CanGrow = false;
			this.ReportHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.Shape1,
			this.lblTitle1,
			this.lblTitle2,
			this.lblTitleLine,
			this.lblReportDate,
			this.imgLogoSm,
			this.lblNorthWind,
			this.lblTraders});
			this.ReportHeader.Height = 1F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// ReportFooter
			// 
			this.ReportFooter.CanGrow = false;
			this.ReportFooter.Height = 0F;
			this.ReportFooter.KeepTogether = true;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// PageHeader
			// 
			this.PageHeader.CanGrow = false;
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.Shape2,
			this.lblCategory,
			this.lblProduct,
			this.lblCurrentWeek,
			this.lblMTD,
			this.lblQTD,
			this.lblYTD,
			this.lblPrevQTD,
			this.lblWkUnits,
			this.lblWkSales,
			this.lblMTDUnits,
			this.lblMTDSales,
			this.lblQTDUnits,
			this.lblQTDSales,
			this.lblYTDUnits,
			this.lblYTDSales,
			this.lblPQTDSales,
			this.lblPQTDChange});
			this.PageHeader.Height = 0.375F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.CanGrow = false;
			this.PageFooter.Height = 0F;
			this.PageFooter.Name = "PageFooter";
			// 
			// ghCategory
			// 
			this.ghCategory.CanGrow = false;
			this.ghCategory.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtCategoryName});
			this.ghCategory.DataField = "CategoryName";
			this.ghCategory.Height = 0.25F;
			this.ghCategory.KeepTogether = true;
			this.ghCategory.Name = "ghCategory";
			this.ghCategory.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage;
			this.ghCategory.UnderlayNext = true;
			// 
			// gfCategory
			// 
			this.gfCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.gfCategory.CanGrow = false;
			this.gfCategory.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.Line1,
			this.txtCatWkUnits,
			this.txtCAtWkSales,
			this.txtCatMTDUnits,
			this.txtCatMTDSales,
			this.txtCatQTDUnits,
			this.txtCatQTDSales,
			this.txtCatYTDUnits,
			this.txtCatYTDSales,
			this.txtCatPQTDSales,
			this.txtCatPQTDChange,
			this.Line2});
			this.gfCategory.Height = 0.2590278F;
			this.gfCategory.KeepTogether = true;
			this.gfCategory.Name = "gfCategory";
			this.gfCategory.Format += new System.EventHandler(this.gfCategory_Format);
			// 
			// ghProduct
			// 
			this.ghProduct.CanGrow = false;
			this.ghProduct.DataField = "ProductName";
			this.ghProduct.Height = 0F;
			this.ghProduct.KeepTogether = true;
			this.ghProduct.Name = "ghProduct";
			this.ghProduct.Visible = false;
			// 
			// gfProduct
			// 
			this.gfProduct.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProduct,
			this.txtWkUnits,
			this.txtWkSales,
			this.txtMTDUnits,
			this.txtMTDSales,
			this.txtQTDUnits,
			this.txtQTDSales,
			this.txtYTDUnits,
			this.txtYTDSales,
			this.txtPQTDSales,
			this.txtPQTDChange,
			this.Line3});
			this.gfProduct.Height = 0.2076389F;
			this.gfProduct.KeepTogether = true;
			this.gfProduct.Name = "gfProduct";
			this.gfProduct.Format += new System.EventHandler(this.gfProduct_Format);
			// 
			// ProductWeeklySales
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			this.PageSettings.Margins.Bottom = 0.5F;
			this.PageSettings.Margins.Left = 0.5F;
			this.PageSettings.Margins.Right = 0.5F;
			this.PageSettings.Margins.Top = 0.5F;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 9.947917F;
			this.Sections.Add(this.ReportHeader);
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.ghCategory);
			this.Sections.Add(this.ghProduct);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.gfProduct);
			this.Sections.Add(this.gfCategory);
			this.Sections.Add(this.PageFooter);
			this.Sections.Add(this.ReportFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.FetchData += new GrapeCity.ActiveReports.SectionReport.FetchEventHandler(this.ProductWeeklySales_FetchData);
			this.ReportStart += new System.EventHandler(this.ProductWeeklySales_ReportStart);
			this.DataInitialize += new System.EventHandler(this.ProductWeeklySales_DataInitialize);
		   
		}
		#endregion
		private int _iCurrWk;
		private int _iCurrMth;
		private int _iCurrQtr;
		private int _iCurrYr;
		private int _iLastYr;
		private Detail Detail;
		private TextBox txtDetProduct;
		private TextBox txtDetUnits;
		private TextBox txtDetSales;
		private TextBox txtDetOrderDate;
		private ReportHeader ReportHeader;
		private Shape Shape1;
		private Label lblTitle1;
		private Label lblTitle2;
		private Line lblTitleLine;
		private Label lblReportDate;
		private Picture imgLogoSm;
		private Label lblNorthWind;
		private Label lblTraders;
		private ReportFooter ReportFooter;
		private PageHeader PageHeader;
		private Shape Shape2;
		private Label lblCategory;
		private Label lblProduct;
		private Label lblCurrentWeek;
		private Label lblMTD;
		private Label lblQTD;
		private Label lblYTD;
		private Label lblPrevQTD;
		private Label lblWkUnits;
		private Label lblWkSales;
		private Label lblMTDUnits;
		private Label lblMTDSales;
		private Label lblQTDUnits;
		private Label lblQTDSales;
		private Label lblYTDUnits;
		private Label lblYTDSales;
		private Label lblPQTDSales;
		private Label lblPQTDChange;
		private PageFooter PageFooter;
		private GroupHeader ghCategory;
		private TextBox txtCategoryName;
		private GroupFooter gfCategory;
		private Line Line1;
		private TextBox txtCatWkUnits;
		private TextBox txtCAtWkSales;
		private TextBox txtCatMTDUnits;
		private TextBox txtCatMTDSales;
		private TextBox txtCatQTDUnits;
		private TextBox txtCatQTDSales;
		private TextBox txtCatYTDUnits;
		private TextBox txtCatYTDSales;
		private TextBox txtCatPQTDSales;
		private TextBox txtCatPQTDChange;
		private Line Line2;
		private GroupHeader ghProduct;
		private GroupFooter gfProduct;
		private TextBox txtProduct;
		private TextBox txtWkUnits;
		private TextBox txtWkSales;
		private TextBox txtMTDUnits;
		private TextBox txtMTDSales;
		private TextBox txtQTDUnits;
		private TextBox txtQTDSales;
		private TextBox txtYTDUnits;
		private TextBox txtYTDSales;
		private TextBox txtPQTDSales;
		private TextBox txtPQTDChange;
		private Line Line3;
		private string _sProductName;
	}
}
