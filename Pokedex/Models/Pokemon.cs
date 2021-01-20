using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pokedex.Models;

namespace Pokedex.Models
{
    public class Pokemon
    {
        public int PokemonId { get; set; }
        public string PokemonName { get; set; }
        public string PokemonType { get; set; }

        public static List<Pokemon> GetPokemons()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Pokemon> pokemonList = JsonConvert.DeserializeObject<List<Pokemon>>(jsonResponse.ToString());

            return pokemonList;
        }
    }
}