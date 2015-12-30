using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Toyota";
            myNewCar.Model = "4Runner";
            myNewCar.Year = 1998;
            myNewCar.Color = "Silver";

            Console.WriteLine("{0} - {1} - {2}",
                myNewCar.Make,
                myNewCar.Model,
                myNewCar.Color);;

            Console.WriteLine("The market value of the {2} {0} {1} is {3:C}",
                myNewCar.Make,
                myNewCar.Model,
                myNewCar.Year,
                myNewCar.DetermineMarketValue());

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            double carValue = this.Year > 1990 ? 10000.0 : 2000.0;
            return carValue;
        }
    }
}
