using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
namespace ActiveReportsWithMVC5.Models
{
	public class CustomerContext 
	{
		public static List<Customer> Customers;
		public static Customer customer;	   
		/// <summary>
		/// Gets customers from CustomerOrders table of Reels.mdb
		/// <returns>list of Customers</returns>
		/// </summary>
		public static List<Customer> GetCustomers()
		{
			if (Customers == null)
			{
				var allcustomers = new List<Customer>();
				var conn = new OleDbConnection(ConnectString());
				conn.Open();
				var command = new OleDbCommand("select Distinct Top 30 CustomerID, FirstName,LastName,MiddleInitial from CustomerOrders", conn);
				var dr = command.ExecuteReader();
				while (dr != null && dr.Read())
				{
					allcustomers.Add(new Customer
					{
						ContactName = dr["FirstName"].ToString() +" "+dr["MiddleInitial"].ToString()+" "+ dr["LastName"].ToString(),						
						CustomerId = Convert.ToInt32(dr["CustomerID"].ToString())
					});
				}
				conn.Close();
				Customers = allcustomers;
			}
			return Customers;
		}
		/// <summary>
		/// Reads the ConnectionString for the Reels.mdb from the web.config file	  
		/// <returns>connectionstring:-"ConnectionString" from web.config</returns>
		/// </summary>
		private static string ConnectString()
		{
			return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
		}
		/// <summary>
		/// Gets customerdetail from CustomerOrders table of based on CustomerID	   
		/// <returns>Customer object顧客オブジェクト</returns>
		/// </summary>
		internal static Customer GetCustomersDetail( int id)
		{
				var conn = new OleDbConnection(ConnectString());
				conn.Open();
				var command = new OleDbCommand("Select * from CustomerOrders where CustomerID="+id, conn);
				var dr = command.ExecuteReader();
				while (dr != null && dr.Read())
				{
					customer=new Customer
					{
						Address = dr["Address1"].ToString(),
						City = dr["City"].ToString(),					   
						ContactName = dr["FirstName"].ToString() +" "+dr["MiddleInitial"].ToString()+" "+ dr["LastName"].ToString(),						
						CustomerId = Convert.ToInt32(dr["CustomerID"].ToString()),						
						Country = dr["Country"].ToString(),										   
						PostalCode = dr["PostalCode"].ToString(),
						Region = dr["Region"].ToString()
					};
				}
				conn.Close();
			return customer;
		}
	}
}
