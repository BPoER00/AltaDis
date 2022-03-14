using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AltaDis.Models;

namespace AltaDis.Controllers
{
    public class HomeController : Controller
    {
        public Conexion DbConexion;
        public HomeController(Conexion DbConexion)
        {
            this.DbConexion = DbConexion;
        }

        public IActionResult Index()
        {
            ViewBag.Datos = this.DbConexion.Employee.ToList();
            return View();
        }

        public IActionResult Guardar()
        {
            return View();
        }

        public IActionResult GuardarDatos(Employee datos)
        {
            if(ModelState.IsValid)
            {
                this.DbConexion.Employee.Add(datos);
                this.DbConexion.SaveChanges();
                return RedirectToAction("Index");
            }else
            {
                return BadRequest();
            }

        }
    }
}
