namespace GrapeCity.ActiveReports.Samples.Web.Professional.CodeReports
{
	/// <summary>
	/// Summary description for Invoicefiltered.
	/// </summary>
	partial class Invoice
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
			this.lblThankyou = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblBillTo = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lblShipTo = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.lneBillTo = new GrapeCity.ActiveReports.SectionReportModel.Line();
			this.LneShipTo = new GrapeCity.ActiveReports.SectionReportModel.Line();
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
			this.lblProductId = new GrapeCity.ActiveReports.SectionReportModel.Label();
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
			this.lblInvoiceTotal = new GrapeCity.ActiveReports.SectionReportModel.Label();
			this.txtSubTotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtFreight = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.txtTotal = new GrapeCity.ActiveReports.SectionReportModel.TextBox();
			this.Detail = new GrapeCity.ActiveReports.SectionReportModel.Detail();
			this.PageHeader = new GrapeCity.ActiveReports.SectionReportModel.PageHeader();
			this.PageFooter = new GrapeCity.ActiveReports.SectionReportModel.PageFooter();
			this.ghOrderID = new GrapeCity.ActiveReports.SectionReportModel.GroupHeader();
			this.GFOrderID = new GrapeCity.ActiveReports.SectionReportModel.GroupFooter();
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
			this.txtOrderDate.MultiLine = false;
			this.txtOrderDate.Name = "txtOrderDate";
			// 
			// imgLogo
			// 
			this.imgLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.imgLogo, "imgLogo");
			this.imgLogo.ImageData = ((System.IO.Stream)(resources.GetObject("imgLogo.ImageData")));
			this.imgLogo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.imgLogo.LineWeight = 1F;
			this.imgLogo.Name = "imgLogo";
			this.imgLogo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom;
			// 
			// lblThankyou
			// 
			resources.ApplyResources(this.lblThankyou, "lblThankyou");
			this.lblThankyou.Name = "lblThankyou";
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
			// LneShipTo
			// 
			resources.ApplyResources(this.LneShipTo, "LneShipTo");
			this.LneShipTo.LineWeight = 2F;
			this.LneShipTo.Name = "LneShipTo";
			this.LneShipTo.X1 = 6.469F;
			this.LneShipTo.X2 = 3.469F;
			this.LneShipTo.Y1 = 0.2F;
			this.LneShipTo.Y2 = 0.2F;
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
			// 
			// lblProductId
			// 
			resources.ApplyResources(this.lblProductId, "lblProductId");
			this.lblProductId.Name = "lblProductId";
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
			// lblInvoiceTotal
			// 
			resources.ApplyResources(this.lblInvoiceTotal, "lblInvoiceTotal");
			this.lblInvoiceTotal.Name = "lblInvoiceTotal";
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
			this.Detail.ColumnSpacing = 0F;
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
			this.lblThankyou});
			this.PageFooter.Height = 0.25F;
			this.PageFooter.Name = "PageFooter";
			// 
			// ghOrderID
			// 
			this.ghOrderID.ColumnLayout = false;
			this.ghOrderID.Controls.AddRange(new GrapeCity.ActiveReports.SectionReportModel.ARControl[] {
			this.lblBillTo,
			this.lblShipTo,
			this.lneBillTo,
			this.LneShipTo,
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
			this.lblProductId,
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
			this.ghOrderID.Height = 1.565F;
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
			this.lblInvoiceTotal,
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
			oleDBDataSource1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\evan.warren\\Documents\\GrapeCity Samples\\ActiveReports 12\\Data\\Nwind.mdb;Persist Security Info=False";
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
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 186", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
						"lic; ddo-char-set: 186", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 186", "Heading3", "Normal"));
			
		}
		#endregion
		private SectionReportModel.Detail Detail;
		private SectionReportModel.TextBox txtProductID;
		private SectionReportModel.TextBox txtProductname;
		private SectionReportModel.TextBox txtQty;
		private SectionReportModel.TextBox txtUnitPrice;
		private SectionReportModel.TextBox txtDiscount;
		private SectionReportModel.TextBox txtExtended;
		private SectionReportModel.PageHeader PageHeader;
		private SectionReportModel.Label lblNorthWind;
		private SectionReportModel.Label lblTraders;
		private SectionReportModel.Label lblNWAddr1;
		private SectionReportModel.Label lblNWAddr2;
		private SectionReportModel.Label lblInvoice;
		private SectionReportModel.Label lblOrderNum;
		private SectionReportModel.TextBox txtOrderID;
		private SectionReportModel.Label lblOrderDate;
		private SectionReportModel.TextBox txtOrderDate;
		private SectionReportModel.Picture imgLogo;
		private SectionReportModel.PageFooter PageFooter;
		private SectionReportModel.Label lblThankyou;
		private SectionReportModel.GroupHeader ghOrderID;
		private SectionReportModel.Label lblBillTo;
		private SectionReportModel.Label lblShipTo;
		private SectionReportModel.Line lneBillTo;
		private SectionReportModel.Line LneShipTo;
		private SectionReportModel.TextBox txtBillToCompany;
		private SectionReportModel.TextBox txtBillToAddress;
		private SectionReportModel.TextBox txtBillToCity;
		private SectionReportModel.TextBox txtBillToRegion;
		private SectionReportModel.TextBox txtBillToPostalCode;
		private SectionReportModel.TextBox txtBillToCountry;
		private SectionReportModel.TextBox txtShipToCompany;
		private SectionReportModel.TextBox txtShipToAddress;
		private SectionReportModel.TextBox txtShipToCity;
		private SectionReportModel.TextBox txtShipToRegion;
		private SectionReportModel.TextBox txtShipToPostalCode;
		private SectionReportModel.TextBox txtShipToCountry;
		private SectionReportModel.TextBox txtSalesPerson;
		private SectionReportModel.Label lblSalesPerson;
		private SectionReportModel.Label lblProductId;
		private SectionReportModel.Label lblProductName;
		private SectionReportModel.Label lblQty;
		private SectionReportModel.Label lblUnitPrice;
		private SectionReportModel.Label lblDiscount;
		private SectionReportModel.Label lblTotal;
		private SectionReportModel.Label lblShipped;
		private SectionReportModel.TextBox txtShipDate;
		private SectionReportModel.Label lblShippedVia;
		private SectionReportModel.TextBox txtShipper;
		private SectionReportModel.GroupFooter GFOrderID;
		private SectionReportModel.Label lblSubTotal;
		private SectionReportModel.Label lblFreight;
		private SectionReportModel.Label lblInvoiceTotal;
		private SectionReportModel.TextBox txtSubTotal;
		private SectionReportModel.TextBox txtFreight;
		private SectionReportModel.TextBox txtTotal;
	}
}
