using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        public static Pokemon GetDetails(int id)
        {
            var apiCallTask = ApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(jsonResponse.ToString());

            return pokemon;
        }
    }
}