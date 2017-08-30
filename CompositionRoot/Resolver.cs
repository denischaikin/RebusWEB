using BLL.Services.Rebus;
using DAL;
using DAL.Repositories;
using DAL.Repositories.Rebus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CompositionRoot
{
    public static class Resolver
    {
        public static void ConfigureServices(IServiceCollection services, string dataSource)
        {
            services.AddDbContext<RebusContext>(options =>
                options.UseSqlite($"Data Source={dataSource}"));

            services.AddScoped<IRebusRepository, RebusRepository>();
            services.AddScoped<IRebusService, RebusService>();
        }
    }
}
