using System.ComponentModel.DataAnnotations;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class Transporte
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingresa el tipo")]
        public int? Tipo { get; set; }

        [Required(ErrorMessage = "Ingresa el modelo")]
        public string? Modelo { get; set; }

        [Required(ErrorMessage = "Ingresa la mátricula")]
        public string? Matricula { get; set; }

        [Required(ErrorMessage = "Ingresa la capacidad")]
        [Range(10, 50, ErrorMessage = "Error. Ingrese un valor dentro los parámetros establecidos")]
        public int? Capacidad { get; set; }
    }
}
