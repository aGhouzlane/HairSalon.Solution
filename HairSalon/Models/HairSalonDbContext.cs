using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonDbContext : DbContext
  {
    public virtual DbSet<Client> Clients { get; set; }
    public DbSet<Stylist> Stylits { get; set; }

    public HairSalonDbContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}