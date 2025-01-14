using Microsoft.AspNetCore.Mvc;
using IngresoInformacion.Models;

namespace IngresoInformacion.Controllers
{
    public class PersonaController : Controller
    {
        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        // Acción para mostrar el formulario
        public IActionResult Ingresar()
        {
            return View();
        }

        // Acción para mostrar los resultados (por ejemplo)
        public IActionResult Resultados()
        {
            return View();
        }
    }
    
}
