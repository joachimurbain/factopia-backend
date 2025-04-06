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
    public DbSet<Resource> Resources { get; set; }
    public DbSet<GameType> GamesTypes { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserQuestion> UsersQuestions { get; set; }
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
             new Resource { Id = 1, QuestionId = 1, Path = "/videos/1_A.mp4", FileType=FileType.Image, Name="A_1.mp4" },
             new Resource { Id = 2, QuestionId = 1, Path = "/videos/1_B.mp4", FileType=FileType.Image, Name="A_1.mp4" },
             new Resource { Id = 3, QuestionId = 1, Path = "/videos/2_A.mp4", FileType=FileType.Image, Name="A_1.mp4" },
             new Resource { Id = 4, QuestionId = 1, Path = "/videos/2_B.mp4", FileType=FileType.Image, Name="A_1.mp4" },
             new Resource { Id = 5, QuestionId = 1, Path = "/videos/3_A.mp4", FileType=FileType.Image, Name="A_1.mp4" },
             new Resource { Id = 6, QuestionId = 1, Path = "/videos/3_B.mp4", FileType=FileType.Image, Name="A_1.mp4" },
             new Resource { Id = 7, QuestionId = 1, Path = "/videos/4_A.mp4", FileType=FileType.Image, Name="A_1.mp4" },
             new Resource { Id = 8, QuestionId = 1, Path = "/videos/4_B.mp4", FileType=FileType.Image, Name="A_1.mp4" },
             new Resource { Id = 9, QuestionId = 1, Path = "/videos/5_A.mp4", FileType=FileType.Image, Name="A_1.mp4" },
             new Resource { Id = 10, QuestionId = 1, Path = "/videos/5_B.mp4", FileType=FileType.Image, Name="A_1.mp4" }     
        );


    }
}
