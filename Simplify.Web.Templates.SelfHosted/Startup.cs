using Owin;
using Simplify.Web.Owin;

namespace $safeprojectname$
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseSimplifyWeb();
		}
	}
}