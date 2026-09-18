namespace PortfolioApp.Models;

public class ProjectDetailViewModel
{
    public Project Project { get; set; } = null!;
    public Project? PreviousProject { get; set; }
    public Project? NextProject { get; set; }
    public List<Comment> Comments { get; set; } = new();
    public CommentFormViewModel NewComment { get; set; } = new();
}
