using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapDashboard.Models;

namespace BootstrapDashboard.Controllers;

public class GeneroController : Controller
{
    // private readonly IGenerosService albumesService;

    public GeneroController()
    {
        // albumesService = service;
    }

    public IActionResult Index()
    {
        // var result = albumesService.GetGenerosAsync();
        return View();
    }
}