using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";


            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

}
