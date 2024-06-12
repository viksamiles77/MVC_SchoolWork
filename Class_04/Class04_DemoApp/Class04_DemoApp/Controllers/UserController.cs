﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Reflection.Metadata.Ecma335;

namespace Class04_DemoApp.Controllers
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
                return View("NoUserView");
            }

            return View(result);
        }

        public IActionResult UsersViewBag()
        {
            ViewBag.Users = StaticDb.Users;
            ViewBag.Nesto = 1;
            return View();
        }

        public IActionResult UsersViewData()
        {
            ViewData["Users"] = StaticDb.Users;
            return View();
        }
    }
}
