using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Repositories
{
    public interface ILoginRepository
    {
        Task<Empleado> LoginAsync(int idEmpleado);
    }
}
