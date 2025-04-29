using System.ComponentModel.DataAnnotations;

namespace TipanExamen.Models
{
    public class Cliente
    {
        [Key] 
        public int ClienteId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Range(18, 100)]
        public int Edad { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        public bool EsActivo { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
    }
}
