using Microsoft.Owin;
using Owin;
[assembly: OwinStartupAttribute(typeof(ActiveReportsWithMVC5.Startup))]
namespace ActiveReportsWithMVC5
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
		}
	}
}
