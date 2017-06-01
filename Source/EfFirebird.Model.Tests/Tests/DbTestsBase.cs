using System.Data.Entity;
using EfFirebird.Model.Tests.Db;
using NUnit.Framework;

namespace EfFirebird.Model.Tests.Tests
{
    [TestFixture]
    public class DbTestsBase
    {
        protected BookstoreDbContext DbContext;

        [OneTimeSetUp]
        public void FixtureSetUp()
        {
            //Database.SetInitializer(new BookstoreDbInitializer());
        }

        [SetUp]
        public void SetUp()
        {
            DbContext = new BookstoreDbContext();
        }

        [TearDown]
        public void CleanUp()
        {
            DbContext = new BookstoreDbContext();
        }
    }
}
