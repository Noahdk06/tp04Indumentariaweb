using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using camisetas.Models;

namespace camisetas.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.diccionario = Equipo.EquiposIndumentaria;
        return View();
    }

    public IActionResult selectIndumentaria()
    {
        ViewBag.ListaEquipo = Equipo.ListaEquipos;
        ViewBag.ListaMedia = Equipo.ListaMedias;
        ViewBag.ListaPantis = Equipo.ListaPantalones;
        ViewBag.ListaRemera = Equipo.ListaRemeras;
        return View();
    }

    public IActionResult GuardarIndumentaria (int equipo, int media, int pantalon, int remera)
    {
     if (equipo==null||media==null||pantalon==null||remera==null){
        ViewBag.error="falta seleccionar una o mas prendas";
        return View("selectIndumentaria");
     }
     else{
        Indumentaria Carlitos = new Indumentaria(Equipo.ListaMedias[media], Equipo.ListaPantalones[pantalon], Equipo.ListaRemeras[remera]);
        Equipo.IngresarIndumentaria(Equipo.ListaEquipos[equipo], Carlitos);
        return View();
     }
     
     
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
