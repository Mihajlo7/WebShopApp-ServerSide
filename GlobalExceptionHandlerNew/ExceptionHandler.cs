using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ExceptionModel;
using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GlobalExceptionHandlerNew
{
    public class ExceptionHandler(RequestDelegate next)
    { 
        //private readonly ILogger _logger=logger;
        private readonly RequestDelegate _next=next;

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }catch(Exception ex)
            {
                //_logger.LogInformation($"Exception has thrown: {ex}");
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        private async Task HandleExceptionAsync(HttpContext httpContext,Exception exception)
        {
            httpContext.Response.ContentType = "application/json";

            var response=httpContext.Response;
            var errorResponse = new ErrorResponse();
            errorResponse.Message = exception.Message;
            if(exception is ValidationException validationException)
            {
                errorResponse.Title = "Validation Exception";
                errorResponse.StatusCode = StatusCodes.Status422UnprocessableEntity;
                errorResponse.ErrorCode = "VAL-00X1";
                errorResponse.Message = "One or more validation errors occurred";
                errorResponse.Errors = validationException.Errors
                    .GroupBy(e=>e.PropertyName)
                    .ToDictionary(g=>g.Key, g=>g.Select(e=>e.ErrorMessage).ToArray());
            }else if (exception is BaseException baseException)
            {
               errorResponse.Title = baseException.Title;
            errorResponse.Message=baseException.ErrorCode;
            errorResponse.ErrorCode = nameof(baseException.ErrorCode);
            errorResponse.StatusCode = baseException.StatusCode;
            errorResponse.DetailedMessage = baseException.StackTrace;
            errorResponse.Instance = $"{httpContext.Request.Method} : {httpContext.Request.Path}";
            errorResponse.Body = httpContext.Request.Body!=null 
                ? httpContext.Request.Body.ToString():null;

            }
            else
            {
                errorResponse.Title = "Server Exception";
                errorResponse.StatusCode = StatusCodes.Status500InternalServerError;
                errorResponse.ErrorCode = "SERVER_00X0";
                errorResponse.Message = exception.Message;
                errorResponse.DetailedMessage = exception.Message;
                errorResponse.Instance = $"{httpContext.Request.Method} : {httpContext.Request.Path}";
                errorResponse.Body = httpContext.Request.Body != null
                    ? await ReadRequestBodyAsync(httpContext) : null;
            }
            

            response.StatusCode = errorResponse.StatusCode;

            //_logger.LogError(exception,errorResponse.Title, errorResponse.Message);
            var excResult=JsonSerializer.Serialize(errorResponse);

            await httpContext.Response.WriteAsync(excResult);

        }

        private async Task<string> ReadRequestBodyAsync(HttpContext httpContext)
        {
            httpContext.Request.EnableBuffering();
            httpContext.Request.Body.Position = 0;
            using (var reader = new StreamReader(httpContext.Request.Body, Encoding.UTF8, detectEncodingFromByteOrderMarks: false, leaveOpen: true))
            {
                var body = await reader.ReadToEndAsync();
                httpContext.Request.Body.Position = 0; // Resetovanje pozicije stream-a za sledeću upotrebu
                return body;
            }
        }
    }
}
