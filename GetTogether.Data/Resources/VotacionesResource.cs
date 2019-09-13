using GetTogether.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Data.Resources
{
    public class VotacionesResource
    {
        public int IdVotacion { get; set; }
        public Empleado Empleado { get; set; }
        public OpcionComida OpcionComida { get; set; }
        //public Lugar Lugar { get; set; }
    }
}
