using Microsoft.AspNetCore.Mvc;
using aspNet.Models;
using System;

namespace aspNet.Controllers
{
    public class AsignaturaController : Controller
    {
      public IActionResult Index() 
      {
        var asignatura = new Asignatura{
          UniqueId = Guid.NewGuid().ToString(),
          Nombre = "Programación"
        };



        ViewBag.CosaDinamica = "La Monja Asignatura";
        ViewBag.Fecha = DateTime.Now;

        return View(asignatura);
      }
    } 
}