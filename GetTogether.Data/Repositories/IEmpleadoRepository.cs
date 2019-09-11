using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Repositories
{
    public interface IEmpleadoRepository
    {
        Task<IList<Empleado>> ObtenerEmpleados();
        Task<Empleado> ObtenerEmpleadosPorId(int numeroEmpleado);
        Task<Empleado> CrearEmpleado(Empleado empleado);
        Task<int> ActualizarEmpleado(Empleado empleadoAct);
        Task<int> EliminarEmpleado(int numeroEmpleado);
    }
}
