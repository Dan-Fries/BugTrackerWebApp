using BugTrackerWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.DAL
{
    public class BugTrackerDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Bug> Bugs { get; set; }

        public BugTrackerDbContext(DbContextOptions<BugTrackerDbContext> options) : base(options) { }

    }
}
