using System.ComponentModel.DataAnnotations;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class Conductor

    {
        [Key]
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
        public DateTime FechaNacimiento { get; set; }


        [Required(ErrorMessage = "Ingresa la fecha de emision de la licencia")]
        [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha valida")]
        public DateTime FechaEmisionLicencia { get; set; }


        [Required(ErrorMessage = "Ingresa la fecha de vencimiento de la licencia")]
        [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha valida")]
        public DateTime FechaVencimientoLicencia { get; set; }

        [Required(ErrorMessage = "Ingresa la contraseña")]
        [DataType(DataType.Password, ErrorMessage ="Ingrese una contraseña valida")]
        public string? Contraseña { get; set; }



        public class ValidarCedula : ValidationAttribute
        {


        }
        





        }
}
