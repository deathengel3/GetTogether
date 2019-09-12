using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Repositories
{
    public interface IEmpleadoRepository
    {
        Task<IEnumerable<Empleado>> ObtenerEmpleadosAsync();
        Task<Empleado> ObtenerEmpleadosPorNumEmpAsync(int numeroEmpleado);
        Task CrearEmpleadoAsync(Empleado empleado);
        void ActualizarEmpleado(Empleado empleado);
    }
}
