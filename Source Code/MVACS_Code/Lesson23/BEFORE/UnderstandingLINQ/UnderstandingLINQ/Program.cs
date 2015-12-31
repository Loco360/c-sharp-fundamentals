using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { Make = "BMW", Model= "550i", Color=CarColor.Blue, StickerPrice=55000, Year=2009},
                new Car() { Make="Toyota", Model="4Runner", Color=CarColor.White, StickerPrice=35000, Year=2010},
                new Car() { Make="BMW", Model = "745li", Color=CarColor.Black, StickerPrice=75000, Year=2008},
                new Car() {Make="Ford", Model="Escape", Color=CarColor.White, StickerPrice=25000, Year=2008},
                new Car() {Make="BMW", Model="55i", Color=CarColor.Black, StickerPrice=57000, Year=2010}
            };

            foreach (var car in myCars)
                Console.WriteLine("{0} - {1} - {2}", car.Make, car.Model, car.Year);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
        public CarColor Color { get; set; }
    }

    enum CarColor
    {
        White,
        Black,
        Red,
        Blue,
        Yellow
    }

}
