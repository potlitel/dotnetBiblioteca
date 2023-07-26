using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapDashboard.Models;
using BootstrapDashboard.Services;

namespace BootstrapDashboard.Controllers;

public class LibroController : Controller
{
    private readonly ILibrosService _albumesService;

    public LibroController(ILibrosService albumesService) => _albumesService = albumesService;

    public IActionResult Index()
    {
        var result = _albumesService.GetLibrosAsync();
        return View(result);
    }
}