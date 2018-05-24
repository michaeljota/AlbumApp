using System.Collections.Generic;
using System.Linq;
using AlbumApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlbumApp.Controllers
{
    [Route("api/countries/{countryId:int}/players")]
    public class CountriesPlayersController : Controller
    {

        private AlbumContext Context { get; }

        public CountriesPlayersController(AlbumContext context)
        {
            Context = context;
        }

        // GET api/countries/1/players
        [HttpGet]
        public IActionResult GetAll([FromRoute] int countryId)
        {
            var country = Context.Countries.Find(countryId);
            
            if (country == null)
            {
                return NotFound();
            }

            return Ok(Context.Players.Where(p => p.CountryId == countryId).ToList());
        }

        // POST api/countries/1/players
        [HttpPost]
        public IActionResult Post([FromRoute] int countryId, [FromBody] Player model)
        {
            var country = Context.Countries.Find(countryId);
            if (country == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            
            country.Players.Add(model);
            Context.SaveChanges();

            return CreatedAtRoute("GetPlayer", new { id = model.ID }, model);
        }
    }
}
