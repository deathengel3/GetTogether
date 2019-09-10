using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Data.Models
{
    public class Votacion
    {
        public int IdVotacion { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
        public int LugarId { get; set; }
        public Lugar Lugar { get; set; }
        public int OpcionComidaId { get; set; }
        public OpcionComida OpcionComida { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int RegistroActivo { get; set; }
    }
}
