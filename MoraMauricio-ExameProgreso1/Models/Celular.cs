using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoraMauricio_ExameProgreso1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Modelo { get; set; }
        [Range(0, 100)]
        public int Año { get; set; }
        [MaxLength(100)]
        public decimal Precio { get; set; }
        public int MMoraId { get; set; }
        [MaxLength(100)]
        public MMora EArmas { get; set; }
    }
}
