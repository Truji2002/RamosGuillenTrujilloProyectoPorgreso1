using System.ComponentModel.DataAnnotations;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class Ruta
    {

        [Key]
        public int IdRuta { get; set; }

        [Display(Name = "Fecha de emisión de la licencia")]
        [Required(ErrorMessage = "Ingresa la fecha de emision de la licencia")]
        [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha valida")]
        public DateTime FechaEmisionLicencia { get; set; }

        [Display(Name = "Fecha de vencimiento de la licencia")]
        [Required(ErrorMessage = "Ingresa la fecha de vencimiento de la licencia")]
        [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha valida")]
        public DateTime FechaVencimientoLicencia { get; set; }

       

        [Display(Name = "Punto de llegada")]
        [Required(ErrorMessage = "Debe ingresar el punto de llegada")]
        [RegularExpression("^[a-zA-Z]*${1,100}", ErrorMessage = "Solo puede ingresar letras")]
        public string? PuntoLlegada { get; set; }

        [Display(Name = "Precio del viaje")]
        [Required(ErrorMessage = "Debe ingresar el precio del viaje")]
        [RegularExpression("^[0.0-9.9]*$", ErrorMessage = "Solo puede ingresar numeros")]
        [Range(50.0, 500, ErrorMessage = "Error. Ingrese un valor dentro los parámetros establecidos")]
        public double Precio { get; set; }

        

        //public DateTime HoraAproximadaLlegada { get; set; }

        [Required(ErrorMessage = "Ingresa el tipo")]
        [Display(Name = "Tipo de transporte")]
        [RegularExpression("^[a-zA-Z]*${1,100}", ErrorMessage = "Solo puede ingresar letras")]
        public string? Tipo { get; set; }

        [Required(ErrorMessage = "Ingresa el modelo")]
        [Display(Name = "Modelo del transporte")]
        [RegularExpression("^[a-zA-Z]*${1,100}", ErrorMessage = "Solo puede ingresar letras")]
        public string? Modelo { get; set; }

        [Required(ErrorMessage = "Ingresa la mátricula")]
        [Display(Name = "Mátricula del transporte ")]
        [RegularExpression("^[a-zA-Z]*${1,100}", ErrorMessage = "Solo puede ingresar letras")]
        public string? Matricula { get; set; }

        [Required(ErrorMessage = "Ingresa la capacidad")]
        [Display(Name = "Capacidad de personas del transporte")]
        [Range(10, 50, ErrorMessage = "Error. Ingrese un valor dentro los parámetros establecidos")]
        [RegularExpression("^[0.-9.]*$", ErrorMessage = "Solo puede ingresar numeros")]
        public int? Capacidad { get; set; }
    }
}
