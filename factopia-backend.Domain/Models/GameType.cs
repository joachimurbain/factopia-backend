namespace factopia_backend.Domain.Models;

public class GameType
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Question> Questions { get; set; }
}
