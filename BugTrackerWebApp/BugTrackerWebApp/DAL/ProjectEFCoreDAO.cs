using BugTrackerWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.DAL
{
    public class ProjectEFCoreDAO : IProjectDAO
    {
        private readonly BugTrackerDbContext dbContext;

        public ProjectEFCoreDAO(BugTrackerDbContext context)
        {
            dbContext = context;
        }
        public int AddProject(Project project)
        {
            dbContext.Projects.Add(project);
            dbContext.SaveChanges();

            return project.ProjectId;
        }

        public IList<Project> GetAllProjects()
        {
            return dbContext.Projects.ToList();
        }
    }
}
