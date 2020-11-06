using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cari.Business.Abstract;
using Cari.WebUI.Library;
using Cari.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cari.WebUI.Controllers
{
   
    public class LoginController : Controller
    {

        public readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var user = _userService.Get(i => i.Username == username && i.Password == password);
            if (user!=null)
            {
                HttpContext.Session.SetJson("user", user);
                return RedirectToAction("Index", "Home");

            }
            else
            {
                TempData["Error"] = "Error";
                return RedirectToAction("Index", "Login");
            }
        }

        [HttpGet]
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("user");
            return RedirectToAction("Index","Login");
        }

    }
}