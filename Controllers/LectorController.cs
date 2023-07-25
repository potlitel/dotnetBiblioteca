using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapDashboard.Models;

namespace BootstrapDashboard.Controllers;

public class LectorController : Controller
{
    // private readonly IGenerosService albumesService;

    public LectorController()
    {
        // albumesService = service;
    }

    public IActionResult Index()
    {
        // var result = albumesService.GetGenerosAsync();
        return View();
    }
}