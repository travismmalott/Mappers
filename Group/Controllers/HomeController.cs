using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Group.Models;
using Group.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Group.Controllers
{
    public class HomeController : Controller
    {
        
            public ActionResult Index()
            {
                //select
                return View();
            }
           
            [HttpPost]
            public IActionResult Index(string iEmail, string iPassword)
            {             
            return View("worldoverview");
            }

        [HttpGet]
            public ActionResult About()
            {
                //select
                return View("About");
            }

            [ActionName("Profile")]
            public ActionResult MyProfile()
            {
                //select
                return View("Profile");

            }

            public ActionResult WeGotOrders()
            {
                //select
                return View("WeGotOrders");
            }

            public ActionResult FavoriteBases()
            {
                //select
                return View("FavoriteBases");
            }
    }
}

