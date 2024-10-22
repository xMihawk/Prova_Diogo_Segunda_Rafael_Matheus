using Microsoft.EntityFrameworkCore;

namespace rafaelaloncofoggiatto.Models;

public class AppDbContext : DbContext
{
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Folha> Folhas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Matheus_Rafael.db");
    }
}