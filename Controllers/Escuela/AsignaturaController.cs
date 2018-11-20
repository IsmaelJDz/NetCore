using Microsoft.AspNetCore.Mvc;
using aspNet.Models;
using System;

namespace aspNet.Controllers
{
    public class AsignaturaController : Controller
    {

      public IActionResult Index(){
        return View(
          new Asignatura{Nombre="Programación",
            UniqueId=Guid.NewGuid().ToString()
          }
        );
      }

      public IActionResult MultiAsignatura() 
      {
        // var asignatura = new Asignatura{
        //   UniqueId = Guid.NewGuid().ToString(),
        //   Nombre = "Programación"
        // };

        var listaAsignaturas = new System.Collections.Generic.List<Asignatura>(){
          new Asignatura{Nombre="Matemáticas", 
            UniqueId=Guid.NewGuid().ToString()
          } ,
          new Asignatura{Nombre="Educación Física",
            UniqueId=Guid.NewGuid().ToString()
          } , 
          new Asignatura{Nombre="Castellano",
            UniqueId=Guid.NewGuid().ToString()
          } ,
          new Asignatura{Nombre="Ciecias Narurales",
            UniqueId=Guid.NewGuid().ToString()
          } ,
          new Asignatura{Nombre="Programación",
            UniqueId=Guid.NewGuid().ToString()
          }
        };

        ViewBag.CosaDinamica = "La Monja Asignatura";
        ViewBag.Fecha = DateTime.Now;

        return View("MultiAsignatura", listaAsignaturas);
      }
    } 
}