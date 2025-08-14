using Microsoft.AspNetCore.Mvc;

namespace Movie.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController
        public ActionResult Index()
        {
            return View();
        }

    }
}
