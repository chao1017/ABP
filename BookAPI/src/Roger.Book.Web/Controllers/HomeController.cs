using Microsoft.AspNetCore.Mvc;

namespace Roger.Book.Web.Controllers
{
    public class HomeController : BookControllerBase
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