using System.Data.Entity.Migrations;
using EfFirebird.Model.Entities;

namespace EfFirebird.Model.Migrations
{
    

    internal sealed class Configuration : DbMigrationsConfiguration<BookstoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookstoreDbContext context)
        {
            var nesbo = new Author { FirstName = "Jo", LastName = "Nesbo" };
            var larsson = new Author { FirstName = "Stieg", LastName = "Larsson" };

            var b1 = new Book { Author = nesbo, Title = "Nemesis" };
            var b2 = new Book { Author = nesbo, Title = "The Snowman" };
            var b3 = new Book { Author = nesbo, Title = "Phantom" };
            var b4 = new Book { Author = larsson, Title = "Men Who Hate Women" };
            var b5 = new Book { Author = larsson, Title = "The Girl Who Played with Fire" };

            context.Authors.AddOrUpdate(x => x.LastName, nesbo);
            context.Authors.AddOrUpdate(x => x.LastName, larsson);

            context.Books.AddOrUpdate(x => x.Title, b1);
            context.Books.AddOrUpdate(x => x.Title, b2);
            context.Books.AddOrUpdate(x => x.Title, b3);
            context.Books.AddOrUpdate(x => x.Title, b4);
            context.Books.AddOrUpdate(x => x.Title, b5);
        }
    }
}
