using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Data.Models
{
    public class OpcionComida
    {
        public int IdOpcion { get; set; }
        public int Descripcion { get; set; }
        public int Costo { get; set; }
        public int LugarId { get; set; }
        public Lugar Lugar { get; set; }
        public DateTime FechaOpcion {get; set;}
    }
}
