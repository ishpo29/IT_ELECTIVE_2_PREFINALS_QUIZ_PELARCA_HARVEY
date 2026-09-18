# Portfolio MVC Application

**"Digital Project Archive"** — an ASP.NET Core MVC portfolio built for the IT Elective 2
(BSIT31E3) pre-final project, showcasing 17 GitHub repositories authored by
**Harvey Ischei Pelarca**.

## Description

This application presents a developer's coursework history as a curated archive rather
than a simple list of links. It includes a full project index, individual case-study
detail pages for every repository, per-project comment threads, and a restricted
administration area protected by a hardcoded login, all wrapped in a dark, editorial,
technical UI.

## Features

- 17 real GitHub projects, each with its exact repository URL (no placeholders)
- Sophisticated project index / table of contents with hover previews
- Secondary card-grid view of all projects
- Dedicated detail ("case study") page per project at `/Projects/Details/{id}`
- Previous / Next / Index navigation on every detail page
- Independent comment thread per project (never a single global comment pool)
- Server-side comment validation (no empty comments, length limits, markup stripped)
- Hardcoded login with cookie-based authentication and a protected admin dashboard
- Fully responsive layout (desktop, laptop, tablet, mobile)
- Centralized project/comment data — no per-view hardcoding
- No external NuGet packages required — builds entirely from the ASP.NET Core shared framework

## Technologies Used

- **ASP.NET Core MVC** (.NET 10, `Microsoft.NET.Sdk.Web`)
- **C#** with nullable reference types enabled
- **Razor views** with strongly-typed view models and built-in tag helpers
- **Cookie authentication** (`Microsoft.AspNetCore.Authentication.Cookies`) for the admin login
- **DataAnnotations** for server-side model validation
- **Anti-forgery tokens** on all POST forms (login, logout, comments)
- Plain **CSS3** (custom design system, no Bootstrap) and vanilla **JavaScript**
- In-memory data stores (`Data/ProjectRepository.cs`, `Data/CommentRepository.cs`) —
  no database required to run the app

## Login Credentials

> Required by the assignment. These are **not** displayed anywhere in the running
> application or in any client-side script — only here, and compared server-side in
> `Controllers/AccountController.cs`.

| Field    | Value             |
|----------|-------------------|
| Username | `admin`           |
| Password | `Portfolio2026!`  |

Logging in unlocks `/Account/Dashboard`, a small protected administration page.
Everything else in the portfolio (browsing projects, reading details, posting
comments) is intentionally public, since the assignment's login requirement targets
an "administration" concept rather than gating the whole site.

## How to Run

