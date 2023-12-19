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
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO> {
                new ProyectoDTO
            {
                Titulo="Google",
                Descripcion="E-Commerce realizado en asp.net core",
                Link="https://google.com",
                ImagenUrl="/imagenes/google.jpg"
            },
                new ProyectoDTO
            {
                Titulo="Amazon",
                Descripcion="E-Commerce realizado en angular y node",
                Link="https://amazon.com",
                ImagenUrl="/imagenes/amazon.jpg"
            },
                new ProyectoDTO
            {
                Titulo="Facebook",
                Descripcion="E-Commerce realizado en asp.net y react",
                Link="https://facebook.com",
                ImagenUrl="/imagenes/facebook.jpg"
            },
                new ProyectoDTO
            {
                Titulo="New York Times",
                Descripcion="E-Commerce realizado en asp.net Vue y Node",
                Link="https://nytimes.com",
                ImagenUrl="/imagenes/newyorktimes.png"
            }
            };
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