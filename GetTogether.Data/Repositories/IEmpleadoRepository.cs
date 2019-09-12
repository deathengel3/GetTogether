using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Repositories
{
    public interface IEmpleadoRepository
    {
        Task<IEnumerable<Empleado>> GetAllAsync();
        Task<Empleado> FindByNumEmpleado(int numeroEmpleado);
        Task CreateAsync(Empleado empleado);
        void Update(Empleado empleado);
        void Delete(Empleado empleado);
    }
}
