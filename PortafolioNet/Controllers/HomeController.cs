using Microsoft.AspNetCore.Mvc;
using PortafolioNet.Models;
using System.Diagnostics;

namespace PortafolioNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //ViewBag.Nombre = "Miguel Alonso";
            var persona = new Persona()
            {
                Nombre = "Miguel Alonso",
                Edad = 29,
                Descripcion = "Soy un desarrollador Full Stack Junior especializado en tecnologías .NET y Javascript."
            };

            return View(persona);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}