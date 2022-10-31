using System.ComponentModel.DataAnnotations;

namespace RamosGuillenTrujilloProyectoPorgreso1.Models
{
    public class Ruta
    {
        public int IdRuta { get; set; }
        [Required(ErrorMessage = "Debe ingresar el punto de partida")]
        public string PuntoPartida { get; set; }
        [Required(ErrorMessage = "Debe ingresar el punto de llegada")]
        public string PuntoLlegada { get; set; }
        public double Precio { get; set; }      
        public DateOnly FechaPartida { get; set; }

        public DateTime HoraAproximadaLlegada { get; set; }
    }
}
