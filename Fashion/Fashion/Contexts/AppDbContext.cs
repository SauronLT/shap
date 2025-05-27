using Fashion.Models;
using Microsoft.EntityFrameworkCore;

namespace Fashion.Contexts;

public class AppDbContext:DbContext
{
    public DbSet<Mal> Mals { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server= DESKTOP-VI89K5E;Database=mal;Trusted_Connection=True;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }

}
