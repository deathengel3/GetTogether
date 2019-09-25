using GetTogether.Data.Models;
using GetTogether.Data.Services.Communication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Services
{
    public interface ILugarService
    {
        Task<IEnumerable<Lugar>> ObtenerLugaresAsync();
        Task<Lugar> ObtenerLugarPorId(int id);
        Task<LugarResponse> CrearLugarAsync(Lugar lugar);
        Task<LugarResponse> ActualizarLugarAsync(int id, Lugar lugar);
        Task<LugarResponse> EliminarLugarAsync(int id);
    }
}
