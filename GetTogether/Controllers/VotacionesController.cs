using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetTogether.Data.Models;
using GetTogether.Data.Resources;
using GetTogether.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetTogether.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotacionesController : ControllerBase
    {
        private readonly IVotacionService _votoService;
        private readonly IMapper _mapper;
        public VotacionesController(IVotacionService votacionService, IMapper mapper)
        {
            _votoService = votacionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerVotaciones()
        {
            var votaciones = await _votoService.ObtenerVotacionesAsync();
            if (votaciones == null)
                return NoContent();

            return Ok(_mapper.Map<IEnumerable<Votacion>, IEnumerable<VotacionesResource>>(votaciones));
        }
    }
}