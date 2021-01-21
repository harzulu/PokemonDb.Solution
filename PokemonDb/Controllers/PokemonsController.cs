using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokemonDb.Models;

namespace PokemonDb.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/{v:apiVersion}/Pokemons")]
    [ApiController]
    public class PokemonsV1Controller : ControllerBase
    {
        private PokemonDbContext _db;

        public PokemonsV1Controller(PokemonDbContext db)
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
    }

        //[ApiVersion("2.0')]
        // [Route(“api/{version:ApiVersion}/Values”)]
        //[ApiController]
        // POST api/pokemons
    [ApiVersion("2.0")]
    [Route("api/{v:apiVersion}/Pokemons")]
    [ApiController]
    public class PokemonsV2Controller : ControllerBase
    {
        private PokemonDbContext _db;

        public PokemonsV2Controller(PokemonDbContext db)
        {
            _db = db;
        }
        
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