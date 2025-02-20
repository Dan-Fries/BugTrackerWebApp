﻿using BugTrackerWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.DAL
{
    public interface IProjectDAO
    {
        IList<Project> GetAllProjects();

        IList<Project> GetProjectsForUserId(int id);
        int AddProject(Project project, int userId);
    }
}
