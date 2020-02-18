using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mappers.Models;
using Microsoft.AspNetCore.Identity;
using Mappers.Data;

namespace Mappers.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<Mapper> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger, UserManager<Mapper> userManager)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }
        public ActionResult Overview()
        {
            return View();
        }
        public ActionResult Index()
        {

            return View();
        }    

        [HttpGet]
        public ActionResult About()
        {
            //select
            return View("About");
        }
        public ActionResult WhoAreWe()
        {
            return View();
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


