using System.ComponentModel.DataAnnotations;

namespace TipanExamen.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no debe superar los 100 caracteres.")]
        public string Nombre { get; set; }

        [Range(18, 100, ErrorMessage = "La edad debe estar entre 18 y 100 años.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
        public string Correo { get; set; }

        [Required]
        public bool EsActivo { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "La fecha de registro es obligatoria.")]
        public DateTime FechaRegistro { get; set; }
    }
}
