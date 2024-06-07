using Microsoft.AspNetCore.Mvc;

namespace Demo_App_1.Controllers
{
    [Route("fakturi/[Action]")]
    public class InvoiceController : Controller
    {
        //[Route("fakturi/all")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
