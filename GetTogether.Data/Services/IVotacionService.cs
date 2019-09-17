using GetTogether.Data.Models;
using GetTogether.Data.Resources;
using GetTogether.Data.Services.Communication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Services
{
    public interface IVotacionService
    {
        Task<IEnumerable<Votacion>> ObtenerVotacionesAsync();
        Task<Votacion> ObtenerVotacionIdAsync(int id);
        Task<VotacionResponse> CrearVotacionAsync(Votacion votacion);
        Task<VotacionResponse> ActualizaVotacionComidaAsync(int id, Votacion votacion);
        Task<VotacionResponse> EliminaVotacionAsync(int id);
    }
}
