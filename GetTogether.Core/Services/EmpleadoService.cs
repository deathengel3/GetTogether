using GetTogether.Data.Models;
using GetTogether.Data.Repos;
using GetTogether.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Core.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepo;
        public EmpleadoService(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepo = empleadoRepository;
        }

        public async Task<IEnumerable<Empleado>> ObtenerEmpleados()
        {
            return await _empleadoRepo.ObtenerEmpleados();
        }

        // AGREGAR ASYNC A TODOS LOS MÉTODOS PARA REGRESAR UN VALOR
        public Task<Empleado> ObtenerEmpleadosPorId(int numeroEmpleado)
        {
            throw new NotImplementedException();
        }

        public Task<int> ActualizarEmpleado(Empleado empleadoAct)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> CrearEmpleado(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public Task<int> EliminarEmpleado(int numeroEmpleado)
        {
            throw new NotImplementedException();
        }
    }
}
