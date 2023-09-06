using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapDashboard.Models;
using BootstrapDashboard.Services;

namespace BootstrapDashboard.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IGenerosService _generosService;

    private readonly ILibrosService _librosService;

    private readonly ILectoresService _lectoresService;

    public HomeController(ILogger<HomeController> logger,
                          IGenerosService generosService,
                          ILibrosService librosService,
                          ILectoresService lectoresService)
    {
        _logger = logger;
        _generosService = generosService;
        _librosService = librosService;
        _lectoresService = lectoresService;
    }

    public async Task<IActionResult> Index()
    {
        var countGeneros = _generosService.GetGenerosAsync().Count();
        var countLibros = _librosService.GetLibrosAsync().Count();
        var countLectores = await _lectoresService.GetLectoresCount();
        ViewBag.Generos = countGeneros;
        ViewBag.Libros = countLibros;
        ViewBag.Lectores = countLectores;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
