using System.ComponentModel.DataAnnotations;

namespace PokemonDb.Models
{
    public class Pokemon
    {
        public int PokemonId { get; set; }
        [Required]
        public string PokemonName { get; set; }
        [Required]
        public string PokemonType { get; set; }
    }
}