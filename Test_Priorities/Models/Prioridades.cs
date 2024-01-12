using System.ComponentModel.DataAnnotations;

namespace Test_Priorities.Models
{
    public class Prioridades
    {
        [Key] // Llave primaria
        public int PrioridadId { get; set; }
        [Required(ErrorMessage = "Descripcion obligatoria")]
        public string? Descripción { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public int DiasCompromiso { get; set; }

    }
}
