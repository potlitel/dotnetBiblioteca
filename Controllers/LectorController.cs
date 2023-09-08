using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapDashboard.Models;
using Microsoft.AspNetCore.Authorization;
using BootstrapDashboard.Services;
using X.PagedList;
using System.Data;
using Newtonsoft.Json;

namespace BootstrapDashboard.Controllers;

public class LectorController : Controller
{
    private readonly ILectoresService _lectoresService;

    public LectorController(ILectoresService lectoresService)
    {
        _lectoresService = lectoresService;
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
        var result = await _lectoresService.GetLectoresAsync();
        var count = await _lectoresService.GetLectoresCount();
        if (!string.IsNullOrEmpty(q))
        {
            page = 1;
            result = result.Where(s => s.Nombre.ToUpper().Contains(q.ToUpper())
                                   || s.Apellidos.ToUpper().ToString().Contains(q.ToUpper())
                                   || s.Email.ToUpper().ToString().Contains(q.ToUpper())
                                   || s.Direccion.ToUpper().ToString().Contains(q.ToUpper())
                                   || s.Telefono.ToUpper().ToString().Contains(q.ToUpper())).ToList();
        }
        if (count == 0 && q != string.Empty)
            TempData["mensaje"] = "No se ha encontrado ningún lector con el criterio de búsqueda especificado.";
        else
        if (count == 0 && q == string.Empty)
            TempData["mensaje"] = "No existen lectores para mostrar.";

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
    public async Task<IActionResult> Crear(int id)
    {
        if (id == 0)
            return View(new Lector());
        else
        {
            ModelState.Clear();
            return View(await _lectoresService.GetLectorById(id));
        }
    }

    // POST: Lector/AddOrEdit
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Crear([Bind("IdLector,Nombre,Apellidos,Email,Telefono,Direccion")] Lector lector)
    {
        // Logger.LogInformation("PostModel: " + JsonConvert.SerializeObject(lector, Formatting.None));
        try
        {
            if (ModelState.IsValid)
            {
                if (lector.IdLector == 0)
                {
                    return await CrearLector(lector);
                }
                else
                {
                    ModelState.Clear();
                    return await EditarLector(lector);
                }
            }
        }
        catch (DataException /* dex */)
        {
            //Log the error (uncomment dex variable name and add a line here to write a log.
            ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            return StatusCode(StatusCodes.Status500InternalServerError, "Error updating data");
        }
        return View(model: lector);
    }

    private async Task<ActionResult> EditarLector(Lector lector)
    {
        var lectorExistente = await _lectoresService.GetLectorById(lector.IdLector);
        if (lectorExistente is not null)
        {
            ModelState.Clear();
            await _lectoresService.UpdateLector(lector);
            TempData["mensaje"] = string.Format("El lector {0} ha sido modificado correctamente", lector.NombreCompleto.ToString());
        }
        return RedirectToAction(nameof(Index));
    }

    private async Task<ActionResult> CrearLector(Lector lector)
    {
        await _lectoresService.AddLector(lector);
        TempData["mensaje"] = string.Format("El lector {0} {1} ha sido adicionado correctamente.", lector.Nombre.ToString(), lector.Apellidos.ToString());
        // return RedirectToAction(nameof(Crear));
        return RedirectToAction(nameof(Index));
    }

    // POST: Lector/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    /**
     * Description
     * @param {any} intid
     * @returns {any}
        */
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        try
        {
            await _lectoresService.DeleteLectorAsync(id);
            TempData["mensaje"] = string.Format("El lector ha sido eliminado correctamente");
        }
        catch (DataException /* dex */)
        {
            //Log the error (uncomment dex variable name and add a line here to write a log.
            ModelState.AddModelError("", "Unable to delete. Try again, and if the problem persists see your system administrator.");
        }
        return RedirectToAction(nameof(Index));
    }

    [AcceptVerbs("Get", "Post")]
    [AllowAnonymous]
    public async Task<string> IsEmailInUse(string email)
    {
        return await _lectoresService.IsEmailInUse(email);
    }
}