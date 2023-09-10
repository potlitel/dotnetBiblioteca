using BootstrapDashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BootstrapDashboard.Services
{
    public interface IPrestamosService
    {
        Task<List<Prestamo>> GetPrestamosAsync();
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
    }
}