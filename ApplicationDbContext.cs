using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    // Constructor that passes options to the base DbContext
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
    }
    // Define DbSets for your tables (entities)
    public DbSet<Student> Students { get; set; }
    // Add more DbSet properties as needed
}
