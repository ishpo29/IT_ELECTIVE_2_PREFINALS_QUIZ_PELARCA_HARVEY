namespace PortfolioApp.Models;

/// <summary>
/// A single comment attached to exactly one project via ProjectId.
/// </summary>
public class Comment
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
