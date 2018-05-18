using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_CSharp
{
    class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Title="title 1", Price=5},
                new Book{Title="title 2", Price=7},
                new Book{Title="title 3", Price=17}
            };
        }
    }
}
