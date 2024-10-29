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
        public int Anio { get; set; }
        [MaxLength(100)]
        public double Precio { get; set; }
        [DataType(DataType.Currency)]
        public int MMoraId { get; set; }
        [MaxLength(100)]
        public MMora EArmas { get; set; }
    }
}
