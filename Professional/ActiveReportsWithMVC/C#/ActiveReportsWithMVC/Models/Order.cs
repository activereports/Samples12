using System;
namespace GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models
{
	/// <summary>
	/// Container for the Rows in the Orders Table of NWind.mdb
	/// </summary>
	public class Order
	{
		public Int64 OrderId { get; set; }
		public string CustomerId { get; set; }
		public Int64 EmployeeId { get; set; }
		public string OrderDate { get; set; }
		public string  RequiredDate { get; set; }
		public string  ShippedDate { get; set; }
		public Int64 ShipVia { get; set; }
		public decimal Freight { get; set; }
		public string ShipName { get; set; }
		public string ShipAddress { get; set; }
		public string ShipCity { get; set; }
		public string ShipRegion { get; set; }
		public string ShipPostalCode { get; set; }
		public string ShipCountry { get; set; }
	}
}
