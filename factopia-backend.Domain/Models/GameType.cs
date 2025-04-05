using System.Text.Json.Serialization;
using factopia_backend.Domain.Interfaces;

namespace factopia_backend.Domain.Models;

public class GameType : IEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    [JsonIgnore]
    public List<Question> Questions { get; set; }
}
