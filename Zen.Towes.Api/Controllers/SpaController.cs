using System.Web.Mvc;

namespace Zen.Towes.Api.Controllers
{
    public class SpaController : Controller
    {
        // GET: Spa
        public ActionResult Index()
        {
            return File("build/index.html", "text/html");
        }
    }
}