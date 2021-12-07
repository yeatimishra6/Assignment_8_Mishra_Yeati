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
    public class Infomation : ControllerBase
    {
        private readonly ILogger<Infomation> _logger;
        private readonly IFinalProjectDataDAO _context;

        public Infomation(ILogger<Infomation> logger, IFinalProjectDataDAO context)
        {
            _logger = logger;
            _context = context;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.GetAllInfomation());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var color = _context.GetInfomationById(id);
            if (color == null)
            {

                return NotFound(id);
            }
            return Ok(_context.GetInfomationById(id));
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var color = _context.GetInfomationById(id);


            if (color == null)

            { return NotFound(id); }
            if (string.IsNullOrEmpty(Infomation))
                return StatusCode(500, "An error occured while processing your request");

            return Ok();

        }

        [HttpPut]
        public IActionResult Put(Infomation infos)
        {
            var result = _context.UpdateInfomation(infos);

            if (result == null)

            { return NotFound(infos.id); }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Infomation infos)
        {
            var result = _context.Add(infos);
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

