using BugTrackerWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.DAL
{
    public class BugEFCoreDAO : IBugDAO
    {
        private readonly BugTrackerDbContext dbContext;

        public BugEFCoreDAO(BugTrackerDbContext context)
        {
            dbContext = context;
        }

        public IList<Bug> GetBugsByProjectID(int id)
        {
            return dbContext.Bugs.Where(b => b.ProjectId == id).ToList();
        }
    }
}
