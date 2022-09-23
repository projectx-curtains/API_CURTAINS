using System.Text.Json;
using Curtains.Infrastructure.Shared.Converters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;


namespace Curtains.Infrastructure.Shared.Filters
{
    public static class ExceptionContextExtensions
    {
        public static Task WriteError(
            this ExceptionContext exceptionContext,
            int statusCode,
            params string[] errors)
        {
            string text = JsonSerializer.Serialize(new
            {
                Errors = errors
            }, SerializerOptions.Default);
            exceptionContext.HttpContext.Response.StatusCode = statusCode;
            exceptionContext.HttpContext.Response.ContentType = "application/json";
            return exceptionContext.HttpContext.Response.WriteAsync(text);
        }
    }
}