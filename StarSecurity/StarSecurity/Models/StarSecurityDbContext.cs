using Microsoft.EntityFrameworkCore;

namespace StarSecurity.Models
{
    public class StarSecurityDbContext:DbContext
    {
        public StarSecurityDbContext(DbContextOptions<StarSecurityDbContext> options)
            : base(options)
        {
        }

        public DbSet<Login> Login { get; set; }

        public DbSet<Employee> Employee { get; set; }
    }
}
