using Microsoft.AspNetCore.Mvc;

namespace Roger.SimpleTaskSystem.Web.Controllers
{
    public class HomeController : SimpleTaskSystemControllerBase
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