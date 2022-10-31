using System.ComponentModel.DataAnnotations;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class Conductor

    {
        
        public int IdConductor { get; set; }

        [Required(ErrorMessage = "Ingresa la cédula")]
        [ValidarCedula]
        public string? Cedula { get; set; }

        [Required(ErrorMessage = "Ingresa el nombre")]
        [RegularExpression("[a-zA-Z] {1000}", ErrorMessage="Solo se permite ingresar letras.")]
        
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Ingresa el apellido")]
        [RegularExpression("[a-zA-Z] {1000}", ErrorMessage="Solo se permite ingresar letras.")]
        public string? Apellido { get; set; }

        [Required(ErrorMessage = "Ingresa el teléfono")]
        [RegularExpression( "[0-9999999999] {10}" , ErrorMessage = "Solo se permite ingresar numeros.")]
        public string? NumeroTelefono { get; set; }


        [Required(ErrorMessage = "Ingresa el correo")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Ingrese un correo valido.")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "Ingresa la fecha de nacimiento")]
        [DataType(DataType.Date, ErrorMessage ="Ingrese una fecha valida")]
        public DateOnly FechaNacimiento { get; set; }


        public class ValidarCedula : ValidationAttribute
        {


        }
        





        }
}
