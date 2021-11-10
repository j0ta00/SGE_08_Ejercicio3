using Microsoft.AspNetCore.Mvc;
using MisClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGE_08_Ejercicio3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Editar()
        {
            clsPersona persona = new clsPersona();
            return View(persona);
        }
        [HttpPost]
        public IActionResult Editar(clsPersona clsPersona)
        {
            if (!ModelState.IsValid){

                return View(clsPersona);

            }
            else
            {
                return View("PersonaModificada", clsPersona);
            }
        }
    }
}
