using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica2.Controllers
{
    public class ControladorInicio : Controller
    {

        public ActionResult Inicio()
        {
            ViewData["Mensaje"] = "Bienvenido a ASP.net MVC";
            return View();
        }

    }
}