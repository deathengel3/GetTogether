using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GetTogether.Data.Resources
{
    public class SaveEmpleadoResource
    {
        [Required(ErrorMessage = "El número de empleado es requerido")]
        [MinLength(6, ErrorMessage = "El número de empleado debe contener al menos 6 caracteres")]
        [Range(0, int.MaxValue, ErrorMessage = "El valor del empleado debe ser un número positivo.")]
        public string NumeroEmpleado { get; set; }
        [Required(ErrorMessage = "El nombre del empleado es requerido")]
        [MaxLength(250, ErrorMessage = "El tamaño del nombre de empleado de contener como máximo 250 caracteres")]
        public string Nombre { get; set; }
    }
}
