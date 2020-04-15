using System;
namespace GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models
{
	/// <summary>
	/// Container for the Rows in the Order Details Table of NWind.mdb
	/// </summary>
	public class OrderDetails
	{
		public Int64 OrderId { get; set; }
		public int ProductId { get; set; }
		public decimal UnitPrice { get; set; }
		public int Quantity { get; set; }
		public int Discount { get; set; }
	}
}
