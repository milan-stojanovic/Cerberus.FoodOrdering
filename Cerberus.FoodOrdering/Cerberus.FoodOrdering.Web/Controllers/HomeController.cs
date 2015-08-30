using System.Web.Mvc;

namespace Cerberus.FoodOrdering.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}