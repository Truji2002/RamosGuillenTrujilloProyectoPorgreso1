using System.ComponentModel.DataAnnotations;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class Cliente

    {
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        public string NombreCompleto { get; set; }
        public string Cedula { get; set; }
        [MaxLength(10)]
        public string Telefono { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Correo no valido")]
        public string? CorreoElectronico { get; set; }
        public DateOnly FechaNacimiento { get; set; }

    }
}
