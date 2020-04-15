using System;
using System.Collections.Generic;
using System.Data.OleDb;
using GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models;
using System.Configuration;
namespace GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.DBContext
{
	/// <summary>
	/// Gets the entire Customer,Orders,Order Details table of the NWIND.mdb
	/// Populates them into in-memory objects
	/// Analogous to how you would fetch data via Ado.net entity framework 
	/// </summary>
	public static class NWindData
	{
		public static List<Customer> Customers;
		public static List<Order> Orders;
		public static List<OrderDetails> OrderDetails;
		
		/// <summary>
		/// Gets customers from Customers table of NWind.mdb
		/// </summary>
		/// <returns>list of Customers</returns>
		public static List<Customer> GetNWindCustomers()
		{
			if (Customers == null)
			{
				var allcustomers = new List<Customer>();
				var conn = new OleDbConnection(GetNWindConnectString());
				conn.Open();
				var command = new OleDbCommand("Select Top 20 * from Customers", conn);
				var dr = command.ExecuteReader();
				while (dr != null && dr.Read())
				{
					allcustomers.Add(new Customer
					{
						Address = dr["Address"].ToString(),
						City = dr["City"].ToString(),
						CompanyName = dr["CompanyName"].ToString(),
						ContactName = dr["ContactName"].ToString(),
						ContactTitle = dr["ContactTitle"].ToString(),
						Country = dr["Country"].ToString(),
						CustomerId = dr["CustomerID"].ToString(),
						Fax = dr["Fax"].ToString(),
						Phone = dr["Phone"].ToString(),
						PostalCode = dr["PostalCode"].ToString(),
						Region = dr["Region"].ToString()
					});
				}
				conn.Close();
				Customers = allcustomers;
			}
			
			return Customers;
		}
		/// <summary>
		/// Gets Orders from Nwind.mdb
		/// </summary>
		/// <returns>list of orders</returns>
		public static List<Order> GetNWindOrders()
		{
			if (Orders == null)
			{
				var allorders = new List<Order>();
				var conn = new OleDbConnection(GetNWindConnectString());
				conn.Open();
				var command = new OleDbCommand("Select * from Orders", conn);
				var dr = command.ExecuteReader();
				while (dr != null && dr.Read())
				{
					allorders.Add(new Order
					  {
						  CustomerId = dr["CustomerID"].ToString(),
						  EmployeeId = Convert.ToInt64(dr["EmployeeID"]),
						  Freight = Convert.ToDecimal(dr["Freight"]),
						  OrderDate = dr["OrderDate"] == DBNull.Value ? DateTime.Now.ToShortDateString() : Convert.ToDateTime(dr["OrderDate"]).ToShortDateString(),
						  OrderId = Convert.ToInt64(dr["OrderID"]),
						  RequiredDate = dr["RequiredDate"] == DBNull.Value ? DateTime.Now.ToShortDateString() : Convert.ToDateTime(dr["RequiredDate"]).ToShortDateString(),
						  ShipAddress = dr["ShipAddress"].ToString(),
						  ShipCity = dr["ShipCity"].ToString(),
						  ShipCountry = dr["ShipCountry"].ToString(),
						  ShipName = dr["ShipName"].ToString(),
						  ShippedDate = dr["ShippedDate"] == DBNull.Value ? DateTime.Now.ToShortDateString() : Convert.ToDateTime(dr["ShippedDate"]).ToShortDateString(),
						  ShipPostalCode = dr["ShipPostalCode"].ToString(),
						  ShipRegion = dr["ShipRegion"].ToString(),
						  ShipVia = Convert.ToInt64(dr["ShipVia"])
					  });
				}
				conn.Close();
				Orders = allorders;
			}
			return Orders;
			 
		}
		/// <summary>
		/// Gets OrdersDetails from Order Details table of NWind.mdb
		/// </summary>
		/// <returns>List of OrderDetails</returns>
		public static List<OrderDetails> GetOrderDetails()
		{
			
			if (OrderDetails == null)
			{
				var allorderdetails = new List<OrderDetails>();
				var conn = new OleDbConnection(GetNWindConnectString());
				conn.Open();
				var command = new OleDbCommand("Select * from [Order Details]", conn);
				var dr = command.ExecuteReader();
				while (dr != null && dr.Read())
				{
					allorderdetails.Add(new OrderDetails { 
					Discount=Convert.ToInt32(dr["Discount"]),
					OrderId = Convert.ToInt64(dr["OrderID"]),
					ProductId = Convert.ToInt32(dr["ProductID"]),
					Quantity = Convert.ToInt32(dr["Quantity"]),
					UnitPrice = Convert.ToDecimal(dr["UnitPrice"])
					});
				}
				conn.Close();
				OrderDetails = allorderdetails;
			}
			return OrderDetails;
		}
		/// <summary>
		/// Reads the ConnectionString for the NWind.mdb from the web.config file
		/// </summary>
		/// <returns>connectionstring:-"NWindConnectionString" from web.config</returns>
		private static string GetNWindConnectString()
		{
			return ConfigurationManager.ConnectionStrings["NWindConnectionString"].ConnectionString;
		}
	}
}
