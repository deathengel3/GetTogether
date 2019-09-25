using GetTogether.Core.Persistance.Contexts;
using GetTogether.Data.Models;
using GetTogether.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using GetTogether.Data.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Core.Persistance.Repositories
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {
        public LoginRepository(AppDbcontext context) : base(context) {}

        public async Task<Empleado> LoginAsync(int numEmpleado)
        {
            return await _context.Empleados.FirstOrDefaultAsync(e => e.NumeroEmpleado == numEmpleado);
        }
    }
}
