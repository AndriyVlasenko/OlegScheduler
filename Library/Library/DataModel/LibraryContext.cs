namespace Library.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LibraryContext1")
        {
        }


         public DbSet<Book> Books { get; set; }
    }

    
}