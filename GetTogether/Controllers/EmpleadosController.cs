using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetTogether.Data.Models;
using GetTogether.Data.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetTogether.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        //Inyección de dependencias
        private readonly IEmpleadoRepo _empleadoRepo;
        public EmpleadosController(IEmpleadoRepo empleadoRepositorio)
        {
            _empleadoRepo = empleadoRepositorio;
        }

        [HttpGet]
        public async Task<IEnumerable<Empleado>> ObtenerEmpleados()
        {
            var empleados = await _empleadoRepo.ObtenerEmpleados();

            return empleados;
        }
    }
}