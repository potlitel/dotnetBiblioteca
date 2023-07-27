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
    public IActionResult Crear([Bind("IdBook, Nombre,CategoryId,ISBN")] Libro libro)
    {
        if (ModelState.IsValid)
        {
            if (libro.IdBook == 0)
            {
                _albumesService.AddLibro(libro);
                TempData["mensaje"] = string.Format("El libro {0} ha sido adicionado correctamente.", libro.Nombre.ToString());
            }
            else
            {
                _albumesService.UpdateLibro(libro);
                TempData["mensaje"] = string.Format("El libro {0} ha sido modificado correctamente", libro.Nombre.ToString());
            }

            return RedirectToAction(nameof(Index));
        }
        PopulateGeneros();
        return View(model: libro);
    }

    // POST: Libro/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _albumesService.DeleteLibro(id);
        TempData["mensaje"] = string.Format("El libro ha sido eliminado correctamente");
        return RedirectToAction(nameof(Index));
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