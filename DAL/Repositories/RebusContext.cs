using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class RebusContext:DbContext
    {
        public RebusContext(DbContextOptions<RebusContext> options) : base(options) { }
    }
}
