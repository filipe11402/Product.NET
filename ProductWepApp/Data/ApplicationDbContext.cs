using Microsoft.EntityFrameworkCore;
using ProductWepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWepApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        //creating context to create the entities sets in database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }

        //mapping the classes to DB
        public DbSet<Product> Products { get; set; }
    }
}
