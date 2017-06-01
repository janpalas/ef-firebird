using System.Data.Entity;
using EfFirebird.Model.Entities;

namespace EfFirebird.Model
{
    public class BookstoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public BookstoreDbContext()
        {
        }
    }
}
