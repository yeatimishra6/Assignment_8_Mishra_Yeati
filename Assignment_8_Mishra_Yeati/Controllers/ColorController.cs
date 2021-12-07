using Assignment_8_Mishra_Yeati.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;
using Assignment_8_Mishra_Yeati.Data;

namespace Assignment_8_Mishra_Yeati.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColorController : ControllerBase
    {
        private readonly ILogger<ColorController> _logger;
        private readonly IFinalProjectDataDAO _context;

        public ColorController(ILogger<ColorController> logger, IFinalProjectDataDAO context)
        {
            _logger = logger;
            _context = context;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllColors());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var color = _context.GetColorById(id);
            if (color == null)
            {

                return NotFound(id);
            }
            return Ok(_context.GetColorById(id));
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var color = _context.GetColorById(id);


            if (color == null)

            { return NotFound(id); }
            if (string.IsNullOrEmpty(color.memberCommonFavColor))
                return StatusCode(500, "An error occured while processing your request");

            return Ok();

        }

        [HttpPut]
        public IActionResult Put(Color color) 
        {
            var colors = _context.UpdateColor(color);

            if (color == null)

            { return NotFound(color.id); }
            if (colors == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Color color) 
        {
            var result = _context.Add(color);
            if (result == null) 
            {
                return StatusCode(500, "Team already exists");
            }
            if (result == 0) 
            {
                return StatusCode(500, "Error occured while processing your request");
            }
            return Ok();
        }
    }
}
