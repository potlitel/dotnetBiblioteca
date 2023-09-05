using BootstrapDashboard.Models;

namespace BootstrapDashboard.Services
{
    public interface IGenerosService
    {
        List<Genero> GetGenerosAsync();
    }

    public class GenerosService : IGenerosService
    {
        private readonly BibliotecaContext _context;
        /**
         * Description: Constructor de la clase
         * @param {any} BibliotecaContextcontext
         * @returns {a        */
        public GenerosService(BibliotecaContext context) => _context = context;
        /**
         * Description: Método para obtener el listado de Géneros
         * @returns {a        */
        public List<Genero> GetGenerosAsync()
        {
            List<Genero> generos;
            try
            {
                generos = _context.Genero.ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return generos;
        }
    }
}