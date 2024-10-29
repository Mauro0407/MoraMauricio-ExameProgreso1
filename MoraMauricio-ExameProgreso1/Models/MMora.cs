using System.ComponentModel.DataAnnotations;

namespace MoraMauricio_ExameProgreso1.Models
{
    public class MMora
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public int Edad { get; set; }
        [MaxLength(150)]
        public decimal Salario { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Range(0, 100)]
        public bool Activo { get; set; }
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
        public Celular Celular { get; set; }

    }
}
