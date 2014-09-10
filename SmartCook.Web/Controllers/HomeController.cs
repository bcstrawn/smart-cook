using System.Web.Mvc;

namespace SmartCook.Web.Controllers
{
    public class HomeController : SmartCookControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}