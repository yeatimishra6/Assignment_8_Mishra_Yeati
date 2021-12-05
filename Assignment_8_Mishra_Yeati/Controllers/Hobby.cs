using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_8_Mishra_Yeati.Controllers
{
    public class Hobby : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
