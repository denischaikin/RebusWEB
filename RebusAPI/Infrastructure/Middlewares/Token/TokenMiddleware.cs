using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RebusAPI.Infrastructure.Middlewares
{
    public class TokenMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _validToken;

        public TokenMiddleware(RequestDelegate next, string validToken)
        {
            this._next = next;
            _validToken = validToken;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Headers["token"];
            if (string.IsNullOrWhiteSpace(token) || token != _validToken)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Token is invalid");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
