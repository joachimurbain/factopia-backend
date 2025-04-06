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
             new Question { Id = 1, GameTypeId = 1, Content = "Regarde et decide si c'est vrai" },
             new Question { Id = 2, GameTypeId = 3, Content = "Les chats ont cinq orteils à chaque patte avant." },
             new Question { Id = 3, GameTypeId = 3, Content = "Le sucre rend les enfants hyperactifs." },
             new Question { Id = 4, GameTypeId = 3, Content = "Le lait aide à réparer les os cassés." },
             new Question { Id = 5, GameTypeId = 3, Content = "Les éléphants sont les seuls animaux qui ne peuvent pas sauter." },
             new Question { Id = 6, GameTypeId = 3, Content = "L'homme a plus de dents que la femme." },
             new Question { Id = 7, GameTypeId = 3, Content = "Le miel ne se périme jamais." },
             new Question { Id = 8, GameTypeId = 3, Content = "Les oranges contiennent de la vitamine C." },
             new Question { Id = 9, GameTypeId = 3, Content = "Le cœur humain est capable de continuer à battre après la mort." }
        );

        modelBuilder.Entity<Resource>().HasData(
             new Resource { Id = 1, QuestionId = 1, Path = "/videos/A_1.mp4", FileType = FileType.Image, Name = "A_1.mp4" }
        );

        modelBuilder.Entity<Answer>().HasData(
            new Answer { Id = 1, QuestionId = 2, Content = "Vrai", IsCorrect = true },
            new Answer { Id = 2, QuestionId = 2, Content = "Faux", IsCorrect = false },
            new Answer { Id = 3, QuestionId = 3, Content = "Vrai", IsCorrect = false },
            new Answer { Id = 4, QuestionId = 3, Content = "Faux", IsCorrect = true },
            new Answer { Id = 5, QuestionId = 4, Content = "Vrai", IsCorrect = true },
            new Answer { Id = 6, QuestionId = 4, Content = "Faux", IsCorrect = false },
            new Answer { Id = 7, QuestionId = 5, Content = "Vrai", IsCorrect = true },
            new Answer { Id = 8, QuestionId = 5, Content = "Faux", IsCorrect = false },
            new Answer { Id = 9, QuestionId = 6, Content = "Vrai", IsCorrect = false },
            new Answer { Id = 10, QuestionId = 6, Content = "Faux", IsCorrect = true },
            new Answer { Id = 11, QuestionId = 7, Content = "Vrai", IsCorrect = true },
            new Answer { Id = 12, QuestionId = 7, Content = "Faux", IsCorrect = false },
            new Answer { Id = 13, QuestionId = 8, Content = "Vrai", IsCorrect = true },
            new Answer { Id = 14, QuestionId = 8, Content = "Faux", IsCorrect = false },
            new Answer { Id = 15, QuestionId = 9, Content = "Vrai", IsCorrect = true },
            new Answer { Id = 16, QuestionId = 9, Content = "Faux", IsCorrect = false }
            );


    }
}
