using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mappers.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Mappers.Controllers
{
    public class MessagesController : Controller 
    {
        
        
        
        public IActionResult Index()
        {
            return View();
        }
    }
}