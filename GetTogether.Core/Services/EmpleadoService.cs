using GetTogether.Data.Models;
using GetTogether.Data.Services;
using GetTogether.Data.Repositories;
using GetTogether.Data.Resources;
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
            return await _empleadoRepo.GetAllAsync();
        }

        // AGREGAR ASYNC A TODOS LOS MÉTODOS PARA REGRESAR UN VALOR
        public async Task<Empleado> ObtenerEmpleadosPorNumEmpAsync(int numeroEmpleado)
        {
            return await _empleadoRepo.FindByNumEmpleado(numeroEmpleado);
        }

        public async Task<EmpleadoResponse> CrearEmpleadoAsync(Empleado empleado)
        {
            try
            {
                await _empleadoRepo.CreateAsync(empleado);
                await _unitOfWork.CompleteAsync();

                return new EmpleadoResponse(empleado);
            }
            catch (Exception ex)
            {
                return new EmpleadoResponse($"Ocurrió un error inesperado al guardar la información: {ex.Message}");
            }
        }

        public async Task<EmpleadoResponse> ActualizarEmpleadoAsync(int numEmpleado, Empleado empleado)
        {
            var empleadoExistente = await _empleadoRepo.FindByNumEmpleado(numEmpleado);

            if (empleadoExistente == null)
                return new EmpleadoResponse("El empleado que intenta actualizar no exite en la Base de Datos.");

            empleadoExistente.Nombre = empleado.Nombre;

            try
            {
                _empleadoRepo.Update(empleadoExistente);
                await _unitOfWork.CompleteAsync();

                return new EmpleadoResponse(empleadoExistente);
            }
            catch (Exception ex)
            {
                return new EmpleadoResponse($"Ocurrió un error inesperado al guardar la información: {ex.Message}");
            }
        }

        public async Task<EmpleadoResponse> EliminarEmpleadoAsync(int numEmpleado)
        {
            var empleadoABorrar = await _empleadoRepo.FindByNumEmpleado(numEmpleado);

            if (empleadoABorrar == null)
                return new EmpleadoResponse("El empleado que intenta eliminar no existe");

            try
            {
                _empleadoRepo.Delete(empleadoABorrar);
                await _unitOfWork.CompleteAsync();

                return new EmpleadoResponse(empleadoABorrar);
            }
            catch (Exception ex)
            {
                return new EmpleadoResponse($"Ocurrió un error inesperado al procesar la transacción: {ex.Message}");
            }
        }
    }
}
