using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Banco.Core;

namespace Banco.AppWeb.Controllers
{
    public class PrestamoController : Controller
    {
        // GET: Prestamo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Generar(int id)
        {
            var producto = ClienteLogic.ObtenerPorId(id);
            ViewBag.categorias =.Listar();
            return View(producto);
        }
    }
}