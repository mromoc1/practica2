using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVC.Models;

namespace MVC.Controllers
{

    //Al unir la BD con el proyecto, creamos una clase controller que nos proporcionará una estructura
    //la clase Index la utilizaremos para hacer la conexion
    public class tablaproductosController : Controller
    {
        string conexion = @"Data Source=DESKTOP-AVIBN7V\SQLEXPRESS;Initial Catalog=practica2BD;Integrated Security=True";
        [HttpGet]
        // GET: productos
        public ActionResult Index()
        {
            DataTable datos_tablaproductos = new DataTable();

            using (SqlConnection conexionsql = new SqlConnection(conexion))
            {
                conexionsql.Open();
                SqlDataAdapter adaptadorsql = new SqlDataAdapter("SELECT * FROM tablaproductos",conexionsql);
                adaptadorsql.Fill(datos_tablaproductos);
            }

                return View(datos_tablaproductos);
        }


        // Para la clase create creamos un nuevo documento de clase en carpeta modelo

        [HttpGet]
        // GET: productos/Create
        public ActionResult Create()
        {

            return View(new Modelotablaproductos());
        }

        // POST: productos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: productos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: productos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: productos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: productos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
