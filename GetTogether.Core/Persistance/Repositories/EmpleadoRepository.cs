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

        public async Task<IEnumerable<Empleado>> GetAllAsync()
        {
            return await _context.Empleados.ToListAsync();
        }
        public async Task<Empleado> FindByNumEmpleado(int numeroEmpleado)
        {
            return await _context.Empleados.FirstOrDefaultAsync(e => e.NumeroEmpleado == numeroEmpleado);
        }

        public async Task CreateAsync(Empleado empleado)
        {
            await _context.Empleados.AddAsync(empleado);
        }

        public void Update(Empleado empleado)
        {
            _context.Empleados.Update(empleado);
        }
        public void Delete(Empleado empleado)
        {
            _context.Empleados.Remove(empleado);
        }
    }
}
