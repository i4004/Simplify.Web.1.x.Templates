using Microsoft.Owin.Hosting;

namespace $safeprojectname$
{
	public class WebApplicationStartup
	{
		public void Run()
		{
			WebApp.Start<Startup>("http://+:8080");
		}
	}
}