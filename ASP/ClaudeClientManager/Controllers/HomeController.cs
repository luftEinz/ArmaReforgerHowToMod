using Microsoft.AspNetCore.Mvc;
using ClaudeClientManager.Models;

namespace ClaudeClientManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new ModGuideViewModel
            {
                Title = "PvPvE Modding Guide",
                CoreMods = new[] { "WCS Core", "RHS Status Quo" },
                Layers = new[]
                {
                    new ModLayer { Name = "Core_Layer1", Description = "Primary gameplay elements", Items = new[] { "Weapons", "Vehicles", "Clothing_Gear", "Factions" } },
                    new ModLayer { Name = "Core_Layer2", Description = "Environment & gameplay modes", Items = new[] { "Terrains_Maps", "Game_Modes", "Missions", "Terrain_Tools_Assets" } }
                }
            };
            return View(model);
        }

        public IActionResult Downloads()
        {
            return View();
        }

        public IActionResult Tools()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
