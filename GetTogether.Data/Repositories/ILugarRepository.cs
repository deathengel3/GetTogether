using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Repositories
{
    public interface ILugarRepository
    {
        Task<IEnumerable<Lugar>> GetAllAsync();
        Task<Lugar> FindByIdAsync(int id);
        Task CreateAsync(Lugar lugar);
        void Update(Lugar lugar);
        void Delete(Lugar lugar);
    }
}
