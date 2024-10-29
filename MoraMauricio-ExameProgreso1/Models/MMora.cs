using System.ComponentModel.DataAnnotations;

namespace MoraMauricio_ExameProgreso1.Models
{
    public class MMora
    {
        [Key]
        public int Id { get; set; }
        public string Modelo { get; set; }
        public DateTime Año { get; set; }
        public Boolean Precio { get; set; }

    }
}
