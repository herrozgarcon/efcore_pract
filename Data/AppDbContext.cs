using efcore_practice.Models;
using Microsoft.EntityFrameworkCore;

namespace efcore_practice.Data;

public class AppDbContext: DbContext
{
    public DbSet<Departments> Departments => Set<Departments>();
    public DbSet<Students> Students => Set<Students>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=efcore;User Id=sa;Password=Hrithik21$;TrustServerCertificate=True;");
            
        }
    }
}