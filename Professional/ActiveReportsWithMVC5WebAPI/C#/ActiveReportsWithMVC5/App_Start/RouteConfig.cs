using System.Web.Mvc;
using System.Web.Routing;
namespace ActiveReportsWithMVC5
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.IgnoreRoute("{*allActiveReport}", new { allActiveReport = @".*\.ar12(/.*)?" });
			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
