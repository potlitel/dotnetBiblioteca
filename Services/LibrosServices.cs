using BootstrapDashboard.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BootstrapDashboard.Services
{
    public interface ILibrosService
    {
        // Task<List<Libro>> GetLibrosAsync();
        List<Libro> GetLibrosAsync();
        Libro? GetLibroById(int Id);

        Libro? GetLibroByISBN(string isbn);

        List<SelectListItem> PopulateGeneros();

        void AddLibro(Libro libro);

        void UpdateLibro(Libro libro);

        void DeleteLibro(int Id);
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
        public Libro? GetLibroById(int Id)
        {
            return _context.Libros.Find(keyValues: Id);
        }

        /**
         * Description: Function para listar todo los generos
         * @returns {a        */
        public List<SelectListItem> PopulateGeneros()
        {
            var CategoryCollection = _context.Genero.Select(c => new SelectListItem() { Text = c.Nombre, Value = c.CategoryId.ToString() }).ToList();
            // Genero DefaultCategory = new() { CategoryId = 0, Nombre = "Seleccione un género" };
            // CategoryCollection.Insert(0, DefaultCategory);
            return CategoryCollection;
        }

        /**
         * Description: Function para adicionar un libro
         * @param {any} Librolibro
         * @returns {a        */
        public void AddLibro(Libro libro)
        {
            _context.Libros.Add(libro);
            _context.SaveChanges();
        }

        /**
         * Description:Function para modificar un libro
         * https://stackoverflow.com/questions/69269866/cannot-update-existing-entries-in-the-databases
         * @param {any} Librolibro
         * @returns {a        */
        public void UpdateLibro(Libro libro)
        {
            Libro? foundBook = _context.Libros.FirstOrDefault(book => book.IdBook == libro.IdBook);
            if (foundBook is not null)
            {
                foundBook.IdBook = libro.IdBook;
                foundBook.CategoryId = libro.CategoryId;
                foundBook.ISBN = libro.ISBN;
                foundBook.Nombre = libro.Nombre;
                _context.Libros.Update(foundBook);
                _context.SaveChanges();
            }
        }

        /**
         * Description: Function para eliminar un libro
         * @param {any} intId
         * @returns {a        */
        public void DeleteLibro(int Id)
        {
            // if (_context.Libros == null)
            // {
            //     return ArgumentException("Entity set 'ApplicationDbContext.Libros'  is null.");
            // }
            Libro? foundBook = _context.Libros.Find(keyValues: Id);
            if (foundBook is not null)
            {
                _context.Libros.Remove(foundBook);
                _context.SaveChanges();
            }
        }

        /**
         * Description: Function para buscar un libro por su ISBN
         * @param {any} stringisbn
         * @returns {a        
         */
        public Libro? GetLibroByISBN(string isbn)
        {
            return _context.Libros.SingleOrDefault(book => book.ISBN == isbn);
        }
    }
}