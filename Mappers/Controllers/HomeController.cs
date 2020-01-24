using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Controllers
{


    public class HomeController : Controller
    {


        [HttpGet]
        public ActionResult Index()
        {
            //select
            return View("index");
        }


        [HttpPost]
        public ActionResult Index(string iName, string iEmail)
        {
            //insert
            return RedirectToAction("Completed");
        }


        public ActionResult Completed()
        {
            return View("Completed");
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

