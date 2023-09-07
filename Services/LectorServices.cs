using BootstrapDashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BootstrapDashboard.Services
{
    public interface ILectoresService
    {
        Task<List<Lector>> GetLectoresAsync();
        Task<Lector?> GetLectorById(int Id);

        Task<Lector?> GetLectorByName(string name);

        Task<int> GetLectoresCount();

        Task AddLector(Lector lector);

        Task UpdateLector(Lector lector);

        Task DeleteLectorAsync(int Id);
    }

    public class LectorService : ILectoresService
    {
        private readonly BibliotecaContext _context;
        /**
         * Description: Constructor de la clase
         * @param {any} BibliotecaContextcontext
         * @returns {a        */
        public LectorService(BibliotecaContext context) => _context = context;
        /**
         * Description: Método para obtener el listado de Lectores
         * @returns {a        */
        public async Task<List<Lector>> GetLectoresAsync()
        {
            List<Lector> lectores;
            try
            {
                lectores = await _context.Lectores.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return lectores;
        }

        /**
         * Description: Busca un lector por su identificador
         * @param {any} intId
         * @returns {a        */
        public async Task<Lector?> GetLectorById(int Id)
        {
            return await _context.Lectores.FindAsync(keyValues: Id);
        }

        /**
         * Description: Function para adicionar un lector
         * @param {any} Lector lector
         * @returns {a        */
        public async Task AddLector(Lector lector)
        {
            _context.Lectores.Add(lector);
            await _context.SaveChangesAsync();
        }

        /**
         * Description:Function para modificar un lector
         * https://stackoverflow.com/questions/69269866/cannot-update-existing-entries-in-the-databases
         * @param {any} Librolibro
         * @returns {a        */
        public async Task UpdateLector(Lector lector)
        {
            Lector? foundLector = await _context.Lectores.FirstOrDefaultAsync(book => book.IdLector == lector.IdLector);
            if (foundLector is not null)
            {
                foundLector.Nombre = lector.Nombre;
                foundLector.Apellidos = lector.Apellidos;
                foundLector.Direccion = lector.Direccion;
                foundLector.Email = lector.Email;
                foundLector.Telefono = lector.Telefono;
                _context.Lectores.Update(foundLector);
                await _context.SaveChangesAsync();
            }
        }

        /**
         * Description: Function para eliminar un lector
         * @param {any} intId
         * @returns {a        */
        public async Task DeleteLectorAsync(int Id)
        {
            Lector? foundLector = await _context.Lectores.FindAsync(keyValues: Id);
            if (foundLector is not null)
            {
                _context.Lectores.Remove(foundLector);
                await _context.SaveChangesAsync();
            }
        }

        /**
         * Description: Function para buscar un lector por su Nombre
         * @param {any} stringisbn
         * @returns {a        
         */
        public async Task<Lector?> GetLectorByName(string name)
        {
            return await _context.Lectores.SingleOrDefaultAsync(book => book.Nombre == name);
        }

        public async Task<int> GetLectoresCount()
        {
            var query = from lector in _context.Lectores

                        select lector.IdLector;

            return await query.CountAsync();
        }
    }
}