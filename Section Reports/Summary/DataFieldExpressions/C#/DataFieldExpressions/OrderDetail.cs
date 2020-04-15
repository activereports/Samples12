namespace GrapeCity.ActiveReports.Samples.DataFieldExpressions
{
	class OrderDetail
	{
		public OrderDetail(string productName, double unitPrice, int quantity)
		{
			this.productName = productName;
			this.unitPrice  = unitPrice;
			this.quantity = quantity;
		}
		public string productName;
		public double unitPrice;
		public int quantity;
	}
}
