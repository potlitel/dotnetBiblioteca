using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapDashboard.Models;
using Microsoft.AspNetCore.Authorization;
using BootstrapDashboard.Services;
using X.PagedList;
using System.Data;
using Newtonsoft.Json;

namespace BootstrapDashboard.Controllers;

public class PrestamoController : Controller
{
    private readonly IPrestamosService _prestamosService;

    public PrestamoController(IPrestamosService prestamosService)
    {
        _prestamosService = prestamosService;
    }

    /**
     * Description: Index method
     * @param {any} stringsortOrder
     * @param {any} stringq
     * @param {any} int?page
     * @returns {any}
        */
    public async Task<IActionResult> Index(string sortOrder, string q, int? page)
    {
        // Thread.Sleep(2000);
        var result = await _prestamosService.GetPrestamosAsync();
        var count = await _prestamosService.GetPrestamosAsync();
        if (!string.IsNullOrEmpty(q))
        {
            page = 1;
            // result = result.Where(s => s.Nombre.ToUpper().Contains(q.ToUpper())
            //                        || s.Apellidos.ToUpper().ToString().Contains(q.ToUpper())
            //                        || s.Email.ToUpper().ToString().Contains(q.ToUpper())
            //                        || s.Direccion.ToUpper().ToString().Contains(q.ToUpper())
            //                        || s.Telefono.ToUpper().ToString().Contains(q.ToUpper())).ToList();
        }
        // if (count == 0 && q != string.Empty)
        //     TempData["mensaje"] = "No se ha encontrado ningún lector con el criterio de búsqueda especificado.";
        // else
        // if (count == 0 && q == string.Empty)
        //     TempData["mensaje"] = "No existen lectores para mostrar.";

        int pageSize = 5;
        int pageNumber = page ?? 1;
        ViewBag.pageListModel = await result.ToPagedListAsync(pageNumber, pageSize);
        return View(await result.ToPagedListAsync(pageNumber, pageSize));
    }
}