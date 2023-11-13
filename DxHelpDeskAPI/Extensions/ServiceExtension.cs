using Microsoft.AspNetCore.Builder;
using System.Reflection;

namespace DxHelpDeskAPI.Extensions
{
    public static class ServiceExtensions
    {
        // ... Other extension methods ...

        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
        public static void AddServicesAndRepositories(this IServiceCollection services, Assembly[] assemblies)
        {
            // Automatically register all repositories
            var repositoryTypes = assemblies
                .SelectMany(a => a.GetTypes())
                .Where(t => t.Name.EndsWith("Repository") && t.GetInterfaces().Any())
                .ToList();

            foreach (var type in repositoryTypes)
            {
                foreach (var implementedInterface in type.GetInterfaces())
                {
                    services.AddScoped(implementedInterface, type);
                }
            }

            // Automatically register all services
            var serviceTypes = assemblies
                .SelectMany(a => a.GetTypes())
                .Where(t => t.Name.EndsWith("Service") && t.GetInterfaces().Any())
                .ToList();

            foreach (var type in serviceTypes)
            {
                foreach (var implementedInterface in type.GetInterfaces())
                {
                    services.AddScoped(implementedInterface, type);
                }
            }
        }
    }
}
