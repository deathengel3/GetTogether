using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GetTogether.Data.Models
{
    public class OpcionComida
    {
        [Key]
        public int IdOpcion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public int LugarId { get; set; }
        public Lugar Lugar { get; set; }
        public DateTime FechaOpcion {get; set;}
        //public int VotacionId { get; set; }
        public IEnumerable<Votacion> Votacion { get; set; }
    }
}
