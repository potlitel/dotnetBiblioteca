using BootstrapDashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BootstrapDashboard.Services
{
    public interface IPrestamosService
    {
        Task<List<Prestamo>> GetPrestamosAsync();
        Task AddPrestamo(Prestamo prstamo);
        Task<int> GetPrestamosCount();
        Task<List<SelectListItem>> PopulateLibros();
        Task<List<SelectListItem>> PopulateLectores();
    }

    public class PrestamosService : IPrestamosService
    {
        private readonly BibliotecaContext _context;
        /**
         * Description: Constructor de la clase
         * @param {any} BibliotecaContextcontext
         * @returns {a        */
        public PrestamosService(BibliotecaContext context) => _context = context;
        public async Task<List<Prestamo>> GetPrestamosAsync()
        {
            // var applicationDbContext = _context.Libros.Include(t => t.Category);
            List<Prestamo> prstamos;

            try
            {
                prstamos = await _context.Prestamos.Include(t => t.Lector).Include(t => t.Libro).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return prstamos;
        }

        /**
         * Description: Function para adicionar un lector
         * @param {any} Lector lector
         * @returns {a        */
        public async Task AddPrestamo(Prestamo prstamo)
        {
            if (prstamo is not null)
            {
                _context.Prestamos.Add(prstamo);
                await _context.SaveChangesAsync();
            }
            else
            {
                new StatusCodeResult(404);
            }
        }

        public async Task<List<SelectListItem>> PopulateLectores()
        {
            var LectoresCollection = await _context.Lectores.Select(c => new SelectListItem() { Text = c.NombreCompleto, Value = c.IdLector.ToString() }).ToListAsync();
            return LectoresCollection;
        }

        public async Task<List<SelectListItem>> PopulateLibros()
        {
            var librosDisponibles = await _context.Libros.Where(c => !_context.Prestamos.Any(b => b.LibroId == c.IdBook)).ToListAsync();
            var LibrosCollection = librosDisponibles.Select(c => new SelectListItem() { Text = c.Nombre, Value = c.IdBook.ToString() }).ToList();
            return LibrosCollection;
        }

        public async Task<int> GetPrestamosCount()
        {
            var query = from prestamo in _context.Prestamos

                        select prestamo.Id;

            return await query.CountAsync();
        }
    }
}