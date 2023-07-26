using BootstrapDashboard.Models;

namespace BootstrapDashboard.Services
{
    public interface ILibrosService
    {
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
            List<Libro> books = new List<Libro>();

            try
            {
                books = _context.Libros.ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return books;
        }
    }
}