using GetTogether.Data.Models;
using GetTogether.Data.Repositories;
using GetTogether.Data.Resources;
using GetTogether.Data.Services;
using GetTogether.Data.Services.Communication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Core.Services
{
    public class VotacionService : IVotacionService
    {
        private readonly IVotacionRepository _votoRepo;
        private readonly IUnitOfWork _unitOfWork;
        public VotacionService(IVotacionRepository votacionRepository, IUnitOfWork unitOfWork)
        {
            _votoRepo = votacionRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Votacion>> ObtenerVotacionesAsync()
        {
            return await _votoRepo.GetAllAsync();
        }

        public async Task<Votacion> ObtenerVotacionIdAsync(int id)
        {
            return await _votoRepo.FindByEmpAsync(id);
        }

        public async Task<VotacionResponse> CrearVotacionAsync(Votacion votacion)
        {
            votacion.FechaRegistro = DateTime.Now;
            votacion.FechaModificacion = votacion.FechaRegistro;

            try
            {
                await _votoRepo.CreatAsync(votacion);
                await _unitOfWork.CompleteAsync();


                return new VotacionResponse(votacion);
            }
            catch(Exception ex)
            {
                return new VotacionResponse($"Ocurrió un error inesperado al guardar la información: {ex.Message}");
            }
        }

        public async Task<VotacionResponse> ActualizaVotacionComidaAsync(int id, Votacion votacion)
        {
            var votacionExistente = await _votoRepo.FindByEmpAsync(id);

            if (votacionExistente == null)
                return new VotacionResponse("El empleado no ha emitido aún su voto. Emita el voto antes de poder modificarlo");

            try
            {
                votacion.FechaModificacion = DateTime.Now;
                _votoRepo.Update(votacion);
                await _unitOfWork.CompleteAsync();

                return new VotacionResponse(votacionExistente);
            }
            catch(Exception ex)
            {
                return new VotacionResponse("algo");
            }

        }

        public Task<VotacionResponse> EliminaVotacionAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
