using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class BookRepository
    {
       public IEnumerable<Book> GetBooks()
        {
            return new List<Book> // a generic list of books
            {
                new Book() {Title = "ADO.NET Step by Step", Price = 5 }, //here adding a new look, and using the object initializer syntax, to immediately initialize a book.
                new Book() {Title = "ASP.NET MVC", Price = 9.99f },
                new Book() {Title = "ASP.NET Web API", Price = 12 },
                new Book() {Title = "C# Advanced Topics", Price = 7 },
                new Book() {Title = "C# Advanced Topics", Price = 9 },

            };
        }
    }
}
