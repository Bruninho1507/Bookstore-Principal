using Microsoft.EntityFrameworkCore;
using Bookstore.Models;
using System.Collections.Generic;

namespace Bookstore.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
    }
}