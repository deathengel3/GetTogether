using GetTogether.Data.Models;
using GetTogether.Data.Services.Communication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Repos
{
    public interface IEmpleadoService
    {
        Task<IEnumerable<Empleado>> ObtenerEmpleadosAsync();
        Task<Empleado> ObtenerEmpleadosPorNumEmpAsync(int numeroEmpleado);
        Task<SaveEmpleadoResponse> CrearEmpleadoAsync(Empleado empleado);
        Task<SaveEmpleadoResponse> ActualizarEmpleadoAsync(int numEmpleado, Empleado empleado);
    }
}
