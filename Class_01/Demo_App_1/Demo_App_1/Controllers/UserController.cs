using Microsoft.AspNetCore.Mvc;

namespace Demo_App_1.Controllers
{
    public class UserController : Controller
    {
        // You need to create new view for new controller
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult PlainText()
        {
            return Content("This is plain text!");
        }

        public IActionResult JsonAction()
        {
            List<KeyValuePair<int, string>> names = new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string> ( 1, "Risto"),
                new KeyValuePair<int, string> (2, "Slave")
            };
            return Json(names);
        }
    }
}
