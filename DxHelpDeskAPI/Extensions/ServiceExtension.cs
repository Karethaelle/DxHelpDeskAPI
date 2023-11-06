using Microsoft.AspNetCore.Builder;

namespace DxHelpDeskAPI.Extensions
{
    public static class ServiceExtensions
    {
        // ... Other extension methods ...

        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
