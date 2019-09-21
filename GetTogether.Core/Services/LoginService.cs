using GetTogether.Data.Models;
using GetTogether.Data.Repositories;
using GetTogether.Data.Resources;
using GetTogether.Data.Services;
using GetTogether.Data.Services.Communication;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Core.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepo;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepo = loginRepository;
        }

        public async Task<Empleado> LoginAsync(string headers)
        {
            string sinespacios = headers.Substring("Basic ".Length).Trim();
            byte[] tmp = Convert.FromBase64String(sinespacios);
            var credentials = Encoding.UTF8.GetString(tmp);
            string[] empleado = credentials.Split('|');

            if (empleado[0].Trim() != empleado[1].Trim())
                return null;

            try
            {
                var usuarioLoggedIn = await _loginRepo.LoginAsync(Convert.ToInt32(empleado[0]));

                if (usuarioLoggedIn == null)
                    return null;

                return usuarioLoggedIn;
            }
            catch (Exception es)
            {
                return null;
            }
        }
    }
}
