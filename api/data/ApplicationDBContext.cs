using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.data
{
    public class ApplicationDBContext : DbContext
    {
       public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
       {
        
       }


       public DbSet<Stock> Stocks { get; set; } // this will create a table called Stocks
       public DbSet<Comment> Comments { get; set; } // this will create a table called Comments
        
    }
}