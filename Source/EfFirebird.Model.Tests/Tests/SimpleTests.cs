using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using EfFirebird.Model.Entities;
using NUnit.Framework;

namespace EfFirebird.Model.Tests.Tests
{
    [TestFixture]
    public class SimpleTests : DbTestsBase
    {
        [Test]
        public void SimpleDbRead()
        {
            IList<Author> authors = DbContext.Authors.ToList();
            IList<Book> books = DbContext.Books.ToList();

            Assert.AreEqual(2, authors.Count);
            Assert.AreEqual(5, books.Count);
        }

        [Test]
        public void LoadingNavigationProperty()
        {
            IList<Author> authors = DbContext.Authors
                .Include(x => x.Books)
                .OrderBy(x => x.LastName)
                .ToList();

            Assert.AreEqual(2, authors.Count);
            Assert.IsNotNull(authors[0].Books);
            Assert.IsNotNull(authors[1].Books);
            Assert.AreEqual(3, authors[0].Books.Count);
            Assert.AreEqual(2, authors[1].Books.Count);
        }
    }
}
