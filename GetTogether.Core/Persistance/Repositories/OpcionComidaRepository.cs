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
    public class OpcionComidaRepository : BaseRepository, IOpcionComidaRepository
    {
        public OpcionComidaRepository(AppDbcontext context) : base(context){}
        public async Task<IEnumerable<OpcionComida>> GetAllAsync()
        {
            return await _context.OpcionesComida.ToListAsync();
        }
        public async Task<OpcionComida> FindByIdAsync(int id)
        {
            return await _context.OpcionesComida.FirstOrDefaultAsync(oc => oc.IdOpcion == id);
        }
        public async Task CreateAsync(OpcionComida opcion)
        {
            await _context.OpcionesComida.AddAsync(opcion);
        }
        public void Update(OpcionComida opcion)
        {
            _context.OpcionesComida.Update(opcion);
        }
        public void Delete(OpcionComida opcion)
        {
            _context.OpcionesComida.Remove(opcion);
        }
    }
}
