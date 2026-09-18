using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Data;
using PortfolioApp.Models;

namespace PortfolioApp.Controllers;

public class AccountController : Controller
{
    // Hardcoded credentials required by the assignment. These are intentionally
    // NOT rendered anywhere in the UI or client-side script — only documented
    // in README.md, and compared here on the server.
    private const string ValidUsername = "admin";
    private const string ValidPassword = "Portfolio2026!";

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Login(string? returnUrl = null)
    {
        if (User.Identity?.IsAuthenticated == true)
        {
            return RedirectToAction("Dashboard");
        }

        return View(new LoginViewModel { ReturnUrl = returnUrl });
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
        {
            model.HasError = true;
            return View(model);
        }

        // Constant-shape comparison isn't strictly necessary for a hardcoded
        // classroom credential, but we still avoid leaking *which* field was
        // wrong to keep the failure message generic.
        var isValid = model.Username == ValidUsername && model.Password == ValidPassword;

        if (!isValid)
        {
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            model.HasError = true;
            model.Password = string.Empty;
            return View(model);
        }

        var claims = new List<Claim>
        {
            new(ClaimTypes.Name, model.Username),
            new(ClaimTypes.Role, "Administrator")
        };

        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var principal = new ClaimsPrincipal(identity);

        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties
        {
            IsPersistent = false
        });

        if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
        {
            return Redirect(model.ReturnUrl);
        }

        return RedirectToAction("Dashboard");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Index", "Home");
    }

    // Protected administrative area — only reachable once authenticated.
    [Authorize]
    public IActionResult Dashboard()
    {
        ViewBag.TotalProjects = ProjectRepository.All.Count;
        ViewBag.TotalComments = ProjectRepository.All.Sum(p => CommentRepository.GetForProject(p.Id).Count);
        return View();
    }
}
