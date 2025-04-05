namespace factopia_backend.Domain.Models;

public class Question
{
    public int Id { get; set; }
    public string Content { get; set; }
    public List<UserQuestion> UserQuestion { get; set; }
    public int GameTypeId { get; set; }
    public GameType GameType { get; set; }
    public List<File> Files { get; set; } = [];
}
