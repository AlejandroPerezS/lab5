using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// import this to be able to inherit from the class called DbContext
using Microsoft.EntityFrameworkCore;

namespace lab5.Models
{
    // bookContext inherits from DbContext
    public class bookContext : DbContext
    {
        //constructor
        public bookContext(DbContextOptions<bookContext> options) : base(options)
        {


        }
        public DbSet<Book> Books { get; set; }
    }
}
