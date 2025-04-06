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
             new Question { Id = 9, GameTypeId = 3, Content = "Le cœur humain est capable de continuer à battre après la mort." },
             new Question { Id = 10, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 11, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 12, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 13, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 14, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 15, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 16, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 17, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 18, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 19, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 20, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 21, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 22, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" },
             new Question { Id = 23, GameTypeId = 1, Content = "Cette vidéo est-elle fake ou réelle ?" }
        );

        modelBuilder.Entity<Resource>().HasData(
             new Resource { Id = 1, QuestionId = 10, Path = "/videos/1_Fake.mp4", FileType = FileType.Video, Name = "A_1.mp4" ,  IsCorrect=false },
             new Resource { Id = 2, QuestionId = 11, Path = "/videos/1_Real.mp4", FileType = FileType.Video, Name = "A_1.mp4", IsCorrect = true },
             new Resource { Id = 3, QuestionId = 12, Path = "/videos/2_Fake.mp4", FileType = FileType.Video, Name = "A_1.mp4", IsCorrect = false },
             new Resource { Id = 4, QuestionId = 13, Path = "/videos/2_Real.mp4", FileType = FileType.Video, Name = "A_1.mp4" , IsCorrect = true },
             new Resource { Id = 5, QuestionId = 14, Path = "/videos/3_Fake.mp4", FileType = FileType.Video, Name = "A_1.mp4" , IsCorrect = false },
             new Resource { Id = 6, QuestionId = 15, Path = "/videos/3_Real.mov", FileType = FileType.Video, Name = "A_1.mp4" , IsCorrect = true },
             new Resource { Id = 7, QuestionId = 16, Path = "/videos/4_Fake.mp4", FileType = FileType.Video, Name = "A_1.mp4" , IsCorrect = false },
             new Resource { Id = 8, QuestionId = 17, Path = "/videos/4_Real.mp4", FileType = FileType.Video, Name = "A_1.mp4" , IsCorrect = true },
             new Resource { Id = 9, QuestionId = 18, Path = "/videos/5_Fake.mp4", FileType = FileType.Video, Name = "A_1.mp4" , IsCorrect = false },
             new Resource { Id = 10, QuestionId = 19, Path = "/videos/5_Real.mp4", FileType = FileType.Video, Name = "A_1.mp4" , IsCorrect = true },
             new Resource { Id = 11, QuestionId = 20, Path = "/videos/LumaAIdroppedaSoracompetitor–Dream Machine-text-to-videogeneratorthatsopentoALLai.mp4.mp4", FileType = FileType.Video, Name = "A_1.mp4" , IsCorrect=false },
             new Resource { Id = 12, QuestionId = 21, Path = "/videos/ThisisnotMorganFreemanADeepfakeSingularity.mp4", FileType = FileType.Video, Name = "A_1.mp4" , IsCorrect = false },
             new Resource { Id = 13, QuestionId = 22, Path = "/videos/TrumpGetsaKimJongUnHaircut–PutinCantStopLaughing.mp4", FileType = FileType.Video, Name = "A_1.mp4" , IsCorrect = false },
             new Resource { Id = 14, QuestionId = 23, Path = "/videos/ViralAIVideoTrumpHarrisRomanceAheadofUSElection.mp4", FileType = FileType.Video, Name = "A_1.mp4" , IsCorrect = false }
        );

        modelBuilder.Entity<Answer>().HasData(

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
            new Answer { Id = 16, QuestionId = 9, Content = "Faux", IsCorrect = false },


            new Answer { Id = 17, QuestionId = 10, Content = "Bien vu, nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer cette fausse vidéo. C'est discret, mais si on regarde bien, le mouvement de la patte n'est pas naturel et, quand on zoome, le grain de l'image est typique de ce que Sora est capable de produire. ", IsCorrect = true },
            new Answer { Id = 18, QuestionId = 10, Content = "Désolé, vous vous êtes trompé, nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer cette fausse vidéo. C'est discret, mais si on regarde bien, le mouvement de la patte n'est pas naturel et, quand on zoome, le grain de l'image est typique de ce que Sora est capable de produire. ", IsCorrect = false },
            new Answer { Id = 19, QuestionId = 11, Content = "Bien vu, il s'agit bien d'une vraie vidéo proposée par Getty Images,", IsCorrect = true },
            new Answer { Id = 20, QuestionId = 11, Content = "Désolé, vous vous êtes trompé, il s'agit en fait un clip vidéo proposé par Getty Images,", IsCorrect = false },
            new Answer { Id = 21, QuestionId = 12, Content = "Bien vu, nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer cette fausse vidéo. Un détail permettait de déceler le fake : le bras d'une personne assise à droite de l'image a esquissé un mouvement pas très naturel. Certaines pailles dans les verres sur le plateau bougent bizarrement aussi. ", IsCorrect = true },
            new Answer { Id = 22, QuestionId = 12, Content = "Désolé, vous vous êtes trompé, nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer cette fausse vidéo. Certains détails auraient pu vous mettre sur la piste  : le bras d'une personne assise à droite de l'image a esquissé un mouvement pas très naturel. Certaines pailles dans les verres sur le plateau bougent bizarrement aussi. ", IsCorrect = false },
            new Answer { Id = 23, QuestionId = 13, Content = "Bien vu, il s'agit bien d'une vraie vidéo proposée par Getty Images,", IsCorrect = true },
            new Answer { Id = 24, QuestionId = 13, Content = "Désolé, vous vous êtes trompé, il s'agit en fait un clip vidéo proposé par Getty Images,", IsCorrect = false },
            new Answer { Id = 25, QuestionId = 14, Content = "Bravo, décidément, on ne vous la fait pas à vous!. Il faut dire que c'était facile avec le téléphone gigantesque en arrière-plan et les mains qui semblent à peine toucher le clavier. Nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer cette vidéo,", IsCorrect = true },
            new Answer { Id = 26, QuestionId = 14, Content = "Désolé, vous vous êtes trompé, vous auriez pu trouver, si vous aviez remarqué le téléphone gigantesque en arrière-plan et les mains qui semblent à peine toucher le clavier, vous auriez pu trouver. Nous avons utilisé Sora, l'outil de création de vidéos mis au point par Open AI pour générer la première vidéo.", IsCorrect = false },
            new Answer { Id = 27, QuestionId = 15, Content = "Bien vu, il s'agit bien d'une vraie vidéo proposée par Getty Images,", IsCorrect = true },
            new Answer { Id = 28, QuestionId = 15, Content = "Désolé, vous vous êtes trompé, il s'agit en fait un clip vidéo proposé par Getty Images,", IsCorrect = false },
            new Answer { Id = 29, QuestionId = 16, Content = "Bien vu ! Vous avez peut-être été frappé par l'aspect trop lisse des bâtiments et par le drapeau américain au premier plan qui bouge avec un mouvement pas très naturel. Encore une fois, c'est l'oeuvre de Sora, tandis que l'autre vidéo vient de Getty Images.", IsCorrect = true },
            new Answer { Id = 30, QuestionId = 16, Content = "Désolé, vous vous êtes trompé, vous auriez pu deviner, si vous aviez remarqué  l'aspect trop lisse des bâtiments et par le drapeau américain au premier plan qui bouge avec un mouvement pas très naturel. Encore une fois, c'est l'oeuvre de Sora,", IsCorrect = false },
            new Answer { Id = 31, QuestionId = 17, Content = "Bien vu, il s'agit bien d'une vraie vidéo proposée par Getty Images,", IsCorrect = true },
            new Answer { Id = 32, QuestionId = 17, Content = "Désolé, vous vous êtes trompé, il s'agit en fait un clip vidéo proposé par Getty Images,", IsCorrect = false },
            new Answer { Id = 33, QuestionId = 18, Content = "Bien vu !  Ce jeune homme est le résultat de l'imagination de l'IA", IsCorrect = true },
            new Answer { Id = 34, QuestionId = 18, Content = "Désolé, vous vous êtes trompé ! Ce jeune homme est le résultat de l'imagination de l'IA", IsCorrect = false },
            new Answer { Id = 35, QuestionId = 19, Content = "Bien vu, il s'agit bien d'une vidéo probablement tournée sur un trampoline, qui vient de Getty Images.", IsCorrect = true },
            new Answer { Id = 36, QuestionId = 19, Content = "Désolé, il s'agit en faite d'une vidéo de Getty Images probablement tournée sur un trampoline.", IsCorrect = false },
            new Answer { Id = 37, QuestionId = 20, Content = "Vrai", IsCorrect = true },
            new Answer { Id = 38, QuestionId = 20, Content = "Faux", IsCorrect = false },
            new Answer { Id = 39, QuestionId = 21, Content = "Vrai", IsCorrect = true },
            new Answer { Id = 40, QuestionId = 21, Content = "Faux", IsCorrect = false },
            new Answer { Id = 41, QuestionId = 22, Content = "Vrai", IsCorrect = true },
            new Answer { Id = 42, QuestionId = 22, Content = "Faux", IsCorrect = false },
            new Answer { Id = 43, QuestionId = 23, Content = "Vrai", IsCorrect = true },
            new Answer { Id = 44, QuestionId = 23, Content = "Faux", IsCorrect = false }
            );


    }
}
