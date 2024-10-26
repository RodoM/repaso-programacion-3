using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
  {
  }

  public DbSet<Driver> Drivers { get; set; }
  public DbSet<Car> Cars { get; set; }
  public DbSet<Garage> Garages { get; set; }
}
