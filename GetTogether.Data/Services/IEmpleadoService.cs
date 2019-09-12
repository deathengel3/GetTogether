using GetTogether.Data.Models;
using GetTogether.Data.Resources;
using GetTogether.Data.Services.Communication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Services
{
    public interface IEmpleadoService
    {
        Task<IEnumerable<Empleado>> ObtenerEmpleadosAsync();
        Task<Empleado> ObtenerEmpleadosPorNumEmpAsync(int numeroEmpleado);
        Task<EmpleadoResponse> CrearEmpleadoAsync(Empleado empleado);
        Task<EmpleadoResponse> ActualizarEmpleadoAsync(int numEmpleado, Empleado empleado);
        Task<EmpleadoResponse> EliminarEmpleadoAsync(int numEmpleado);
    }
}
