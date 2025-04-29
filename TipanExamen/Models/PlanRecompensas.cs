using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TipanExamen.Models
{
    public class PlanRecompensas
    {
        [Key] 
        public int PlanRecompensasId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        public int PuntosAcumulados { get; set; }

        [Required]
        public string TipoRecompensa { get; set; }

        
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
