using GetTogether.Data.Models;
using GetTogether.Data.Resources;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTogether.Mapping
{
    public class ResourcesToModelProfile : Profile
    {
        public ResourcesToModelProfile()
        {
            CreateMap<SaveEmpleadoResource, Empleado>();
            CreateMap<SaveLugarResource, Lugar>();
            CreateMap<SaveOpcionComidaResource, OpcionComida>();
        }
    }
}
