using GetTogether.Core.Persistance.Contexts;
using GetTogether.Data.Models;
using GetTogether.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Core.Persistance.Repositories
{
    public class EmpleadoRepository : BaseRepository, IEmpleadoRepository
    {
        public EmpleadoRepository(AppDbcontext context) : base(context) { }

        public async Task<IList<Empleado>> ObtenerEmpleados()
        {
            return await _context.Empleados.ToListAsync();
        }
        public Task<Empleado> ObtenerEmpleadosPorId(int numeroEmpleado)
        {
            throw new NotImplementedException();
        }

        public Task<int> ActualizarEmpleado(Empleado empleadoAct)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> CrearEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public Task<int> EliminarEmpleado(int numeroEmpleado)
        {
            throw new NotImplementedException();
        }
    }
}
