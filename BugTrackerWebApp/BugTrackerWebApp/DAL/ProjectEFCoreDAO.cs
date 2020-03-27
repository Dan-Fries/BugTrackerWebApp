using BugTrackerWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        /// <summary>
        /// Adds a new project to the project table and the UserProjects table for the supplied userId and project object
        /// </summary>
        /// <param name="project">An object of type Project that will be added to the db</param>
        /// <param name="userId">An integer representing UserId</param>
        /// <returns>An integer with the id of the added project</returns>
        public int AddProject(Project project, int userId)
        {
            // Add the project to the DB
            dbContext.Projects.Add(project);
            dbContext.SaveChanges();

            // Build a new UserProjects object to insert into the association table
            UserProjects userProject = new UserProjects();
            userProject.BTUserId = userId;

            // Project object will have the Id of the newly created project so use it to get Id
            userProject.ProjectId = project.ProjectId;
            dbContext.UserProjects.Add(userProject);
            dbContext.SaveChanges();

            return project.ProjectId;
        }

        // Currently not in use will be added to admin functionality later
        public IList<Project> GetAllProjects()
        {
            return dbContext.Projects.ToList();
        }

        public IList<Project> GetProjectsForUserId(int id)
        {
            // Create a list of projects that will store the projects with ids matching the user ids in the association table
            IList<Project> projects = new List<Project>();

            // Create a list of Project Ids that have a User Id matching the passed in id
            List<int> projectIds = dbContext.UserProjects.Where(ups => ups.BTUserId == id).Select(p => p.ProjectId).ToList();

            // Iterate over the list of project ids and retrieve project objects to add to the result list
            foreach (int projId in projectIds)
            {
                projects.Add(dbContext.Projects.Where(p => p.ProjectId == projId).FirstOrDefault());
            }

            return projects;
        }
    }
}
