using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Almacen.Web.Models
{
    public class Persona
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Debe proporcionar un nombre")]
        public string Nombre { get; set; }

        [StringLength(5, MinimumLength = 5, ErrorMessage = "El código postal debe ser de 5 caracteres")]
        public string CodigoPostal { get; set; }

        [Range(0,100, ErrorMessage = "El porcentaje debe de ser de 0 a 100%")]
        public byte DominioIngles { get; set; }

        [Required(ErrorMessage = "El correo es requerido")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "La dirección de correo debe ser válida")]
        public string Correo { get; set; }
    }
}