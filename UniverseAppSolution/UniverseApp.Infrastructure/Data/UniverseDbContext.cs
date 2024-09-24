using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UniverseApp.Infrastructure.Data
{
    public class UniverseDbContext : IdentityDbContext
    {
        public UniverseDbContext(DbContextOptions<UniverseDbContext> options)
            : base(options)
        {
        }
    }
}
