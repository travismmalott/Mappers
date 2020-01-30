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
        //private readonly UserManager<Mapper> _userManager;
        private ApplicationDbContext _context;
        //private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context/*ILogger<HomeController> logger, UserManager<Mapper> userManager*/)
        {
            _context = context;
            //_logger = logger;
            //_userManager = userManager;


        }


        public ActionResult usaoverview()
        {
            return View();
        }
        public ActionResult Index()
        {
            //var model = _context.Bases.ToList();
            //var user = await _userManager.GetUserAsync(User);
            //ViewBag.User = user?.UserName;
            //ViewBag.FirstName = user?.firstName;
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(string iEmail, string iPassword)
        //{
        //    return View("worldoverview");
        //}

        [HttpGet]
        public ActionResult About()
        {
            //select
            return View("About");
        }

        public ActionResult MyProfile()
        {
            //select
            return View("MyProfile");

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

