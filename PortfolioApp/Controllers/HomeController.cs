using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Data;
using PortfolioApp.Models;

namespace PortfolioApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // Homepage shows the hero, portfolio statistics, and a preview of the archive.
        ViewBag.TotalProjects = ProjectRepository.All.Count;
        var preview = ProjectRepository.All.Take(6).ToList();
        return View(preview);
    }

    public IActionResult About()
    {
        return View();
    }

    [AllowAnonymous]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        return View(model: requestId);
    }
}
