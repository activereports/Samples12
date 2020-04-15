using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	public partial class Catalog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			this.txtProductName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtProductID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtQtyPerUnit = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Line1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lblTitle = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDesc1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDesc2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDesc3 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDesc4 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDesc5 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDesc6 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDesc7 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDesc8 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.imgNWLogo = new GrapeCity.ActiveReports.SectionReportModel.Picture();
			this.PageBreak1 = new GrapeCity.ActiveReports.SectionReportModel.PageBreak();
			this.boxShip = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.boxTotals = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.boxProducts = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.lblOrderForm = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblAddress = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblInstructionsText = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblBillTo = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblShipTo = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDateOfOrder = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDateRequired = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblCustomerID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProductID2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProductName2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblUnitPrice2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblQuantity2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblExtendedPrice2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblSubTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblFreight = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lneBillTo1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneBillTo2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneBillTo3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneBillTo4 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneShipTo1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneShipTo2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneShipTo3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneShipTo4 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneDateOfOrder = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneDateRequired = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneCustomerID = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts3 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts4 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts5 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts6 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts7 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts8 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts9 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts10 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts12 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts14 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts13 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneTotal1 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneTotal2 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lblSpeedyExpress = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblUnitedPackage = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblFederalShipping = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblShipVia = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.boxSpeedyExpress = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.boxUnitedPackage = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.boxFederalShipping = new GrapeCity.ActiveReports.SectionReportModel.Shape();
			this.SmallPictureLogo = new GrapeCity.ActiveReports.SectionReportModel.Picture();
			this.NameLogo = new GrapeCity.ActiveReports.SectionReportModel.Picture();
			this.lneSeparator = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneProducts11 = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lblPageFooter = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblPage = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtDescription = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblProductName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProductID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblQtyPerUnit = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtCategoryName = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.oleCategory = new GrapeCity.ActiveReports.SectionReportModel.OleObject();
			this.lneSep = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.ReportHeader = new GrapeCity.ActiveReports.SectionReportModel.ReportHeader();
			this.ReportFooter = new GrapeCity.ActiveReports.SectionReportModel.ReportFooter();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.ghCategoryName = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.gfCategoryName = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			// 
			// txtProductName
			// 
			this.txtProductName.CanGrow = false;
			this.txtProductName.DataField = "ProductName";
			resources.ApplyResources(this.txtProductName, "txtProductName");
			this.txtProductName.Name = "txtProductName";
			// 
			// txtProductID
			// 
			this.txtProductID.CanGrow = false;
			this.txtProductID.DataField = "ProductID";
			resources.ApplyResources(this.txtProductID, "txtProductID");
			this.txtProductID.Name = "txtProductID";
			// 
			// txtQtyPerUnit
			// 
			this.txtQtyPerUnit.CanGrow = false;
			this.txtQtyPerUnit.DataField = "QuantityPerUnit";
			resources.ApplyResources(this.txtQtyPerUnit, "txtQtyPerUnit");
			this.txtQtyPerUnit.Name = "txtQtyPerUnit";
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.CanGrow = false;
			this.txtUnitPrice.DataField = "UnitPrice";
			resources.ApplyResources(this.txtUnitPrice, "txtUnitPrice");
			this.txtUnitPrice.Name = "txtUnitPrice";
			// 
			// Line1
			// 
			resources.ApplyResources(this.Line1, "Line1");
			this.Line1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Line1.LineWeight = 4F;
			this.Line1.Name = "Line1";
			this.Line1.X1 = 0F;
			this.Line1.X2 = 6.5F;
			this.Line1.Y1 = 2.5625F;
			this.Line1.Y2 = 2.5625F;
			// 
			// lblTitle
			// 
			resources.ApplyResources(this.lblTitle, "lblTitle");
			this.lblTitle.Name = "lblTitle";
			// 
			// lblDesc1
			// 
			resources.ApplyResources(this.lblDesc1, "lblDesc1");
			this.lblDesc1.Name = "lblDesc1";
			// 
			// lblDesc2
			// 
			resources.ApplyResources(this.lblDesc2, "lblDesc2");
			this.lblDesc2.Name = "lblDesc2";
			// 
			// lblDesc3
			// 
			resources.ApplyResources(this.lblDesc3, "lblDesc3");
			this.lblDesc3.Name = "lblDesc3";
			// 
			// lblDesc4
			// 
			resources.ApplyResources(this.lblDesc4, "lblDesc4");
			this.lblDesc4.Name = "lblDesc4";
			// 
			// lblDesc5
			// 
			resources.ApplyResources(this.lblDesc5, "lblDesc5");
			this.lblDesc5.Name = "lblDesc5";
			// 
			// lblDesc6
			// 
			resources.ApplyResources(this.lblDesc6, "lblDesc6");
			this.lblDesc6.Name = "lblDesc6";
			// 
			// lblDesc7
			// 
			resources.ApplyResources(this.lblDesc7, "lblDesc7");
			this.lblDesc7.Name = "lblDesc7";
			// 
			// lblDesc8
			// 
			resources.ApplyResources(this.lblDesc8, "lblDesc8");
			this.lblDesc8.Name = "lblDesc8";
			// 
			// imgNWLogo
			// 
			this.imgNWLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.imgNWLogo, "imgNWLogo");
			this.imgNWLogo.ImageData = ((System.IO.Stream)(resources.GetObject("imgNWLogo.ImageData")));
			this.imgNWLogo.LineColor = System.Drawing.Color.Black;
			this.imgNWLogo.LineWeight = 1F;
			this.imgNWLogo.Name = "imgNWLogo";
			// 
			// PageBreak1
			// 
			resources.ApplyResources(this.PageBreak1, "PageBreak1");
			this.PageBreak1.Name = "PageBreak1";
			this.PageBreak1.Size = new System.Drawing.SizeF(6.5F, 0.05555556F);
			// 
			// boxShip
			// 
			resources.ApplyResources(this.boxShip, "boxShip");
			this.boxShip.Name = "boxShip";
			this.boxShip.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, null, null, null, null);
			this.boxShip.Tag = "";
			// 
			// boxTotals
			// 
			resources.ApplyResources(this.boxTotals, "boxTotals");
			this.boxTotals.Name = "boxTotals";
			this.boxTotals.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, null, null, null, null);
			this.boxTotals.Tag = "";
			// 
			// boxProducts
			// 
			resources.ApplyResources(this.boxProducts, "boxProducts");
			this.boxProducts.Name = "boxProducts";
			this.boxProducts.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, null, null, null, null);
			this.boxProducts.Tag = "";
			// 
			// lblOrderForm
			// 
			resources.ApplyResources(this.lblOrderForm, "lblOrderForm");
			this.lblOrderForm.Name = "lblOrderForm";
			this.lblOrderForm.Tag = "";
			// 
			// lblAddress
			// 
			resources.ApplyResources(this.lblAddress, "lblAddress");
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Tag = "";
			// 
			// lblInstructionsText
			// 
			resources.ApplyResources(this.lblInstructionsText, "lblInstructionsText");
			this.lblInstructionsText.Name = "lblInstructionsText";
			this.lblInstructionsText.Tag = "";
			// 
			// lblBillTo
			// 
			resources.ApplyResources(this.lblBillTo, "lblBillTo");
			this.lblBillTo.Name = "lblBillTo";
			this.lblBillTo.Tag = "";
			// 
			// lblShipTo
			// 
			resources.ApplyResources(this.lblShipTo, "lblShipTo");
			this.lblShipTo.Name = "lblShipTo";
			this.lblShipTo.Tag = "";
			// 
			// lblDateOfOrder
			// 
			resources.ApplyResources(this.lblDateOfOrder, "lblDateOfOrder");
			this.lblDateOfOrder.Name = "lblDateOfOrder";
			this.lblDateOfOrder.Tag = "";
			// 
			// lblDateRequired
			// 
			resources.ApplyResources(this.lblDateRequired, "lblDateRequired");
			this.lblDateRequired.Name = "lblDateRequired";
			this.lblDateRequired.Tag = "";
			// 
			// lblCustomerID
			// 
			resources.ApplyResources(this.lblCustomerID, "lblCustomerID");
			this.lblCustomerID.Name = "lblCustomerID";
			this.lblCustomerID.Tag = "";
			// 
			// lblProductID2
			// 
			resources.ApplyResources(this.lblProductID2, "lblProductID2");
			this.lblProductID2.Name = "lblProductID2";
			this.lblProductID2.Tag = "";
			// 
			// lblProductName2
			// 
			resources.ApplyResources(this.lblProductName2, "lblProductName2");
			this.lblProductName2.Name = "lblProductName2";
			this.lblProductName2.Tag = "";
			// 
			// lblUnitPrice2
			// 
			resources.ApplyResources(this.lblUnitPrice2, "lblUnitPrice2");
			this.lblUnitPrice2.Name = "lblUnitPrice2";
			this.lblUnitPrice2.Tag = "";
			// 
			// lblQuantity2
			// 
			resources.ApplyResources(this.lblQuantity2, "lblQuantity2");
			this.lblQuantity2.Name = "lblQuantity2";
			this.lblQuantity2.Tag = "";
			// 
			// lblExtendedPrice2
			// 
			resources.ApplyResources(this.lblExtendedPrice2, "lblExtendedPrice2");
			this.lblExtendedPrice2.Name = "lblExtendedPrice2";
			this.lblExtendedPrice2.Tag = "";
			// 
			// lblSubTotal
			// 
			resources.ApplyResources(this.lblSubTotal, "lblSubTotal");
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.Tag = "";
			// 
			// lblFreight
			// 
			resources.ApplyResources(this.lblFreight, "lblFreight");
			this.lblFreight.Name = "lblFreight";
			this.lblFreight.Tag = "";
			// 
			// lblTotal
			// 
			resources.ApplyResources(this.lblTotal, "lblTotal");
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Tag = "";
			// 
			// lneBillTo1
			// 
			resources.ApplyResources(this.lneBillTo1, "lneBillTo1");
			this.lneBillTo1.LineWeight = 1F;
			this.lneBillTo1.Name = "lneBillTo1";
			this.lneBillTo1.Tag = "";
			this.lneBillTo1.X1 = 0.7875F;
			this.lneBillTo1.X2 = 2.985417F;
			this.lneBillTo1.Y1 = 2.958333F;
			this.lneBillTo1.Y2 = 2.958333F;
			// 
			// lneBillTo2
			// 
			resources.ApplyResources(this.lneBillTo2, "lneBillTo2");
			this.lneBillTo2.LineWeight = 1F;
			this.lneBillTo2.Name = "lneBillTo2";
			this.lneBillTo2.Tag = "";
			this.lneBillTo2.X1 = 0.28125F;
			this.lneBillTo2.X2 = 2.985417F;
			this.lneBillTo2.Y1 = 3.135417F;
			this.lneBillTo2.Y2 = 3.135417F;
			// 
			// lneBillTo3
			// 
			resources.ApplyResources(this.lneBillTo3, "lneBillTo3");
			this.lneBillTo3.LineWeight = 1F;
			this.lneBillTo3.Name = "lneBillTo3";
			this.lneBillTo3.Tag = "";
			this.lneBillTo3.X1 = 0.28125F;
			this.lneBillTo3.X2 = 2.985417F;
			this.lneBillTo3.Y1 = 3.302083F;
			this.lneBillTo3.Y2 = 3.302083F;
			// 
			// lneBillTo4
			// 
			resources.ApplyResources(this.lneBillTo4, "lneBillTo4");
			this.lneBillTo4.LineWeight = 1F;
			this.lneBillTo4.Name = "lneBillTo4";
			this.lneBillTo4.Tag = "";
			this.lneBillTo4.X1 = 0.28125F;
			this.lneBillTo4.X2 = 2.985417F;
			this.lneBillTo4.Y1 = 3.46875F;
			this.lneBillTo4.Y2 = 3.46875F;
			// 
			// lneShipTo1
			// 
			resources.ApplyResources(this.lneShipTo1, "lneShipTo1");
			this.lneShipTo1.LineWeight = 1F;
			this.lneShipTo1.Name = "lneShipTo1";
			this.lneShipTo1.Tag = "";
			this.lneShipTo1.X1 = 3.902083F;
			this.lneShipTo1.X2 = 6.089583F;
			this.lneShipTo1.Y1 = 2.958333F;
			this.lneShipTo1.Y2 = 2.958333F;
			// 
			// lneShipTo2
			// 
			resources.ApplyResources(this.lneShipTo2, "lneShipTo2");
			this.lneShipTo2.LineWeight = 1F;
			this.lneShipTo2.Name = "lneShipTo2";
			this.lneShipTo2.Tag = "";
			this.lneShipTo2.X1 = 3.395833F;
			this.lneShipTo2.X2 = 6.089583F;
			this.lneShipTo2.Y1 = 3.135417F;
			this.lneShipTo2.Y2 = 3.135417F;
			// 
			// lneShipTo3
			// 
			resources.ApplyResources(this.lneShipTo3, "lneShipTo3");
			this.lneShipTo3.LineWeight = 1F;
			this.lneShipTo3.Name = "lneShipTo3";
			this.lneShipTo3.Tag = "";
			this.lneShipTo3.X1 = 3.395833F;
			this.lneShipTo3.X2 = 6.089583F;
			this.lneShipTo3.Y1 = 3.302083F;
			this.lneShipTo3.Y2 = 3.302083F;
			// 
			// lneShipTo4
			// 
			resources.ApplyResources(this.lneShipTo4, "lneShipTo4");
			this.lneShipTo4.LineWeight = 1F;
			this.lneShipTo4.Name = "lneShipTo4";
			this.lneShipTo4.Tag = "";
			this.lneShipTo4.X1 = 3.395833F;
			this.lneShipTo4.X2 = 6.089583F;
			this.lneShipTo4.Y1 = 3.46875F;
			this.lneShipTo4.Y2 = 3.46875F;
			// 
			// lneDateOfOrder
			// 
			resources.ApplyResources(this.lneDateOfOrder, "lneDateOfOrder");
			this.lneDateOfOrder.LineWeight = 1F;
			this.lneDateOfOrder.Name = "lneDateOfOrder";
			this.lneDateOfOrder.Tag = "";
			this.lneDateOfOrder.X1 = 1.166667F;
			this.lneDateOfOrder.X2 = 2.666667F;
			this.lneDateOfOrder.Y1 = 3.916667F;
			this.lneDateOfOrder.Y2 = 3.916667F;
			// 
			// lneDateRequired
			// 
			resources.ApplyResources(this.lneDateRequired, "lneDateRequired");
			this.lneDateRequired.LineWeight = 1F;
			this.lneDateRequired.Name = "lneDateRequired";
			this.lneDateRequired.Tag = "";
			this.lneDateRequired.X1 = 1.166667F;
			this.lneDateRequired.X2 = 2.666667F;
			this.lneDateRequired.Y1 = 4.15625F;
			this.lneDateRequired.Y2 = 4.15625F;
			// 
			// lneCustomerID
			// 
			resources.ApplyResources(this.lneCustomerID, "lneCustomerID");
			this.lneCustomerID.LineWeight = 1F;
			this.lneCustomerID.Name = "lneCustomerID";
			this.lneCustomerID.Tag = "";
			this.lneCustomerID.X1 = 4.18125F;
			this.lneCustomerID.X2 = 6.0875F;
			this.lneCustomerID.Y1 = 4.15625F;
			this.lneCustomerID.Y2 = 4.15625F;
			// 
			// lneProducts2
			// 
			resources.ApplyResources(this.lneProducts2, "lneProducts2");
			this.lneProducts2.LineWeight = 1F;
			this.lneProducts2.Name = "lneProducts2";
			this.lneProducts2.Tag = "";
			this.lneProducts2.X1 = 0.3F;
			this.lneProducts2.X2 = 6.1F;
			this.lneProducts2.Y1 = 4.645833F;
			this.lneProducts2.Y2 = 4.645833F;
			// 
			// lneProducts3
			// 
			resources.ApplyResources(this.lneProducts3, "lneProducts3");
			this.lneProducts3.LineWeight = 1F;
			this.lneProducts3.Name = "lneProducts3";
			this.lneProducts3.Tag = "";
			this.lneProducts3.X1 = 0.3F;
			this.lneProducts3.X2 = 6.1F;
			this.lneProducts3.Y1 = 4.8125F;
			this.lneProducts3.Y2 = 4.8125F;
			// 
			// lneProducts4
			// 
			resources.ApplyResources(this.lneProducts4, "lneProducts4");
			this.lneProducts4.LineWeight = 1F;
			this.lneProducts4.Name = "lneProducts4";
			this.lneProducts4.Tag = "";
			this.lneProducts4.X1 = 0.3F;
			this.lneProducts4.X2 = 6.1F;
			this.lneProducts4.Y1 = 4.979167F;
			this.lneProducts4.Y2 = 4.979167F;
			// 
			// lneProducts5
			// 
			resources.ApplyResources(this.lneProducts5, "lneProducts5");
			this.lneProducts5.LineWeight = 1F;
			this.lneProducts5.Name = "lneProducts5";
			this.lneProducts5.Tag = "";
			this.lneProducts5.X1 = 0.3F;
			this.lneProducts5.X2 = 6.1F;
			this.lneProducts5.Y1 = 5.145833F;
			this.lneProducts5.Y2 = 5.145833F;
			// 
			// lneProducts6
			// 
			resources.ApplyResources(this.lneProducts6, "lneProducts6");
			this.lneProducts6.LineWeight = 1F;
			this.lneProducts6.Name = "lneProducts6";
			this.lneProducts6.Tag = "";
			this.lneProducts6.X1 = 0.3F;
			this.lneProducts6.X2 = 6.1F;
			this.lneProducts6.Y1 = 5.3125F;
			this.lneProducts6.Y2 = 5.3125F;
			// 
			// lneProducts7
			// 
			resources.ApplyResources(this.lneProducts7, "lneProducts7");
			this.lneProducts7.LineWeight = 1F;
			this.lneProducts7.Name = "lneProducts7";
			this.lneProducts7.Tag = "";
			this.lneProducts7.X1 = 0.3F;
			this.lneProducts7.X2 = 6.1F;
			this.lneProducts7.Y1 = 5.479167F;
			this.lneProducts7.Y2 = 5.479167F;
			// 
			// lneProducts8
			// 
			resources.ApplyResources(this.lneProducts8, "lneProducts8");
			this.lneProducts8.LineWeight = 1F;
			this.lneProducts8.Name = "lneProducts8";
			this.lneProducts8.Tag = "";
			this.lneProducts8.X1 = 0.3F;
			this.lneProducts8.X2 = 6.1F;
			this.lneProducts8.Y1 = 5.645833F;
			this.lneProducts8.Y2 = 5.645833F;
			// 
			// lneProducts9
			// 
			resources.ApplyResources(this.lneProducts9, "lneProducts9");
			this.lneProducts9.LineWeight = 1F;
			this.lneProducts9.Name = "lneProducts9";
			this.lneProducts9.Tag = "";
			this.lneProducts9.X1 = 0.3F;
			this.lneProducts9.X2 = 6.1F;
			this.lneProducts9.Y1 = 5.8125F;
			this.lneProducts9.Y2 = 5.8125F;
			// 
			// lneProducts10
			// 
			resources.ApplyResources(this.lneProducts10, "lneProducts10");
			this.lneProducts10.LineWeight = 1F;
			this.lneProducts10.Name = "lneProducts10";
			this.lneProducts10.Tag = "";
			this.lneProducts10.X1 = 0.3F;
			this.lneProducts10.X2 = 6.1F;
			this.lneProducts10.Y1 = 5.979167F;
			this.lneProducts10.Y2 = 5.979167F;
			// 
			// lneProducts1
			// 
			resources.ApplyResources(this.lneProducts1, "lneProducts1");
			this.lneProducts1.LineWeight = 1F;
			this.lneProducts1.Name = "lneProducts1";
			this.lneProducts1.Tag = "";
			this.lneProducts1.X1 = 0.3F;
			this.lneProducts1.X2 = 6.1F;
			this.lneProducts1.Y1 = 4.489583F;
			this.lneProducts1.Y2 = 4.489583F;
			// 
			// lneProducts12
			// 
			resources.ApplyResources(this.lneProducts12, "lneProducts12");
			this.lneProducts12.LineWeight = 1F;
			this.lneProducts12.Name = "lneProducts12";
			this.lneProducts12.Tag = "";
			this.lneProducts12.X1 = 3.404167F;
			this.lneProducts12.X2 = 3.404167F;
			this.lneProducts12.Y1 = 4.259722F;
			this.lneProducts12.Y2 = 6.144444F;
			// 
			// lneProducts14
			// 
			resources.ApplyResources(this.lneProducts14, "lneProducts14");
			this.lneProducts14.LineWeight = 1F;
			this.lneProducts14.Name = "lneProducts14";
			this.lneProducts14.Tag = "";
			this.lneProducts14.X1 = 5.177083F;
			this.lneProducts14.X2 = 5.177083F;
			this.lneProducts14.Y1 = 4.259722F;
			this.lneProducts14.Y2 = 6.822222F;
			// 
			// lneProducts13
			// 
			resources.ApplyResources(this.lneProducts13, "lneProducts13");
			this.lneProducts13.LineWeight = 1F;
			this.lneProducts13.Name = "lneProducts13";
			this.lneProducts13.Tag = "";
			this.lneProducts13.X1 = 4.302083F;
			this.lneProducts13.X2 = 4.302083F;
			this.lneProducts13.Y1 = 4.259722F;
			this.lneProducts13.Y2 = 6.144444F;
			// 
			// lneTotal1
			// 
			resources.ApplyResources(this.lneTotal1, "lneTotal1");
			this.lneTotal1.LineWeight = 1F;
			this.lneTotal1.Name = "lneTotal1";
			this.lneTotal1.Tag = "";
			this.lneTotal1.X1 = 3.404167F;
			this.lneTotal1.X2 = 6.095833F;
			this.lneTotal1.Y1 = 6.365278F;
			this.lneTotal1.Y2 = 6.365278F;
			// 
			// lneTotal2
			// 
			resources.ApplyResources(this.lneTotal2, "lneTotal2");
			this.lneTotal2.LineWeight = 1F;
			this.lneTotal2.Name = "lneTotal2";
			this.lneTotal2.Tag = "";
			this.lneTotal2.X1 = 3.404167F;
			this.lneTotal2.X2 = 6.095833F;
			this.lneTotal2.Y1 = 6.594444F;
			this.lneTotal2.Y2 = 6.594444F;
			// 
			// lblSpeedyExpress
			// 
			resources.ApplyResources(this.lblSpeedyExpress, "lblSpeedyExpress");
			this.lblSpeedyExpress.Name = "lblSpeedyExpress";
			this.lblSpeedyExpress.Tag = "";
			// 
			// lblUnitedPackage
			// 
			resources.ApplyResources(this.lblUnitedPackage, "lblUnitedPackage");
			this.lblUnitedPackage.Name = "lblUnitedPackage";
			this.lblUnitedPackage.Tag = "";
			// 
			// lblFederalShipping
			// 
			resources.ApplyResources(this.lblFederalShipping, "lblFederalShipping");
			this.lblFederalShipping.Name = "lblFederalShipping";
			this.lblFederalShipping.Tag = "";
			// 
			// lblShipVia
			// 
			resources.ApplyResources(this.lblShipVia, "lblShipVia");
			this.lblShipVia.Name = "lblShipVia";
			this.lblShipVia.Tag = "";
			// 
			// boxSpeedyExpress
			// 
			resources.ApplyResources(this.boxSpeedyExpress, "boxSpeedyExpress");
			this.boxSpeedyExpress.Name = "boxSpeedyExpress";
			this.boxSpeedyExpress.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, null, null, null, null);
			this.boxSpeedyExpress.Tag = "";
			// 
			// boxUnitedPackage
			// 
			resources.ApplyResources(this.boxUnitedPackage, "boxUnitedPackage");
			this.boxUnitedPackage.Name = "boxUnitedPackage";
			this.boxUnitedPackage.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, null, null, null, null);
			this.boxUnitedPackage.Tag = "";
			// 
			// boxFederalShipping
			// 
			resources.ApplyResources(this.boxFederalShipping, "boxFederalShipping");
			this.boxFederalShipping.Name = "boxFederalShipping";
			this.boxFederalShipping.RoundingRadius = new GrapeCity.ActiveReports.Controls.CornersRadius(9.99F, null, null, null, null);
			this.boxFederalShipping.Tag = "";
			// 
			// SmallPictureLogo
			// 
			this.SmallPictureLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.SmallPictureLogo, "SmallPictureLogo");
			this.SmallPictureLogo.ImageData = ((System.IO.Stream)(resources.GetObject("SmallPictureLogo.ImageData")));
			this.SmallPictureLogo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.SmallPictureLogo.Name = "SmallPictureLogo";
			this.SmallPictureLogo.Tag = "";
			// 
			// NameLogo
			// 
			this.NameLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.NameLogo, "NameLogo");
			this.NameLogo.ImageData = ((System.IO.Stream)(resources.GetObject("NameLogo.ImageData")));
			this.NameLogo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NameLogo.Name = "NameLogo";
			this.NameLogo.Tag = "";
			// 
			// lneSeparator
			// 
			resources.ApplyResources(this.lneSeparator, "lneSeparator");
			this.lneSeparator.LineWeight = 1F;
			this.lneSeparator.Name = "lneSeparator";
			this.lneSeparator.Tag = "";
			this.lneSeparator.X1 = 0F;
			this.lneSeparator.X2 = 6.5F;
			this.lneSeparator.Y1 = 0.9270833F;
			this.lneSeparator.Y2 = 0.9270833F;
			// 
			// lneProducts11
			// 
			resources.ApplyResources(this.lneProducts11, "lneProducts11");
			this.lneProducts11.LineWeight = 1F;
			this.lneProducts11.Name = "lneProducts11";
			this.lneProducts11.Tag = "";
			this.lneProducts11.X1 = 0.96875F;
			this.lneProducts11.X2 = 0.96875F;
			this.lneProducts11.Y1 = 4.259722F;
			this.lneProducts11.Y2 = 6.144444F;
			// 
			// lblPageFooter
			// 
			resources.ApplyResources(this.lblPageFooter, "lblPageFooter");
			this.lblPageFooter.Name = "lblPageFooter";
			// 
			// lblPage
			// 
			resources.ApplyResources(this.lblPage, "lblPage");
			this.lblPage.Name = "lblPage";
			// 
			// txtDescription
			// 
			this.txtDescription.CanGrow = false;
			this.txtDescription.DataField = "Description";
			resources.ApplyResources(this.txtDescription, "txtDescription");
			this.txtDescription.Name = "txtDescription";
			// 
			// lblProductName
			// 
			resources.ApplyResources(this.lblProductName, "lblProductName");
			this.lblProductName.Name = "lblProductName";
			// 
			// lblProductID
			// 
			resources.ApplyResources(this.lblProductID, "lblProductID");
			this.lblProductID.Name = "lblProductID";
			// 
			// lblQtyPerUnit
			// 
			resources.ApplyResources(this.lblQtyPerUnit, "lblQtyPerUnit");
			this.lblQtyPerUnit.Name = "lblQtyPerUnit";
			// 
			// lblUnitPrice
			// 
			resources.ApplyResources(this.lblUnitPrice, "lblUnitPrice");
			this.lblUnitPrice.Name = "lblUnitPrice";
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.DataField = "CategoryName";
			resources.ApplyResources(this.txtCategoryName, "txtCategoryName");
			this.txtCategoryName.Name = "txtCategoryName";
			// 
			// oleCategory
			// 
			this.oleCategory.Class = null;
			this.oleCategory.DataField = "Picture";
			this.oleCategory.DataValue = null;
			resources.ApplyResources(this.oleCategory, "oleCategory");
			this.oleCategory.Name = "oleCategory";
			this.oleCategory.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Stretch;
			// 
			// lneSep
			// 
			resources.ApplyResources(this.lneSep, "lneSep");
			this.lneSep.LineWeight = 2F;
			this.lneSep.Name = "lneSep";
			this.lneSep.X1 = 0.125F;
			this.lneSep.X2 = 6.4375F;
			this.lneSep.Y1 = 0F;
			this.lneSep.Y2 = 0F;
			// 
			// Detail
			// 
			this.Detail.CanGrow = false;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProductName,
			this.txtProductID,
			this.txtQtyPerUnit,
			this.txtUnitPrice});
			this.Detail.Height = 0.2625F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// ReportHeader
			// 
			this.ReportHeader.CanGrow = false;
			this.ReportHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.Line1,
			this.lblTitle,
			this.lblDesc1,
			this.lblDesc2,
			this.lblDesc3,
			this.lblDesc4,
			this.lblDesc5,
			this.lblDesc6,
			this.lblDesc7,
			this.lblDesc8,
			this.imgNWLogo,
			this.PageBreak1});
			this.ReportHeader.Height = 13.0625F;
			this.ReportHeader.Name = "ReportHeader";
			this.ReportHeader.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After;
			// 
			// ReportFooter
			// 
			this.ReportFooter.CanGrow = false;
			this.ReportFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.boxShip,
			this.boxTotals,
			this.boxProducts,
			this.lblOrderForm,
			this.lblAddress,
			this.lblInstructionsText,
			this.lblBillTo,
			this.lblShipTo,
			this.lblDateOfOrder,
			this.lblDateRequired,
			this.lblCustomerID,
			this.lblProductID2,
			this.lblProductName2,
			this.lblUnitPrice2,
			this.lblQuantity2,
			this.lblExtendedPrice2,
			this.lblSubTotal,
			this.lblFreight,
			this.lblTotal,
			this.lneBillTo1,
			this.lneBillTo2,
			this.lneBillTo3,
			this.lneBillTo4,
			this.lneShipTo1,
			this.lneShipTo2,
			this.lneShipTo3,
			this.lneShipTo4,
			this.lneDateOfOrder,
			this.lneDateRequired,
			this.lneCustomerID,
			this.lneProducts2,
			this.lneProducts3,
			this.lneProducts4,
			this.lneProducts5,
			this.lneProducts6,
			this.lneProducts7,
			this.lneProducts8,
			this.lneProducts9,
			this.lneProducts10,
			this.lneProducts1,
			this.lneProducts12,
			this.lneProducts14,
			this.lneProducts13,
			this.lneTotal1,
			this.lneTotal2,
			this.lblSpeedyExpress,
			this.lblUnitedPackage,
			this.lblFederalShipping,
			this.lblShipVia,
			this.boxSpeedyExpress,
			this.boxUnitedPackage,
			this.boxFederalShipping,
			this.SmallPictureLogo,
			this.NameLogo,
			this.lneSeparator,
			this.lneProducts11});
			this.ReportFooter.Height = 7.53125F;
			this.ReportFooter.KeepTogether = true;
			this.ReportFooter.Name = "ReportFooter";
			this.ReportFooter.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.Before;
			// 
			// PageHeader
			// 
			this.PageHeader.CanGrow = false;
			this.PageHeader.Height = 0F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.CanGrow = false;
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblPageFooter,
			this.lblPage});
			this.PageFooter.Height = 0.46875F;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.BeforePrint += new System.EventHandler(this.PageFooter_BeforePrint);
			// 
			// ghCategoryName
			// 
			this.ghCategoryName.CanGrow = false;
			this.ghCategoryName.ColumnLayout = false;
			this.ghCategoryName.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtDescription,
			this.lblProductName,
			this.lblProductID,
			this.lblQtyPerUnit,
			this.lblUnitPrice,
			this.txtCategoryName,
			this.oleCategory});
			this.ghCategoryName.DataField = "CategoryName";
			this.ghCategoryName.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All;
			this.ghCategoryName.Height = 1.606F;
			this.ghCategoryName.KeepTogether = true;
			this.ghCategoryName.Name = "ghCategoryName";
			// 
			// gfCategoryName
			// 
			this.gfCategoryName.CanGrow = false;
			this.gfCategoryName.ColumnLayout = false;
			this.gfCategoryName.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lneSep});
			this.gfCategoryName.Height = 0.07222223F;
			this.gfCategoryName.KeepTogether = true;
			this.gfCategoryName.Name = "gfCategoryName";
			// 
			// Catalog
			// 
			this.MasterReport = false;
			oleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\NWIND.mdb;Persist Security Info=False";
			oleDBDataSource1.SQL = "SELECT Categories.*, Products.*\r\nFROM Categories INNER JOIN Products ON Categorie" +
	"s.CategoryID = Products.CategoryID\r\nORDER BY Categories.CategoryName;";
			this.DataSource = oleDBDataSource1;
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.5F;
			this.Sections.Add(this.ReportHeader);
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.ghCategoryName);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.gfCategoryName);
			this.Sections.Add(this.PageFooter);
			this.Sections.Add(this.ReportFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
			"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
		}
		#endregion
		private OleObject oleCategory;
		public GrapeCity.ActiveReports.Data.OleDBDataSource ds = null;
		private ReportHeader ReportHeader;
		private Line Line1;
		private Label lblTitle;
		private Label lblDesc1;
		private Label lblDesc2;
		private Label lblDesc3;
		private Label lblDesc4;
		private Label lblDesc5;
		private Label lblDesc6;
		private Label lblDesc7;
		private Label lblDesc8;
		private Picture imgNWLogo;
		private PageBreak PageBreak1;
		private PageHeader PageHeader;
		private GroupHeader ghCategoryName;
		private TextBox txtDescription;
		private Label lblProductName;
		private Label lblProductID;
		private Label lblQtyPerUnit;
		private Label lblUnitPrice;
		private TextBox txtCategoryName;
		private Detail Detail;
		private TextBox txtProductName;
		private TextBox txtProductID;
		private TextBox txtQtyPerUnit;
		private TextBox txtUnitPrice;
		private GroupFooter gfCategoryName;
		private Line lneSep;
		private PageFooter PageFooter;
		private Label lblPageFooter;
		private Label lblPage;
		private ReportFooter ReportFooter;
		private Shape boxShip;
		private Shape boxTotals;
		private Shape boxProducts;
		private Label lblOrderForm;
		private Label lblAddress;
		private Label lblInstructionsText;
		private Label lblBillTo;
		private Label lblShipTo;
		private Label lblDateOfOrder;
		private Label lblDateRequired;
		private Label lblCustomerID;
		private Label lblProductID2;
		private Label lblProductName2;
		private Label lblUnitPrice2;
		private Label lblQuantity2;
		private Label lblExtendedPrice2;
		private Label lblSubTotal;
		private Label lblFreight;
		private Label lblTotal;
		private Line lneBillTo1;
		private Line lneBillTo2;
		private Line lneBillTo3;
		private Line lneBillTo4;
		private Line lneShipTo1;
		private Line lneShipTo2;
		private Line lneShipTo3;
		private Line lneShipTo4;
		private Line lneDateOfOrder;
		private Line lneDateRequired;
		private Line lneCustomerID;
		private Line lneProducts2;
		private Line lneProducts3;
		private Line lneProducts4;
		private Line lneProducts5;
		private Line lneProducts6;
		private Line lneProducts7;
		private Line lneProducts8;
		private Line lneProducts9;
		private Line lneProducts10;
		private Line lneProducts1;
		private Line lneProducts12;
		private Line lneProducts14;
		private Line lneProducts13;
		private Line lneTotal1;
		private Line lneTotal2;
		private Label lblSpeedyExpress;
		private Label lblUnitedPackage;
		private Label lblFederalShipping;
		private Label lblShipVia;
		private Shape boxSpeedyExpress;
		private Shape boxUnitedPackage;
		private Shape boxFederalShipping;
		private Picture SmallPictureLogo;
		private Picture NameLogo;
		private Line lneSeparator;
		private Line lneProducts11;
	}
}
