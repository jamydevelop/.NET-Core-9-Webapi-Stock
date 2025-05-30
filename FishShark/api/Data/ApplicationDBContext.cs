using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;

namespace api.Data
{
    //public class ApplicationDBContext : DbContext  //Think of DbContext as a bridge between your C# application and your database.
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {
        private static readonly string AdminRoleId = Guid.NewGuid().ToString();
        private static readonly string UserRoleId = Guid.NewGuid().ToString();

        public ApplicationDBContext(DbContextOptions dbContextOptions) //you need to tell it how to connect to the database. You do that using DbContextOptions.
            : base(dbContextOptions) // A map to the librarys location "connection string"
        {
        }


        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    //Id = Guid.NewGuid().ToString(),
                    //Id = "1",
                    //Id = "dcb69e7c-6a42-4b9f-b47c-70c3fc05c333", // Admin
                    Id = AdminRoleId,
                    //Id = "testAdmin",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                  new IdentityRole
                {
                      //Id = Guid.NewGuid().ToString(),
                      //Id = "2",
                      //Id = "875b1a76-f41b-4e0e-8710-89fc3e7ad2c4", // User
                    Id = UserRoleId,
                   //Id = "testUser",
                    Name = "User",
                    NormalizedName = "USER"
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }

    }
}
