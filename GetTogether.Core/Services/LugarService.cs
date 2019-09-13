using GetTogether.Data.Models;
using GetTogether.Data.Repositories;
using GetTogether.Data.Services;
using GetTogether.Data.Services.Communication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Core.Services
{
    public class LugarService : ILugarService
    {
        private readonly ILugarRepository _lugarRepo;
        private readonly IUnitOfWork _unitOfWork;

        public LugarService(ILugarRepository lugarRepositorio, IUnitOfWork unitOfWork)
        {
            _lugarRepo = lugarRepositorio;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Lugar>> ObtenerLugaresAsync()
        {
            return await _lugarRepo.GetAllAsync();
        }

        public async Task<Lugar> ObtenerLugarPorId(int id)
        {
            return await _lugarRepo.FindByIdAsync(id);
        }

        public async Task<LugarResponse> CrearLugarAsync(Lugar lugar)
        {
            lugar.FechaLugar = DateTime.Now;
            lugar.FechaLugarModificacion = lugar.FechaLugar;
            try
            {
                await _lugarRepo.CreateAsync(lugar);
                await _unitOfWork.CompleteAsync();

                return new LugarResponse(lugar);
            }
            catch (Exception ex)
            {
                return new LugarResponse($"Ocurrió un error inesperado al guardar la información: {ex.Message}");
            }
        }


        public async Task<LugarResponse> ActualizarLugarAsync(int id, Lugar lugar)
        {
            var lugarExistente = await _lugarRepo.FindByIdAsync(id);
            if (lugarExistente == null)
                return new LugarResponse("El lugar que intenta modificar no existe.");

            lugarExistente.NombreLugar = lugar.NombreLugar;
            lugarExistente.DireccionLugar = lugar.DireccionLugar;

            try
            {
                lugar.FechaLugarModificacion = DateTime.Now;
                _lugarRepo.Update(lugarExistente);
                await _unitOfWork.CompleteAsync();

                return new LugarResponse(lugarExistente);
            }
            catch(Exception ex)
            {
                return new LugarResponse($"Ocurrió un error inesperado al guardar la información: {ex.Message}");
            }
        }

        public async Task<LugarResponse> EliminarLugarAsync(int id)
        {
            var lugarABorrar = await _lugarRepo.FindByIdAsync(id);
            if (lugarABorrar == null)
                return new LugarResponse("El lugar que intenta eliminar no existe.");

            try
            {
                _lugarRepo.Delete(lugarABorrar);
                await _unitOfWork.CompleteAsync();

                return new LugarResponse(lugarABorrar);
            }
            catch (Exception ex)
            {
                return new LugarResponse($"Ocurrió un error inesperado al guardar la información: {ex.Message}");
            }
        }
    }
}
