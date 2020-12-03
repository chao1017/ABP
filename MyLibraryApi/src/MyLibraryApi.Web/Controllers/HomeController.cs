using Microsoft.AspNetCore.Mvc;

namespace MyLibraryApi.Web.Controllers
{
    public class HomeController : MyLibraryApiControllerBase
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