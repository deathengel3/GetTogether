using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GetTogether.Data.Resources
{
    public class SaveLugarResource
    {
        //public int IdLugar { get; set; }
        [Required(ErrorMessage = "El nombre del lugar es requerido")]
        [MaxLength(250, ErrorMessage = "El número de caracteres del nombre no debe sobrepasar los 250")]
        public string NombreLugar { get; set; }
        [Required(ErrorMessage = "La dirección del lugar es requerido")]
        [MaxLength(250, ErrorMessage = "El número de caracteres de la dirección no debe sobrepasar los 250")]
        public string DireccionLugar { get; set; }
        //public IEnumerable<OpcionComida> OpcionesComida { get; set; }
        //public DateTime FechaLugar { get; set; }
    }
}
