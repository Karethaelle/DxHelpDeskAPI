using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Extensions
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                response.StatusCode = error switch
                {
                    CustomExceptionBadRequest e => (int)HttpStatusCode.BadRequest, // Custom bad request exception
                    CustomExceptionInvalidModel e => (int)HttpStatusCode.UnprocessableEntity, // Custom validation exception
                    NotFoundException e => (int)HttpStatusCode.NotFound, // Not found exception
                                                                         // Other custom exceptions here
                    _ => (int)HttpStatusCode.InternalServerError, // Unhandled errors
                };

                var result = JsonSerializer.Serialize(new { message = error?.Message });
                await response.WriteAsync(result);
            }
        }
    }
}
