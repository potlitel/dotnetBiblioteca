using BootstrapDashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace BootstrapDashboard.Services
{
    public interface ILibrosService
    {
        // Task<List<Libro>> GetLibrosAsync();
        List<Libro> GetLibrosAsync();
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
    }
}