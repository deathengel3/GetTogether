using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Data.Services.Communication
{
    public class SaveEmpleadoResponse : BadResponse
    {
        public Empleado Empleado { get; private set; }

        private SaveEmpleadoResponse(bool success, string message, Empleado empleado) : base(success, message)
        {
            this.Empleado = empleado;
        }

        public SaveEmpleadoResponse(Empleado empleado) : this(true, string.Empty, empleado) { }

        public SaveEmpleadoResponse(string message) : this(false, message, null) { }

    }
    
}
