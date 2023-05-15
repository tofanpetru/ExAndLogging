using System.Net.Http;

namespace Shared
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Log the request path (which corresponds to the action method being called)
            Console.WriteLine($"Before request: {context.Request.Path}");

            await _next(context);

            Console.WriteLine($"After request: {context.Request.Path}");
        }
    }
}