using System;
using GrapeCity.ActiveReports.SectionReportModel;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	public partial class Invoice
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
			GrapeCity.ActiveReports.Data.OleDBDataSource oleDBDataSource1 = new GrapeCity.ActiveReports.Data.OleDBDataSource();
			this.txtProductID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtProductname = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtQty = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtDiscount = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtExtended = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblNorthWind = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTraders = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblNWAddr1 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblNWAddr2 = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblInvoice = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblOrderNum = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtOrderID = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblOrderDate = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtOrderDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.imgLogo = new GrapeCity.ActiveReports.SectionReportModel.Picture();
			this.lblThankYou = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblBillTo = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblShipTo = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lneBillTo = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.lneShipTo = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.txtBillToCompany = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtBillToAddress = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtBillToCity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtBillToRegion = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtBillToPostalCode = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtBillToCountry = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtShipToCompany = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtShipToAddress = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtShipToCity = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtShipToRegion = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtShipToPostalCode = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtShipToCountry = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtSalesPerson = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblSalesPerson = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProductID = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblProductName = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblQty = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblUnitPrice = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblDiscount = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblShipped = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtShipDate = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblShippedVia = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtShipper = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.lblSubTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblFreight = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblGrandTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtSubTotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtFreight = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtTotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.ghOrderID = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GFOrderID = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
			((System.ComponentModel.ISupportInitialize)(this.txtProductID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductname)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExtended)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNorthWind)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTraders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNWAddr1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNWAddr2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblInvoice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblThankYou)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBillTo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblShipTo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillToCompany)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillToAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillToCity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillToRegion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillToPostalCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillToCountry)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipToCompany)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipToAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipToCity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipToRegion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipToPostalCode)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipToCountry)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSalesPerson)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSalesPerson)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProductID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProductName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUnitPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDiscount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblShipped)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipDate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblShippedVia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipper)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFreight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblGrandTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSubTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFreight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// txtProductID
			// 
			this.txtProductID.CanGrow = false;
			this.txtProductID.DataField = "ProductID";
			resources.ApplyResources(this.txtProductID, "txtProductID");
			this.txtProductID.Name = "txtProductID";
			// 
			// txtProductname
			// 
			this.txtProductname.CanGrow = false;
			this.txtProductname.DataField = "ProductName";
			resources.ApplyResources(this.txtProductname, "txtProductname");
			this.txtProductname.Name = "txtProductname";
			// 
			// txtQty
			// 
			this.txtQty.CanGrow = false;
			this.txtQty.DataField = "Quantity";
			resources.ApplyResources(this.txtQty, "txtQty");
			this.txtQty.Name = "txtQty";
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.CanGrow = false;
			this.txtUnitPrice.DataField = "UnitPrice";
			resources.ApplyResources(this.txtUnitPrice, "txtUnitPrice");
			this.txtUnitPrice.Name = "txtUnitPrice";
			// 
			// txtDiscount
			// 
			this.txtDiscount.CanGrow = false;
			this.txtDiscount.DataField = "Discount";
			resources.ApplyResources(this.txtDiscount, "txtDiscount");
			this.txtDiscount.Name = "txtDiscount";
			// 
			// txtExtended
			// 
			this.txtExtended.CanGrow = false;
			this.txtExtended.DataField = "ExtendedPrice";
			resources.ApplyResources(this.txtExtended, "txtExtended");
			this.txtExtended.Name = "txtExtended";
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
			// lblNWAddr1
			// 
			resources.ApplyResources(this.lblNWAddr1, "lblNWAddr1");
			this.lblNWAddr1.Name = "lblNWAddr1";
			// 
			// lblNWAddr2
			// 
			resources.ApplyResources(this.lblNWAddr2, "lblNWAddr2");
			this.lblNWAddr2.Name = "lblNWAddr2";
			// 
			// lblInvoice
			// 
			resources.ApplyResources(this.lblInvoice, "lblInvoice");
			this.lblInvoice.Name = "lblInvoice";
			// 
			// lblOrderNum
			// 
			resources.ApplyResources(this.lblOrderNum, "lblOrderNum");
			this.lblOrderNum.Name = "lblOrderNum";
			// 
			// txtOrderID
			// 
			this.txtOrderID.CanGrow = false;
			this.txtOrderID.DataField = "OrderID";
			resources.ApplyResources(this.txtOrderID, "txtOrderID");
			this.txtOrderID.Name = "txtOrderID";
			// 
			// lblOrderDate
			// 
			resources.ApplyResources(this.lblOrderDate, "lblOrderDate");
			this.lblOrderDate.Name = "lblOrderDate";
			// 
			// txtOrderDate
			// 
			this.txtOrderDate.CanGrow = false;
			this.txtOrderDate.DataField = "OrderDate";
			resources.ApplyResources(this.txtOrderDate, "txtOrderDate");
			this.txtOrderDate.Name = "txtOrderDate";
			// 
			// imgLogo
			// 
			this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.imgLogo, "imgLogo");
			this.imgLogo.ImageData = ((System.IO.Stream)(resources.GetObject("imgLogo.ImageData")));
			this.imgLogo.LineColor = System.Drawing.Color.Black;
			this.imgLogo.LineWeight = 1F;
			this.imgLogo.Name = "imgLogo";
			this.imgLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom;
			// 
			// lblThankYou
			// 
			resources.ApplyResources(this.lblThankYou, "lblThankYou");
			this.lblThankYou.Name = "lblThankYou";
			// 
			// lblBillTo
			// 
			resources.ApplyResources(this.lblBillTo, "lblBillTo");
			this.lblBillTo.Name = "lblBillTo";
			// 
			// lblShipTo
			// 
			resources.ApplyResources(this.lblShipTo, "lblShipTo");
			this.lblShipTo.Name = "lblShipTo";
			// 
			// lneBillTo
			// 
			resources.ApplyResources(this.lneBillTo, "lneBillTo");
			this.lneBillTo.LineWeight = 2F;
			this.lneBillTo.Name = "lneBillTo";
			this.lneBillTo.X1 = 0F;
			this.lneBillTo.X2 = 3F;
			this.lneBillTo.Y1 = 0.2F;
			this.lneBillTo.Y2 = 0.2F;
			// 
			// lneShipTo
			// 
			resources.ApplyResources(this.lneShipTo, "lneShipTo");
			this.lneShipTo.LineWeight = 2F;
			this.lneShipTo.Name = "lneShipTo";
			this.lneShipTo.X1 = 6.469F;
			this.lneShipTo.X2 = 3.469F;
			this.lneShipTo.Y1 = 0.2F;
			this.lneShipTo.Y2 = 0.2F;
			// 
			// txtBillToCompany
			// 
			this.txtBillToCompany.CanGrow = false;
			this.txtBillToCompany.DataField = "Customers.CompanyName";
			resources.ApplyResources(this.txtBillToCompany, "txtBillToCompany");
			this.txtBillToCompany.Name = "txtBillToCompany";
			// 
			// txtBillToAddress
			// 
			this.txtBillToAddress.DataField = "Address";
			resources.ApplyResources(this.txtBillToAddress, "txtBillToAddress");
			this.txtBillToAddress.Name = "txtBillToAddress";
			// 
			// txtBillToCity
			// 
			this.txtBillToCity.CanGrow = false;
			this.txtBillToCity.DataField = "City";
			resources.ApplyResources(this.txtBillToCity, "txtBillToCity");
			this.txtBillToCity.Name = "txtBillToCity";
			// 
			// txtBillToRegion
			// 
			this.txtBillToRegion.CanGrow = false;
			this.txtBillToRegion.DataField = "Region";
			resources.ApplyResources(this.txtBillToRegion, "txtBillToRegion");
			this.txtBillToRegion.Name = "txtBillToRegion";
			// 
			// txtBillToPostalCode
			// 
			this.txtBillToPostalCode.CanGrow = false;
			this.txtBillToPostalCode.DataField = "PostalCode";
			resources.ApplyResources(this.txtBillToPostalCode, "txtBillToPostalCode");
			this.txtBillToPostalCode.Name = "txtBillToPostalCode";
			// 
			// txtBillToCountry
			// 
			this.txtBillToCountry.CanGrow = false;
			this.txtBillToCountry.DataField = "Country";
			resources.ApplyResources(this.txtBillToCountry, "txtBillToCountry");
			this.txtBillToCountry.Name = "txtBillToCountry";
			// 
			// txtShipToCompany
			// 
			this.txtShipToCompany.CanGrow = false;
			this.txtShipToCompany.DataField = "ShipName";
			resources.ApplyResources(this.txtShipToCompany, "txtShipToCompany");
			this.txtShipToCompany.Name = "txtShipToCompany";
			// 
			// txtShipToAddress
			// 
			this.txtShipToAddress.DataField = "ShipAddress";
			resources.ApplyResources(this.txtShipToAddress, "txtShipToAddress");
			this.txtShipToAddress.Name = "txtShipToAddress";
			// 
			// txtShipToCity
			// 
			this.txtShipToCity.CanGrow = false;
			this.txtShipToCity.DataField = "ShipCity";
			resources.ApplyResources(this.txtShipToCity, "txtShipToCity");
			this.txtShipToCity.Name = "txtShipToCity";
			// 
			// txtShipToRegion
			// 
			this.txtShipToRegion.CanGrow = false;
			this.txtShipToRegion.DataField = "ShipRegion";
			resources.ApplyResources(this.txtShipToRegion, "txtShipToRegion");
			this.txtShipToRegion.Name = "txtShipToRegion";
			// 
			// txtShipToPostalCode
			// 
			this.txtShipToPostalCode.CanGrow = false;
			this.txtShipToPostalCode.DataField = "ShipPostalCode";
			resources.ApplyResources(this.txtShipToPostalCode, "txtShipToPostalCode");
			this.txtShipToPostalCode.Name = "txtShipToPostalCode";
			// 
			// txtShipToCountry
			// 
			this.txtShipToCountry.CanGrow = false;
			this.txtShipToCountry.DataField = "ShipCountry";
			resources.ApplyResources(this.txtShipToCountry, "txtShipToCountry");
			this.txtShipToCountry.Name = "txtShipToCountry";
			// 
			// txtSalesPerson
			// 
			this.txtSalesPerson.CanGrow = false;
			this.txtSalesPerson.DataField = "Salesperson";
			resources.ApplyResources(this.txtSalesPerson, "txtSalesPerson");
			this.txtSalesPerson.Name = "txtSalesPerson";
			// 
			// lblSalesPerson
			// 
			resources.ApplyResources(this.lblSalesPerson, "lblSalesPerson");
			this.lblSalesPerson.Name = "lblSalesPerson";
			this.lblSalesPerson.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// lblProductID
			// 
			resources.ApplyResources(this.lblProductID, "lblProductID");
			this.lblProductID.Name = "lblProductID";
			// 
			// lblProductName
			// 
			resources.ApplyResources(this.lblProductName, "lblProductName");
			this.lblProductName.Name = "lblProductName";
			// 
			// lblQty
			// 
			resources.ApplyResources(this.lblQty, "lblQty");
			this.lblQty.Name = "lblQty";
			// 
			// lblUnitPrice
			// 
			resources.ApplyResources(this.lblUnitPrice, "lblUnitPrice");
			this.lblUnitPrice.Name = "lblUnitPrice";
			// 
			// lblDiscount
			// 
			resources.ApplyResources(this.lblDiscount, "lblDiscount");
			this.lblDiscount.Name = "lblDiscount";
			// 
			// lblTotal
			// 
			resources.ApplyResources(this.lblTotal, "lblTotal");
			this.lblTotal.Name = "lblTotal";
			// 
			// lblShipped
			// 
			resources.ApplyResources(this.lblShipped, "lblShipped");
			this.lblShipped.Name = "lblShipped";
			this.lblShipped.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// txtShipDate
			// 
			this.txtShipDate.CanGrow = false;
			this.txtShipDate.DataField = "ShippedDate";
			resources.ApplyResources(this.txtShipDate, "txtShipDate");
			this.txtShipDate.Name = "txtShipDate";
			// 
			// lblShippedVia
			// 
			resources.ApplyResources(this.lblShippedVia, "lblShippedVia");
			this.lblShippedVia.Name = "lblShippedVia";
			this.lblShippedVia.Padding = new GrapeCity.ActiveReports.PaddingEx(2, 0, 0, 0);
			// 
			// txtShipper
			// 
			this.txtShipper.CanGrow = false;
			this.txtShipper.DataField = "Shippers.CompanyName";
			resources.ApplyResources(this.txtShipper, "txtShipper");
			this.txtShipper.Name = "txtShipper";
			// 
			// lblSubTotal
			// 
			resources.ApplyResources(this.lblSubTotal, "lblSubTotal");
			this.lblSubTotal.Name = "lblSubTotal";
			// 
			// lblFreight
			// 
			resources.ApplyResources(this.lblFreight, "lblFreight");
			this.lblFreight.Name = "lblFreight";
			// 
			// lblGrandTotal
			// 
			resources.ApplyResources(this.lblGrandTotal, "lblGrandTotal");
			this.lblGrandTotal.Name = "lblGrandTotal";
			// 
			// txtSubTotal
			// 
			this.txtSubTotal.CanGrow = false;
			this.txtSubTotal.DataField = "ExtendedPrice";
			resources.ApplyResources(this.txtSubTotal, "txtSubTotal");
			this.txtSubTotal.Name = "txtSubTotal";
			this.txtSubTotal.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtFreight
			// 
			this.txtFreight.CanGrow = false;
			this.txtFreight.DataField = "Freight";
			resources.ApplyResources(this.txtFreight, "txtFreight");
			this.txtFreight.Name = "txtFreight";
			this.txtFreight.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal;
			// 
			// txtTotal
			// 
			this.txtTotal.CanGrow = false;
			resources.ApplyResources(this.txtTotal, "txtTotal");
			this.txtTotal.Name = "txtTotal";
			// 
			// Detail
			// 
			this.Detail.CanGrow = false;
			this.Detail.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.txtProductID,
			this.txtProductname,
			this.txtQty,
			this.txtUnitPrice,
			this.txtDiscount,
			this.txtExtended});
			this.Detail.Height = 0.2F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			// 
			// PageHeader
			// 
			this.PageHeader.CanGrow = false;
			this.PageHeader.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblNorthWind,
			this.lblTraders,
			this.lblNWAddr1,
			this.lblNWAddr2,
			this.lblInvoice,
			this.lblOrderNum,
			this.txtOrderID,
			this.lblOrderDate,
			this.txtOrderDate,
			this.imgLogo});
			this.PageHeader.Height = 1.15F;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.CanGrow = false;
			this.PageFooter.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblThankYou});
			this.PageFooter.Name = "PageFooter";
			// 
			// ghOrderID
			// 
			this.ghOrderID.ColumnLayout = false;
			this.ghOrderID.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblBillTo,
			this.lblShipTo,
			this.lneBillTo,
			this.lneShipTo,
			this.txtBillToCompany,
			this.txtBillToAddress,
			this.txtBillToCity,
			this.txtBillToRegion,
			this.txtBillToPostalCode,
			this.txtBillToCountry,
			this.txtShipToCompany,
			this.txtShipToAddress,
			this.txtShipToCity,
			this.txtShipToRegion,
			this.txtShipToPostalCode,
			this.txtShipToCountry,
			this.txtSalesPerson,
			this.lblSalesPerson,
			this.lblProductID,
			this.lblProductName,
			this.lblQty,
			this.lblUnitPrice,
			this.lblDiscount,
			this.lblTotal,
			this.lblShipped,
			this.txtShipDate,
			this.lblShippedVia,
			this.txtShipper});
			this.ghOrderID.DataField = "OrderID";
			this.ghOrderID.Height = 1.5625F;
			this.ghOrderID.KeepTogether = true;
			this.ghOrderID.Name = "ghOrderID";
			// 
			// GFOrderID
			// 
			this.GFOrderID.CanGrow = false;
			this.GFOrderID.ColumnLayout = false;
			this.GFOrderID.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblSubTotal,
			this.lblFreight,
			this.lblGrandTotal,
			this.txtSubTotal,
			this.txtFreight,
			this.txtTotal});
			this.GFOrderID.Height = 0.6F;
			this.GFOrderID.KeepTogether = true;
			this.GFOrderID.Name = "GFOrderID";
			this.GFOrderID.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.After;
			// 
			// Invoice
			// 
			this.MasterReport = false;
			oleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\NWIND.MDB";
			oleDBDataSource1.SQL = "SELECT * FROM Invoices \r\nORDER BY Customers.CompanyName, OrderID";
			this.DataSource = oleDBDataSource1;
			this.MaxPages = ((long)(100));
			this.PageSettings.PaperHeight = 11F;
			this.PageSettings.PaperWidth = 8.5F;
			this.PrintWidth = 6.5F;
			this.Script = resources.GetString("$this.Script");
			this.Sections.Add(this.PageHeader);
			this.Sections.Add(this.ghOrderID);
			this.Sections.Add(this.Detail);
			this.Sections.Add(this.GFOrderID);
			this.Sections.Add(this.PageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
			"l; font-size: 10pt; color: Black; ddo-char-set: 186", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 16pt; font-style: normal; font-weight: bold", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-style: italic; font-weight: b" +
			"old", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-size: 13pt; font-style: normal; font-weight: bold", "Heading3", "Normal"));
			((System.ComponentModel.ISupportInitialize)(this.txtProductID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtProductname)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtExtended)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNorthWind)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTraders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNWAddr1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblNWAddr2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblInvoice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblOrderDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOrderDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblThankYou)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBillTo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblShipTo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillToCompany)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillToAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillToCity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillToRegion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillToPostalCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillToCountry)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipToCompany)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipToAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipToCity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipToRegion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipToPostalCode)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipToCountry)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSalesPerson)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSalesPerson)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProductID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblProductName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblUnitPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblDiscount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblShipped)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipDate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblShippedVia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtShipper)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblSubTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblFreight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblGrandTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSubTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFreight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		#endregion
		public GrapeCity.ActiveReports.Data.OleDBDataSource ds;
		private PageHeader PageHeader;
		private Label lblNorthWind;
		private Label lblTraders;
		private Label lblNWAddr1;
		private Label lblNWAddr2;
		private Label lblInvoice;
		private Label lblOrderNum;
		private TextBox txtOrderID;
		private Label lblOrderDate;
		private TextBox txtOrderDate;
		private Picture imgLogo;
		private GroupHeader ghOrderID;
		private Label lblBillTo;
		private Label lblShipTo;
		private Line lneBillTo;
		private Line lneShipTo;
		private TextBox txtBillToCompany;
		private TextBox txtBillToAddress;
		private TextBox txtBillToCity;
		private TextBox txtBillToRegion;
		private TextBox txtBillToPostalCode;
		private TextBox txtBillToCountry;
		private TextBox txtShipToCompany;
		private TextBox txtShipToAddress;
		private TextBox txtShipToCity;
		private TextBox txtShipToRegion;
		private TextBox txtShipToPostalCode;
		private TextBox txtShipToCountry;
		private TextBox txtSalesPerson;
		private Label lblSalesPerson;
		private Label lblProductID;
		private Label lblProductName;
		private Label lblQty;
		private Label lblUnitPrice;
		private Label lblDiscount;
		private Label lblTotal;
		private Label lblShipped;
		private TextBox txtShipDate;
		private Label lblShippedVia;
		private TextBox txtShipper;
		private Detail Detail;
		private TextBox txtProductID;
		private TextBox txtProductname;
		private TextBox txtQty;
		private TextBox txtUnitPrice;
		private TextBox txtDiscount;
		private TextBox txtExtended;
		private GroupFooter GFOrderID;
		private Label lblSubTotal;
		private Label lblFreight;
		private Label lblGrandTotal;
		public TextBox txtSubTotal;
		public TextBox txtFreight;
		public TextBox txtTotal;
		private PageFooter PageFooter;
		private Label lblThankYou;
	}
}