**Prerequisites:** [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later.

```bash
# from the project root (where PortfolioApp.csproj lives)
dotnet restore
dotnet build
dotnet run
```

Then open the URL printed in the console (typically `https://localhost:7265` or
`http://localhost:5265`). No database setup or connection string is required — all
project and comment data lives in memory for the lifetime of the running process,
so posted comments reset when the app restarts.

## Project Structure

```
PortfolioApp/
├── Models/
│   ├── Project.cs                 # Project entity (Id, Name, GitHubUrl, Technologies, Features, ...)
│   ├── Comment.cs                 # Comment entity (Id, ProjectId, Name, Content, CreatedAt)
│   ├── CommentFormViewModel.cs    # Validated input for the comment form
│   ├── LoginViewModel.cs          # Validated input for the login form
│   └── ProjectDetailViewModel.cs  # Composes a project + prev/next + comments for the detail page
│
├── Data/
│   ├── ProjectRepository.cs       # Single source of truth for all 17 projects
│   └── CommentRepository.cs       # Thread-safe in-memory comment store, keyed by ProjectId
│
├── Controllers/
│   ├── HomeController.cs          # Hero/landing page, About, Error
│   ├── ProjectsController.cs      # Project index (TOC) and detail/case-study pages
│   ├── CommentsController.cs      # Handles comment submission per project
│   └── AccountController.cs       # Login / Logout / protected Dashboard
│
├── Views/
│   ├── Home/                      # Index (hero + stats + preview), About, Error
│   ├── Projects/                  # Index (TOC + grid), Details (case study + comments)
│   ├── Account/                   # Login, Dashboard
│   └── Shared/                    # _Layout, _ProjectThumb (generated SVG thumbnails)
│
└── wwwroot/
    ├── css/site.css                # The full "Digital Project Archive" design system
    └── js/site.js                  # Mobile nav toggle + subtle scroll-reveal
```

**Why no database?** All 17 projects are static, known-in-advance data, so a
`static` in-memory repository (`ProjectRepository`) is used as the single source of
truth — every view reads from it instead of hardcoding project info per page.
Comments are similarly stored in-memory (`CommentRepository`), scoped strictly by
`ProjectId`. The boundary is isolated behind these two classes so the storage layer
could be swapped for Entity Framework Core later without touching any controller or view.

## Security Notes

- Login credentials are compared server-side only; never rendered in HTML or JS.
- All state-changing POST actions (login, logout, comment submission) require a
  valid anti-forgery token.
- Comment input is validated server-side (`[Required]`, length limits) and angle
  brackets are stripped before storage; Razor's automatic output encoding provides
  a second layer of protection against script injection when comments are rendered.
- The `/Account/Dashboard` action is decorated with `[Authorize]` and unreachable
  without a valid authentication cookie.
- Cookies are `HttpOnly` and `SameSite=Strict`.

## Projects

All 17 repositories included in this portfolio, in the order they appear in the
project index:

1. **Prefinal Exam** — [IT_ELECTTIVE_2_BSIT31E3_PREFINAL_EXAM_PELARCA_HARVEY](https://github.com/ishpo29/IT_ELECTTIVE_2_BSIT31E3_PREFINAL_EXAM_PELARCA_HARVEY)
2. **Prefinals Homework 1** — [BSIT31E3_PREFINALS-H1_PELARCA_HARVEY](https://github.com/ishpo29/BSIT31E3_PREFINALS-H1_PELARCA_HARVEY)
3. **Prefinals Activity 1** — [IT_ELECTIVE_2_PREFINALS_ACT1_Pelarca_Harvey](https://github.com/ishpo29/IT_ELECTIVE_2_PREFINALS_ACT1_Pelarca_Harvey)
4. **Prefinals Group Project** — [IT_ELECTIVE_2_BSIT31E3_PreFinalsProject_PjGalang_Pelarca_Romulo](https://github.com/ishpo29/IT_ELECTIVE_2_BSIT31E3_PreFinalsProject_PjGalang_Pelarca_Romulo)
5. **Midterm Quiz 3** — [IT_ELECTIVE_2_MIDTERM_Q3_Pelarca_Harvey](https://github.com/ishpo29/IT_ELECTIVE_2_MIDTERM_Q3_Pelarca_Harvey)
6. **Midterm Exam — Set 1** — [IT_ELECTIVE_2_MIDTERM_EXAM_SET1_Pelarca_Harvey](https://github.com/ishpo29/IT_ELECTIVE_2_MIDTERM_EXAM_SET1_Pelarca_Harvey)
7. **Midterm Homeworks (H1–H3)** — [IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Pelarca_Harvey](https://github.com/ishpo29/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Pelarca_Harvey)
8. **Midterm Quiz 2** — [IT_ELECTIVE_2_MIDTERM_Q2_Pelarca_Harvey](https://github.com/ishpo29/IT_ELECTIVE_2_MIDTERM_Q2_Pelarca_Harvey)
9. **IT Elective Coursework** — [IT_ELECTIVE_BSIT_31E3_Pelarca_Harvey](https://github.com/ishpo29/IT_ELECTIVE_BSIT_31E3_Pelarca_Harvey)
10. **Midterm Activity 1** — [IT_ELECTIVE_2_Midterm_A1_Pelarca_Harvey](https://github.com/ishpo29/IT_ELECTIVE_2_Midterm_A1_Pelarca_Harvey)
11. **Prelim Exam** — [IT_ELECTIVE_2_PRELIM_EXAM_Pelarca_Harvey](https://github.com/ishpo29/IT_ELECTIVE_2_PRELIM_EXAM_Pelarca_Harvey)
12. **Prelim Activity 3** — [ishpo29-BSIT31E3_PRELIM_A3_PELARCA_HARVEY](https://github.com/ishpo29/ishpo29-BSIT31E3_PRELIM_A3_PELARCA_HARVEY)
13. **Prelim Quiz 1** — [BSIT_BSIT31E3_PRELIM_Q1_Pelarca_Harvey](https://github.com/ishpo29/BSIT_BSIT31E3_PRELIM_Q1_Pelarca_Harvey)
14. **Prelim Homework 2** — [BSIT31E3_PRELIM_H2_Pelarca_Harvey](https://github.com/ishpo29/BSIT31E3_PRELIM_H2_Pelarca_Harvey)
15. **Prelim Homework 1** — [BSIT31E1_PRELIM_H1_PELARCA_HARVEY](https://github.com/ishpo29/BSIT31E1_PRELIM_H1_PELARCA_HARVEY)
16. **Prelim Activity 2** — [BSIT31E3_PRELIM_A2_PELARCA_HARVEY](https://github.com/ishpo29/BSIT31E3_PRELIM_A2_PELARCA_HARVEY)
17. **Prelim Activity 1** — [BSIT31E3_PRELIM_A1_PELARCA_HARVEY](https://github.com/ishpo29/BSIT31E3_PRELIM_A1_PELARCA_HARVEY)

GitHub profile: [github.com/ishpo29](https://github.com/ishpo29)

## Notes on Thumbnails

Real screenshots were not available for these repositories, so each project uses a
consistent, generated abstract SVG "preview" (an abstracted browser-window shape
with the project number, category and technology stack) rather than a fake or
stock screenshot. Every generated thumbnail is explicitly labeled
**"GENERATED PREVIEW — NOT AN ACTUAL SCREENSHOT"** in its own metadata text so it is
never confused with a real application screenshot.
