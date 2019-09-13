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
    public class VotacionRepository : BaseRepository, IVotacionRepository
    {
        public VotacionRepository(AppDbcontext context) : base(context){}
        public async Task<IEnumerable<Votacion>> GetAllAsync()
        {
            return await _context.Votaciones
                            .Include(v => v.Empleado)
                            .Include(v => v.OpcionComida)
                            .ToListAsync();
        }
        public async Task<Votacion> FindByEmpAsync(int id)
        {
            return await _context.Votaciones
                .Include(v => v.Empleado)
                .Include(v => v.OpcionComida)
                .FirstOrDefaultAsync(v => v.EmpleadoId == id);
        }
        public async Task CreatAsync(Votacion votacion)
        {
            await _context.Votaciones.AddAsync(votacion);
        }
        public void Update(Votacion votacion)
        {
            _context.Update(votacion);
        }

        public void Delete(Votacion votacion)
        {
            _context.Remove(votacion);
        }
    }
}
