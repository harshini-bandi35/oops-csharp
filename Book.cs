/***Constructor Overloading in a Library System**
Implement a `Book` class with three different constructors:
(1) Default constructor, (2) Constructor with `Title` and `Author`, 
(3) Constructor with `Title`, `Author`, and `ISBN`. Ensure each constructor 
initializes properties correctly.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }


        public Book()
        {
            Title = "unknown";
            Author = "unknown";
            ISBN = "00000000";
        }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;

        }
        public void DisplayDetails()
        {
            Console.WriteLine("The title is: " + Title);
            Console.WriteLine("The Author is: " + Author);
            Console.WriteLine("The ISBN is: " + ISBN);
        }

    }
}
