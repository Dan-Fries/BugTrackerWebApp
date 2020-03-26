using BugTrackerWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BugTrackerWebApp.DAL
{
    public class BugTrackerDbContext : IdentityDbContext<BTUser, BTUserRole, int> //DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Bug> Bugs { get; set; }

        public BugTrackerDbContext(DbContextOptions<BugTrackerDbContext> options) : base(options) { }

    }
}
