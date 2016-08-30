using Simplify.Web;
using Simplify.Web.Attributes;
using Simplify.Web.Responses;

namespace $safeprojectname$.Controllers
{
	[Get("/")]
	public class DefaultController : Controller
	{
		public override ControllerResponse Invoke()
		{
			return new Tpl("Hello world!");
		}
	}
}