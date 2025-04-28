using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.EntidadesNegocio
{
    public class PersonaR
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? NombreR { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string? ApellidoR { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatorio")]
        public DateTime FechaNacimientoR { get; set; }

        [Required(ErrorMessage = "El sueldo es obligatorio")]
        public decimal SueldoR { get; set; }

        public byte EstatusR { get; set; }
    }
}
