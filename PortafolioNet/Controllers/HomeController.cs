﻿using Microsoft.AspNetCore.Mvc;
using PortafolioNet.Models;
using PortafolioNet.Servicios;
using System.Diagnostics;

namespace PortafolioNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioProyectos repositorioProyectos;


        public HomeController(
            IRepositorioProyectos repositorioProyectos

            )
        {
            this.repositorioProyectos = repositorioProyectos;

        }

        public IActionResult Index()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();

            var modelo = new HomeIndexViewModel()
            {
                Proyectos = proyectos
            };
            return View(modelo);
        }


        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();

            return View(proyectos);
        }

        public IActionResult Contacto()
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