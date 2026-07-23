using BookCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext
        (DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //table created in database
        public DbSet<Book> Books { get; set; }
    }
}