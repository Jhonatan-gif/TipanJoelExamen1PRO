using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TipanExamen.Models
{
    public class Reserva
    {
        [Key] 
        public int ReservaId { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaEntrada { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }

        [Range(1, 10000)]
        public decimal ValorPagar { get; set; }

        
        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }

}
