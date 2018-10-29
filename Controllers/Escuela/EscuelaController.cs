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
        escuela.AnoFundacion=2005;
        escuela.EscuelaId = Guid.NewGuid().ToString();
        escuela.Nombre = "Platzi School";
        return View(escuela);
      }
    } 
}