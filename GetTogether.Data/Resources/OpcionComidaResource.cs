using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Data.Resources
{
    public class OpcionComidaResource
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public int LugarId { get; set; }
        //public DateTime FechaOpcion { get; set; }
        //public int VotacionId { get; set; }
        //public IEnumerable<Votacion> Votacion { get; set; }
    }
}
