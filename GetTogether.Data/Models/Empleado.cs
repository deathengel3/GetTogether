using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GetTogether.Data.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public int NumeroEmpleado { get; set; }
        public string Nombre { get; set; }
        public RolEnum Rol { get; set; }
        //public int VotacionId { get; set; }
        //public Votacion Votacion { get; set; }
    }
}
