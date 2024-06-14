using Microsoft.AspNetCore.Mvc;

namespace AspCoreMvc.Controllers
{
    public class PagesController : Controller
    {
        //Views/Pages/Index.cshtml 호출
        //http://localhost:5011/pages
        public IActionResult Index()
        {
            return View();
        }

        //Views/Pages/Welcome.cshtml
        //http://localhost:5011/pages/Welcome
        public IActionResult Welcome()
        {
            return View();
        }

        //Views/Pages/NotFound.cshtml 호출
        //http://localhost:5011/pages/NotFoundPage
        public IActionResult NotFoundPage()
        {
            return View();
        }

        //iews/Pages/NotAssigned.cshtml 호출
        //http://localhost:5011/pages/NotAssigned
        public IActionResult NotAssigned()
        {
            return View();
        }

        //http://localhost:5011/pages/Intro
        public IActionResult Intro()
        {
            return View();
        }
    }
}
