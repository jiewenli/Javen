using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Javen.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : JavenControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}