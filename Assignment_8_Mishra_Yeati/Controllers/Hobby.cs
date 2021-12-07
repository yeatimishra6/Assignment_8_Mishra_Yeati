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
    public class Hobby : ControllerBase
    {
        private readonly ILogger<Hobby> _logger;
        private readonly IFinalProjectDataDAO _context;

        public Hobby(ILogger<Hobby> logger, IFinalProjectDataDAO context)
        {
            _logger = logger;
            _context = context;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllHobby());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var hobbys = _context.GetHobbyById(id);
            if (hobbys == null)
            {

                return NotFound(id);
            }
            return Ok(_context.GetHobbyById(id));
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var hobbys = _context.GetHobbyById(id);


            if (hobbys == null)

            { return NotFound(id); }
            if (string.IsNullOrEmpty(hobbys.favMovie))
                return StatusCode(500, "An error occured while processing your request");

            return Ok();

        }

        [HttpPut]
        public IActionResult Put(Hobby muji)
        {
        //    var d = _context.UpdateHobby(muji);
           var Result = _context.UpdateHobby(muji);

            if (Result == null)

            { return NotFound(muji); }
            if (Result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Hobby hobbys)
        {
            var result = _context.Add(hobbys);
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
