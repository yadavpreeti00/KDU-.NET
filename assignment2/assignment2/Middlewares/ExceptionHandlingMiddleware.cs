using assignment2.DTOs;
using assignment2.Exceptions;
using System.Text.Json;

namespace assignment2.Middlewares
{
    public class ExceptionHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (CustomException ex)
            {
                context.Response.StatusCode = ex.StatusCode;
                context.Response.ContentType = "application/json";
                string jsonErrorResponse = GenerateErrorResponse(ex.Message, context.Request.Path, ex.StatusCode);
                await context.Response.WriteAsync(jsonErrorResponse);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";
                string jsonErrorResponse = GenerateErrorResponse(ex.Message, context.Request.Path, 500);
                await context.Response.WriteAsync(jsonErrorResponse);
            }
        }

        private string GenerateErrorResponse(string message, string path, int statusCode)
        {
            ErrorResponseDTO errorResponse = new ErrorResponseDTO(message, path, DateTime.Now, statusCode);
            return JsonSerializer.Serialize(errorResponse);
        }
    }
}
