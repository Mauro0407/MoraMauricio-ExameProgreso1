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
        [MaxLength(50)]
        public Decimal Precio { get; set; }
        public DateTime Año { get; set; }
        [ForeignKey("IdCelular")]
        public Boolean IdCelular { get; set; }
    }
}
