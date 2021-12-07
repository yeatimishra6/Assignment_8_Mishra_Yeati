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
    public class favFood : ControllerBase
    {
        private readonly ILogger<favFood> _logger;
        private readonly IFinalProjectDataDAO _context;

        public favFood(ILogger<favFood> logger, IFinalProjectDataDAO context)
        {
            _logger = logger;
            _context = context;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllFoods());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var food = _context.GetFoodById(id);
            if (food == null)
            {

                return NotFound(id);
            }
            return Ok(_context.GetFoodById(id));
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var food = _context.GetFoodById(id);


            if (food == null)

            { return NotFound(id); }
            if (string.IsNullOrEmpty(food.favBreakfastPlace))
                return StatusCode(500, "An error occured while processing your request");

            return Ok();

        }

        [HttpPut]
        public IActionResult Put(Favoritebreakfastfoods food)
        {
            var foods = _context.UpdateFood(food);

            if (foods == null)

            { return NotFound(food.id); }
            if (foods == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Favoritebreakfastfoods Food)
        {
            var result = _context.Add(Food);
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
