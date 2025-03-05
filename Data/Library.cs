using Microsoft.EntityFrameworkCore;
using SimpleBookLibraryApi.Models;

namespace SimpleBookLibraryApi.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
