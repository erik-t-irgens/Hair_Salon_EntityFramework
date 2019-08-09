using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
    public class HairSalonContext : DbContext
    {
        public virtual DbSet<Category> Stylists { get; set; }
        public virtual DbSet<Item> Clients { get; set; }
        public HairSalonContext(DbContextOptions options) : base(options) { }
    }
}