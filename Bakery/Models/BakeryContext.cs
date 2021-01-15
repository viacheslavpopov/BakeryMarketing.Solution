using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
    public class BakeryContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Flavors> Flavors { get; set; }
        public virtual DbSet<Sweets> Sweets { get; set; }
        public DbSet<FlavorSweet> FlavorSweet { get; set; }
        public BakeryContext(DbContextOptions options) : base(options) { }
    }
}