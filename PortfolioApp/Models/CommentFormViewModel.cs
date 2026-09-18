using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models;

/// <summary>
/// Server-validated input for posting a comment on a specific project.
/// </summary>
public class CommentFormViewModel
{
    [Required]
    public int ProjectId { get; set; }

    [Required(ErrorMessage = "Please enter your name.")]
    [StringLength(60, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 60 characters.")]
    [Display(Name = "Name")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Comment cannot be empty.")]
    [StringLength(600, MinimumLength = 2, ErrorMessage = "Comment must be between 2 and 600 characters.")]
    [Display(Name = "Comment")]
    public string Content { get; set; } = string.Empty;
}
