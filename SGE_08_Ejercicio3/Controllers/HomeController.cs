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
            clsPersona persona = new clsPersona("juanyo","android >:I");
            return View(persona);
        }
        [HttpPost]
        public IActionResult Editar(clsPersona clsPersona)
        {
            return View("PersonaModificada",clsPersona);
        }
    }
}
