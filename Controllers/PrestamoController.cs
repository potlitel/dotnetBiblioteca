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

    //Http Get Creates
    /**
     * Description
     * @param {any} intid
     * @returns {any}
        */
    public async Task<IActionResult> Crear()
    {
        await PopulateLibros();
        await PopulateLectores();
        return View(new Prestamo());
    }

    // POST: Préstamo/AddOrEdit
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Crear([Bind("IdLector,IdLibro")] Prestamo prstamo)
    {
        try
        {
            if (ModelState.IsValid)
            {
                if (prstamo.Id == 0)
                {
                    return await RegistrarPrestamo(prstamo);
                }
                // else
                // {
                //     ModelState.Clear();
                //     return await EditarLector(lector);
                // }
            }
        }
        catch (DataException /* dex */)
        {
            //Log the error (uncomment dex variable name and add a line here to write a log.
            ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
        }
        return View(model: prstamo);
    }

    private async Task<ActionResult> RegistrarPrestamo(Prestamo prstamo)
    {
        await _prestamosService.AddPrestamo(prstamo);
        TempData["mensaje"] = "El préstamo se ha registrado correctamente.";
        return RedirectToAction(nameof(Index));
    }

    [NonAction]
    /**
     * Description: Método para poblar de datos (Libros) el control correspondiente en la vista de creación de Préstamos
     * @returns {any}
        */
    public async Task PopulateLibros()
    {
        try
        {
            ViewBag.Libros = await _prestamosService.PopulateLibros();
        }
        catch (DataException /* dex */)
        {
            //Log the error (uncomment dex variable name and add a line here to write a log.
            ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
        }
    }

    [NonAction]
    /**
     * Description: Método para poblar de datos (lectores) el control correspondiente en la vista de creación de Préstamos
     * @returns {any}
        */
    public async Task PopulateLectores()
    {
        try
        {
            ViewBag.Lectores = await _prestamosService.PopulateLectores();
        }
        catch (DataException /* dex */)
        {
            //Log the error (uncomment dex variable name and add a line here to write a log.
            ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
        }
    }
}