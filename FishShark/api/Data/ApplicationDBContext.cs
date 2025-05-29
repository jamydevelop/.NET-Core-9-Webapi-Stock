using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;

namespace api.Data
{
       public class ApplicationDBContext : DbContext  //Think of DbContext as a bridge between your C# application and your database.

    {
        /*
        EF Core uses dependency injection to pass the configuration (e.g., database provider, connection string) to the context.
        */
        public ApplicationDBContext(DbContextOptions dbContextOptions) //you need to tell it how to connect to the database. You do that using DbContextOptions.
            : base(dbContextOptions) // A map to the librarys location "connection string"
        {
        }

        /*
        These represent tables in your database.
        A DbSet<T> is basically an abstraction over a table that lets you perform LINQ operations (e.g., .Where(), .ToListAsync()).
        */
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
