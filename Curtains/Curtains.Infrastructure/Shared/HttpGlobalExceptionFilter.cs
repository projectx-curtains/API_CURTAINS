using Bogus;
using Curtains.Infrastructure.Shared.Exceptions;
using Curtains.Infrastructure.Shared.Filters;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using ValidationException = FluentValidation.ValidationException;


namespace Curtains.Infrastructure.Shared
{
    public class HttpGlobalExceptionFilter : IAsyncExceptionFilter, IFilterMetadata
    {
        private readonly IHostEnvironment _env;
        private readonly ILogger<HttpGlobalExceptionFilter> _logger;

        public HttpGlobalExceptionFilter(
            IHostEnvironment environment,
            ILogger<HttpGlobalExceptionFilter> logger)
        {
            this._env = environment ?? throw new ArgumentNullException(nameof (environment));
            this._logger = logger ?? throw new ArgumentNullException(nameof (logger));
        }

        public Task OnExceptionAsync(ExceptionContext context)
        {
            this._logger.LogError(new EventId(context.Exception.HResult), context.Exception, string.Format("Failed api call: {0}.", (object) context.HttpContext.Request.Path));
            context.ExceptionHandled = true;
            Exception exception = context.Exception;
            if (true);
            Task task;
            switch (exception)
            {
                case ResourceNotFoundException _:
                    task = this.HandleNotFoundError(context);
                    break;
                case ValidationException validationResult:
                    task = this.HandleValidationError(context, validationResult);
                    break;
                default:
                    task = this.HandleError(context);
                    break;
            }
            if (true)
                ;
            return task;
        }

        private Task HandleValidationError(
            ExceptionContext context,
            FluentValidation.ValidationException validationResult)
        {
            return context.WriteError(400, validationResult.Errors.Select<ValidationFailure, string>((Func<ValidationFailure, string>) (x => x.ErrorMessage)).ToArray<string>());
        }

        private Task HandleNotFoundError(ExceptionContext context) => context.WriteError(404, this._env.IsDevelopment() ? context.Exception.Message : "Resource(s) not found");

        private Task HandleError(ExceptionContext context)
        {
            context.HttpContext.Response.Headers.Add("X-Error", (StringValues) "An unexpected error occured");
            return context.WriteError(500, this._env.IsDevelopment() ? context.Exception.Message : "An unexpected error occured");
        }
    }
}