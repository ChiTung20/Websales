using Microsoft.AspNetCore.Mvc;

namespace DA.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
