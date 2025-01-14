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
        public IActionResult Resultado()
{
        // Crear un objeto de ejemplo, puedes remplazarlo por datos de base de datos
        var persona = new Persona
        {
            Nombre = "Juan",
            Apellido = "Pérez"
        };

        // Pasar el objeto persona a la vista
        return View(persona);
    }
    }
    
}
