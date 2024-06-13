using Microsoft.AspNetCore.Mvc;

namespace AspCoreMvc.Controllers
{
    public class FirstController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public string Index()
        //{
        //    return "안녕하세요";
        //}

        public object Index()
        {
            return new { Name = "백아", Age = 78 };
        }


        public IActionResult WithoutView()
        {
            return View();
        }
    }
}
