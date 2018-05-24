using System.Collections.Generic;
using System.Linq;
using AlbumApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlbumApp.Controllers
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {

        private AlbumContext Context { get; }

        public PlayersController(AlbumContext context)
        {
            Context = context;
        }

        // GET api/players/5
        [HttpGet("{id}", Name = "GetPlayer")]
        public IActionResult Get(int id)
        {
            Player result = Context.Players.Find(id);
            
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // PUT api/players/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Player newModel)
        {
            var current = Context.Players.Find(id);
            if (current == null)
            {
                return NotFound();
            }

            current.FirstName = newModel.FirstName ?? current.FirstName;
            current.LastName = newModel.LastName ?? current.LastName;
            current.Position = newModel.Position ?? current.Position;

            Context.Players.Update(current);

            Context.SaveChanges();

            return NoContent();
        }

        // DELETE api/players/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var model = Context.Players.Find(id);
            if (model == null)
            {
                return NotFound();
            }

            Context.Entry(model).State = EntityState.Deleted;

            Context.SaveChanges();

            return NoContent();
        }
    }
}
