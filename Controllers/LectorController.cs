using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapDashboard.Models;
using Microsoft.AspNetCore.Authorization;

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