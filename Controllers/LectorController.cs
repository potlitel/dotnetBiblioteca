using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapDashboard.Models;
using Microsoft.AspNetCore.Authorization;
using BootstrapDashboard.Services;
using X.PagedList;

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
        ViewBag.pageListModel = result.ToPagedList(pageNumber, pageSize);
        return View(result.ToPagedList(pageNumber, pageSize));
    }

    [AcceptVerbs("Get", "Post")]
    [AllowAnonymous]
    public async Task<IActionResult> IsEmailInUse(string email)
    {
        //check if the emailAddress already exists or not in database
        // var user = await _dbContext.managers.Where(x => x.Email == email).FirstOrDefaultAsync();
        // if (user == null)
        // {
        //     return Json(true);
        // }
        // else
        // {
        //     return Json($"Email {email} is already in use");
        // }
        return null;
    }
}