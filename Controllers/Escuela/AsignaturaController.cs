using Microsoft.AspNetCore.Mvc;
using aspNet.Models;
using System;
using System.Linq;

namespace aspNet.Controllers
{
    public class AsignaturaController : Controller
    {

      public IActionResult Index(){
        return View(
          _context.Asignaturas.FirstOrDefault()
        );
      }

      public IActionResult MultiAsignatura() 
      {
        // var asignatura = new Asignatura{
        //   UniqueId = Guid.NewGuid().ToString(),
        //   Nombre = "Programación"
        // };

        ViewBag.CosaDinamica = "La Monja Asignatura";
        ViewBag.Fecha = DateTime.Now;

        return View("MultiAsignatura", _context.Asignaturas);
      }

      private EscuelaContext _context;
      public AsignaturaController(EscuelaContext context)
      {
          _context = context;
      }

    } 
}