using Microsoft.AspNetCore.Mvc;

namespace AspCoreMvc.Controllers
{
    /// <summary>
    /// Basic 컨트롤러 클래스
    /// </summary>
    public class BasicController : Controller
    {
        /// <summary>
        /// 액션 메서드 
        /// </summary>

        //http://localhost:5011/Basic
        //http://localhost:5011/Basic/Index
        public IActionResult Index()
        {
            return View();
        }

        //http://localhost:5011/Basic/Unit
        public IActionResult Unit()
        {
            return View();
        }

        //http://localhost:5011/Basic/Quiz
        [HttpGet]  //get 방식, 기본 디폴트, 생략 가능
        public IActionResult Quiz(int id, int page)
        {
            //var page = Request.Form["page"];
            //액션 메서드이 값을 뷰페이지에 전송
            ViewBag.Page = page;        //속성값으로 전달
            ViewData["Id"] = id;        //컬렉션 문자열 전달
            return View();
        }
        [HttpPost]      //post 방식
        public IActionResult Quiz(string answer)
        {
            ViewBag.Answer = answer;
            return View();
        }

        /// <summary>
        /// 강력한 형식(Strongly Typed)의 뷰 페이지
        /// </summary>
        /// http://localhost:5011/Basic/Analysis
        public IActionResult Analysis()
        {
            int score = 100;
            return View(score);
        }

        public IActionResult Review()
        {
            return View();
        }
    }
}
