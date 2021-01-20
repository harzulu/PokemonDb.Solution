using Pokedex.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Controllers
{
  public class PokemonsController : Controller
  {
    public IActionResult Index()
    {
      var allPokemons = Pokemon.GetPokemons();
      return View(allPokemons);
    }

    public ActionResult Details(int id)
    {
      var pokemon = Pokemon.GetDetails(id);
      return View(pokemon);
    }
  }
}