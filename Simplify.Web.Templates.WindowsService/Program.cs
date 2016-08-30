using Simplify.WindowsServices;

namespace $safeprojectname$
{
	internal class Program
	{
		private static void Main(string[] args)
		{
#if DEBUG
			System.Diagnostics.Debugger.Launch();
#endif

			new BasicServiceHandler<WebApplicationStartup>(true).Start(args);
		}
	}
}