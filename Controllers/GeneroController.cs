using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapDashboard.Models;
using BootstrapDashboard.Services;
using X.PagedList;

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
    public IActionResult Index(string? q, int? page)
    {
        var result = _albumesService.GetGenerosAsync();

        if (!string.IsNullOrEmpty(q))
        {
            page = 1;
            result = result.Where(s => s.Nombre.ToUpper().Contains(q.ToUpper())).ToList();
        }

        if (result.Count == 0 && q != string.Empty)
            TempData["mensaje"] = string.Format("No se ha encontrado ningún género con el criterio de búsqueda especificado: {0}.", q);
        else
        if (result.Count == 0 && q == string.Empty)
            TempData["mensaje"] = "No existen géneros para mostrar.";

        int pageSize = 5;
        int pageNumber = page ?? 1;
        ViewBag.pageListModel = result.ToPagedList(pageNumber, pageSize);
        return View(result.ToPagedList(pageNumber, pageSize));
    }
}