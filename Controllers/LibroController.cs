using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootstrapDashboard.Models;
using BootstrapDashboard.Services;

namespace BootstrapDashboard.Controllers;

public class LibroController : Controller
{
    private readonly ILibrosService _albumesService;

    public LibroController(ILibrosService albumesService) => _albumesService = albumesService;

    /**
     * Description
     * @param {any} stringsortOrder
     * @param {any} stringq
     * @returns {any}
        */
    public IActionResult Index(string sortOrder, string q)
    {
        Thread.Sleep(2000);
        var result = _albumesService.GetLibrosAsync();
        if (!string.IsNullOrEmpty(q))
        {
            result = result.Where(s => s.Nombre.Contains(q)
                                   || s.ISBN.ToString().Contains(q)).ToList();

            // result = (from item in result
            //           where item.Nombre.ToList().Contains(item.Id)
            //           select item).ToList();
        }
        // switch (sortOrder)
        // {
        //     case "nombre":
        //         result = (List<Libro>)result.OrderByDescending(s => s.Nombre);
        //         break;
        //     // case "category":
        //     //     result = (List<Libro>)result.OrderBy(s => s.Category);
        //     //     break;
        //     case "isbn":
        //         result = (List<Libro>)result.OrderByDescending(s => s.ISBN);
        //         break;
        //         // default:
        //         //     result = (List<Libro>)result.OrderBy(s => s.Estado);
        //         //     break;
        // }
        if (result.Count == 0 && q != string.Empty)
            TempData["mensaje"] = string.Format("No se ha encontrado ningún libro con el criterio de búsqueda especificado: {0}.", q);
        return View(result.ToList());
    }

    //Http Get Creates
    /**
     * Description
     * @param {any} intid
     * @returns {any}
        */
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
                return CrearLibro(libro);
            }
            else
            {
                return EditarLibro(libro);
            }
        }
        return View(model: libro);
    }

    /**
     * Description
     * @param {any} Librolibro
     * @returns {any}
        */
    private IActionResult EditarLibro(Libro libroAActualizar)
    {
        var libroExistente = _albumesService.GetLibroByISBN(libroAActualizar.ISBN);

        //Si el libro mantiene su mismo ISBN no procedemos con ninguna validación
        if (libroExistente != null && ((libroExistente.ISBN == libroAActualizar.ISBN && libroExistente.IdBook == libroAActualizar.IdBook) ||
         (libroExistente.ISBN != libroAActualizar.ISBN && libroExistente.IdBook == libroAActualizar.IdBook)))
        {
            _albumesService.UpdateLibro(libroAActualizar);
            TempData["mensaje"] = string.Format("El libro {0} ha sido modificado correctamente", libroAActualizar.Nombre.ToString());
            return RedirectToAction(nameof(Index));
        }
        else
        if (libroExistente != null)//Existe un ISBN previamente, no se procede con el proceso de update
        {
            TempData["mensaje"] = string.Format("Ya existe un libro '" + "{1}" + "' con el ISBN {0} que acaba de especificar, por verifique e intente nuevamente.", libroAActualizar.ISBN.ToString(), libroExistente.Nombre.ToString());
            PopulateGeneros();
            return View(libroAActualizar);
        }
        else
        {
            _albumesService.UpdateLibro(libroAActualizar);
            TempData["mensaje"] = string.Format("El libro {0} ha sido modificado correctamente", libroAActualizar.Nombre.ToString());
            return RedirectToAction(nameof(Index));
        }
        return null; // we can change the null to anything else also.
    }

    /**
     * Description
     * @param {any} Librolibro
     * @returns {any}
        */
    private IActionResult CrearLibro(Libro libro)
    {
        var item = _albumesService.GetLibroByISBN(libro.ISBN);
        if (item == null)
        {
            _albumesService.AddLibro(libro);
            TempData["mensaje"] = string.Format("El libro {0} ha sido adicionado correctamente.", libro.Nombre.ToString());
            // return RedirectToAction(nameof(Crear));
            return RedirectToAction(nameof(Index));
        }
        else
        {
            TempData["mensaje"] = string.Format("Ya existe un libro '" + "{1}" + "' con el ISBN {0} que acaba de especificar, por verifique e intente nuevamente.", libro.ISBN.ToString(), item.Nombre.ToString());
            PopulateGeneros();
            return View(libro);
        }
    }

    // POST: Libro/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    /**
     * Description
     * @param {any} intid
     * @returns {any}
        */
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