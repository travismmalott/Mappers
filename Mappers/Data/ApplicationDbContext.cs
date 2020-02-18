using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mappers.Models;

namespace Mappers.Data
{
    public class ApplicationDbContext : IdentityDbContext<Mapper>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Mapper> Mappers { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Base> Bases { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }
}
