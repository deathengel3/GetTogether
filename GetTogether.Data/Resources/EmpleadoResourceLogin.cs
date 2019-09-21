using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Data.Resources
{
    public class EmpleadoResourceLogin
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public RolEnum Rol { get; set; }
        public string Token { get; set; }
    }
}
