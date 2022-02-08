using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Middlewaretask1
    {
        private readonly RequestDelegate _requestDelegate; 

        public Middlewaretask1(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate; 
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync(context.Request.Body.ToString()+"\n");
            await _requestDelegate.Invoke(context);
        }

    }
}
