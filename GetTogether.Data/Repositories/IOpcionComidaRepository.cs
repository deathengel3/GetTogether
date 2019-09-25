using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Repositories
{
    public interface IOpcionComidaRepository
    {
        Task<IEnumerable<OpcionComida>> GetAllAsync();
        Task<OpcionComida> FindByIdAsync(int id);
        Task CreateAsync(OpcionComida opcion);
        void Update(OpcionComida opcion);
        void Delete(OpcionComida opcion);
    }
}
