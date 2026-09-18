using PortfolioApp.Models;

namespace PortfolioApp.Data;

/// <summary>
/// Centralized, read-only project catalogue. Every repository URL below is the
/// exact, verified GitHub URL supplied for this portfolio — none are placeholders.
/// </summary>
public static class ProjectRepository
{
    private const string Owner = "https://github.com/ishpo29/";

    public static readonly IReadOnlyList<Project> All = new List<Project>
    {
        new Project
        {
            Id = 1,
            Name = "Prefinal Exam",
            RepositoryName = "IT_ELECTTIVE_2_BSIT31E3_PREFINAL_EXAM_PELARCA_HARVEY",
            GitHubUrl = Owner + "IT_ELECTTIVE_2_BSIT31E3_PREFINAL_EXAM_PELARCA_HARVEY",
            Category = "Prefinal",
            ShortDescription = "The prefinal examination project for IT Elective 2 (BSIT31E3), built as an ASP.NET Core MVC application.",
            Description = "Submission for the prefinal examination of the IT Elective 2 course (section BSIT31E3). The repository contains a complete ASP.NET Core MVC solution structured around controllers, views and models, developed under exam conditions to demonstrate applied MVC architecture.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC", "Razor" },
            Features = new() { "Exam-scoped MVC solution", "Controller/View/Model separation", "Built and submitted under timed conditions" },
            ThumbAccent = "accent",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 2,
            Name = "Prefinals Homework 1",
            RepositoryName = "BSIT31E3_PREFINALS-H1_PELARCA_HARVEY",
            GitHubUrl = Owner + "BSIT31E3_PREFINALS-H1_PELARCA_HARVEY",
            Category = "Prefinal",
            ShortDescription = "First homework assignment of the prefinal term, focused on ASP.NET Core MVC fundamentals.",
            Description = "A homework exercise assigned during the prefinal term of IT Elective 2. The project reinforces core MVC concepts covered in class, implemented as a standalone ASP.NET Core application.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "Homework-scoped exercise", "Reinforces MVC request/response flow" },
            ThumbAccent = "primary",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 3,
            Name = "Prefinals Activity 1",
            RepositoryName = "IT_ELECTIVE_2_PREFINALS_ACT1_Pelarca_Harvey",
            GitHubUrl = Owner + "IT_ELECTIVE_2_PREFINALS_ACT1_Pelarca_Harvey",
            Category = "Prefinal",
            ShortDescription = "In-class activity from the prefinal term of IT Elective 2.",
            Description = "The first graded activity of the prefinal term, completed individually as part of the IT Elective 2 curriculum and structured as an ASP.NET Core MVC project.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "In-class activity", "Individual submission" },
            ThumbAccent = "muted",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 4,
            Name = "Prefinals Group Project",
            RepositoryName = "IT_ELECTIVE_2_BSIT31E3_PreFinalsProject_PjGalang_Pelarca_Romulo",
            GitHubUrl = Owner + "IT_ELECTIVE_2_BSIT31E3_PreFinalsProject_PjGalang_Pelarca_Romulo",
            Category = "Prefinal",
            ShortDescription = "A collaborative prefinal project built together with two classmates.",
            Description = "The larger, group-based prefinal project for IT Elective 2 (BSIT31E3), developed jointly with classmates PJ Galang and Romulo. As a multi-contributor repository it involved coordinating an ASP.NET Core MVC codebase across several developers.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "Group collaboration", "Shared repository across three contributors", "Larger scope than the solo prefinal exercises" },
            Collaborators = new() { "PJ Galang", "Romulo" },
            ThumbAccent = "accent",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 5,
            Name = "Midterm Quiz 3",
            RepositoryName = "IT_ELECTIVE_2_MIDTERM_Q3_Pelarca_Harvey",
            GitHubUrl = Owner + "IT_ELECTIVE_2_MIDTERM_Q3_Pelarca_Harvey",
            Category = "Midterm",
            ShortDescription = "Third midterm-term quiz submission for IT Elective 2.",
            Description = "The third short quiz of the midterm term, submitted as a compact ASP.NET Core MVC project demonstrating a specific concept taught that week.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "Timed quiz format", "Focused, single-concept scope" },
            ThumbAccent = "primary",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 6,
            Name = "Midterm Exam — Set 1",
            RepositoryName = "IT_ELECTIVE_2_MIDTERM_EXAM_SET1_Pelarca_Harvey",
            GitHubUrl = Owner + "IT_ELECTIVE_2_MIDTERM_EXAM_SET1_Pelarca_Harvey",
            Category = "Midterm",
            ShortDescription = "Midterm examination submission (question set 1) for IT Elective 2.",
            Description = "The midterm examination project for IT Elective 2, built to satisfy the requirements of question set 1 under exam conditions using ASP.NET Core MVC.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "Exam-scoped MVC solution", "Built under timed conditions" },
            ThumbAccent = "muted",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 7,
            Name = "Midterm Homeworks (H1–H3)",
            RepositoryName = "IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Pelarca_Harvey",
            GitHubUrl = Owner + "IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Pelarca_Harvey",
            Category = "Midterm",
            ShortDescription = "Combined submission covering homeworks 1 through 3 of the midterm term.",
            Description = "A consolidated repository holding three separate homework assignments from the midterm term of IT Elective 2, each building incrementally on ASP.NET Core MVC concepts.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "Three homeworks in one repository", "Incremental skill progression" },
            ThumbAccent = "accent",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 8,
            Name = "Midterm Quiz 2",
            RepositoryName = "IT_ELECTIVE_2_MIDTERM_Q2_Pelarca_Harvey",
            GitHubUrl = Owner + "IT_ELECTIVE_2_MIDTERM_Q2_Pelarca_Harvey",
            Category = "Midterm",
            ShortDescription = "Second midterm-term quiz submission for IT Elective 2.",
            Description = "The second short quiz of the midterm term, submitted as a focused ASP.NET Core MVC exercise.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "Timed quiz format", "Focused, single-concept scope" },
            ThumbAccent = "primary",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 9,
            Name = "IT Elective Coursework",
            RepositoryName = "IT_ELECTIVE_BSIT_31E3_Pelarca_Harvey",
            GitHubUrl = Owner + "IT_ELECTIVE_BSIT_31E3_Pelarca_Harvey",
            Category = "Coursework",
            ShortDescription = "General coursework repository for the BSIT31E3 IT Elective track.",
            Description = "A general-purpose coursework repository maintained throughout the BSIT31E3 IT Elective track, used for exercises that did not belong to a specific exam or activity period.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "General coursework exercises", "Ongoing skill-building repository" },
            ThumbAccent = "muted",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 10,
            Name = "Midterm Activity 1",
            RepositoryName = "IT_ELECTIVE_2_Midterm_A1_Pelarca_Harvey",
            GitHubUrl = Owner + "IT_ELECTIVE_2_Midterm_A1_Pelarca_Harvey",
            Category = "Midterm",
            ShortDescription = "First graded activity of the midterm term for IT Elective 2.",
            Description = "The first in-class activity assigned during the midterm term of IT Elective 2, implemented as an ASP.NET Core MVC exercise.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "In-class activity", "Individual submission" },
            ThumbAccent = "accent",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 11,
            Name = "Prelim Exam",
            RepositoryName = "IT_ELECTIVE_2_PRELIM_EXAM_Pelarca_Harvey",
            GitHubUrl = Owner + "IT_ELECTIVE_2_PRELIM_EXAM_Pelarca_Harvey",
            Category = "Prelim",
            ShortDescription = "The preliminary examination project for IT Elective 2.",
            Description = "The prelim-term examination submission for IT Elective 2, marking one of the earliest applied MVC projects in the course sequence.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "Exam-scoped MVC solution", "Early-stage coursework" },
            ThumbAccent = "primary",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 12,
            Name = "Prelim Activity 3",
            RepositoryName = "ishpo29-BSIT31E3_PRELIM_A3_PELARCA_HARVEY",
            GitHubUrl = Owner + "ishpo29-BSIT31E3_PRELIM_A3_PELARCA_HARVEY",
            Category = "Prelim",
            ShortDescription = "Third graded activity of the prelim term for BSIT31E3.",
            Description = "The third in-class activity of the prelim term, submitted as an individual ASP.NET Core MVC exercise for the BSIT31E3 section.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "In-class activity", "Individual submission" },
            ThumbAccent = "muted",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 13,
            Name = "Prelim Quiz 1",
            RepositoryName = "BSIT_BSIT31E3_PRELIM_Q1_Pelarca_Harvey",
            GitHubUrl = Owner + "BSIT_BSIT31E3_PRELIM_Q1_Pelarca_Harvey",
            Category = "Prelim",
            ShortDescription = "First prelim-term quiz, based on a shared class starter template.",
            Description = "The first quiz of the prelim term, forked from a shared class starter repository and completed individually to satisfy the quiz requirements for IT Elective 2.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "Based on a class-provided starter template", "Timed quiz format" },
            IsFork = true,
            ThumbAccent = "accent",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 14,
            Name = "Prelim Homework 2",
            RepositoryName = "BSIT31E3_PRELIM_H2_Pelarca_Harvey",
            GitHubUrl = Owner + "BSIT31E3_PRELIM_H2_Pelarca_Harvey",
            Category = "Prelim",
            ShortDescription = "Second prelim-term homework, based on a shared class starter template.",
            Description = "The second homework assignment of the prelim term, forked from a class-provided starter repository and extended for submission in IT Elective 2.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "Based on a class-provided starter template", "Homework-scoped exercise" },
            IsFork = true,
            ThumbAccent = "primary",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 15,
            Name = "Prelim Homework 1",
            RepositoryName = "BSIT31E1_PRELIM_H1_PELARCA_HARVEY",
            GitHubUrl = Owner + "BSIT31E1_PRELIM_H1_PELARCA_HARVEY",
            Category = "Prelim",
            ShortDescription = "First prelim-term homework, based on a shared class starter template.",
            Description = "The first homework assignment of the prelim term, forked from a class-provided starter repository as part of the IT Elective coursework.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "Based on a class-provided starter template", "Earliest homework in the sequence" },
            IsFork = true,
            ThumbAccent = "muted",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 16,
            Name = "Prelim Activity 2",
            RepositoryName = "BSIT31E3_PRELIM_A2_PELARCA_HARVEY",
            GitHubUrl = Owner + "BSIT31E3_PRELIM_A2_PELARCA_HARVEY",
            Category = "Prelim",
            ShortDescription = "Second graded activity of the prelim term for BSIT31E3.",
            Description = "The second in-class activity of the prelim term, submitted individually as an ASP.NET Core MVC exercise for the BSIT31E3 section.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "In-class activity", "Individual submission" },
            ThumbAccent = "accent",
            ImageUrl = "/images/project-preview.png"
        },
        new Project
        {
            Id = 17,
            Name = "Prelim Activity 1",
            RepositoryName = "BSIT31E3_PRELIM_A1_PELARCA_HARVEY",
            GitHubUrl = Owner + "BSIT31E3_PRELIM_A1_PELARCA_HARVEY",
            Category = "Prelim",
            ShortDescription = "The very first graded activity of the course, opening the prelim term.",
            Description = "The first graded activity of IT Elective 2, marking the start of the prelim term and the earliest project in this portfolio's development timeline.",
            Technologies = new() { "C#", "ASP.NET Core", "MVC" },
            Features = new() { "In-class activity", "First project of the course sequence" },
            ThumbAccent = "primary",
            ImageUrl = "/images/project-preview.png"
        },
    };

    public static Project? GetById(int id) => All.FirstOrDefault(p => p.Id == id);

    public static Project? GetPrevious(int id) => All.Where(p => p.Id < id).OrderByDescending(p => p.Id).FirstOrDefault()
                                                    ?? All.OrderByDescending(p => p.Id).FirstOrDefault(p => p.Id != id);

    public static Project? GetNext(int id) => All.Where(p => p.Id > id).OrderBy(p => p.Id).FirstOrDefault()
                                                ?? All.OrderBy(p => p.Id).FirstOrDefault(p => p.Id != id);
}
