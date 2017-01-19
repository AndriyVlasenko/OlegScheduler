using Library.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            using (LibraryContext context = new LibraryContext())
            {
                Book book = new Book();
                book.Title = "Voyna i mir";
                book.Author = "Lev Tolstoy";

                context.Books.Add(book);
                context.SaveChanges();
            }
        }
    }
}
