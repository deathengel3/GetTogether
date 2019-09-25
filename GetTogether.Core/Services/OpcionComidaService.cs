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
    public class OpcionComidaService : IOpcionComidaService
    {
        private readonly IOpcionComidaRepository _opcionRepo;
        private readonly ILugarRepository _lugarRepo;
        private readonly IUnitOfWork _unitOfWork;

        public OpcionComidaService(IOpcionComidaRepository opcionesReopository, IUnitOfWork unitOfWork, ILugarRepository lugarRepository)
        {
            _opcionRepo = opcionesReopository;
            _unitOfWork = unitOfWork;
            _lugarRepo = lugarRepository;
        }
        public async Task<IEnumerable<OpcionComida>> ObtenerOpcionesComidaAsync()
        {
            return await _opcionRepo.GetAllAsync();

        }
        public async Task<OpcionComida> ObtenerOpcionComidaPorIdAsync(int id)
        {
            return await _opcionRepo.FindByIdAsync(id);
        }
        public async Task<OpcionComidaResponse> CrearOpcionComidaAsync(OpcionComida opcion)
        {
            var opcionExistente = await _lugarRepo.FindByIdAsync(opcion.LugarId);

            if(opcionExistente == null)
                return new OpcionComidaResponse("El Lugar de comida no existe.");

            opcion.FechaOpcion = DateTime.Now;
            opcion.FechaOpcionModificacion = opcion.FechaOpcion;

            try
            {
                await _opcionRepo.CreateAsync(opcion);
                await _unitOfWork.CompleteAsync();

                return new OpcionComidaResponse(opcion);
            }
            catch(Exception ex)
            {
                return new OpcionComidaResponse($"Ocurrió un error inesperado al guardar la información: {ex.Message}");
            }
        }
        public async Task<OpcionComidaResponse> ActualizarOpcionComidaAsync(int id, OpcionComida opcion)
        {
            var opcionExistente = await _opcionRepo.FindByIdAsync(id);

            if (opcionExistente == null)
                return new OpcionComidaResponse("La opción de comida que intenta actualizar no exite en la Base de Datos.");

            opcionExistente.Nombre = opcion.Nombre;
            opcionExistente.Descripcion = opcion.Descripcion;
            opcionExistente.Costo = opcion.Costo;

            try
            {
                opcion.FechaOpcionModificacion = DateTime.Now;
                _opcionRepo.Update(opcionExistente);
                await _unitOfWork.CompleteAsync();

                return new OpcionComidaResponse(opcionExistente);
            }
            catch (Exception ex)
            {
                return new OpcionComidaResponse($"Ocurrió un error inesperado al guardar la información: {ex.Message}");
            }
        }

        public async Task<OpcionComidaResponse> EliminarOpcionComidaAsync(int id)
        {
            var opcionExistente = await _opcionRepo.FindByIdAsync(id);

            if (opcionExistente == null)
                return new OpcionComidaResponse("La opción de comida que intenta eliminar no exite en la Base de Datos.");

            try
            {
                _opcionRepo.Delete(opcionExistente);
                await _unitOfWork.CompleteAsync();

                return new OpcionComidaResponse(opcionExistente);
            }
            catch (Exception ex)
            {
                return new OpcionComidaResponse($"Ocurrió un error inesperado al guardar la información: {ex.Message}");
            }
        }
    }
}
