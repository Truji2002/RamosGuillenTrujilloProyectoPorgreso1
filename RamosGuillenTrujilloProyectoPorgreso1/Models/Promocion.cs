using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class Promocion

    {
        [Key]
        public int IdPromociones { get; set; }

        [Display(Name = "Fecha de caducidad de la promocion")]
        [Required(ErrorMessage = "Ingresa la fecha de caducidad de la promocion")]
        [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha valida")]
        public DateTime FechaCaducidad { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "Ingrese el tipo de promocion")]
        [RegularExpression("^[a-zA-Z]*${1,100}", ErrorMessage = "Solo puede ingresar letras")]
        public string? TipoPromocion { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Ingrese la descripcion")]
        [RegularExpression("^[a-zA-Z]*${1,100}", ErrorMessage = "Solo puede ingresar letras")]
        public string? Descripcion { get; set; }

    }
}
