using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Almacen.Web.Models
{
    public class NombreValido : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return VerificarNombre(value.ToString());
        }

        private bool VerificarNombre(string nombre)
        {
            if (this.ErrorMessage.Contains("{0}"))
            {
                this.ErrorMessage = this.ErrorMessage.Replace("{0}", "Demo");
            }
            return nombre != "Demo";
        }
    }
}