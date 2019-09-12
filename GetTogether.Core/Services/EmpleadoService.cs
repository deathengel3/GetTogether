using GetTogether.Data.Models;
using GetTogether.Data.Repos;
using GetTogether.Data.Repositories;
using GetTogether.Data.Services.Communication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Core.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepo;
        private readonly IUnitOfWork _unitOfWork;
        public EmpleadoService(IEmpleadoRepository empleadoRepository, IUnitOfWork unitOfWork)
        {
            _empleadoRepo = empleadoRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Empleado>> ObtenerEmpleadosAsync()
        {
            return await _empleadoRepo.ObtenerEmpleadosAsync();
        }

        // AGREGAR ASYNC A TODOS LOS MÉTODOS PARA REGRESAR UN VALOR
        public async Task<Empleado> ObtenerEmpleadosPorNumEmpAsync(int numeroEmpleado)
        {
            return await _empleadoRepo.ObtenerEmpleadosPorNumEmpAsync(numeroEmpleado);
        }

        public async Task<SaveEmpleadoResponse> CrearEmpleadoAsync(Empleado empleado)
        {
            try
            {
                await _empleadoRepo.CrearEmpleadoAsync(empleado);
                await _unitOfWork.CompletarTareaAsync();

                return new SaveEmpleadoResponse(empleado);
            }
            catch (Exception ex)
            {
                return new SaveEmpleadoResponse($"Ocurrió un error inesperado al guardar la información: {ex.Message}");
            }
        }

        public async Task<SaveEmpleadoResponse> ActualizarEmpleadoAsync(int numEmpleado, Empleado empleado)
        {
            var empleadoExistente = await _empleadoRepo.ObtenerEmpleadosPorNumEmpAsync(numEmpleado);

            if (empleadoExistente == null)
                return new SaveEmpleadoResponse("El empleado que intenta actualizar no exite en la Base de Datos.");

            empleadoExistente.Nombre = empleado.Nombre;

            try
            {
                _empleadoRepo.ActualizarEmpleado(empleadoExistente);
                await _unitOfWork.CompletarTareaAsync();

                return new SaveEmpleadoResponse(empleadoExistente);
            }
            catch (Exception ex)
            {
                return new SaveEmpleadoResponse($"Ocurrió un error inesperado al guardar la información: {ex.Message}");
            }
        }
    }
}
