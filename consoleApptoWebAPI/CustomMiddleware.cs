using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace consoleApptoWebAPI
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Message from custom middleware1 \n");
            await next(context);
            await context.Response.WriteAsync("Message from custom middleware2 \n");
        }
    }
}
