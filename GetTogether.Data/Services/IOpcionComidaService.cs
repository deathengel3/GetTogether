using GetTogether.Data.Models;
using GetTogether.Data.Services.Communication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Services
{
    public interface IOpcionComidaService
    {
        Task<IEnumerable<OpcionComida>> ObtenerOpcionesComidaAsync();
        Task<OpcionComida> ObtenerOpcionComidaPorIdAsync(int id);
        Task<OpcionComidaResponse> CrearOpcionComidaAsync(OpcionComida opcion);
        Task<OpcionComidaResponse> ActualizarOpcionComidaAsync(int id, OpcionComida opcion);
        Task<OpcionComidaResponse> EliminarOpcionComidaAsync(int id);
    }
}
