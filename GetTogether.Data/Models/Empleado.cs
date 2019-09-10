using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GetTogether.Data.Models
{
    public class Empleado
    {
        [Required(ErrorMessage = "El número de empleado es necesario")]
        [MinLength(6, ErrorMessage = "El número de empleado debe tener al menos 6 caracteres")]
        public int IdEmpleado { get; set; }
        [Required(ErrorMessage = "Se debe de especificar un nombre para el empleado")]
        public int Nombre { get; set; }
    }
}
