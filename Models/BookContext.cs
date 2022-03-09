using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class BookContext : DbContext
    {


        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<School> Schools { get; set; }
        //public  DbSet<Auth> Auths { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

    }
}
