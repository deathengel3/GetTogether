using GetTogether.Core.Persistance.Contexts;
using GetTogether.Data.Models;
using GetTogether.Data.Repositories;
using GetTogether.Data.Resources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Core.Persistance.Repositories
{
    public class VotacionRepository : BaseRepository, IVotacionRepository
    {
        public VotacionRepository(AppDbcontext context) : base(context){}
        public async Task<IEnumerable<Votacion>> GetAllAsync()
        {
            //var opcionesComida = await _context.Votaciones
            //                           .Include(v => v.OpcionComida).Select(v => v.OpcionComida.LugarId).ToListAsync();

            //var lugar = await _context.Lugares
            //                    .Where(lu =>
            //                        opcionesComida.Contains(lu.IdLugar))
            //                    .Include(lu => lu.OpcionesComida)
            //                    .FirstOrDefaultAsync();

            //var empleados = await _context.Votaciones
            //                              .Include(v => v.Empleado)
            //                              .Select(e => e.Empleado)
            //                              .FirstOrDefaultAsync();

            //var votaciones = await _context.Votaciones
            //                               .Where(v => opcionesComida.Contains(v.OpcionComidaId))
            //                               .Include(e => e.Empleado)
            //                               .Select(voto => new {
            //                                     IdVotacion = (int)voto.IdVotacion,
            //                                     Empleado = (Empleado)voto.Empleado,
            //                                     Lugar = (Lugar)lugar
            //                                  }
            //                               )
            //                               .ToListAsync();



            //return query;

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
