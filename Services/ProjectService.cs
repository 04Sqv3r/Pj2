using System;
using System.Collections.Generic;

namespace BlazorApp1.Services
{
    public class Project
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public class ProjectService
    {
        private readonly List<Project> _projects = new();

        public IReadOnlyList<Project> Projects => _projects;

        public ProjectService()
        {
            
            _projects.AddRange(new[]
            {
                new Project { Name = "Task Manager", Description = "TEST", CreatedAt = new DateTime(2025, 8, 1) },
        new Project { Name = "Budget Tracker", Description = "TEST", CreatedAt = new DateTime(2025, 7, 15) },
        new Project { Name = "Fitness App", Description = "TEST", CreatedAt = new DateTime(2025, 6, 30) },
        new Project { Name = "Recipe Hub", Description = "TEST", CreatedAt = new DateTime(2025, 6, 5) },
        new Project { Name = "Portfolio Website", Description = "TEST", CreatedAt = new DateTime(2025, 5, 28) },
        new Project { Name = "Language Learner", Description = "TEST", CreatedAt = new DateTime(2025, 5, 1) },
            });
        }

        public void AddProject(Project project)
        {
            _projects.Add(project);
        }
    

    }
}
