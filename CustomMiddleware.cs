using Castle.Core.Logging;
using CoreDemo.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo
{
    public class CustomMiddleware : IMiddleware
    {
        public BookContext db;
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from new File 1 \n");
            await next(context);

            await context.Response.WriteAsync("Hello from new File 2\n");
        }
    }
}



    //public class RequestLoggingMiddleware
    //{
    //    private readonly RequestDelegate _next;
    //    private readonly ILogger _logger;

    //    public RequestLoggingMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
    //    {
    //        _next = next;
    //        _logger = loggerFactory.CreateLogger<RequestLoggingMiddleware>();
    //    }

    //    public async Task Invoke(HttpContext context)
    //    {
    //        try
    //        {
    //            await _next(context);
    //        }
    //        finally
    //        {
    //            _logger.LogInformation(
    //                "Request {method} {url} => {statusCode}",
    //                context.Request?.Method,
    //                context.Request?.Path.Value,
    //                context.Response?.StatusCode);
    //        }
    //    }
    //    }
    //}
