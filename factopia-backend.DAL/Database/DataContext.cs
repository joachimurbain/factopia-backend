using factopia_backend.DAL.Database.Configurations;
using factopia_backend.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace factopia_backend.DAL.Database;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<Answer> Answers { get; set; }
    public DbSet<Answer> Files { get; set; }
    public DbSet<Answer> GamesTypes { get; set; }
    public DbSet<Answer> Questions { get; set; }
    public DbSet<Answer> Users { get; set; }
    public DbSet<Answer> UsersQuestions { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AnswerConfig());
        modelBuilder.ApplyConfiguration(new FileConfig());
        modelBuilder.ApplyConfiguration(new GameTypeConfig());
        modelBuilder.ApplyConfiguration(new QuestionConfig());
        modelBuilder.ApplyConfiguration(new UserConfig());
        modelBuilder.ApplyConfiguration(new UserQuestionConfig());
    }
}
