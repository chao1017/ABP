using Microsoft.AspNetCore.Mvc;

namespace Roger.Api1.Web.Controllers
{
    public class HomeController : Api1ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}