using BugTrackerWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.DAL
{
    public interface IBugDAO
    {
        IList<Bug> GetBugsByProjectID(int id);
    }
}
