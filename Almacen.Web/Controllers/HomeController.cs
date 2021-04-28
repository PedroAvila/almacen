using Almacen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Almacen.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var c = new Categoria()
            {
                ID = 1,
                Nombre = "Bebidas",
                Descripcion = "Categorias de productos liquidos"
            };

            return View(c);
        }
    }
}