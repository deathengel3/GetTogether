using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetTogether.Data.Models;
using GetTogether.Data.Repos;
using GetTogether.Data.Resources;
using GetTogether.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetTogether.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        //Inyección de dependencias
        private readonly IEmpleadoService _empleadoService;
        private readonly IMapper _mapper;

        public EmpleadosController(IEmpleadoService empleadoService, IMapper mapper)
        {
            _empleadoService = empleadoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerEmpleados()
        {
            var empleados = await _empleadoService.ObtenerEmpleadosAsync();

            if (empleados == null)
                return NoContent();

            return Ok(_mapper.Map<IEnumerable<Empleado>, IEnumerable<EmpleadoResource>>(empleados));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerEmpleadoId([FromRoute]int id)
        {
            var empleado = await _empleadoService.ObtenerEmpleadosPorNumEmpAsync(id);

            if (empleado == null)
                return NotFound(new Error { EstatusHttp = 404, MensajeError = "No se encontró el empleado especificado. Intente nuevamente un id diferente." });

            return Ok(_mapper.Map<Empleado, EmpleadoResource>(empleado));
        }

        [HttpPost]
        public async Task<IActionResult> CrearEmpleado([FromBody]SaveEmpleadoResource empleado)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            //Convierte datos para guardar
            var empleadoAGuardar = _mapper.Map<SaveEmpleadoResource, Empleado>(empleado);

            //Obtiene el empleado a guardar
            var resultado = await _empleadoService.CrearEmpleadoAsync(empleadoAGuardar);

            //Si no fue exitoso regresa un mensaje de error
            if (!resultado.Success)
                return BadRequest(resultado.Message);

            //Si todo salió bien regresa un objeto empleado mapeado para regresar los datos enviados por el usuario
            var empleadoResource = _mapper.Map<Empleado, EmpleadoResource>(resultado.Empleado);            

            return Ok(empleadoResource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarEmpleado(int id, [FromBody]SaveEmpleadoResource empleado)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var empleadoAModif = _mapper.Map<SaveEmpleadoResource, Empleado>(empleado);
            var resultado = await _empleadoService.ActualizarEmpleadoAsync(id, empleadoAModif);

            if (!resultado.Success)
                return BadRequest(resultado.Message);

            //Si todo salió bien regresa un objeto empleado mapeado para regresar los datos enviados por el usuario
            var empleadoResource = _mapper.Map<Empleado, EmpleadoResource>(resultado.Empleado);

            return Ok(empleadoResource);
        }
    }
}