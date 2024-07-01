using Microsoft.EntityFrameworkCore;

namespace DataBaseAndClasses;

internal class ApplicationDbContext : DbContext
{
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=new;Encrypt=False;Trusted_Connection=True;");
        base.OnConfiguring(optionsBuilder);
    }
    
    public DbSet<Kitab> Kitablar { get; set; }
    public DbSet<Insan> Insanlar { get; set; }
    public DbSet<Muellim> Muellimler { get; set; }
    
}