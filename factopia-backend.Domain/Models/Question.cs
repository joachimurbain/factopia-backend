using factopia_backend.Domain.Interfaces;

namespace factopia_backend.Domain.Models;

public class Question : IEntity
{
    public int Id { get; set; }
    public string Content { get; set; }
    public List<UserQuestion> UserQuestion { get; set; }
    public int GameTypeId { get; set; }
    public GameType GameType { get; set; }
    public List<Resource> Files { get; set; } = [];
    public List<Answer> Answers { get; set; }
}
