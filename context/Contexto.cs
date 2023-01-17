using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Contextos
{
    public class Contexto : DbContext
    {
              public DbSet<User> User { get; set; }
              public DbSet<Glicemia> Glicemia { get; set; }

              protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
              {
                  optionsBuilder.UseNpgsql("Server=localhost; Port=5432;Database=postgres;User Id=postgres;Password=password;");
              }

    }
}