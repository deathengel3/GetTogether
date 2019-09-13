using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Repositories
{
    public interface IVotacionRepository
    {
        Task<IEnumerable<Votacion>> GetAllAsync();
        Task<Votacion> FindByEmpAsync(int id);
        Task CreatAsync(Votacion votacion);
        void Update(Votacion votacion);
        void Delete(Votacion votacion);
    }
}
