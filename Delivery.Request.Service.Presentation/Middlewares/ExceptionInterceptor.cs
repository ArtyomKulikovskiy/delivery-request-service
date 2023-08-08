using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Request.Service.Presentation.Middlewares;

public sealed class ExceptionInterceptor
{
    private readonly RequestDelegate _next;

    public ExceptionInterceptor(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (ApplicationException e)
        {
            await PutExceptionToHttpResponse(context, 400, e.Message);
        }
        catch (Exception e)
        {
            await PutExceptionToHttpResponse(context, 500, e.Message);
        }
    }

    private async Task PutExceptionToHttpResponse(HttpContext context, int statusCode, string message)
    {
        var problemDetails = new ProblemDetails()
        {
            Status = statusCode,
            Detail = message,
        };

        context.Response.StatusCode = statusCode;
        await context.Response.WriteAsJsonAsync(problemDetails);
    }
}
