using System.Data.Entity;
using EfFirebird.Model.Entities;

namespace EfFirebird.Model.Tests.Db
{
    public class BookstoreDbInitializer : CreateDatabaseIfNotExists<BookstoreDbContext>
    {
        protected override void Seed(BookstoreDbContext context)
        {
            var nesbo = new Author {FirstName = "Jo", LastName = "Nesbo"};
            var larsson = new Author {FirstName = "Stieg", LastName = "Larsson"};

            var b1 = new Book {Author = nesbo, Title = "Nemesis"};
            var b2 = new Book {Author = nesbo, Title = "The Snowman"};
            var b3 = new Book {Author = nesbo, Title = "Phantom"};
            var b4 = new Book {Author = larsson, Title = "Men Who Hate Women" };
            var b5 = new Book {Author = larsson, Title = "The Girl Who Played with Fire" };

            context.Authors.Add(nesbo);
            context.Authors.Add(larsson);

            context.Books.Add(b1);
            context.Books.Add(b2);
            context.Books.Add(b3);
            context.Books.Add(b4);
            context.Books.Add(b5);

            base.Seed(context);
        }
    }
}
