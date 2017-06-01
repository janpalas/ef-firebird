﻿using System.Collections.Generic;

namespace EfFirebird.Model.Entities
{
    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual IList<Book> Books { get; set; }
    }
}
