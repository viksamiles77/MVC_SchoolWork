using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace Demo_App_1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var result = StaticDb.Users;
            return View(result);
        }

        public IActionResult Details(int id)
        {
            var result = StaticDb.Users.FirstOrDefault(x => x.Id == id);


            if (result == null)
            {
                return View("No User View");
            }
            return View(result);
        }
    }
}
