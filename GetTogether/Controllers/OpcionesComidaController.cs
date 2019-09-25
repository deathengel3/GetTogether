using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetTogether.Data.Models;
using GetTogether.Data.Resources;
using GetTogether.Data.Services;
using GetTogether.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetTogether.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpcionesComidaController : ControllerBase
    {
        private readonly IOpcionComidaService _opcionService;
        private readonly IMapper _mapper;

        public OpcionesComidaController(IOpcionComidaService comidaService, IMapper mapper)
        {
            _opcionService = comidaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerOpcionesComida()
        {
            var opciones = await _opcionService.ObtenerOpcionesComidaAsync();

            if (opciones == null)
                return NoContent();

            return Ok(_mapper.Map<IEnumerable<OpcionComida>, IEnumerable<OpcionComidaResource>>(opciones));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerOpcionesComida([FromRoute]int id)
        {
            var opcion = await _opcionService.ObtenerOpcionComidaPorIdAsync(id);

            if (opcion == null)
                return NotFound(new Error { EstatusHttp = 404, MensajeError = "No se encontró la opción de comida especificada. Intente nuevamente un id diferente." });

            return Ok(_mapper.Map<OpcionComida, OpcionComidaResource>(opcion));
        }

        [HttpPost]
        public async Task<IActionResult> CrearOpcionComida([FromBody]SaveOpcionComidaResource opcion)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var opcionAGuardar = _mapper.Map<SaveOpcionComidaResource, OpcionComida>(opcion);

            var resultado = await _opcionService.CrearOpcionComidaAsync(opcionAGuardar);

            if (!resultado.Success)
                if (resultado.Message.Contains("no existe"))
                    return NotFound(resultado.Message);
                else
                    return BadRequest(resultado.Message);

            var opcionResource = _mapper.Map<OpcionComida, OpcionComidaResource>(resultado.Opcion);

            return Ok(opcionResource);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarOpcionComida([FromRoute]int id, [FromBody]SaveOpcionComidaResource opcion)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var opcionAModif = _mapper.Map<SaveOpcionComidaResource, OpcionComida>(opcion);
            var resultado = await _opcionService.ActualizarOpcionComidaAsync(id, opcionAModif);

            if (!resultado.Success)
                return BadRequest(resultado.Message);

            var opcionResource = _mapper.Map<OpcionComida, OpcionComidaResource>(resultado.Opcion);

            return Ok(opcionResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarOpcionComida([FromRoute]int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var resultado = await _opcionService.EliminarOpcionComidaAsync(id);

            if (!resultado.Success)
                return BadRequest(resultado.Message);

            var opcionResource = _mapper.Map<OpcionComida, OpcionComidaResource>(resultado.Opcion);

            return Ok(opcionResource);
        }


    }
}