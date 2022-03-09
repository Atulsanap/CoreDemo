using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            List<string> classes = new List<string>
            {
                "Anubhuti Class (EA)", " Ac First Class(1A)","AC 2 Tier (2A)",""
            };
            return View(classes);
        }
    }
}
