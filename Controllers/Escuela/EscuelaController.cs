using Microsoft.AspNetCore.Mvc;
using aspNet.Models;
using System;

namespace aspNet.Controllers
{
    public class EscuelaController : Controller
    {
      public IActionResult Index() 
      {
        var escuela = new Escuela();
        escuela.AñoDeCreacion=2005;
        escuela.UniqueId = Guid.NewGuid().ToString();
        escuela.Nombre = "Platzi School";
        escuela.Ciudad = "México CDMX";
        escuela.Pais = "México";
        escuela.TipoEscuela = TiposEscuela.Secundaria;
        escuela.Direccion = "Metro isabel la catolica";

        ViewBag.CosaDinamica = "La Monja";

        return View(escuela);
      }
    } 
}