using Microsoft.EntityFrameworkCore;
using Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Api.Contextos
{
    public class Contexto : IdentityDbContext<IdentityUser>
    {
              public Contexto(DbContextOptions<Contexto> options) : base(options) { }
              public Contexto() {}
              public DbSet<User> User { get; set; }
              public DbSet<Glicemia> Glicemia { get; set; }

              protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
              {
                  optionsBuilder.UseNpgsql("Server=diagest.postgres.database.azure.com;Database=diagest_dev;Port=5432;User Id=diagest;Password=f!dasl3&sd89@2d!;Trust Server Certificate=True;");
              }
              
              protected override void OnModelCreating(ModelBuilder builder)
              {
                  base.OnModelCreating(builder);
              }

    }
}