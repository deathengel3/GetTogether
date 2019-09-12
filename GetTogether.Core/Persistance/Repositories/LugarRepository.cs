using GetTogether.Core.Persistance.Contexts;
using GetTogether.Data.Models;
using GetTogether.Data.Repositories;
using GetTogether.Data.Resources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Core.Persistance.Repositories
{
    public class LugarRepository : BaseRepository, ILugarRepository
    {
        public LugarRepository(AppDbcontext context) : base(context) { }

        public async Task<IEnumerable<Lugar>> GetAllAsync()
        {
            return await _context.Lugares.Include(l => l.OpcionesComida).ToListAsync();
        }

        public async Task<Lugar> FindByIdAsync(int id)
        {
            return await _context.Lugares.Include(l => l.OpcionesComida).FirstOrDefaultAsync(l => l.IdLugar == id);
        }

        public async Task CreateAsync(Lugar lugar)
        {
            await _context.Lugares.AddAsync(lugar);
        }

        public void Update(Lugar lugar)
        {
            _context.Lugares.Update(lugar);
        }

        public void Delete(Lugar lugar)
        {
            _context.Lugares.Remove(lugar);
        }
    }
}
