using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Data;
using PortfolioApp.Models;

namespace PortfolioApp.Controllers;

public class ProjectsController : Controller
{
    // GET: /Projects
    // The main table of contents / project index.
    public IActionResult Index()
    {
        var projects = ProjectRepository.All.OrderBy(p => p.Id).ToList();
        return View(projects);
    }

    // GET: /Projects/Details/5
    public IActionResult Details(int id)
    {
        var project = ProjectRepository.GetById(id);
        if (project is null)
        {
            return NotFound();
        }

        var viewModel = new ProjectDetailViewModel
        {
            Project = project,
            PreviousProject = ProjectRepository.GetPrevious(id),
            NextProject = ProjectRepository.GetNext(id),
            Comments = CommentRepository.GetForProject(id),
            NewComment = new CommentFormViewModel { ProjectId = id }
        };

        return View(viewModel);
    }
}
