using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agua.Models;

namespace Agua.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Calcular(DateTime ProximoCumple, int minutos)
        {
            /// Aquí tienen que hacer todo
            /// La fecha que y los minutos vienen del formulario 
            /// Investigar Model Binding 

            DateTime Hoy = DateTime.Today;
            TimeSpan DiasFaltantes = ProximoCumple - Hoy;
            int Agua = minutos * 12;
            int Tiempo = DiasFaltantes.Days;
            int BotellasFaltante = Agua * Tiempo;
            
            ViewBag.Dias = Tiempo;
            ViewBag.Botellas = BotellasFaltante;

            return View();
        }

    }
}
