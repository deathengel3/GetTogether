using GetTogether.Data.Models;
using GetTogether.Data.Resources;
using GetTogether.Data.Services.Communication;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetTogether.Data.Services
{
    public interface ILoginService
    {
        Task<Empleado> LoginAsync(string request);
    }
}
