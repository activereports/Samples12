using System;
using GrapeCity.ActiveReports.SectionReportModel;
using System.Drawing;
using System.ComponentModel;
using System.Collections;
namespace GrapeCity.ActiveReports.Samples.IListBinding
{
	public partial class IlistReportSample
	{
	  
		#region Windows Form Designer generated code
	   
	   
		
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IlistReportSample));
			this.Label10 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label5 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label6 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label7 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label8 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.Label9 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtProductName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtUnitsInStock = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtUnitsOnOrder = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.cbDiscontinued = new GrapeCity.ActiveReports.SectionReportModel.CheckBox();
			this.txtReorderLevel = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtProductId = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtQuantityPerUnit = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtComments = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.ReportHeader = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
			this.GroupHeader1 = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.GroupFooter1 = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			this.ReportFooter = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
		   
			// 
			// Label10
			// 
			resources.ApplyResources(this.Label10, "Label10");
			this.Label10.Name = "Label10";
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			// 
			// Label2
			// 
			this.Label2.Angle = 900;
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.Name = "Label2";
			// 
			// Label3
			// 
			this.Label3.Angle = 900;
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.Name = "Label3";
			// 
			// Label4
			// 
			resources.ApplyResources(this.Label4, "Label4");
			this.Label4.Name = "Label4";
			// 
			// Label5
			// 
			this.Label5.Angle = 900;
			resources.ApplyResources(this.Label5, "Label5");
			this.Label5.Name = "Label5";
			// 
			// Label6
			// 
			this.Label6.Angle = 900;
			resources.ApplyResources(this.Label6, "Label6");
			this.Label6.Name = "Label6";
			// 
			// Label7
			// 
			this.Label7.Angle = 900;
			resources.ApplyResources(this.Label7, "Label7");
			this.Label7.Name = "Label7";
			// 
			// Label8
			// 
			resources.ApplyResources(this.Label8, "Label8");
			this.Label8.Name = "Label8";
			// 
			// Label9
			// 
			resources.ApplyResources(this.Label9, "Label9");
			this.Label9.Name = "Label9";
			// 
			// txtProductName
			// 
			resources.ApplyResources(this.txtProductName, "txtProductName");
			this.txtProductName.DataField = "ProductName";
			this.txtProductName.Name = "txtProductName";
			// 
			// txtUnitPrice
			// 
			resources.ApplyResources(this.txtUnitPrice, "txtUnitPrice");
			this.txtUnitPrice.DataField = "UnitPrice";
			this.txtUnitPrice.Name = "txtUnitPrice";
			// 
			// txtUnitsInStock
			// 
			resources.ApplyResources(this.txtUnitsInStock, "txtUnitsInStock");
			this.txtUnitsInStock.DataField = "UnitsInStock";
			this.txtUnitsInStock.Name = "txtUnitsInStock";
			// 
			// txtUnitsOnOrder
			// 
			resources.ApplyResources(this.txtUnitsOnOrder, "txtUnitsOnOrder");
			this.txtUnitsOnOrder.DataField = "UnitsOnOrder";
			this.txtUnitsOnOrder.Name = "txtUnitsOnOrder";
			// 
			// cbDiscontinued
			// 
			resources.ApplyResources(this.cbDiscontinued, "cbDiscontinued");
			this.cbDiscontinued.DataField = "Discontinued";
			this.cbDiscontinued.Name = "cbDiscontinued";
			// 
			// txtReorderLevel
			// 
			resources.ApplyResources(this.txtReorderLevel, "txtReorderLevel");
			this.txtReorderLevel.DataField = "ReorderLevel";
			this.txtReorderLevel.Name = "txtReorderLevel";
			// 
			// txtProductId
			// 
			resources.ApplyResources(this.txtProductId, "txtProductId");
			this.txtProductId.DataField = "ProductId";
			this.txtProductId.Name = "txtProductId";
			// 
			// txtQuantityPerUnit
			// 
			resources.ApplyResources(this.txtQuantityPerUnit, "txtQuantityPerUnit");
			this.txtQuantityPerUnit.DataField = "QuantityPerUnit";
			this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
			// 
			// txtComments
			// 
			resources.ApplyResources(this.txtComments, "txtComments");
			this.txtComments.Name = "txtComments";
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.Label10});
			this.ReportHeader.Height = 0.4375F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// GroupHeader1
			// 
			this.GroupHeader1.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.Label1,
			this.Label2,
			this.Label3,
			this.Label4,
			this.Label5,
			this.Label6,
			this.Label7,
			this.Label8,
			this.Label9});
			this.GroupHeader1.Height = 1.0625F;
			this.GroupHeader1.Name = "GroupHeader1";
			this.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage;
			// 
			// Detail
			// 
			this.Detail.CanShrink = true;
			this.Detail.ColumnSpacing = 0F;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProductName,
			this.txtUnitPrice,
			this.txtUnitsInStock,
			this.txtUnitsOnOrder,
			this.cbDiscontinued,
			this.txtReorderLevel,
			this.txtProductId,
			this.txtQuantityPerUnit,
			this.txtComments});
			this.Detail.Height = 0.1875F;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			this.ReportStart += IlistReportSample_ReportStart;
			
			// 
			// GroupFooter1
			// 
			this.GroupFooter1.Height = 0F;
			this.GroupFooter1.Name = "GroupFooter1";
			// 
			// ReportFooter
			// 
			this.ReportFooter.Height = 0F;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// IlistReportSample
			// 
			this.MasterReport = false;
			resources.ApplyResources(this, "$this");
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Bottom = 0.45F;
			this.PageSettings.Margins.Left = 0.2F;
			this.PageSettings.Margins.Right = 0.2F;
			this.PageSettings.Margins.Top = 0.5F;
			this.PageSettings.PaperHeight = 11.69291F;
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.PageSettings.PaperWidth = 8.267716F;
			this.PrintWidth = 7.87F;
			this.Sections.Add(this.ReportHeader);
			this.Sections.Add(this.GroupHeader1);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GroupFooter1);
			this.Sections.Add(this.ReportFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
		}
		#endregion
		private ReportHeader ReportHeader;
		private Label Label10;
		private GroupHeader GroupHeader1;
		private Label Label1;
		private Label Label2;
		private Label Label3;
		private Label Label4;
		private Label Label5;
		private Label Label6;
		private Label Label7;
		private Label Label8;
		private Label Label9;
		private Detail Detail;
		private TextBox txtProductName;
		private TextBox txtUnitPrice;
		private TextBox txtUnitsInStock;
		private TextBox txtUnitsOnOrder;
		private CheckBox cbDiscontinued;
		private TextBox txtReorderLevel;
		private TextBox txtProductId;
		private TextBox txtQuantityPerUnit;
		private TextBox txtComments;
		private GroupFooter GroupFooter1;
		private ReportFooter ReportFooter;
	}
}
