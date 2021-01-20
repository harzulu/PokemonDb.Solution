using Microsoft.EntityFrameworkCore;

namespace PokemonDb.Models
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext(DbContextOptions<PokemonDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pokemon> Pokemons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pokemon>()
                .HasData(
                    new Pokemon { PokemonId = 1, PokemonName = "Bulbasaur", PokemonType = "Grass"},
                    new Pokemon { PokemonId = 2, PokemonName = "Ivysaur", PokemonType = "Grass"},
                    new Pokemon { PokemonId = 3, PokemonName = "Venusaur", PokemonType = "Grass"},
                    new Pokemon { PokemonId = 4, PokemonName = "Charmander", PokemonType = "Fire"},
                    new Pokemon { PokemonId = 5, PokemonName = "Charmeleon", PokemonType = "Fire"},
                    new Pokemon { PokemonId = 6, PokemonName = "Charizard", PokemonType = "Fire"},
                    new Pokemon { PokemonId = 7, PokemonName = "Squirtle", PokemonType = "Water"},
                    new Pokemon { PokemonId = 8, PokemonName = "Wartortle", PokemonType = "Water"},
                    new Pokemon { PokemonId = 9, PokemonName = "Blastoise", PokemonType = "Water"},
                    new Pokemon { PokemonId = 10, PokemonName = "Caterpie", PokemonType = "Bug"} 
                );
        }
    }
}