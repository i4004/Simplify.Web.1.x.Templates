using Microsoft.Owin.Hosting;

namespace $safeprojectname$
{
	public class WebApplicationStartup
	{
		public void Run()
		{
			WebApp.Start<Startup>("http://localhost:8080");
		}
	}
}