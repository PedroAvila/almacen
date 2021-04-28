using Almacen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almacen.Web.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Persona datos)
        {
            ActionResult resultado;
            if (ModelState.IsValid)
            {
                resultado = Content("Datos correctos");
            }
            else
            {
                resultado = View(datos);
            }
            return resultado;
        }
    }
}