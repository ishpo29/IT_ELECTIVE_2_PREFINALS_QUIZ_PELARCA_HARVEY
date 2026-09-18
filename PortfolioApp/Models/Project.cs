namespace PortfolioApp.Models;

/// <summary>
/// Represents a single project/repository entry in the portfolio archive.
/// All project data is centralized in Data/ProjectRepository.cs so that no
/// Razor view ever hardcodes project information.
/// </summary>
public class Project
{
    public int Id { get; set; }

    /// <summary>Display name shown throughout the UI.</summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>Exact GitHub repository name (used for reference / metadata).</summary>
    public string RepositoryName { get; set; } = string.Empty;

    /// <summary>Full, exact GitHub repository URL. Never a placeholder.</summary>
    public string GitHubUrl { get; set; } = string.Empty;

    /// <summary>One-line summary shown on index/card views.</summary>
    public string ShortDescription { get; set; } = string.Empty;

    /// <summary>Longer summary shown on the detail/case-study page.</summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>Course phase this project belongs to: Prelim / Midterm / Prefinal / Coursework.</summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>Technology tags, e.g. "C#", "ASP.NET Core", "MVC".</summary>
    public List<string> Technologies { get; set; } = new();

    /// <summary>Notable characteristics of the exercise/project.</summary>
    public List<string> Features { get; set; } = new();

    /// <summary>True when the repository is a fork of a classmate's/instructor's starter repo.</summary>
    public bool IsFork { get; set; }

    /// <summary>Optional collaborator names for group work.</summary>
    public List<string> Collaborators { get; set; } = new();

    /// <summary>Accent used to seed the generated abstract thumbnail (kept within the site palette).</summary>
    public string ThumbAccent { get; set; } = "primary";

    /// <summary>
    /// Optional path (relative to wwwroot) to a real preview image, e.g. "/images/project-preview.png".
    /// When set, the thumbnail renders this image instead of the generated abstract SVG.
    /// </summary>
    public string? ImageUrl { get; set; }
}
