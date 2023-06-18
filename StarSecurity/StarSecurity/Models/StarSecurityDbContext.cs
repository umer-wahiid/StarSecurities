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

        public DbSet<Services> Services { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Vacancy> Vacancy { get; set; }

        public DbSet<Testimonials> Testimonials { get; set; }
    }
}
