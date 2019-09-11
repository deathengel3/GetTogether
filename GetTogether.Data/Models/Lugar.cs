using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GetTogether.Data.Models
{
    public class Lugar
    {
        [Key]
        public int IdLugar { get; set; }
        public string NombreLugar { get; set; }
        public string DireccionLugar { get; set; }
        public IEnumerable<OpcionComida> OpcionesComida { get; set; }
        public DateTime FechaLugar { get; set; }
        //public IEnumerable<Votacion> Votacion { get; set; }
    }
}
