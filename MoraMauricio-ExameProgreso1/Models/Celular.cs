using System.ComponentModel.DataAnnotations;

namespace MoraMauricio_ExameProgreso1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        public string Modelo { get; set; }
        public Decimal Precio { get; set; }
        public Boolean IdCelular { get; set; }
        public DateTime Año { get; set; }
    }
}
