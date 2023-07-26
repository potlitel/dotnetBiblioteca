using BootstrapDashboard.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BootstrapDashboard.Services
{
    public interface ILibrosService
    {
        // Task<List<Libro>> GetLibrosAsync();
        List<Libro> GetLibrosAsync();
        Libro GetLibroById(int Id);

        List<SelectListItem> PopulateGeneros();

        void AddLibro(Libro libro);

        void UpdateLibro(Libro libro);
    }

    public class LibrosService : ILibrosService
    {
        private readonly BibliotecaContext _context;
        /**
         * Description: Constructor de la clase
         * @param {any} BibliotecaContextcontext
         * @returns {a        */
        public LibrosService(BibliotecaContext context) => _context = context;
        /**
         * Description: Método para obtener el listado de Géneros
         * @returns {a        */
        public List<Libro> GetLibrosAsync()
        {
            // var applicationDbContext = _context.Libros.Include(t => t.Category);
            List<Libro> books = new List<Libro>();

            try
            {
                books = _context.Libros.Include(t => t.Category).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return books;
        }

        /**
         * Description: Busca un libro por su identificador
         * @param {any} intId
         * @returns {a        */
        public Libro GetLibroById(int Id) => _context.Libros.Find(keyValues: Id);

        public List<SelectListItem> PopulateGeneros()
        {
            var CategoryCollection = _context.Genero.Select(c => new SelectListItem() { Text = c.Nombre, Value = c.CategoryId.ToString() }).ToList();
            // Genero DefaultCategory = new() { CategoryId = 0, Nombre = "Seleccione un género" };
            // CategoryCollection.Insert(0, DefaultCategory);
            return CategoryCollection;
        }

        public void AddLibro(Libro libro)
        {
            _context.Libros.Add(libro);
            _context.SaveChanges();
        }

        public void UpdateLibro(Libro libro)
        {
            _context.Libros.Update(libro);
            _context.SaveChanges();
        }
    }
}