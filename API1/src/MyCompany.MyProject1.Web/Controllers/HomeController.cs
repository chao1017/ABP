using Microsoft.AspNetCore.Mvc;

namespace MyCompany.MyProject1.Web.Controllers
{
    public class HomeController : MyProject1ControllerBase
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