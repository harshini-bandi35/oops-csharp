/***Multiple Inheritance Using Interfaces**

Define two interfaces `IPrintable` (for printing details) 
and `ISerializable` (for saving to a file). Implement both 
in a `Report` class and demonstrate multiple interface implementation.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    interface IPrintable
    {
        
        void Print();
    }

    interface ISerializable
    {
        void SaveToFile(string filePath);
    }

    public class Report : IPrintable, ISerializable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public void Print()
        {
            Console.WriteLine("Printing Report:");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Content: {Content}");
        }

        public void SaveToFile(string filePath)
        {
            System.IO.File.WriteAllText(filePath, $"Title: {Title}\nContent: {Content}");
            Console.WriteLine($"Report saved to {filePath}");
        }
    }
}

