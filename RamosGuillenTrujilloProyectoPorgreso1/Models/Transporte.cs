using System.ComponentModel.DataAnnotations;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class Transporte
    {
        public int Id { get; set; }
        
        [Required]
        public int Tipo { get; set; }
        
        [Required]
        public string Modelo { get; set; }
        
        [Required]
        public string Matricula { get; set; }

        [Required]
        [Range(10, 50, ErrorMessage = "Error. Ingrese un valor dentro los parámetros establecidos")]
        public int Capacidad { get; set; }

    }
}
