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

    //Http Get Creates
    public IActionResult Crear(int id)
    {
        PopulateGeneros();
        if (id == 0)
            return View(new Libro());
        else
            return View(_albumesService.GetLibroById(id));
    }

    // POST: Libro/AddOrEdit
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Crear([Bind("Nombre,CategoryId,ISBN")] Libro libro)
    {
        if (ModelState.IsValid)
        {
            if (libro.IdBook == 0)
                // _context.Add(transaction);
                _albumesService.AddLibro(libro);
            else
                // _context.Update(transaction);
                _albumesService.UpdateLibro(libro);
            // await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        PopulateGeneros();
        return View(model: libro);
    }

    [NonAction]
    /**
     * Description: Método para poblar de datos (Géneros) el control correspondiente en la vista de creación de Libros
     * @returns {any}
        */
    public void PopulateGeneros()
    {
        ViewBag.Generos = _albumesService.PopulateGeneros();
    }
}