using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapDashboard.Models;
using BootstrapDashboard.Services;

namespace BootstrapDashboard.Controllers;

public class GeneroController : Controller
{
    private readonly IGenerosService _albumesService;

    /**
     * Description: Constructor de la clase
     * @param {any} IGenerosServicealbumesService
     * @returns {any}
        */
    public GeneroController(IGenerosService albumesService) => _albumesService = albumesService;

    /**
     * Description
     * @returns {any}
        */
    public IActionResult Index()
    {
        var result = _albumesService.GetGenerosAsync();
        return View(result);
    }
}