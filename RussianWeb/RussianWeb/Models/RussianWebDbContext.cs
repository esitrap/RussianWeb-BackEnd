using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace RussianWeb.Models
{
    public class RussianWebDbContext : DbContext
    {
        public RussianWebDbContext(DbContextOptions<RussianWebDbContext> options)
           : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet <Post>Posts { get; set; }
        public DbSet <Ax>Axes { get; set; }
    }  
}

