using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GetTogether.Data.Resources
{
    public class SaveVotacionesResource
    {
        [Required(ErrorMessage = "El empleado es requerido.")]
        public int EmpleadoId { get; set; }
        [Required(ErrorMessage = "La opción de comida es requerida.")]
        public int OpcionComidaId { get; set; }
    }
}
