using BootstrapDashboard.Services;
// using Microsoft.Extensions.DependencyInjection;

namespace BootstrapDashboard.Middleware
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            // Inyectamos el servicio de Géneros
            services.AddTransient<IGenerosService, GenerosService>();
            // Inyectamos el servicio de Libros
            services.AddTransient<ILibrosService, LibrosService>();
            // Inyectamos el servicio de Lectores
            services.AddTransient<ILectoresService, LectorService>();
            return services;
        }
    }
}