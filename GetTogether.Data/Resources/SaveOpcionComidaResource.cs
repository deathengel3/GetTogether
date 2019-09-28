using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GetTogether.Data.Resources
{
    public class SaveOpcionComidaResource
    {

        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(250, ErrorMessage = "El nombre debe contener un máximo de 250 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La descripción es requerida")]
        [MaxLength(250, ErrorMessage = "La descripción debe contener un máximo de 250 caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El costo es requerido")]
        public decimal Costo { get; set; }
        [Required(ErrorMessage = "El Lugar al que pertenece la comida es requerido")]
        public string Imagen { get; set; }
        public int LugarId { get; set; }
    }
}
