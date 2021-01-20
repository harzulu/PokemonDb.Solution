using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public ActionResult<IEnumerable<Pokemon>> Get(string pokemonName, string pokemonType)
        {
            var query = _db.Pokemons.AsQueryable();

            if (pokemonName != null)
            {
                query = query.Where(entry => entry.PokemonName == pokemonName);
            }

            if (pokemonType != null)
            {
                query = query.Where(entry => entry.PokemonType == pokemonType);
            }

            return query.ToList();
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

        // PUT api/pokemons/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pokemon pokemon)
        {
            pokemon.PokemonId = id;
            _db.Entry(pokemon).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //DELETE api/pokemons/1
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var pokemonToDelete = _db.Pokemons.FirstOrDefault(entry => entry.PokemonId == id);
            _db.Pokemons.Remove(pokemonToDelete);
            _db.SaveChanges();
        }
    }
}