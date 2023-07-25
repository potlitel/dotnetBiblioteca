using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapDashboard.Models;

namespace BootstrapDashboard.Controllers;

public class LibroController : Controller
{
    // private readonly IGenerosService albumesService;

    public LibroController()
    {
        // albumesService = service;
    }

    public IActionResult Index()
    {
        // var result = albumesService.GetGenerosAsync();
        return View();
    }
}