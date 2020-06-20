using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium1.Model;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium1.Controllers
{
    [Route("api/championships")]
    [ApiController]
    public class ChampionshipsController : ControllerBase
    {
        private readonly KolokwiumDBContext _context;

        public ChampionshipsController (KolokwiumDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetChampionShip()
        {
            return Ok();
        }
    }
}