using factopia_backend.DAL.Database.Configurations;
using factopia_backend.Domain.CustomEnums;
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
        modelBuilder.ApplyConfiguration(new ResourceConfig());
        modelBuilder.ApplyConfiguration(new GameTypeConfig());
        modelBuilder.ApplyConfiguration(new QuestionConfig());
        modelBuilder.ApplyConfiguration(new UserConfig());
        modelBuilder.ApplyConfiguration(new UserQuestionConfig());



        modelBuilder.Entity<GameType>().HasData(
             new GameType { Id = 1, Title = "TikTok", Description = "REgarde la video ensuite, swipe a droite si c'est vrai !" },
             new GameType { Id = 2, Title = "Le Saviez-vous ?", Description = "Fun fact, annecdote et autre conseil." },
             new GameType { Id = 3, Title = "Vrai ou Fake?", Description = "" }
        );

        modelBuilder.Entity<Question>().HasData(
             new Question { Id = 1, GameTypeId = 1, Content = "Regarde et decide si c'est vrai" }
        );

        modelBuilder.Entity<Resource>().HasData(
             new Resource { Id = 1, QuestionId = 1, Path = "/videos/A_1.mp4", FileType=FileType.Image, Name="A_1.mp4" }
        );


    }
}
