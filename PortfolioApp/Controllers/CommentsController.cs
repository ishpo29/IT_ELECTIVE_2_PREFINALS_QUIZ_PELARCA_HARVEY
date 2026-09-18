using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Data;
using PortfolioApp.Models;

namespace PortfolioApp.Controllers;

public class CommentsController : Controller
{
    // POST: /Comments/Create
    // Adds a comment scoped to a single ProjectId. Never a global comment pool.
    // Parameter is named "NewComment" (not "form") so that its default model
    // binding prefix lines up exactly with the "NewComment.*" field names and
    // validation keys produced by asp-for="NewComment.X" on the detail page.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(CommentFormViewModel NewComment)
    {
        var project = ProjectRepository.GetById(NewComment.ProjectId);
        if (project is null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            // Re-render the full detail page with validation messages instead of
            // silently dropping the invalid submission.
            var viewModel = new ProjectDetailViewModel
            {
                Project = project,
                PreviousProject = ProjectRepository.GetPrevious(project.Id),
                NextProject = ProjectRepository.GetNext(project.Id),
                Comments = CommentRepository.GetForProject(project.Id),
                NewComment = NewComment
            };
            return View("~/Views/Projects/Details.cshtml", viewModel);
        }

        // Basic defense-in-depth against raw markup being stored: strip angle
        // brackets so no HTML/script tags can ever persist in the store, on top
        // of Razor's automatic output encoding on render.
        var safeName = StripMarkup(NewComment.Name);
        var safeContent = StripMarkup(NewComment.Content);

        CommentRepository.Add(project.Id, safeName, safeContent);

        return Redirect($"/Projects/Details/{project.Id}#comments");
    }

    private static string StripMarkup(string input)
    {
        return input.Replace("<", string.Empty).Replace(">", string.Empty);
    }
}
