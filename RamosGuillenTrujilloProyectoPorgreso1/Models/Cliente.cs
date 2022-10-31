using System.ComponentModel.DataAnnotations;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        [Required]
        public string NombreCompleto { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        [MaxLength(10)]
        public string? CorreoElectronico { get; set; }
        [DataType(DataType.EmailAddress)]
        public DateOnly FechaNacimiento { get; set; }
    }
}
