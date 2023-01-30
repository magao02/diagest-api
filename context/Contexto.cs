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
                  optionsBuilder.UseNpgsql("Server=localhost; Port=5432;Database=postgres;User Id=postgres;Password=password;");
              }
              
              protected override void OnModelCreating(ModelBuilder builder)
              {
                  base.OnModelCreating(builder);
              }

    }
}