using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class SignInModel
    {
        [ForeignKey("Conductor")]
        [Display(Name = "Correo electronico")]
        [Required(ErrorMessage = "Ingrese su correo electrónico")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese un correo valido")]
        public string? CorreoElectronico { get; set; }

        [ForeignKey("Conductor")]
        [Required(ErrorMessage = "Ingresa la contraseña")]
        [DataType(DataType.Password, ErrorMessage = "Ingrese una contraseña valida")]
        public string? Contraseña { get; set; }
    }
}
