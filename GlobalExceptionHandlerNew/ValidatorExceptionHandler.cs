using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ExceptionModel;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace GlobalExceptionHandlerNew
{
    public class ValidatorExceptionHandler(RequestDelegate next,ILogger logger)
    {
        private readonly ILogger _logger=logger;
        private readonly RequestDelegate _next=next;

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }catch(ValidationException ex)
            {
                _logger.LogInformation($"Validation Exception : {ex}");
                await HandleValidationExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleValidationExceptionAsync(HttpContext httpContext,ValidationException exception)
        {
            httpContext.Response.ContentType = "application/json";

            var response = httpContext.Response;
            var errorResponse = new ErrorResponse();

            errorResponse.Title = "Validation Exception";
            errorResponse.Message = exception.Message;
            errorResponse.ErrorCode = "V3456";
            errorResponse.StatusCode = 400;
            errorResponse.DetailedMessage = exception.StackTrace;
            errorResponse.Instance = $"{httpContext.Request.Method} : {httpContext.Request.Path}";
            errorResponse.Body = httpContext.Request.Body != null
                ? httpContext.Request.Body.ToString() : null;

            response.StatusCode = errorResponse.StatusCode;

            _logger.LogError(exception, errorResponse.Title, errorResponse.Message);
            var excResult = JsonSerializer.Serialize(errorResponse);

            await httpContext.Response.WriteAsync(excResult);
        }
    }
}
