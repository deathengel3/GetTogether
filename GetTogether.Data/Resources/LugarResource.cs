using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Data.Resources
{
    public class LugarResource
    {
        public int IdLugar { get; set; }
        public string NombreLugar { get; set; }
        public string DireccionLugar { get; set; }
        public string Imagen { get; set; }
        public IEnumerable<OpcionComida> OpcionesComida { get; set; }
        //public DateTime FechaLugar { get; set; }
    }
}
