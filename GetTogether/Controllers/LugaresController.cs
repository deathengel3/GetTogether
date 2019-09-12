using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetTogether.Data.Models;
using GetTogether.Data.Resources;
using GetTogether.Data.Services;
using GetTogether.Data.Services.Communication;
using GetTogether.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetTogether.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LugaresController : ControllerBase
    {
        private readonly ILugarService _lugarService;
        private readonly IMapper _mapper;

        public LugaresController(ILugarService lugarService, IMapper mapper)
        {
            _lugarService = lugarService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerLugares()
        {
            var lugares = await _lugarService.ObtenerLugaresAsync();

            if (lugares == null)
                return NoContent();



            return Ok(_mapper.Map<IEnumerable<Lugar>, IEnumerable<LugarResource>>(lugares));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerLugarPorId([FromRoute]int id)
        {
            var lugar = await _lugarService.ObtenerLugarPorId(id);

            if (lugar == null)
                return NotFound(new Error { EstatusHttp = 404, MensajeError = "No se encontró el lugar especificado" });

            return Ok(_mapper.Map<Lugar, LugarResource>(lugar));
        }

        [HttpPost]
        public async Task<IActionResult> CrearLugar([FromBody] SaveLugarResource lugar)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var lugarCrear = _mapper.Map<SaveLugarResource, Lugar>(lugar);

            var resultado = await _lugarService.CrearLugarAsync(lugarCrear);

            if (!resultado.Success)
                return BadRequest(resultado.Message);

            return Ok(lugarCrear);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizaLugar([FromRoute]int id, SaveLugarResource lugar)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var lugarAModif = _mapper.Map<SaveLugarResource, Lugar>(lugar);
            var resultado = await _lugarService.ActualizarLugarAsync(id, lugarAModif);

            if (!resultado.Success)
                return BadRequest(resultado.Message);

            var lugarResource = _mapper.Map<Lugar, LugarResource>(resultado.Lugar);

            return Ok(lugarResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarLugar([FromRoute]int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var resultado = await _lugarService.EliminarLugarAsync(id);

            if (!resultado.Success)
                return BadRequest(resultado.Message);

            var lugarResource = _mapper.Map<Lugar, LugarResource>(resultado.Lugar);

            return Ok(lugarResource);

        }
    }
}