using System.Web.Mvc;
using GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models;
namespace GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Controllers
{
	public class HomeController : Controller
	{
		/// <summary>
		/// Returns view Index.cshtml
		/// Passes the Entire Customers list to its model
		/// </summary>
		/// <returns>Index.cshtml</returns>
		public ActionResult Index()
		{
			
			return View("Index", Repository.GetCustomers());
		 
			
		}
		/// <summary>
		/// Start method
		/// </summary>
		/// <returns></returns>
		public ActionResult Start()
		{
			return Index();
		}
		/// <summary>
		/// Returns View Details.cshtml
		/// </summary>
		/// <param name="id">Customer ID</param>
		/// <returns>Details.cshtml</returns>
		public ActionResult Details(string id)
		{
			return View("Details",Repository.GetCustomer(id) );
		}
		/// <summary>
		/// Returns View Viewer.cshtml
		/// </summary>
		/// <param name="id">Customer id</param>
		/// <param name="reporttype">Section/Page</param>
		/// <returns>Viewer.cshtml</returns>
		public ActionResult ViewReport(string id,string reporttype)
		{
			return View("Viewer", new ReportDescriptor { Id = id, Type = reporttype });
		  
		}
	}
}
