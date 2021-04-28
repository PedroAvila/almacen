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

        [Required]
        public string Nombre { get; set; }

        [StringLength(5, MinimumLength = 5)]
        public string CodigoPostal { get; set; }

        [Range(0,100)]
        public byte DominioIngles { get; set; }

        [Required]
        [RegularExpression(@".+\@.+\..+")]
        public string Correo { get; set; }
    }
}