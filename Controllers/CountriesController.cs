using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlbumApp.Controllers
{
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private AlbumContext Context { get; }

        public CountriesController(AlbumContext context) {
            Context = context;
        }

        // GET api/countries
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Context.Countries.ToList());
        }
    }
}
