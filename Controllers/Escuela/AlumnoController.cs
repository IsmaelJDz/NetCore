using Microsoft.AspNetCore.Mvc;
using aspNet.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace aspNet.Controllers
{
    public class AlumnoController : Controller
    {

      public IActionResult Index(){
        return View(
          _context.Alumnos.FirstOrDefault()
        );
      }

      public IActionResult MultiAlumno() 
      {
        // var asignatura = new Asignatura{
        //   UniqueId = Guid.NewGuid().ToString(),
        //   Nombre = "Programación"
        // };

        ViewBag.CosaDinamica = "La Monja Asignatura";
        ViewBag.Fecha = DateTime.Now;

        return View("MultiAlumno", _context.Alumnos);
      }

        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }

    } 
}