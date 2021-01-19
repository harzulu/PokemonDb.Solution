using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PokemonDb.Models;

namespace PokemonDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private PokemonDbContext _db;

        public PokemonsController(PokemonDbContext db)
        {
            _db = db;
        }

        // GET api/pokemons
        [HttpGet]
        public ActionResult<IEnumerable<Pokemon>> Get()
        {
            return _db.Pokemons.ToList();
        }

        // POST api/pokemons
        [HttpPost]
        public void Post([FromBody] Pokemon pokemon)
        {
            _db.Pokemons.Add(pokemon);
            _db.SaveChanges();
        }

        // GET api/pokemons/5
        [HttpGet("{id}")]
        public ActionResult<Pokemon> Get (int id)
        {
            return _db.Pokemons.FirstOrDefault(entry => entry.PokemonId == id);
        }
    }
}