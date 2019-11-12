using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAuthTest.Models.Data;

namespace WebAuthTest.Data
{
    public class BubbaDbContext : IdentityDbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Post> Posts { get; set; }

        public BubbaDbContext(DbContextOptions<BubbaDbContext> options)
            : base(options)
        {
        }
    }
}
