using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace Curtains.Infrastructure.Correlation
{
    public class CorrelationMiddleware : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (context.Request != null && !context.Request.Headers.ContainsKey("correlation-id"))
                context.Request?.Headers.Add("correlation-id", (StringValues) context.GetCorrelationId());
            return next(context);
        }
    }
}