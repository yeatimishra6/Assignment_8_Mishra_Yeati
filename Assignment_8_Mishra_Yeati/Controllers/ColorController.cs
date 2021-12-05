using Assignment_8_Mishra_Yeati.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;


namespace Assignment_8_Mishra_Yeati.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColorController : ControllerBase
    {
        private readonly ILogger<ColorController> _logger;
        private readonly FinalProjectData _context;

        public ColorController(ILogger<ColorController> logger, FinalProjectData contexts)
        {
            _logger = logger;
            _context = contexts;
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Colors.ToList());
        }

    }
}
