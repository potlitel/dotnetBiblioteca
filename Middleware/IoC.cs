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

            return services;
        }
    }
}