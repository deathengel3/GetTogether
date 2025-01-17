﻿using System;
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
        public string Imagen { get; set; }
        public int LugarId { get; set; }
        public DateTime FechaOpcion {get; set;}
        public DateTime FechaOpcionModificacion { get; set; }
    }
}
