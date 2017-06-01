using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace EfFirebird.Model.Entities
{
    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual IList<Book> Books { get; set; }
    }

    public class AuthorEntityConfiguration : EntityTypeConfiguration<Author>
    {
        public AuthorEntityConfiguration()
        {
            //Property(x => x.FirstName).IsRequired();
            //(x => x.LastName).IsRequired();
        }
    }
}
