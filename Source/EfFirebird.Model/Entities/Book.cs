using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EfFirebird.Model.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }

        //public string Note { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }

    public class BookEntityConfiguration : EntityTypeConfiguration<Book>
    {
        public BookEntityConfiguration()
        {
            //Property(x => x.Note).HasMaxLength(250).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
