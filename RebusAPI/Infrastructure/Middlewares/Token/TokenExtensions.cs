using Microsoft.AspNetCore.Builder;

namespace RebusAPI.Infrastructure.Middlewares.Token
{
    public static class TokenExtensions
    {
        public static IApplicationBuilder UseToken(this IApplicationBuilder builder, string validToken)
        {
            return builder.UseMiddleware<TokenMiddleware>(validToken);
        }
    }
}
