using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lambda Expressions
            //x=>...
            //(x,y)=>...
            //(x,y,z)=>....

            //Func<int, int> square = number => number * number;
            //Func<int,int, double> multiply = (x, y) => x * y;
            //Console.WriteLine("Square root of 5:"+square(5));
            //Console.WriteLine("3*4 is:"+multiply(3,4));

            //Get the lowest price of book
            //Method 1
            //var books = new BookRepository().GetBooks();
            //var cheaperBooks = books.FindAll(IsCheaperThanTen);

            //Method 2
            var books = new BookRepository().GetBooks();
            var cheaperBooks = books.FindAll(x=>x.Price<10);

            foreach (var book in cheaperBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
        static bool IsCheaperThanTen(Book book)
        {
            return book.Price < 10;
        }
    }
}
