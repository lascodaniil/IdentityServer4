using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Identity.WebApp.Controllers
{
    
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Login()
        {
            return View();
        }
    }
}