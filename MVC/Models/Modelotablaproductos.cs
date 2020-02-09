using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    //se creo por la funcion create de la base de datos
    public class Modelotablaproductos
    {

        public int idproducto { get; set; }
        public string nombreproducto{ get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }


    }
}