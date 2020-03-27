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
    // Context for database access inherits from IdentityDbContext for Identity Services integration
    public class BugTrackerDbContext : IdentityDbContext<BTUser, BTRole, int>
    {
        public BugTrackerDbContext(DbContextOptions<BugTrackerDbContext> options) : base(options) { }


        public DbSet<Project> Projects { get; set; }
        public DbSet<Bug> Bugs { get; set; }

        // Used to seed database with data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed the database with Admin and User roles
            modelBuilder.Entity<BTRole>().HasData(
                new List<BTRole>
                {
                    new BTRole {
                        Id = 1,
                        Name = "Admin",
                        NormalizedName = "ADMIN"
                    },
                    new BTRole {
                        Id = 2,
                        Name = "User",
                        NormalizedName = "USER"
                    },
                });

            // Instantiate a new password hasher that will be used to create hashed passwords to insert in the db
            PasswordHasher<BTUser> hasher = new PasswordHasher<BTUser>();

            // Seed the database with a Test Admin and Test User entry
            modelBuilder.Entity<BTUser>().HasData(
                    new BTUser
                    {
                        Id = 1,
                        Email = "BTadmin@BTApp.com",
                        NormalizedEmail = "BTADMIN@BTAPP.COM",
                        UserName = "BTadmin@BTApp.com",
                        NormalizedUserName = "BTADMIN@BTAPP.COM",
                        PasswordHash = hasher.HashPassword(null, "P@ssw0rd"),
                        SecurityStamp = Guid.NewGuid().ToString()
                    },
                    new BTUser
                    {
                        Id = 2,
                        Email = "BTuser@BTApp.com",
                        NormalizedEmail = "BTUSER@BTAPP.COM",
                        UserName = "BTuser@BTApp.com",
                        NormalizedUserName = "BTUSER@BTAPP.COM",
                        PasswordHash = hasher.HashPassword(null, "P@ssw0rd"),
                        SecurityStamp = Guid.NewGuid().ToString()
                    }
                );
            // Seed the database by assigning users to roles
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int>
                {
                    UserId = 1,
                    RoleId = 1
                },
                new IdentityUserRole<int>
                {
                    UserId = 2,
                    RoleId = 2
                }

                );
        }
    }
}
