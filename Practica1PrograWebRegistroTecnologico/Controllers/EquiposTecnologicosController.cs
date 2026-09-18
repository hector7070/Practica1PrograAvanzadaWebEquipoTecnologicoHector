using Microsoft.AspNetCore.Mvc;
using Practica1PrograWebRegistroTecnologico.Models;

namespace Practica1PrograWebRegistroTecnologico.Controllers
{
    public class EquiposTecnologicosController : Controller
    {
        [HttpGet]
        public IActionResult CrearEquipoTecnologico()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearEquipoTecnologico([Bind("Nombre,Marca,Precio,CodigoInventario")] EquipoTecnologico equipo)
        {
            if (!ModelState.IsValid)
            {
                return View(equipo);
            }
            return View("Resultado", equipo);
        }
    }
}
