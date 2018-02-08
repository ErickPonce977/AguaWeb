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
            int BotellasxDias = minutos * 12;
            
            int fecha = DiasFaltantes.Days;
            int agua = BotellasxDias * fecha;
            ViewBag.Dias = fecha;
            ViewBag.Botellas = agua;

            return View();
        }

    }
}
