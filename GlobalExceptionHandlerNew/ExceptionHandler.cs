using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ExceptionModel;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GlobalExceptionHandlerNew
{
    public class ExceptionHandler(RequestDelegate next,ILogger logger)
    { 
        private readonly ILogger _logger=logger;
        private readonly RequestDelegate _next=next;

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }catch(BaseException ex)
            {
                _logger.LogInformation($"Exception has thrown: {ex}");
            }
        }
        private async Task HandleExceptionAsync(HttpContext httpContext,BaseException exception)
        {
            httpContext.Response.ContentType = "application/json";

            var response=httpContext.Response;
            var errorResponse = new ErrorResponse();

            errorResponse.Title = exception.Title;
            errorResponse.Message=exception.ErrorCode;
            errorResponse.ErrorCode = nameof(exception.ErrorCode);
            errorResponse.StatusCode = exception.StatusCode;
            errorResponse.DetailedMessage = exception.StackTrace;

            response.StatusCode = errorResponse.StatusCode;

            _logger.LogError(exception,errorResponse.Title, errorResponse.Message);
            var excResult=JsonSerializer.Serialize(errorResponse);

            await httpContext.Response.WriteAsync(excResult);

        }
    }
}
