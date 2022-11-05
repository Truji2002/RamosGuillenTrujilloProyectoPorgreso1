using System.ComponentModel.DataAnnotations;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class Cliente

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

        [Display(Name = "Correo electronico")]
        [Required(ErrorMessage = "Ingrese su correo electrónico")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese un correo valido")]
        public string? CorreoElectronico { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "Ingrese su fecha de nacimiento")]
        [DataType(DataType.DateTime, ErrorMessage = "Ingrese una fecha valida")]
        public DateTime FechaNacimiento { get; set; }

    }
}
