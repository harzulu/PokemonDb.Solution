﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonDb.Models;

namespace PokemonDb.Migrations
{
    [DbContext(typeof(PokemonDbContext))]
    [Migration("20210119225056_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PokemonDb.Models.Pokemon", b =>
                {
                    b.Property<int>("PokemonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PokemonName");

                    b.Property<string>("PokemonType");

                    b.HasKey("PokemonId");

                    b.ToTable("Pokemons");

                    b.HasData(
                        new
                        {
                            PokemonId = 1,
                            PokemonName = "Bulbasaur",
                            PokemonType = "Grass"
                        },
                        new
                        {
                            PokemonId = 2,
                            PokemonName = "Ivysaur",
                            PokemonType = "Grass"
                        },
                        new
                        {
                            PokemonId = 3,
                            PokemonName = "Venusaur",
                            PokemonType = "Grass"
                        },
                        new
                        {
                            PokemonId = 4,
                            PokemonName = "Charmander",
                            PokemonType = "Fire"
                        },
                        new
                        {
                            PokemonId = 5,
                            PokemonName = "Charmeleon",
                            PokemonType = "Fire"
                        },
                        new
                        {
                            PokemonId = 6,
                            PokemonName = "Charizard",
                            PokemonType = "Fire"
                        },
                        new
                        {
                            PokemonId = 7,
                            PokemonName = "Squirtle",
                            PokemonType = "Water"
                        },
                        new
                        {
                            PokemonId = 8,
                            PokemonName = "Wartortle",
                            PokemonType = "Water"
                        },
                        new
                        {
                            PokemonId = 9,
                            PokemonName = "Blastoise",
                            PokemonType = "Water"
                        },
                        new
                        {
                            PokemonId = 10,
                            PokemonName = "Caterpie",
                            PokemonType = "Bug"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
