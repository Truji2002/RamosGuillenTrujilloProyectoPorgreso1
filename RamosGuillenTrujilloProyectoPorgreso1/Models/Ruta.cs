using System.ComponentModel.DataAnnotations;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class Ruta
    {
        public int IdRuta { get; set; }

        [Required(ErrorMessage = "Debe ingresar el punto de partida")]
        [RegularExpression("[a-zA-Z] {1000}", ErrorMessage = "Solo se permite ingresar letras.")]
        public string PuntoPartida { get; set; }
        [Required(ErrorMessage = "Debe ingresar el punto de llegada")]
        [RegularExpression("[a-zA-Z] {1000}", ErrorMessage = "Solo se permite ingresar letras.")]
        public string PuntoLlegada { get; set; }

        [Required(ErrorMessage = "Debe ingresar el precio del viaje")]
        [RegularExpression("[0.0-9999999999.0] {10}", ErrorMessage = "Solo se permite ingresar numeros.")]
        [Range(50.0, 500, ErrorMessage = "Error. Ingrese un valor dentro los parámetros establecidos")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "Ingresa la fecha de partida")]
        [DataType(DataType.Date, ErrorMessage = "Ingrese una fecha valida")]
        public DateOnly FechaPartida { get; set; }

        //public DateTime HoraAproximadaLlegada { get; set; }

        [Required(ErrorMessage = "Ingresa el tipo")]
        [Display(Name = "Ingrese el tipo de transporte: ")]
        [RegularExpression("[a-zA-Z] {1000}", ErrorMessage = "Solo se permite ingresar letras.")]
        public string? Tipo { get; set; }

        [Required(ErrorMessage = "Ingresa el modelo")]
        [Display(Name = "Ingrese el modelo del transporte: ")]
        [RegularExpression("[a-zA-Z] {1000}", ErrorMessage = "Solo se permite ingresar letras.")]
        public string? Modelo { get; set; }

        [Required(ErrorMessage = "Ingresa la mátricula")]
        [Display(Name = "Ingrese la mátricula del transporte: ")]
        [RegularExpression("[a-zA-Z] {1000}", ErrorMessage = "Solo se permite ingresar letras.")]
        public string? Matricula { get; set; }

        [Required(ErrorMessage = "Ingresa la capacidad")]
        [Display(Name = "Ingrese la capacidad del transporte: ")]
        [Range(10, 50, ErrorMessage = "Error. Ingrese un valor dentro los parámetros establecidos")]
        public int? Capacidad { get; set; }
    }
}
