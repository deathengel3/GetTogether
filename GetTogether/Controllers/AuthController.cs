using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GetTogether.Data.Models;
using GetTogether.Data.Resources;
using GetTogether.Data.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetTogether.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class AuthController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IMapper _mapper;
        public AuthController(ILoginService loginService, IMapper mapper)
        {
            _loginService = loginService;
            _mapper = mapper;
        }

        [HttpGet("login")]
        public async Task<IActionResult> Login()
        {
            var headers = Request.Headers["Authorization"].ToString();

            if (string.IsNullOrWhiteSpace(headers))
                return BadRequest();

            if (!headers.StartsWith("Basic"))
                return BadRequest();

            var usuario = await _loginService.LoginAsync(headers);

            if (usuario == null)
                return Forbid();

            var empleado = _mapper.Map<Empleado, EmpleadoResourceLogin>(usuario);

            empleado.Token = "fake-token-valid"; // ONLY FOR TESTING

            return Ok(empleado);
        }
    }
}