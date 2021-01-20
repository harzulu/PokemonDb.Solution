using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;

namespace Pokedex.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allPokemons = Pokemon.GetPokemons();
            return View(allPokemons);
        }
    }
}
