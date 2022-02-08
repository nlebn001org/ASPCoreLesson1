using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class MiddlewareTask2
    {
        private readonly RequestDelegate requestDelegate;

        public MiddlewareTask2(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync(new Random().Next(10, 100).ToString() + "\n");
            await requestDelegate.Invoke(context);
        }
    }
}
