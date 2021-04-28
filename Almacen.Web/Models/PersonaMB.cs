using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almacen.Web.Models
{
    public class PersonaMB : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;
            var persona = new Persona();
            persona.Nombre = request.Form["Nombre"];
            persona.CodigoPostal = request.Form["CodigoPostal"];
            persona.DominioIngles = byte.Parse(request.Form["DominioIngles"]);
            persona.Correo = request.Form["Correo"];
            persona.Habilidades = request.Form["Habilidades"].Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries).Select(h => h.Trim()).ToArray();

            if (persona.Habilidades.Count() <= 1)
            {
                bindingContext.ModelState.AddModelError("Habilidades", "Debe proporcionar más de una habilidad");
            }
            return persona;
        }
    }
}