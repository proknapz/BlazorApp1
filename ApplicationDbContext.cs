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
    public DbSet<StudentRecord> StudentRecords { get; set; }
    public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<QuizResponse> Attendances { get; set; }
    public DbSet<QuizBank> QuizBanks { get; set; }
    public DbSet<QuizQuestion> QuizQuestions { get; set; }
    public DbSet<QuizSession> QuizSessions { get; set; }
    
    public DbSet<Configuration> Configurations { get; set; }
    // Add more DbSet properties as needed
}
