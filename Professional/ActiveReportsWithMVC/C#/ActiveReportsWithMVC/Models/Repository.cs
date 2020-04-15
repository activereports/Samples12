using System.Collections.Generic;
using System.Linq;
using GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.DBContext;
namespace GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models
{
	/// <summary>
	/// Container for data required by application
	/// </summary>
	public static class Repository
	{
		/// <summary>
		/// Gets the Orders for a particular CustomerID
		/// </summary>
		/// <param name="id">Customer ID</param>
		/// <returns>Orders</returns>
		public static IEnumerable<Order> GetOrders(string id)
		{
			return NWindData.GetNWindOrders().FindAll(s => s.CustomerId == id);
		}
		/// <summary>
		/// Gets Order details for a particular CustomerID
		/// </summary>
		/// <param name="customerid">CustomerID</param>
		/// <returns>Order Details</returns>
		public static IEnumerable<OrderDetails> GetDetails(string customerid)
		{
			var ordersofcustomer = GetOrders(customerid);
			return ordersofcustomer.SelectMany(order => NWindData.GetOrderDetails().FindAll(s => s.OrderId == order.OrderId)).ToList();
		}
		/// <summary>
		/// Gets the details of Customer
		/// </summary>
		/// <param name="id">CustomerID</param>
		/// <returns>Customer Details</returns>
		public static Customer GetCustomer(string id)
		{
			return NWindData.GetNWindCustomers().FirstOrDefault(s => s.CustomerId == id);
		}
		/// <summary>
		/// Gets Customers ordered by ContactName
		/// </summary>
		/// <returns>Ordered list of Customers</returns>
		public static List<Customer> GetCustomers()
		{
			return NWindData.GetNWindCustomers().OrderBy(x => x.ContactName).ToList();
		}
		
	}
}
