using System.ComponentModel.DataAnnotations;

namespace IngresoInformacion.Models
{
        public class Persona
    {
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
    }
}