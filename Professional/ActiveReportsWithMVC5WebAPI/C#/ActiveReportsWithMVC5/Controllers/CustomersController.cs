using ActiveReportsWithMVC5.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace ActiveReportsWithMVC5.Controllers
{
	public class CustomersController : ApiController
	{
		//Return customers
		public IEnumerable<Customer> Get()
		{
			return CustomerContext.GetCustomers().AsEnumerable();
		}
		//Return customer based on CustomerID
		public Customer Get(int id)
		{
			Customer customer = CustomerContext.GetCustomersDetail(id);			   
			if(customer==null)
			{
				throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
			}
			return customer;
		}	   
	}
}
