using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Document.Section;
namespace GrapeCity.ActiveReports.Samples.ActiveReportsSilverlightViewer.Web
{
	/// <summary>
	/// Summary description for Invoice.
	/// </summary>
	partial class CodeReport 
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
		#region  ActiveReports Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeReport));
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			this.line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.qtyTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.productNameTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.unitPriceTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.totalTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.companyNameLabel = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.invoiceLabel = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.orderDateTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.orderIDTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.orderIDLabel = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.label2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.shape3 = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.pageNoFMReportInfo = new GrapeCity.ActiveReports.SectionReportModel.ReportInfo();
			this.shape1 = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.shippingAddressLabel = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.billingAddressLabel = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.qtyLabel = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.productDescLabel = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.unitPriceLabel = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.totalLabel = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.crossSectionLine1 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
			this.crossSectionLine2 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
			this.crossSectionLine3 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionLine();
			this.line2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.billingAddressTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.shippingAddressTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.shape4 = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.freightLabel = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.freightTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.subTotalLabel = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.subtotalTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.label1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.grandTotalTextBox = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.shape2 = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.line3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.line4 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.crossSectionBox1 = new GrapeCity.ActiveReports.SectionReportModel.CrossSectionBox();
			this.line5 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.customerGroupHeader = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.customerGroupFooter = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			this.BillingAddress = new GrapeCity.ActiveReports.Data.Field();
			this.ShippingAddress = new GrapeCity.ActiveReports.Data.Field();
			this.Total = new GrapeCity.ActiveReports.Data.Field();
			// 
			// line1
			// 
			this.line1.AnchorBottom = true;
			resources.ApplyResources(this.line1, "line1");
			this.line1.LineWeight = 1F;
			this.line1.Name = "line1";
			this.line1.X1 = 0.002F;
			this.line1.X2 = 6.5F;
			this.line1.Y1 = 0.198F;
			this.line1.Y2 = 0.198F;
			// 
			// qtyTextBox
			// 
			resources.ApplyResources(this.qtyTextBox, "qtyTextBox");
			this.qtyTextBox.DataField = "Quantity";
			this.qtyTextBox.Name = "qtyTextBox";
			this.qtyTextBox.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// productNameTextBox
			// 
			resources.ApplyResources(this.productNameTextBox, "productNameTextBox");
			this.productNameTextBox.DataField = "ProductName";
			this.productNameTextBox.Name = "productNameTextBox";
			this.productNameTextBox.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// unitPriceTextBox
			// 
			resources.ApplyResources(this.unitPriceTextBox, "unitPriceTextBox");
			this.unitPriceTextBox.DataField = "UnitPrice";
			this.unitPriceTextBox.Name = "unitPriceTextBox";
			this.unitPriceTextBox.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// totalTextBox
			// 
			resources.ApplyResources(this.totalTextBox, "totalTextBox");
			this.totalTextBox.DataField = "Total";
			this.totalTextBox.Name = "totalTextBox";
			this.totalTextBox.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// companyNameLabel
			// 
			resources.ApplyResources(this.companyNameLabel, "companyNameLabel");
			this.companyNameLabel.Name = "companyNameLabel";
			// 
			// invoiceLabel
			// 
			resources.ApplyResources(this.invoiceLabel, "invoiceLabel");
			this.invoiceLabel.Name = "invoiceLabel";
			// 
			// orderDateTextBox
			// 
			resources.ApplyResources(this.orderDateTextBox, "orderDateTextBox");
			this.orderDateTextBox.DataField = "OrderDate";
			this.orderDateTextBox.Name = "orderDateTextBox";
			this.orderDateTextBox.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// orderIDTextBox
			// 
			resources.ApplyResources(this.orderIDTextBox, "orderIDTextBox");
			this.orderIDTextBox.DataField = "OrderID";
			this.orderIDTextBox.Name = "orderIDTextBox";
			this.orderIDTextBox.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// orderIDLabel
			// 
			resources.ApplyResources(this.orderIDLabel, "orderIDLabel");
			this.orderIDLabel.Name = "orderIDLabel";
			this.orderIDLabel.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			this.label2.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// shape3
			// 
			resources.ApplyResources(this.shape3, "shape3");
			this.shape3.Name = "shape3";
			this.shape3.RoundingRadius = 9.999999F;
			// 
			// pageNoFMReportInfo
			// 
			this.pageNoFMReportInfo.FormatString = "{PageNumber} / {PageCount} ";
			resources.ApplyResources(this.pageNoFMReportInfo, "pageNoFMReportInfo");
			this.pageNoFMReportInfo.Name = "pageNoFMReportInfo";
			// 
			// shape1
			// 
			this.shape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(39)))), ((int)(((byte)(126)))));
			resources.ApplyResources(this.shape1, "shape1");
			this.shape1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(39)))), ((int)(((byte)(126)))));
			this.shape1.Name = "shape1";
			this.shape1.RoundingRadius = 9.999999F;
			// 
			// shippingAddressLabel
			// 
			this.shippingAddressLabel.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.shippingAddressLabel.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.shippingAddressLabel.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.shippingAddressLabel.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.shippingAddressLabel, "shippingAddressLabel");
			this.shippingAddressLabel.Name = "shippingAddressLabel";
			// 
			// billingAddressLabel
			// 
			this.billingAddressLabel.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.billingAddressLabel.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.billingAddressLabel.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.billingAddressLabel.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.billingAddressLabel, "billingAddressLabel");
			this.billingAddressLabel.Name = "billingAddressLabel";
			// 
			// qtyLabel
			// 
			resources.ApplyResources(this.qtyLabel, "qtyLabel");
			this.qtyLabel.Name = "qtyLabel";
			this.qtyLabel.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// productDescLabel
			// 
			resources.ApplyResources(this.productDescLabel, "productDescLabel");
			this.productDescLabel.Name = "productDescLabel";
			this.productDescLabel.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// unitPriceLabel
			// 
			resources.ApplyResources(this.unitPriceLabel, "unitPriceLabel");
			this.unitPriceLabel.Name = "unitPriceLabel";
			this.unitPriceLabel.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// totalLabel
			// 
			resources.ApplyResources(this.totalLabel, "totalLabel");
			this.totalLabel.Name = "totalLabel";
			this.totalLabel.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// crossSectionLine1
			// 
			this.crossSectionLine1.Bottom = 1.192093E-07F;
			resources.ApplyResources(this.crossSectionLine1, "crossSectionLine1");
			this.crossSectionLine1.LineWeight = 1F;
			this.crossSectionLine1.Name = "crossSectionLine1";
			// 
			// crossSectionLine2
			// 
			this.crossSectionLine2.Bottom = 0F;
			resources.ApplyResources(this.crossSectionLine2, "crossSectionLine2");
			this.crossSectionLine2.LineWeight = 1F;
			this.crossSectionLine2.Name = "crossSectionLine2";
			// 
			// crossSectionLine3
			// 
			this.crossSectionLine3.Bottom = 0.5965834F;
			resources.ApplyResources(this.crossSectionLine3, "crossSectionLine3");
			this.crossSectionLine3.LineWeight = 1F;
			this.crossSectionLine3.Name = "crossSectionLine3";
			// 
			// line2
			// 
			this.line2.AnchorBottom = true;
			resources.ApplyResources(this.line2, "line2");
			this.line2.LineWeight = 1F;
			this.line2.Name = "line2";
			this.line2.X1 = 0F;
			this.line2.X2 = 6.5F;
			this.line2.Y1 = 1.253F;
			this.line2.Y2 = 1.253F;
			// 
			// billingAddressTextBox
			// 
			this.billingAddressTextBox.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.billingAddressTextBox.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.billingAddressTextBox.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.billingAddressTextBox.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.billingAddressTextBox, "billingAddressTextBox");
			this.billingAddressTextBox.DataField = "BillingAddress";
			this.billingAddressTextBox.Name = "billingAddressTextBox";
			// 
			// shippingAddressTextBox
			// 
			this.shippingAddressTextBox.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.shippingAddressTextBox.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.shippingAddressTextBox.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			this.shippingAddressTextBox.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid;
			resources.ApplyResources(this.shippingAddressTextBox, "shippingAddressTextBox");
			this.shippingAddressTextBox.DataField = "ShippingAddress";
			this.shippingAddressTextBox.Name = "shippingAddressTextBox";
			// 
			// shape4
			// 
			this.shape4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(39)))), ((int)(((byte)(126)))));
			resources.ApplyResources(this.shape4, "shape4");
			this.shape4.LineColor = System.Drawing.Color.Transparent;
			this.shape4.Name = "shape4";
			this.shape4.RoundingRadius = 9.999999F;
			// 
			// freightLabel
			// 
			resources.ApplyResources(this.freightLabel, "freightLabel");
			this.freightLabel.Name = "freightLabel";
			this.freightLabel.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// freightTextBox
			// 
			resources.ApplyResources(this.freightTextBox, "freightTextBox");
			this.freightTextBox.DataField = "Freight";
			this.freightTextBox.Name = "freightTextBox";
			this.freightTextBox.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// subTotalLabel
			// 
			resources.ApplyResources(this.subTotalLabel, "subTotalLabel");
			this.subTotalLabel.Name = "subTotalLabel";
			this.subTotalLabel.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// subtotalTextBox
			// 
			resources.ApplyResources(this.subtotalTextBox, "subtotalTextBox");
			this.subtotalTextBox.DataField = "Total";
			this.subtotalTextBox.Name = "subtotalTextBox";
			this.subtotalTextBox.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			this.subtotalTextBox.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group;
			this.subtotalTextBox.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this.label1.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// grandTotalTextBox
			// 
			resources.ApplyResources(this.grandTotalTextBox, "grandTotalTextBox");
			this.grandTotalTextBox.Name = "grandTotalTextBox";
			this.grandTotalTextBox.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 2, 0);
			// 
			// shape2
			// 
			resources.ApplyResources(this.shape2, "shape2");
			this.shape2.Name = "shape2";
			this.shape2.RoundingRadius = 9.999999F;
			// 
			// line3
			// 
			resources.ApplyResources(this.line3, "line3");
			this.line3.LineWeight = 1F;
			this.line3.Name = "line3";
			this.line3.X1 = 4.5F;
			this.line3.X2 = 6.498F;
			this.line3.Y1 = 0.2F;
			this.line3.Y2 = 0.2F;
			// 
			// line4
			// 
			resources.ApplyResources(this.line4, "line4");
			this.line4.LineWeight = 1F;
			this.line4.Name = "line4";
			this.line4.X1 = 4.5F;
			this.line4.X2 = 6.498F;
			this.line4.Y1 = 0.394F;
			this.line4.Y2 = 0.394F;
			// 
			// crossSectionBox1
			// 
			this.crossSectionBox1.Bottom = 0F;
			resources.ApplyResources(this.crossSectionBox1, "crossSectionBox1");
			this.crossSectionBox1.LineWeight = 1F;
			this.crossSectionBox1.Name = "crossSectionBox1";
			this.crossSectionBox1.Right = 6.501F;
			// 
			// line5
			// 
			resources.ApplyResources(this.line5, "line5");
			this.line5.LineWeight = 1F;
			this.line5.Name = "line5";
			this.line5.X1 = 4.498F;
			this.line5.X2 = 6.498F;
			this.line5.Y1 = 0.8F;
			this.line5.Y2 = 0.804F;
			// 
			// Detail
			// 
			this.Detail.CanGrow = false;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.line1,
			this.qtyTextBox,
			this.productNameTextBox,
			this.unitPriceTextBox,
			this.totalTextBox});
			this.Detail.Height = 0.2F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			// 
			// PageHeader
			// 
			this.PageHeader.CanGrow = false;
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.shape3,
			this.companyNameLabel,
			this.invoiceLabel,
			this.orderDateTextBox,
			this.orderIDTextBox,
			this.orderIDLabel,
			this.label2,
			this.line5});
			this.PageHeader.Height = 1.25F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.CanGrow = false;
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.pageNoFMReportInfo});
			this.PageFooter.Name = "PageFooter";
			// 
			// customerGroupHeader
			// 
			this.customerGroupHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.shape1,
			this.shippingAddressLabel,
			this.billingAddressLabel,
			this.qtyLabel,
			this.productDescLabel,
			this.unitPriceLabel,
			this.totalLabel,
			this.crossSectionLine1,
			this.crossSectionLine2,
			this.crossSectionLine3,
			this.line2,
			this.billingAddressTextBox,
			this.shippingAddressTextBox,
			this.crossSectionBox1});
			this.customerGroupHeader.DataField = "OrderID";
			this.customerGroupHeader.Height = 1.2F;
			this.customerGroupHeader.Name = "customerGroupHeader";
			this.customerGroupHeader.Format += new System.EventHandler(this.customerGroupHeader_Format);
			// 
			// customerGroupFooter
			// 
			this.customerGroupFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.grandTotalTextBox,
			this.shape2,
			this.shape4,
			this.freightLabel,
			this.freightTextBox,
			this.subTotalLabel,
			this.subtotalTextBox,
			this.label1,
			this.line3,
			this.line4});
			this.customerGroupFooter.Height = 1F;
			this.customerGroupFooter.Name = "customerGroupFooter";
			this.customerGroupFooter.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After;
			this.customerGroupFooter.Format += new System.EventHandler(this.customerGroupFooter_Format);
			// 
			// BillingAddress
			// 
			this.BillingAddress.DefaultValue = "";
			this.BillingAddress.FieldType = GrapeCity.ActiveReports.Data.FieldTypeEnum.None;
			this.BillingAddress.Formula = "Customers.CompanyName + \"\n\" + Address + \"\n\" + City + \", \" + Region + \"  \" + Posta" +
	"lCode";
			this.BillingAddress.Name = "BillingAddress";
			this.BillingAddress.Tag = null;
			// 
			// ShippingAddress
			// 
			this.ShippingAddress.DefaultValue = null;
			this.ShippingAddress.FieldType = GrapeCity.ActiveReports.Data.FieldTypeEnum.None;
			this.ShippingAddress.Formula = "ShipName + \"\n\" + ShipAddress + \"\n\" + ShipCity + \", \" + ShipRegion + \"  \" + ShipPo" +
	"stalCode";
			this.ShippingAddress.Name = "ShippingAddress";
			this.ShippingAddress.Tag = null;
			// 
			// Total
			// 
			this.Total.DefaultValue = null;
			this.Total.FieldType = GrapeCity.ActiveReports.Data.FieldTypeEnum.None;
			this.Total.Formula = "Quantity * UnitPrice";
			this.Total.Name = "Total";
			this.Total.Tag = null;
			// 
			// CodeReport
			// 
			this.MasterReport = false;
			this.CalculatedFields.Add(this.BillingAddress);
			this.CalculatedFields.Add(this.ShippingAddress);
			this.CalculatedFields.Add(this.Total);
			resources.ApplyResources(this, "$this");
			oleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\NWIND.mdb;Persist Security Info=False";
			oleDBDataSource1.SQL = "";
			this.DataSource = oleDBDataSource1;
			this.MaxPages = ((long)(100));
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.510417F;
			this.Script = resources.GetString("$this.Script");
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.customerGroupHeader);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.customerGroupFooter);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.ReportStart += new System.EventHandler(this.Invoice_ReportStart);			
		}
		#endregion
		private Detail Detail;
		private PageHeader PageHeader;
		private PageFooter PageFooter;
		private Label companyNameLabel;
		private Label invoiceLabel;
		private GroupHeader customerGroupHeader;
		private Label shippingAddressLabel;
		private Label billingAddressLabel;
		private GroupFooter customerGroupFooter;
		private Label qtyLabel;
		private Label productDescLabel;
		private Label unitPriceLabel;
		private Label totalLabel;
		private Shape shape1;
		private Line line1;
		private CrossSectionLine crossSectionLine1;
		private CrossSectionLine crossSectionLine2;
		private CrossSectionLine crossSectionLine3;
		private Line line2;
		private TextBox qtyTextBox;
		private TextBox productNameTextBox;
		private TextBox unitPriceTextBox;
		private TextBox totalTextBox;
		private TextBox billingAddressTextBox;
		private TextBox shippingAddressTextBox;
		private ReportInfo pageNoFMReportInfo;
		private GrapeCity.ActiveReports.Data.Field BillingAddress;
		private GrapeCity.ActiveReports.Data.Field ShippingAddress;
		private TextBox orderDateTextBox;
		private TextBox orderIDTextBox;
		private Label orderIDLabel;
		private Label label2;
		private GrapeCity.ActiveReports.Data.Field Total;
		private Label freightLabel;
		private TextBox freightTextBox;
		private Label subTotalLabel;
		private TextBox subtotalTextBox;
		private Label label1;
		private TextBox grandTotalTextBox;
		private Shape shape2;
		private Shape shape3;
		private Shape shape4;
		private Line line3;
		private Line line4;
		private CrossSectionBox crossSectionBox1;
		private Line line5;
	}
}
