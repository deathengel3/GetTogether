﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GetTogether.Data.Models
{
    public class Lugar
    {
        public int IdLugar { get; set; }
        public int NombreLugar { get; set; }
        public int DireccionLugar { get; set; }
        public IEnumerable<OpcionComida> OpcionesComida { get; set; }
        public DateTime FechaLugar { get; set; }
    }
}