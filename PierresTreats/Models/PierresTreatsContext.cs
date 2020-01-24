using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierresTreats.Models
{
    public class PierresTreatsContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Flavor> Flavor { get; set; }
        public DbSet<Treat> Treats { get; set; }

        public PierresTreatsContext(DbContextOptions options) : base(options) { }
    }
}