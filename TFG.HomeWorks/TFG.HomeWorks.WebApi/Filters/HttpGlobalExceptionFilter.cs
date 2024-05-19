using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TFG.HomeWorks.Application.Exceptions;

namespace TFG.HomeWorks.WebApi.Filters
{
    /// <summary>
    /// Clase para la gestión de todas las excepciones HTTP
    /// </summary>
    public class HttpGlobalExceptionHandler(IWebHostEnvironment env, ILogger<HttpGlobalExceptionHandler> logger) : IExceptionHandler
    {
        private readonly IWebHostEnvironment _env = env;
        private readonly ILogger<HttpGlobalExceptionHandler> _logger = logger;

        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            {
                // log la excepción
                _logger.LogError(exception, $"Error Message --> {exception.Message}");

                // Crear mensaje y código según el tipo de excepción
                int statusCode;
                string title = "An error occurred.";
                CustomApplicationException? applicationControlledException = null;

                IDictionary<string, string[]> errors = null;

                switch (exception)
                {
                    case ValidationException validationException:
                        errors = validationException.Errors
                            .Select(item => new { Key = item.PropertyName.Split('.').Last(), Value = item.ErrorMessage ?? item.ErrorCode })
                            .GroupBy(item => item.Key)
                            .ToDictionary(grouped => grouped.Key, grouped => grouped.Select(item => item.Value).ToArray());
                        title = exception.Message;

#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                        applicationControlledException = CustomApplicationException.Create(CustomApplicationExceptionCode.ValidationException);
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos

                        statusCode = StatusCodes.Status400BadRequest;
                        break;
                    case CustomApplicationException controlledException:
                        applicationControlledException = controlledException;
                        statusCode = StatusCodes.Status400BadRequest;
                        break;
                    case UnauthorizedAccessException:
                        statusCode = StatusCodes.Status403Forbidden;
                        break;
                    case KeyNotFoundException:
                        statusCode = StatusCodes.Status404NotFound;
                        break;
                    case NotImplementedException:
                        statusCode = StatusCodes.Status501NotImplemented;
                        break;
                    default:
                        statusCode = StatusCodes.Status500InternalServerError;
                        break;
                }

                // crear el problema y asociarlo al contexto en la respuesta
                ProblemDetails problemDetails = errors is null
                    ? new ProblemDetails()
                    : new ValidationProblemDetails(errors);

                problemDetails.Title = title;
                problemDetails.Status = statusCode;
                problemDetails.Instance = httpContext.Request.Path;
                if (Activity.Current is not null)
                    problemDetails.Extensions.Add("traceId", Activity.Current.Id);

                if (applicationControlledException != null)
                {
                    problemDetails.Extensions.Add("errorCode", (int)applicationControlledException.Code);
                    problemDetails.Extensions.Add("errorMessage", applicationControlledException.Message);
                }

                // Añadir información de depuración
                if (!_env.IsProduction())
                {
                    problemDetails.Extensions.Add("_exceptionMessage", exception.Message);
                    problemDetails.Extensions.Add("_stackTrace", exception.StackTrace);
                }

                httpContext.Response.StatusCode = statusCode;

                if (errors is null)
                    await (httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken: cancellationToken));
                else
                    await (httpContext.Response.WriteAsJsonAsync((ValidationProblemDetails)problemDetails, cancellationToken: cancellationToken));

                return true;
            }
        }
    }
}
