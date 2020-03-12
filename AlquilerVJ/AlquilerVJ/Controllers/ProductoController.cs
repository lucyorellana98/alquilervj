using AlquilerVJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlquilerVJ.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = " Mario Kart";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = " Mortal Kombat";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = " FIFA 2020";

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = " Naruto Shipuden 4";

            var producto5 = new ProductoModel();
            producto5.Id = 5;
            producto5.Descripcion = " GOD of Wars";

            var producto6 = new ProductoModel();
            producto6.Id = 6;
            producto6.Descripcion = " Resident Evil 7";

            var listadeproductos = new List<ProductoModel>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);
            listadeproductos.Add(producto4);
            listadeproductos.Add(producto5);
            listadeproductos.Add(producto6);


            return View (listadeproductos);
          
        }
    }
}