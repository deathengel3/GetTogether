using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Data.Services.Communication
{
    public class EmpleadoResponse : BaseResponse
    {
        public Empleado Empleado { get; private set; }

        private EmpleadoResponse(bool success, string message, Empleado empleado) : base(success, message)
        {
            this.Empleado = empleado;
        }

        public EmpleadoResponse(Empleado empleado) : this(true, string.Empty, empleado) { }

        public EmpleadoResponse(string message) : this(false, message, null) { }

    }
    
}
