
using BlogPostModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Cryptography;
//Author: Prakash Bl Dhakal Date:2023 / 18 / 03
namespace BlogDBContext
{
    public class BlogDbContext : IdentityDbContext<IdentityUser>
    {
        public BlogDbContext(DbContextOptions options) : base(options)
        {
        }
        //User and their role seeded here.it will update datebase during migration automatically.
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
        }
        private static void SeedRoles(ModelBuilder modelBuilder)
        {var passwordHasher = new PasswordHasher<IdentityUser>();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id="1", Name = "Admin",  NormalizedName = "Admin" },
                new IdentityRole() { Id = "2", Name = "User",  NormalizedName = "User" },
                new IdentityRole() { Id = "3", Name = "HR",  NormalizedName = "HR" });
            modelBuilder.Entity<IdentityUser>().HasData(
               new IdentityUser() { Id = "1", PasswordHash = passwordHasher.HashPassword(null, "Admin@123"),UserName= "admin@gmail.com", NormalizedUserName = ("admin@gmail.com").ToUpper(),  Email = "admin@gmail.com",LockoutEnabled=true },
               new IdentityUser() { Id = "2", PasswordHash = passwordHasher.HashPassword(null, "User@123"), UserName = "user@gmail.com", NormalizedUserName = ("user@gmail.com").ToUpper(), Email = "user@gmail.com", LockoutEnabled = true   },
               new IdentityUser() { Id = "3", PasswordHash = passwordHasher.HashPassword(null, "HumanResource@123"), UserName = "hr@gmail.com", NormalizedUserName = ("hr@gmail.com").ToUpper(), Email = "hr@gmail.com", LockoutEnabled = true   });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
    new IdentityUserRole<string>()
    {
        RoleId = "1", 
        UserId = "1"  
    },
    new IdentityUserRole<string>()
    {
        RoleId = "2",
        UserId = "2"  
    },
    new IdentityUserRole<string>()
    {
        RoleId = "3", 
        UserId = "3"  
    }
);
        }
        public DbSet<PostContent> PostContents { get; set; }
    }
}