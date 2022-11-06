using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class Usuario

    {
        [Key]
        public int IdCliente { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Ingrese su nombre")]
        [RegularExpression("^[a-zA-Z]*${1,100}", ErrorMessage = "Solo puede ingresar letras")]
        public string? Nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Ingrese su apellido")]
        [RegularExpression("^[a-zA-Z]*${1,100}", ErrorMessage = "Solo puede ingresar letras")]
        public string? Apellido { get; set; }

        [Display(Name = "Cedula")]
        [Required(ErrorMessage = "Ingrese su cedula")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Solo puede ingresar numeros")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Su cedula debe tener 10 números")]
        public string? Cedula { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "Ingrese su celular")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Solo puede ingresar numeros")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Su celular debe tener 10 números")]
        public string? Telefono { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "Ingrese su fecha de nacimiento")]
        [DataType(DataType.DateTime, ErrorMessage = "Ingrese una fecha valida")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Correo electronico")]
        [Required(ErrorMessage = "Ingrese su correo electrónico")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese un correo valido")]
        public string? CorreoElectronico { get; set; }


        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Ingresa la contraseña")]
        [DataType(DataType.Password, ErrorMessage = "Ingrese una contraseña valida")]
        public string? Contraseña { get; set; }

        [Display(Name = "Tipo (Conductor o Cliente)")]
        [Required(ErrorMessage = "Ingresa el tipo")]
        [RegularExpression("^[a-zA-Z]*${1,100}", ErrorMessage = "Solo puede ingresar letras")]
        [VerificarTipo]
        public string? Tipo { get; set; }
    
    }

    public class VerificarTipo : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            string valor1 = (string)value;
            if (valor1 == "Conductor"||valor1=="Cliente")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

