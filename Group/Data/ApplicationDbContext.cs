using System;
using System.Collections.Generic;
using System.Text;
using Group.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Group.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Mapper> Mappers { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Base> Bases { get; set; }
        public DbSet<State> States { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
